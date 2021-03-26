using System.Data.SqlClient;
using Dominio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Repositórios;

namespace DataBase.Repositórios
{
    public class RepositórioCadastro1 : Repositório
    {
        public string Create(FinalizarCadastro cadastro)
        {
            Message = "Cadastro Finalizado com sucesso";
            SqlCommand.CommandText = @"Select nomeDaSala From Salas where SalaID%2 = 0;";
            try
            {
                SqlCommand.Connection = Connection.Connect();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read())
                {

                }
            }
            catch (Exception)
            {

            }
            return Message;
        }
    }
}
