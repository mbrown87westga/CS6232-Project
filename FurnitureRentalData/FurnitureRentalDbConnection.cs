using System.Data.SqlClient;

namespace FurnitureRentalData
{
  /// <summary>
  /// Get a connection object. 
  /// </summary>
  public static class FurnitureRentalDbConnection

  {
    /// <summary>
    /// Gets the connection
    /// </summary>
    /// <returns>the connection</returns>
    public static SqlConnection GetConnection()
    {
      string connectionString = "Data Source=localhost;Initial Catalog=cs6232-g2; Integrated Security=True";

      SqlConnection connection = new SqlConnection(connectionString);
      return connection;
    }
  }
}