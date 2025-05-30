using Microsoft.Data.SqlClient;
using System.Configuration;

namespace SmartInventoryApp.Helpers
{
    public static class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
            return new SqlConnection(connStr);
        }
    }
}
