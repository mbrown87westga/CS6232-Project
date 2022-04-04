namespace FurnitureRentalDomain.Helpers
{
    /// <summary>
    /// This is a helper class that I made to parse genders, since adding static methods to enums is not possible
    /// </summary> 
    public static class GenderHelper
    {
        /// <summary>
        /// Converts a string representation of a gender into a gender enum value
        /// </summary>
        /// <param name="value">The gender as a string</param>
        /// <returns>the enum value</returns>
        public static Gender ParseGender(string value)
        {
            switch (value.ToLower())
            {
                case "m":
                case "male":
                    return Gender.Male;
                case "f":
                case "female":
                    return Gender.Female;
                default:
                    return Gender.Unknown;
            }
        }

        /// <summary>
        /// Converts a gender into a string
        /// </summary>
        /// <param name="thisGender">The gender</param>
        /// <returns>a string representing the gender</returns>
        public static string ToString(this Gender thisGender)
        {
            switch (thisGender)
            {
                case Gender.Female:
                    return "f";
                case Gender.Male:
                    return "m";
                default:
                    return "?";
            }
        }
    }
}
