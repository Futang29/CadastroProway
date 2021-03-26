using Domínio.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositórios
{
    public class RepositórioAluno : Repositório
    {
        public string Create(Aluno aluno)
        {
            SqlCommand.CommandText = "insert into Alunos values (@nome);";
            SqlCommand.Parameters.AddWithValue("@nome", aluno.nome);

            try
            {
                SqlCommand.Connection = Connection.Connect();
                SqlCommand.ExecuteNonQuery();
                Connection.Disconnect();

                Message = "Cadastrado com sucesso.";
            }
            catch (SqlException ex)
            {
                Message = "erro no banco de dados.";
            }

            return Message;
        }
    }
}
