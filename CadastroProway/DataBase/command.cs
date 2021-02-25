using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CadastroProway.DataBase
{
    public class command
    {
        public string message = "";
        SqlCommand cmd = new SqlCommand();
        connection Con = new connection();
        public string Student(string nome)
        {
            cmd.CommandText = "insert into alunos values (@nome, @nomeID);";
            cmd.Parameters.AddWithValue("@nome", nome);
            try
            {
                cmd.Connection = Con.Connect();
                cmd.ExecuteNonQuery();
                Con.Disconnect();
                this.message = "Cadastrado com sucesso.";
            }
            catch (SqlException)
            {

                this.message = "erro no banco de dados.";
            }
            return message;
        }
        public string Room(string nomeSala)
        {
            cmd.CommandText = "insert into sala values (@nomeSala);";
            cmd.Parameters.AddWithValue("@nomeSala", nomeSala);
            try
            {
                cmd.Connection = Con.Connect();
                cmd.ExecuteNonQuery();
                Con.Disconnect();
                this.message = "Cadastrado com sucesso.";
            }
            catch (SqlException)
            {

                this.message = "erro no banco de dados.";
            }
            return message;
        }
        public string Coffee(string nomeCafe)
        {
            cmd.CommandText = "insert into cafe values (@nomeCafe);";
            cmd.Parameters.AddWithValue("@nomeCafe", nomeCafe);
            try
            {
                cmd.Connection = Con.Connect();
                cmd.ExecuteNonQuery();
                Con.Disconnect();
                this.message = "cadastrado com sucesso";
            }
            catch (SqlException)
            {

                this.message = "erro no banco de dados";
            }
            return message;
        }
    }
}
