using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentalDomain.Helpers
{
  /// <summary>
  /// This is a helper class that I made to parse genders, since adding static methods to enums is not possible
  /// </summary> 
  public static class GenderHelper
  {
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
  }
}
