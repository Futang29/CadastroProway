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

    public class RepositórioConAluno : Repositório
    {
        public string Create(consultaAluno2 aluno2)
        {

            try  //SALA PAR, CAFÉ IMPAR, SEGUNDA SALA PAR.
            {
                SqlCommand.CommandText = @"Select nomeDaSala from SALAS where SalaID%2 = 0;";
                SqlCommand.Connection = Connection.Connect();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    consultaAluno CA = new consultaAluno(Convert.ToString(reader["nomeDaSala"]));
                    SqlCommand.CommandText = @"Select * from " + CA.nomeSala + " where Alunos = '" + aluno2.nome + "';";
                    reader.Close();
                    try
                    {
                        SqlCommand.Connection = Connection.Connect();
                        SqlDataReader reader2 = SqlCommand.ExecuteReader();

                        if (reader2.HasRows)
                        {
                            SqlCommand.CommandText = @"Select nomeDoCafe from CAFES where cafeID%2 != 0;";
                            reader2.Close();
                            try
                            {
                                SqlCommand.Connection = Connection.Connect();
                                SqlDataReader reader1 = SqlCommand.ExecuteReader();
                                if (reader1.Read())
                                {
                                    consultaAluno CA1 = new consultaAluno(Convert.ToString(reader1["nomeDoCafe"]));
                                    SqlCommand.CommandText = @"Select Alunos from " + CA1.nomeSala + " where Alunos = '" + aluno2.nome + "';";
                                    reader1.Close();
                                    SqlDataReader reader3 = SqlCommand.ExecuteReader();
                                    if (reader3.Read())
                                    {
                                        consultaAluno CA2 = new consultaAluno(Convert.ToString(reader3["Alunos"]));
                                        reader3.Close();
                                        SqlCommand.CommandText = @"Select Alunos from " + CA.nomeSala + "SegundaEtapa where Alunos = '" + aluno2.nome + "';";
                                        SqlDataReader reader4 = SqlCommand.ExecuteReader();
                                        if (reader3.HasRows)
                                        {
                                            consultaAluno CA4 = new consultaAluno(Convert.ToString(reader4["Alunos"]));
                                            if (reader4.HasRows)
                                            {
                                                Message = "Sala: " + CA.nomeSala + ", Espaço de Café: " + CA1.nomeSala + ", Sala da Segunda Etapa: " + CA4.nomeSala + ".";
                                            }
                                        }
                                        else
                                        {
                                            reader3.Close();
                                        }
                                    }
                                    reader3.Close();

                                }
                                reader1.Close();
                            }
                            catch (Exception)
                            {

                            }
                        }
                        else
                        {
                            reader2.Close();
                        }
                        Connection.Disconnect();


                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    reader.Close();
                }
            }
            catch (Exception)
            {

            }
            try  //SALA IMPAR, CAFÉ PAR, SEGUNDA SALA IMPAR
            {
                SqlCommand.CommandText = @"Select nomeDaSala from SALAS where SalaID%2 != 0;";
                SqlCommand.Connection = Connection.Connect();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    consultaAluno CA = new consultaAluno(Convert.ToString(reader["nomeDaSala"]));
                    SqlCommand.CommandText = @"Select * from " + CA.nomeSala + " where Alunos = '" + aluno2.nome + "';";
                    reader.Close();
                    try
                    {
                        SqlCommand.Connection = Connection.Connect();
                        SqlDataReader reader2 = SqlCommand.ExecuteReader();

                        if (reader2.HasRows)
                        {
                            SqlCommand.CommandText = @"Select nomeDoCafe from CAFES where cafeID%2 = 0;";
                            reader2.Close();
                            try
                            {
                                SqlCommand.Connection = Connection.Connect();
                                SqlDataReader reader1 = SqlCommand.ExecuteReader();
                                if (reader1.Read())
                                {
                                    consultaAluno CA1 = new consultaAluno(Convert.ToString(reader1["nomeDoCafe"]));
                                    SqlCommand.CommandText = @"Select Alunos from " + CA1.nomeSala + " where Alunos = '" + aluno2.nome + "';";
                                    reader1.Close();
                                    SqlDataReader reader3 = SqlCommand.ExecuteReader();
                                    if(reader3.Read())
                                    {
                                        consultaAluno CA2 = new consultaAluno(Convert.ToString(reader3["Alunos"]));
                                        SqlCommand.CommandText = @"Select Alunos from " + CA.nomeSala + "SegundaEtapa where Alunos = '" + aluno2.nome + "';";
                                        SqlDataReader reader4 = SqlCommand.ExecuteReader();
                                        if (reader3.HasRows)
                                        {
                                            reader3.Close();
                                            consultaAluno CA4 = new consultaAluno(Convert.ToString(reader4["Alunos"]));
                                            if (reader4.HasRows)
                                            {
                                                Message = "Sala: " + CA.nomeSala + ", Espaço de Café: " + CA1.nomeSala + ", Sala da Segunda Etapa: " + CA4.nomeSala + ".";
                                                reader4.Close();
                                            }
                                            else
                                            {
                                                reader4.Close();

                                            }
                                        }
                                        else
                                        {
                                            reader3.Close();
                                        }
                                    }
                                    reader3.Close();

                                }
                                else
                                {
                                    reader1.Close();
                                }
                            }
                            catch (Exception)
                            {

                            }
                        }
                        else
                        {
                            reader2.Close();
                        }
                        Connection.Disconnect();


                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    reader.Close();
                }
            }
            catch (Exception ex)
            {

            }
            try  //SALA IMPAR, CAFÉ PAR, SEGUNDA SALA PAR
            {
                SqlCommand.CommandText = @"Select nomeDaSala from SALAS where SalaID%2 != 0;";
                SqlCommand.Connection = Connection.Connect();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    consultaAluno CA = new consultaAluno(Convert.ToString(reader["nomeDaSala"]));
                    SqlCommand.CommandText = @"Select * from " + CA.nomeSala + " where Alunos = '" + aluno2.nome + "';";
                    reader.Close();
                    try
                    {
                        SqlCommand.Connection = Connection.Connect();
                        SqlDataReader reader2 = SqlCommand.ExecuteReader();

                        if (reader2.HasRows)
                        {
                            SqlCommand.CommandText = @"Select nomeDoCafe from CAFES where cafeID%2 = 0;";
                            reader2.Close();
                            try
                            {
                                SqlCommand.Connection = Connection.Connect();
                                SqlDataReader reader1 = SqlCommand.ExecuteReader();
                                if (reader1.Read())
                                {
                                    consultaAluno CA1 = new consultaAluno(Convert.ToString(reader1["nomeDoCafe"]));
                                    SqlCommand.CommandText = @"Select Alunos from " + CA1.nomeSala + " where Alunos = '" + aluno2.nome + "';";
                                    reader1.Close();
                                    SqlDataReader reader3 = SqlCommand.ExecuteReader();
                                    if (reader3.Read())
                                    {
                                        consultaAluno CA2 = new consultaAluno(Convert.ToString(reader3["Alunos"]));
                                        if (reader3.HasRows)
                                        {
                                            reader3.Close();
                                            SqlCommand.CommandText = @"Select nomeDaSala from Salas where SalaID%2 = 0;";
                                            SqlDataReader reader4 = SqlCommand.ExecuteReader();
                                            if (reader4.Read())
                                            {
                                                consultaAluno CA3 = new consultaAluno(Convert.ToString(reader3["nomeDaSala"]));
                                                reader4.Close();
                                                SqlCommand.CommandText = @"Select Alunos from " + CA3.nomeSala + "SegundaEtapa where Alunos = '" + aluno2.nome + "';";
                                                SqlDataReader reader5 = SqlCommand.ExecuteReader();
                                                if(reader5.Read())
                                                {
                                                    consultaAluno CA4 = new consultaAluno(Convert.ToString(reader5["Alunos"]));
                                                    reader5.Close();
                                                    if(reader5.HasRows)
                                                    { 
                                                        Message = "Sala: " + CA.nomeSala + ", Espaço de Café: " + CA1.nomeSala + ", Sala da Segunda Etapa " + CA4 + ".";
                                                        reader5.Close();
                                                    }
                                                    else
                                                    {
                                                        reader5.Close();
                                                    }
                                                }
                                                else
                                                {
                                                    reader5.Close();
                                                }
                                            }
                                            else
                                            {
                                                reader4.Close();
                                            }
                                        }
                                        else
                                        {
                                            reader3.Close();
                                        }
                                    }
                                    reader3.Close();

                                }
                                else
                                {
                                    reader1.Close();
                                }
                            }
                            catch (Exception)
                            {

                            }
                        }
                        else
                        {
                            reader2.Close();
                        }
                        Connection.Disconnect();


                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    reader.Close();
                }
            }
            catch (Exception ex)
            {

            }
            try  //SALA IMPAR, CAFÉ PAR, SEGUNDA SALA IMPAR
            {
                SqlCommand.CommandText = @"Select nomeDaSala from SALAS where SalaID%2 != 0;";
                SqlCommand.Connection = Connection.Connect();
                SqlDataReader reader = SqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    consultaAluno CA = new consultaAluno(Convert.ToString(reader["nomeDaSala"]));
                    SqlCommand.CommandText = @"Select * from " + CA.nomeSala + " where Alunos = '" + aluno2.nome + "';";
                    reader.Close();
                    try
                    {
                        SqlCommand.Connection = Connection.Connect();
                        SqlDataReader reader2 = SqlCommand.ExecuteReader();

                        if (reader2.HasRows)
                        {
                            SqlCommand.CommandText = @"Select nomeDoCafe from CAFES where cafeID%2 = 0;";
                            reader2.Close();
                            try
                            {
                                SqlCommand.Connection = Connection.Connect();
                                SqlDataReader reader1 = SqlCommand.ExecuteReader();
                                if (reader1.Read())
                                {
                                    consultaAluno CA1 = new consultaAluno(Convert.ToString(reader1["nomeDoCafe"]));
                                    SqlCommand.CommandText = @"Select Alunos from " + CA1.nomeSala + " where Alunos = '" + aluno2.nome + "';";
                                    reader1.Close();
                                    SqlDataReader reader3 = SqlCommand.ExecuteReader();
                                    if (reader3.Read())
                                    {
                                        consultaAluno CA2 = new consultaAluno(Convert.ToString(reader3["Alunos"]));
                                        if (reader3.HasRows)
                                            reader3.Close();
                                        SqlCommand.CommandText = @"Select nomeDaSala from Salas where SalaID%2 != 0;";
                                        SqlDataReader reader4 = SqlCommand.ExecuteReader();
                                        if (reader4.Read())
                                        {
                                            consultaAluno CA3 = new consultaAluno(Convert.ToString(reader3["nomeDaSala"]));
                                            reader4.Close();
                                            SqlCommand.CommandText = @"Select Alunos from " + CA3.nomeSala + "SegundaEtapa where Alunos = '" + aluno2.nome + "';";
                                            SqlDataReader reader5 = SqlCommand.ExecuteReader();
                                            if (reader5.Read())
                                            {
                                                consultaAluno CA4 = new consultaAluno(Convert.ToString(reader5["Alunos"]));
                                                reader5.Close();
                                                if (reader5.HasRows)
                                                {
                                                    Message = "Sala: " + CA.nomeSala + ", Espaço de Café: " + CA1.nomeSala + ", Sala da Segunda Etapa " + CA4 + ".";
                                                    reader5.Close();
                                                }
                                                else
                                                {
                                                    reader5.Close();
                                                }
                                            }
                                            else
                                            {
                                                reader5.Close();
                                            }
                                        }
                                        else
                                        {
                                            reader4.Close();
                                        }

                                    }
                                    else
                                    {
                                        reader3.Close();
                                    }
                                }
                                else
                                {
                                    reader1.Close();
                                }
                            }
                            catch (Exception)
                            {

                            }
                        }
                        else
                        {
                            reader2.Close();
                        }
                        Connection.Disconnect();


                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    reader.Close();
                }
            }
            catch (Exception ex)
            {

            }

            return Message;
        }
    }
}