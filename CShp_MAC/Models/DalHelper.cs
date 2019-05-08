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

        //Cria conexão
        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=D:\\dados\\Cadastro.sqlite; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }


        //public static List<string> getCarsFromCPF(string cpf)
        //{
        //    List<string> ImportedFiles = new List<string>();

        //    SQLiteDataAdapter da = null;

        //    try
        //    {
        //        using (var cmd = DbConnection().CreateCommand())
        //        {
        //            cmd.CommandText = "SELECT * FROM Carros Where CPF= '" + cpf + "'";
        //            da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());

        //            using (SQLiteDataReader rdr = cmd.ExecuteReader())
        //            {
        //                while (rdr.Read())
        //                {
        //                    Console.Write("{0} ", rdr["NUMERO"]);
        //                    ImportedFiles.Add(Convert.ToString(rdr["NUMERO"]));
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return ImportedFiles;
        //}

        //public static int generateRandomID()
        //{
        //    Random random = new Random();
        //    return random.Next(9999);
        //}

        //Cria o banco de dados
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

        //CRIA TABELAS
        public static void CriarTableCarroSQlite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    //cmd.CommandText = "CREATE TABLE IF NOT EXISTS Carros(ID INTEGER, PLACA BLOB, CPF TEXT, NUMERO TEXT, MODELO TEXT)";
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS CARRO(ID INT PRIMARY KEY, PLACA_NUMBER TEXT UNIQUE NOT NULL, PLACA BLOB, PROPRIETARIO_ID INT, FOREIGN KEY(PROPRIETARIO_ID) REFERENCES PROPRIETARIO(ID))";

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void CriarTableProprietarioSQlite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS PROPRIETARIO(ID INT PRIMARY KEY, CPF TEXT UNIQUE NOT NULL, NOME TEXT)";

                    cmd.ExecuteNonQuery();

                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void CriarTableInfracoesSQlite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS INFRACOES(ID INT PRIMARY KEY, PROPRIETARIO_ID INT, INFRACOES TEXT, DATA TEXT, CARRO_ID INT, FOREIGN KEY(PROPRIETARIO_ID) REFERENCES PROPRIETARIO(ID), FOREIGN KEY(CARRO_ID) REFERENCES CARRO(ID))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Table Populating methods

        public static DataTable populateInfracoesTable()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT INFRACOES, DATA FROM INFRACOES";
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

        public static DataTable populateCarroTable()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT PLACA_NUMBER, PLACA, CPF FROM CARRO INNER JOIN PROPRIETARIO ON CARRO.PROPRIETARIO_ID = PROPRIETARIO.ID";
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

        //Metodos de filtragem

        public static DataTable filtraPlacasCarros(string numPlaca)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT PLACA_NUMBER, PLACA, CPF FROM CARRO INNER JOIN PROPRIETARIO ON CARRO.PROPRIETARIO_ID = PROPRIETARIO.ID WHERE PLACA_NUMBER=" + numPlaca;
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

        public static DataTable filtraCPFCarros(string numPlaca)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT PLACA_NUMBER, PLACA FROM CARRO INNER JOIN PROPRIETARIO ON CARRO.PROPRIETARIO_ID = PROPRIETARIO.ID WHERE PLACA_NUMBER=" + numPlaca;
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

        //----------------- OLD METHODS

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