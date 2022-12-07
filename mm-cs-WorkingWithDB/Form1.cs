using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mm_cs_WorkingWithDB
{
    public partial class Form1 : Form
    {
        const string connectionString = "Server=tcp:haimgilboavote.database.windows.net,1433;Initial Catalog=vote;Persist Security Info=False;User ;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string occupation = ConfigurationManager.AppSettings["occupation"];


            // Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = "select 123,+ 23 as 'calc', code,email,99 from email";

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int colIdx = reader.GetOrdinal("email");
                            string email = reader.GetString(colIdx);
                            string code = reader.GetString(reader.GetOrdinal("code"));
                            int num = reader.GetInt32(2);
                        }
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {



            // Connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = "update tbl set name='kuku'";

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();

                    int rowsEffectes = command.ExecuteNonQuery();
                }
                   



            }


        }
    }
}
