using Database.Conexão;
using Database.Repositórios;
using Domínio.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositórios
{
    public class RepositórioCafe : Repositório
    {
        public string Create(Cafe cafe)
        {
            SqlCommand.CommandText = @"Insert into CAFES(nomeDoCafe) values ('" + cafe.cafe + "');" +
                                       "Create table " + cafe.cafe + " (" +
                                       "ID smallint primary key identity," +
                                       "Alunos varchar(100) )";
            try
            {
                SqlCommand.Connection = Connection.Connect();
                SqlCommand.ExecuteNonQuery();
                Connection.Disconnect();

                Message = "cadastrado com sucesso.";
            }
            catch (Exception ex)
            {
                Message = "erro no banco de dados.";
            }

            return Message;
        }
    }
}
