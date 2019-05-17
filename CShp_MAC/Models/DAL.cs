using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;

namespace CShp_MAC.Models
{
    class DAL
    {

        //inicia o Parâmetro da conexão
        protected static SQLiteConnection sqliteConnection;

        //Cria conexão
        protected static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=D:\\dados\\Cadastro.sqlite; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

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
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS CARRO(ID INTEGER PRIMARY KEY AUTOINCREMENT, PLACA_NUMBER TEXT UNIQUE NOT NULL, PLACA BLOB, PROPRIETARIO_ID INT, FOREIGN KEY(PROPRIETARIO_ID) REFERENCES PROPRIETARIO(ID))";

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

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS PROPRIETARIO(ID INTEGER PRIMARY KEY AUTOINCREMENT, CPF TEXT UNIQUE NOT NULL, NOME TEXT)";

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
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS INFRACOES(ID INTEGER PRIMARY KEY AUTOINCREMENT, PROPRIETARIO_ID INT, CARRO_ID INT, INFRACOES TEXT NOT NULL, DATA TEXT NOT NULL, UNIQUE (INFRACOES, DATA, PROPRIETARIO_ID) , FOREIGN KEY(PROPRIETARIO_ID) REFERENCES PROPRIETARIO(ID), FOREIGN KEY(CARRO_ID) REFERENCES CARRO(ID))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Metodos para encontro dos IDS de tabelas
        public static string getOwnerId(string cpf)
        {

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    Debug.WriteLine("Procurando: " + cpf);

                    cmd.CommandText = "SELECT ROWID FROM PROPRIETARIO WHERE CPF = @CPF";
                    cmd.Parameters.AddWithValue("@CPF", cpf);

                    object result = cmd.ExecuteScalar();

                    Debug.WriteLine("Encontrado em: " + result);

                    return (result == null ? "" : result.ToString());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        public static string getIdFromCar(string placa)
        {

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    Debug.WriteLine("Procurando: " + placa);

                    cmd.CommandText = "SELECT ROWID FROM CARRO WHERE PLACA_NUMBER = @PLACA_NUMBER";
                    cmd.Parameters.AddWithValue("@PLACA_NUMBER", placa);

                    object result = cmd.ExecuteScalar();

                    Debug.WriteLine("Encontrado em: " + result);

                    return (result == null ? "" : result.ToString());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Excepted in getIdFromPlaca");
                throw ex;
            }
        }

        public static string getIdFromInfraction(string infracoes, string data, string cpf)
        {

            string proprietario_ID = getOwnerId(cpf);


            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {


                    cmd.CommandText = "SELECT ROWID FROM INFRACOES WHERE INFRACOES = @INFRACOES AND DATA = @DATA AND PROPRIETARIO_ID = @PROPRIETARIO_ID";
                    cmd.Parameters.AddWithValue("@INFRACOES", infracoes);
                    cmd.Parameters.AddWithValue("@DATA", data);
                    cmd.Parameters.AddWithValue("@PROPRIETARIO_ID", proprietario_ID);

                    object result = cmd.ExecuteScalar();

                    Debug.WriteLine("Encontrado em: " + result);

                    return (result == null ? "" : result.ToString());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Excepted in getIdFromPlaca");
                throw ex;
            }
        }

        public static bool ForeignKeyINFRACAOCheck(string rowID)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    cmd.CommandText = "SELECT ROWID FROM INFRACOES WHERE CARRO_ID = @CARRO_ID";
                    cmd.Parameters.AddWithValue("@CARRO_ID", rowID);

                    object result = cmd.ExecuteScalar();

                    string resultINFRACOES = result == null ? "" : result.ToString();

                    Debug.WriteLine("Infracao: " + resultINFRACOES);


                    if (string.IsNullOrEmpty(resultINFRACOES))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Excepted in getIdFromPlaca");
                throw ex;
            }
        }


        public static bool ForeignKeyCheck(string rowID)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {


                    cmd.CommandText = "SELECT ROWID FROM CARRO WHERE PROPRIETARIO_ID = @PROPRIETARIO_ID";
                    cmd.Parameters.AddWithValue("@PROPRIETARIO_ID", rowID);

                    object result = cmd.ExecuteScalar();


                    string resultCARRO = result == null ? "" : result.ToString();
                    Debug.WriteLine("Carro: " + resultCARRO);

                    cmd.CommandText = "SELECT ROWID FROM INFRACOES WHERE PROPRIETARIO_ID = @PROPRIETARIO_ID";
                    cmd.Parameters.AddWithValue("@PROPRIETARIO_ID", rowID);

                    result = cmd.ExecuteScalar();

                    string resultINFRACOES = result == null ? "" : result.ToString();

                    Debug.WriteLine("Infracao: " + resultINFRACOES);


                    if (string.IsNullOrEmpty(resultCARRO) && string.IsNullOrEmpty(resultINFRACOES))
                    {
                        return true;
                    } else
                    {
                        return false;
                    }

                    
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Excepted in getIdFromPlaca");
                throw ex;
            }
        }

        //Metodos para popular a tabela
        public static DataTable populateInfracoesTable()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT INFRACOES, DATA, PLACA_NUMBER, CPF, NOME AS CONDUTOR FROM INFRACOES INNER JOIN PROPRIETARIO ON INFRACOES.PROPRIETARIO_ID = PROPRIETARIO.ROWID INNER JOIN CARRO ON INFRACOES.CARRO_ID = CARRO.ROWID";
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
                    cmd.CommandText = "SELECT PLACA_NUMBER, PLACA, CPF, NOME AS PROPRIETARIO FROM CARRO INNER JOIN PROPRIETARIO ON CARRO.PROPRIETARIO_ID = PROPRIETARIO.ROWID";
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

        public static DataTable populateProprietarioTable()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT NOME, CPF FROM PROPRIETARIO";
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

        public static DataTable filtraProprietarioNome(string nome)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT NOME, CPF FROM PROPRIETARIO WHERE NOME LIKE '%" + nome + "%'";
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

        public static DataTable filtraProprietarioCPF(string cpf)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT NOME, CPF FROM PROPRIETARIO WHERE CPF = '" + cpf + "'";
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

        public static DataTable filtraProprietarioCPFNome(string cpf, string nome)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT NOME, CPF FROM PROPRIETARIO WHERE CPF = '" + cpf + "' AND NOME LIKE '%" + nome + "%'";
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

        public static DataTable filtraCarroNome(string nome)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT PLACA_NUMBER, PLACA, CPF, NOME FROM CARRO INNER JOIN PROPRIETARIO ON CARRO.PROPRIETARIO_ID = PROPRIETARIO.ROWID WHERE NOME LIKE '%" + nome + "%'";
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

        public static DataTable filtraInfracaoNome(string nome)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT INFRACOES, DATA, PLACA_NUMBER, CPF, NOME FROM INFRACOES INNER JOIN PROPRIETARIO ON INFRACOES.PROPRIETARIO_ID = PROPRIETARIO.ROWID INNER JOIN CARRO ON INFRACOES.CARRO_ID = CARRO.ROWID WHERE NOME LIKE '%" + nome + "%'";
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


        public static DataTable filtraPlacasCarros(string numPlaca)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT PLACA_NUMBER, PLACA, CPF, NOME FROM CARRO INNER JOIN PROPRIETARIO ON CARRO.PROPRIETARIO_ID = PROPRIETARIO.ROWID WHERE PLACA_NUMBER = '" + numPlaca + "'";
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


        public static DataTable filtraCPFCarros(string cpf)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT PLACA_NUMBER, PLACA, CPF, NOME FROM CARRO INNER JOIN PROPRIETARIO ON CARRO.PROPRIETARIO_ID = PROPRIETARIO.ROWID WHERE CPF = '" + cpf + "'";
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

        public static DataTable filtraCPFPlacasCarros(string numplaca, string cpf)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT PLACA_NUMBER, PLACA, CPF, NOME FROM CARRO INNER JOIN PROPRIETARIO ON CARRO.PROPRIETARIO_ID = PROPRIETARIO.ID WHERE PLACA_NUMBER = '" + numplaca + "' AND CPF= '" + cpf + "'";
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

        public static DataTable filtraPlacasInfracoes(string numPlaca)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT INFRACOES, DATA, PLACA_NUMBER, CPF, NOME FROM INFRACOES INNER JOIN PROPRIETARIO ON INFRACOES.PROPRIETARIO_ID = PROPRIETARIO.ROWID INNER JOIN CARRO ON INFRACOES.CARRO_ID = CARRO.ROWID WHERE PLACA_NUMBER = '" + numPlaca + "'";
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

        public static DataTable filtraCPFInfracoes(string cpf)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT INFRACOES, DATA, PLACA_NUMBER, CPF, NOME FROM INFRACOES INNER JOIN PROPRIETARIO ON INFRACOES.PROPRIETARIO_ID = PROPRIETARIO.ROWID INNER JOIN CARRO ON INFRACOES.CARRO_ID = CARRO.ROWID WHERE CPF = '" + cpf + "'";
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

        public static DataTable filtraCPFPlacasInfracoes(string numplaca, string cpf)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT INFRACOES, DATA, PLACA_NUMBER, CPF, NOME FROM INFRACOES INNER JOIN PROPRIETARIO ON INFRACOES.PROPRIETARIO_ID = PROPRIETARIO.ROWID INNER JOIN CARRO ON INFRACOES.CARRO_ID = CARRO.ROWID WHERE PLACA_NUMBER = '" + numplaca + "' AND CPF= '" + cpf + "'";
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
    }
}
