using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CadastroProway.DataBase
{
    public class connection
    {
        public SqlConnection Con = new SqlConnection();

        public connection()
        {
            Con.ConnectionString = @"Data Source=DESKTOP-TTAP1HH;Initial Catalog=ProWayGoDev;Integrated Security=True";

        }

        public SqlConnection Connect()
        {
            if (Con.State == System.Data.ConnectionState.Closed)
            {
                Con.Open();
            }
            return Con;
        }
        public void Disconnect()
        {
            if(Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }
        }
    }
}