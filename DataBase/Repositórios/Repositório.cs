using Database.Conexão;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositórios
{
    public class Repositório
    {
        public Connection Connection { get; set; } = new Connection();
        public SqlCommand SqlCommand { get; set; } = new SqlCommand();
        public string Message { get; set; }
    }
}
