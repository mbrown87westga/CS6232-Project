USE [cs6232-g2];

/* Stored Procedure */
DROP PROCEDURE IF EXISTS getMostPopularFurnitureDuringDates;
GO

CREATE PROCEDURE getMostPopularFurnitureDuringDates @start_date_param DATE,
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
	 WHERE rt.rentalTimestamp >= @start_date_param
	   AND rt.rentalTimestamp <= @end_date_param

	-- Get qualifying transactions
	DROP TABLE IF EXISTS #in_range_rentals
	SELECT QualifiedFurniture.furnitureID, QualifiedFurniture.qualifiedRentals, FurnitureRentals.nbrRentals
	  INTO #in_range_rentals
	  FROM (SELECT f.furnitureID, rt.rentalTransactionID, count(*) AS qualifiedRentals
	          FROM Furniture f, RentalItem ri, RentalTransaction rt, Member m
			 WHERE f.furnitureID = ri.furnitureID
			   AND rt.rentalTransactionID = ri.rentalTransactionID
			   AND rt.rentalTimestamp >= @start_date_param
			   AND rt.rentalTimestamp <= @end_date_param
			   AND rt.memberID = m.memberID
			   AND m.birthDate <= DateAdd(year, -18, getdate())
			   AND m.birthDate >= DateAdd(year, -29, getdate())
			GROUP BY f.furnitureID, rt.rentalTransactionID) AS QualifiedFurniture
	  LEFT JOIN
		   (SELECT f.furnitureID, count(*) AS nbrRentals
		      FROM Furniture f, RentalTransaction rt, RentalItem ri
			 WHERE f.furnitureID = ri.furnitureID
			   AND ri.rentalTransactionID = rt.rentalTransactionID
			   AND rt.rentalTimestamp >= @start_date_param
			   AND rt.rentalTimestamp <= @end_date_param
			GROUP BY f.furnitureID) AS FurnitureRentals
	  ON QualifiedFurniture.furnitureID = FurnitureRentals.furnitureID
	  WHERE nbrRentals > 1

	SELECT f.furnitureID, f.categoryDescription AS category, f.[name], irr.nbrRentals, @totalRentals AS totalRentals,
		   CONCAT(ROUND(CAST(irr.nbrRentals AS FLOAT) / CAST(@totalRentals AS FLOAT) * 100, 2), '%') AS 'PctOfTotal',
		   CONCAT(ROUND(CAST(irr.qualifiedRentals AS FLOAT) / CAST(irr.nbrRentals AS FLOAT) * 100, 2), '%') AS 'PctInAgeRange',
		   CONCAT(ROUND((irr.nbrRentals - irr.qualifiedRentals) / CAST(irr.nbrRentals AS FLOAT) * 100, 2), '%') AS 'PctNotInAgeRange'
	 FROM Furniture f, #in_range_rentals irr
	WHERE f.furnitureID = irr.furnitureID
	ORDER BY f.furnitureID

END
GO
