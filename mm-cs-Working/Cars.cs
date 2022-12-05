using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm_cs_Working
{
    public  class Cars
    {
        public static void Sql()
        {

            string connectionString = "Server=tcp:haimgilboavote.database.windows.net,1433;Initial Catalog=vote;Persist Security Info=False;User ID=haim;Password=Qwe123Qwe123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


            string queryString = "SELECT * FROM dbo.email";

            using (SqlConnection connection =
                       new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand(queryString, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    // Call Read before accessing data.
                    while (reader.Read())
                    {
                        string f = reader.GetString(reader.GetOrdinal("email"));
                    }

                    // Call Close when done reading.
                }
            }
        }
        public int Run() { 




            Cola cola = new Cola();
            cola.a = 1;
            cola.b = 2;
            
            
            return 10; }
    }
}
