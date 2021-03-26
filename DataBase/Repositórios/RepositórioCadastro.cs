using Database.Repositórios;
using Dominio.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositórios
{
    public class RepositórioCadastro : Repositório
    {
        public string Create(FinalizarCadastro cadastro)
        {
            SqlCommand.CommandText = @"Select nomeDaSala from salas where SalaID%2 = 0;";

            try
            {
                SqlCommand.Connection = Connection.Connect();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    FinalizarCadastro FC = new FinalizarCadastro(Convert.ToString(reader["nomeDaSala"]));
                    SqlCommand.CommandText = @"insert into " + FC.cadastrar + " (Alunos) select nome from Alunos where ID%2 = 0;";
                    reader.Close();
                    try
                    {
                        SqlCommand.Connection = Connection.Connect();
                        SqlCommand.ExecuteNonQuery();
                        Connection.Disconnect();
                    }
                    catch (Exception)
                    {
                        Message = "Erro no banco de dados";
                    }

                    SqlCommand.CommandText = @"select nomeDaSala from Salas where SalaID%2 != 0;";

                    SqlCommand.Connection = Connection.Connect();
                    SqlDataReader reader1 = SqlCommand.ExecuteReader();
                    if (reader1.Read())
                    {
                        FinalizarCadastro FC1 = new FinalizarCadastro(Convert.ToString(reader1["nomeDaSala"]));
                        SqlCommand.CommandText = @"insert into " + FC1.cadastrar + " (Alunos) Select nome From Alunos where ID%2 != 0;";
                        reader1.Close();
                        try
                        {
                            SqlCommand.Connection = Connection.Connect();
                            SqlCommand.ExecuteNonQuery();
                            Connection.Disconnect();
                        }
                        catch (Exception ex)
                        {
                            Message = "Erro no banco de dados.";
                        }
                        SqlCommand.CommandText = @"insert into " + FC.cadastrar + "SegundaEtapa (Alunos) Select Alunos From " + FC1.cadastrar + " where ID%2 = 0;" +
                                                  " Insert into " + FC.cadastrar + "SegundaEtapa (Alunos) Select Alunos from " + FC.cadastrar + " where ID%2 != 0;" +
                                                  " Insert into " + FC1.cadastrar + "SegundaEtapa (Alunos) Select Alunos From " + FC.cadastrar + " where ID%2 = 0;" +
                                                  " Insert into " + FC1.cadastrar + "SegundaEtapa (Alunos) Select Alunos From " + FC1.cadastrar + " where ID%2 != 0;";
                        try
                        {
                            SqlCommand.Connection = Connection.Connect();
                            SqlCommand.ExecuteNonQuery();
                            Connection.Disconnect();
                        }
                        catch (Exception ex)
                        {
                            Message = "Erro no banco de dados.";
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Message = "Erro no banco de dados";
            }
            SqlCommand.CommandText = @"Select nomeDoCafe from CAFES where cafeID%2 = 0;";
            try
            {
                SqlCommand.Connection = Connection.Connect();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    FinalizarCadastro FC = new FinalizarCadastro(Convert.ToString(reader["nomeDoCafe"]));
                    SqlCommand.CommandText = @"insert into " + FC.cadastrar + " (Alunos) select nome from Alunos where ID%2 !=0;";
                    reader.Close();
                    try
                    {
                        SqlCommand.Connection = Connection.Connect();
                        SqlCommand.ExecuteNonQuery();
                        Connection.Disconnect();
                    }
                    catch (Exception)
                    {
                        Message = "Erro no banco de dados.";
                    }
                }
                reader.Close();
                Connection.Disconnect();
            }
            catch (Exception)
            {
                Message = "Erro no banco de dados.";
            }
            SqlCommand.CommandText = @"Select nomeDoCafe from CAFES where cafeID%2 != 0;";
            try
            {
                SqlCommand.Connection = Connection.Connect();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    FinalizarCadastro FC = new FinalizarCadastro(Convert.ToString(reader["nomeDoCafe"]));
                    SqlCommand.CommandText = @"insert into " + FC.cadastrar + " (Alunos) select nome from Alunos where ID%2 = 0;";
                    reader.Close();
                    try
                    {
                        SqlCommand.Connection = Connection.Connect();
                        SqlCommand.ExecuteNonQuery();
                        Connection.Disconnect();
                    }
                    catch (Exception)
                    {
                        Message = "Erro no banco de dados.";
                    }
                }
                reader.Close();
                Connection.Disconnect();
                Message = "Cadastro finalizado com sucesso.";
            }
            catch (Exception)
            {
                Message = "Erro no banco de dados.";
            }

            return Message;
        }
    }
}
