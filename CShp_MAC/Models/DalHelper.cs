﻿using csharp_Sqlite.Models;
using System;
using System.Data;
using System.Data.SQLite;
using CShp_MAC.Models;
using System.Collections.Generic;
using CShp_MAC;
using System.Windows.Forms;
using System.Diagnostics;

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

        //THIS GOES TO THE NEW CHILD METHOD
        public static void AddCarro(Placa placa)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    string ownerId = getOwnerId(placa.donoCPF);


                    while (string.IsNullOrEmpty(ownerId))
                    {
                        Form4 ownerForm = new Form4(placa.donoCPF);

                        var result = ownerForm.ShowDialog();

                        if (result == DialogResult.Cancel)
                        {
                            return;
                        }

                        ownerId = getOwnerId(placa.donoCPF);

                    }


                    cmd.CommandText = "INSERT OR REPLACE INTO CARRO(PLACA_NUMBER, PLACA, PROPRIETARIO_ID ) values (@PLACA_NUMBER, @PLACA, @PROPRIETARIO_ID)";

                    cmd.Parameters.AddWithValue("@PLACA_NUMBER", placa.placaNumero);
                    cmd.Parameters.AddWithValue("@PLACA", placa.placaImg);
                    cmd.Parameters.AddWithValue("@PROPRIETARIO_ID", ownerId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Excepted in AddCarro");
                throw ex;
            }
        }

        //THIS GOES TO THE NEW CHILD METHOD
        public static void deleteCarro(string RowId)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM CARRO Where ROWID=@ROWID";
                    cmd.Parameters.AddWithValue("@ROWID", RowId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //THIS GOES TO THE NEW CHILD METHOD
        public static void deleteInfracao(string RowId)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM INFRACOES Where ROWID=@ROWID";
                    cmd.Parameters.AddWithValue("@ROWID", RowId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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

        public static string getIdFromPlaca(string placa)
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

        //THIS GOES TO THE NEW CHILD METHOD
        public static void insertProprietario(string nome, string cpf)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    cmd.CommandText = "INSERT INTO PROPRIETARIO(CPF, NOME) values (@CPF, @NOME)";

                    cmd.Parameters.AddWithValue("@CPF", cpf);
                    cmd.Parameters.AddWithValue("@NOME", nome);

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

        //THIS GOES TO THE NEW CHILD METHOD
        public static void insertInfracoes(Infracao infracao)
        {

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    string ownerId = getOwnerId(infracao.cpfNumero);
                    string carId = getIdFromPlaca(infracao.placaNumero);

                    while (string.IsNullOrEmpty(ownerId))
                    {
                        Form4 ownerForm = new Form4(infracao.cpfNumero);

                        var result = ownerForm.ShowDialog();

                        if (result == DialogResult.Cancel)
                        {
                            return;
                        }

                        ownerId = getOwnerId(infracao.cpfNumero);

                    }

                    cmd.CommandText = "INSERT OR REPLACE INTO INFRACOES(PROPRIETARIO_ID, INFRACOES, DATA, CARRO_ID ) values (@PROPRIETARIO_ID, @INFRACOES, @DATA, @CARRO_ID)";

                    cmd.Parameters.AddWithValue("@PROPRIETARIO_ID", ownerId);
                    cmd.Parameters.AddWithValue("@INFRACOES", infracao.infracao);
                    cmd.Parameters.AddWithValue("@DATA", infracao.data);
                    cmd.Parameters.AddWithValue("@CARRO_ID", carId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Excepted in AddCarro");
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
                    cmd.CommandText = "SELECT INFRACOES, DATA, PLACA_NUMBER, CPF, NOME FROM INFRACOES LEFT OUTER JOIN PROPRIETARIO ON INFRACOES.PROPRIETARIO_ID = PROPRIETARIO.ROWID LEFT OUTER JOIN CARRO ON INFRACOES.CARRO_ID = CARRO.ROWID";
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
                    cmd.CommandText = "SELECT PLACA_NUMBER, PLACA, CPF, NOME FROM CARRO INNER JOIN PROPRIETARIO ON CARRO.PROPRIETARIO_ID = PROPRIETARIO.ROWID";
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