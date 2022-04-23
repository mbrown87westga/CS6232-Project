USE [cs6232-g2]
GO
/****** Object:  StoredProcedure [dbo].[getMostPopularFurnitureDuringDates]    Script Date: 4/23/2022 2:41:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[getMostPopularFurnitureDuringDates] @start_date_param DATE,
													@end_date_param   DATE
AS
BEGIN
	--Validate parameter values
	IF(@start_date_param IS NULL)
	BEGIN
		RAISERROR('The start date cannot be null',16,1)
		RETURN
	END
	IF(@end_date_param IS NULL)
	BEGIN
		RAISERROR('The end date cannot be null',16,1)
		RETURN
	END
	IF(@start_date_param > @end_date_param)
	BEGIN
		RAISERROR('The end date cannot be prior to the start date',16,1)
		RETURN
	END

	-- Get total # of rentals for time period
	DECLARE @totalRentals INT
	SELECT @totalRentals = COUNT(rt.rentalTransactionID)
	  FROM RentalTransaction rt
	 WHERE cast(rt.rentalTimestamp as date) >= cast(@start_date_param as date)
	   AND cast(rt.rentalTimestamp as date) <= cast(@end_date_param as date)

	-- Get qualifying transactions
	DROP TABLE IF EXISTS #in_range_rentals
	SELECT QualifiedFurniture.furnitureID, QualifiedFurniture.qualifiedRentals, FurnitureRentals.nbrRentals
	  INTO #in_range_rentals
	  FROM (SELECT f.furnitureID, count(*) AS qualifiedRentals
	          FROM Furniture f, RentalItem ri, RentalTransaction rt, Member m
			 WHERE f.furnitureID = ri.furnitureID
			   AND rt.rentalTransactionID = ri.rentalTransactionID
			   AND cast(rt.rentalTimestamp as date) >= cast(@start_date_param as date)
			   AND cast(rt.rentalTimestamp as date) <= cast(@end_date_param as date)
			   AND rt.memberID = m.memberID
			   AND ((0 + Convert(Char(8),rt.rentalTimestamp,112) - Convert(Char(8),m.birthDate,112)) / 10000) >= 18
			   AND ((0 + Convert(Char(8),rt.rentalTimestamp,112) - Convert(Char(8),m.birthDate,112)) / 10000) <= 29
	       GROUP BY f.furnitureID) AS QualifiedFurniture
	  LEFT JOIN
		   (SELECT f.furnitureID, count(*) AS nbrRentals
		      FROM Furniture f, RentalTransaction rt, RentalItem ri
			 WHERE f.furnitureID = ri.furnitureID
			   AND ri.rentalTransactionID = rt.rentalTransactionID
			   AND cast(rt.rentalTimestamp as date) >= cast(@start_date_param as date)
			   AND cast(rt.rentalTimestamp as date) <= cast(@end_date_param as date)
			GROUP BY f.furnitureID) AS FurnitureRentals
	  ON QualifiedFurniture.furnitureID = FurnitureRentals.furnitureID
	  WHERE nbrRentals > 1

	SELECT DISTINCT f.furnitureID, f.categoryDescription AS category, f.[name], irr.nbrRentals, @totalRentals AS totalRentals,
		   CONCAT(ROUND(CAST(irr.nbrRentals AS FLOAT) / CAST(@totalRentals AS FLOAT) * 100, 2), '%') AS 'PctOfTotal',
		   CONCAT(ROUND(CAST(irr.qualifiedRentals AS FLOAT) / CAST(irr.nbrRentals AS FLOAT) * 100, 2), '%') AS 'PctInAgeRange',
		   CONCAT(ROUND((irr.nbrRentals - irr.qualifiedRentals) / CAST(irr.nbrRentals AS FLOAT) * 100, 2), '%') AS 'PctNotInAgeRange'
	 FROM Furniture f, #in_range_rentals irr
	WHERE f.furnitureID = irr.furnitureID
	ORDER BY f.furnitureID

END
