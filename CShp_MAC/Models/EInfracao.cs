using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Windows.Forms;

namespace CShp_MAC.Models
{
    class EInfracao : DAL
    {

        private string Infracao { get; set; }
        private string Data { get; set; }
        private string PlacaNumero { get; set; }
        private string CpfNumero { get; set; }

        private string ROWID = "";
        private string OWNERID = "";
        private string CARID = "";

        public EInfracao(string infracao, string data, string placaNumero, string cpfNumero)
        {

            this.Infracao = infracao;
            this.Data = data;
            this.PlacaNumero = placaNumero;
            this.CpfNumero = cpfNumero;

            ROWID = getIdFromInfraction(Infracao, Data, CpfNumero);
            OWNERID = getOwnerId(cpfNumero);
            CARID = getIdFromCar(placaNumero);

        }

        public void InsertInfracao()
        {
            //Se não encontrado nenhuma placa igual no banco de dados
            if (string.IsNullOrEmpty(ROWID))
            {
                insertNewRow();
                MessageBox.Show("Entrada " + Infracao + " inserida com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else //Caso encontre alguma entrada correspondente
            {
                UpdateRow();
                MessageBox.Show("Entrada " + Infracao + " atualizada com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void insertNewRow()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    cmd.CommandText = "INSERT INTO INFRACOES(PROPRIETARIO_ID, INFRACOES, DATA, CARRO_ID ) values (@PROPRIETARIO_ID, @INFRACOES, @DATA, @CARRO_ID)";

                    cmd.Parameters.AddWithValue("@PROPRIETARIO_ID", OWNERID);
                    cmd.Parameters.AddWithValue("@INFRACOES", Infracao);
                    cmd.Parameters.AddWithValue("@DATA", Data);
                    cmd.Parameters.AddWithValue("@CARRO_ID", CARID);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Excepted in insertNewRow");
                throw ex;
            }
        }

        private void UpdateRow()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    cmd.CommandText = "UPDATE INFRACOES SET PROPRIETARIO_ID = @PROPRIETARIO_ID, INFRACOES = @INFRACOES, DATA = @DATA, CARRO_ID = @CARRO_ID WHERE ROWID = @ROWID";

                    cmd.Parameters.AddWithValue("@PROPRIETARIO_ID", OWNERID);
                    cmd.Parameters.AddWithValue("@PLACA", Infracao);
                    cmd.Parameters.AddWithValue("@PROPRIETARIO_ID", Data);
                    cmd.Parameters.AddWithValue("@CARRO_ID", CARID);
                    cmd.Parameters.AddWithValue("@ROWID", ROWID);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Excepted in UPDATEROW");
                throw ex;
            }
        }

        public static void DeleteRow(string infracao, string data, string cpfNumero)
        {
            string ROWID = getIdFromInfraction(infracao, data, cpfNumero);
            if (!string.IsNullOrEmpty(ROWID))
            {
                try
                {
                    using (var cmd = new SQLiteCommand(DbConnection()))
                    {
                        cmd.CommandText = "DELETE FROM INFRACOES Where ROWID=@ROWID";
                        cmd.Parameters.AddWithValue("@ROWID", ROWID);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Entrada " + data + " deletada!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            else
            {
                MessageBox.Show("Entrada da deleção não encontrada", "Erro",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
