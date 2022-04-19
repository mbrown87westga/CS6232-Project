using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentalDomain
{
    public class GetMostPopularDuringDateReport
    {
        public int FurnitureID { get; set; }

        public string Category { get; set; }

        public string FurnitureName { get; set; }

        public int NbrRentals { get; set; }

        public int TotalRentals { get; set; }

        public string PctOfTotal { get; set; }

        public string PctInAgeRange { get; set; }

        public string PctNotInAgeRange { get; set; }
    }
}
