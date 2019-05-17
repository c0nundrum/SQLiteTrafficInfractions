using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Windows.Forms;

namespace CShp_MAC.Models
{
    class ECarro : DAL
    {

        private byte[] PlacaImg { get; set; }
        private string DonoCPF { get; set; }
        private string PlacaNumero { get; set; }

        public string ROWID = "";
        private string OWNERID = "";

        //Metodo Construtor
        public ECarro(byte[] placaImg, string donoCPF, string placaNumero)
        {
            this.PlacaImg = placaImg;
            this.DonoCPF = donoCPF;
            this.PlacaNumero = placaNumero;

            ROWID = getIdFromCar(placaNumero);

            OWNERID = getOwnerId(donoCPF);



        }

        //Quando criado, tenha certeza que o carro tem um dono
        private void SetProprietario()
        {

            while (string.IsNullOrEmpty(OWNERID))
            {
                FInsertProprietario ownerForm = new FInsertProprietario(DonoCPF);

                var result = ownerForm.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    return;
                }

                OWNERID = getOwnerId(DonoCPF);

            }

        }

        public void InsertCarro()
        {
            SetProprietario();
            //Se não encontrado nenhuma placa igual no banco de dados
            if (string.IsNullOrEmpty(ROWID))
            {
                insertNewRow();
                MessageBox.Show("Entrada " + PlacaNumero + " inserida com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else //Caso encontre alguma entrada correspondente
            {
                UpdateRow();
                MessageBox.Show("Entrada " + PlacaNumero + " atualizada com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void insertNewRow()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    cmd.CommandText = "INSERT INTO CARRO(PLACA_NUMBER, PLACA, PROPRIETARIO_ID ) values (@PLACA_NUMBER, @PLACA, @PROPRIETARIO_ID)";

                    cmd.Parameters.AddWithValue("@PLACA_NUMBER", PlacaNumero);
                    cmd.Parameters.AddWithValue("@PLACA", PlacaImg);
                    cmd.Parameters.AddWithValue("@PROPRIETARIO_ID", OWNERID);

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

                    cmd.CommandText = "UPDATE CARRO SET PLACA_NUMBER = @PLACA_NUMBER, PLACA = @PLACA, PROPRIETARIO_ID = @PROPRIETARIO_ID WHERE ROWID = @ROWID";

                    cmd.Parameters.AddWithValue("@PLACA_NUMBER", PlacaNumero);
                    cmd.Parameters.AddWithValue("@PLACA", PlacaImg);
                    cmd.Parameters.AddWithValue("@PROPRIETARIO_ID", OWNERID);
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


        public static void DeleteRow(string numeroPlaca)
        {
            string ROWID = getIdFromCar(numeroPlaca);
            if (!string.IsNullOrEmpty(ROWID))
            {
                if (ForeignKeyINFRACAOCheck(ROWID))
                {
                    try
                    {
                        using (var cmd = new SQLiteCommand(DbConnection()))
                        {
                            cmd.CommandText = "DELETE FROM CARRO Where ROWID=@ROWID";
                            cmd.Parameters.AddWithValue("@ROWID", ROWID);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Entrada " + numeroPlaca + " deletada!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, limpe as infrações do carro", "Erro",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Entrada para deleção não encotrada", "Erro",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
