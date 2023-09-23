using Microsoft.Data.SqlClient;

namespace MVCAuthor.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()//Connection Factory - a method that creates connection objects
        {
            var connString = @"server=200411LTP2860\SQLEXPRESS;database=TestDb;
                                integrated security=true;Encrypt=false;";
            SqlConnection sqlcn = new SqlConnection(connString);
            return sqlcn;
        }
    }
}
