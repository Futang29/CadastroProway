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
    public class RepositorioSala : Repositório
    {
        public string Create(Sala sala)
        {
            SqlCommand.CommandText = @"Insert into Salas(nomeDaSala) values ('" + sala.sala + "');" +
                                      "Create table " + sala.sala + " (" +
                                      "ID smallint primary key identity," +
                                      "Alunos varchar(100) )" +
                                      "Create table " + sala.sala + "SegundaEtapa (" +
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
