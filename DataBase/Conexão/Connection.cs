using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Conexão
{
    public class Connection
    {
        public SqlConnection Con { get; protected set; } = new SqlConnection();

        public Connection()
        {
            Con.ConnectionString = @"Data Source=DESKTOP-TTAP1HH;Initial Catalog=ProWay;Integrated Security=True";
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
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
            }
        }
    }
}
