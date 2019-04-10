using csharp_Sqlite.Models;
using System;
using System.Data;
using System.Data.SQLite;
using CShp_MAC.Models;
using System.Collections.Generic;

namespace csharp_Sqlite
{
    public class DalHelper
    {
        private static SQLiteConnection sqliteConnection;

        public DalHelper()
        { }

        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=D:\\dadosCadastro.sqlite; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }


        public static List<string> getCarsFromCPF(string cpf)
        {
            List<string> ImportedFiles = new List<string>();

            SQLiteDataAdapter da = null;

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Carros Where CPF= '" + cpf + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Console.Write("{0} ", rdr["NUMERO"]);
                            ImportedFiles.Add(Convert.ToString(rdr["NUMERO"]));
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ImportedFiles;
        }

        public static int generateRandomID()
        {
            Random random = new Random();
            return random.Next(9999);
        }

        public static void CriarBancoSQLite()
        {
            try
            {
                SQLiteConnection.CreateFile(@"D:\dados\Cadastro.sqlite");
            }
            catch
            {
                throw;
            }
        }
        public static void CriarTabelaSQlite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Carros(ID INTEGER, PLACA BLOB, CPF TEXT, NUMERO TEXT, MODELO TEXT)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CriarTabelaSQliteInfracoes()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Infracoes(CPF_CONDUTOR TEXT, INFRACOES TEXT, DATA TEXT, NUMERO_PLACA TEXT)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetCarros()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Carros";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetInfracoes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Infracoes";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetClientes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Clientes";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetCarro(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Carros Where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static DataTable GetCarro(string cpf)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Carros Where CPF= '" + cpf + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetCliente(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Carros Where Id=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AddCarro(Placa placa)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Carros(ID, PLACA, CPF, NUMERO, MODELO ) values (@ID, @PLACA, @CPF, @NUMERO, @MODELO)";
                    cmd.Parameters.AddWithValue("@ID", placa.ID);
                    cmd.Parameters.AddWithValue("@PLACA", placa.placaImg);
                    cmd.Parameters.AddWithValue("@CPF", placa.donoCPF);
                    cmd.Parameters.AddWithValue("@NUMERO", placa.placaNumero);
                    cmd.Parameters.AddWithValue("@MODELO", placa.modelo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Add(Cliente cliente)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Clientes(id, Nome, email ) values (@id, @nome, @email)";
                    cmd.Parameters.AddWithValue("@Id", cliente.Id);
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Update(Placa placa)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (placa.ID != null)
                    {
                        cmd.CommandText = "UPDATE Carros SET CPF=@CPF, NUMERO=@NUMERO, MODELO=@MODELO WHERE ID=@ID";
                        cmd.Parameters.AddWithValue("@ID", placa.ID);
                        cmd.Parameters.AddWithValue("@CPF", placa.donoCPF);
                        cmd.Parameters.AddWithValue("@NUMERO", placa.placaNumero);
                        cmd.Parameters.AddWithValue("@MODELO", placa.modelo);
                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Delete(int Id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM Carros Where Id=@ID";
                    cmd.Parameters.AddWithValue("@ID", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}