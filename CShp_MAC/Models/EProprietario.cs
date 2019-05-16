using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShp_MAC.Models
{
    class EProprietario : DAL
    {

        private string Nome { get; set; }
        private string Cpf { get; set; }

        private string ROWID = "";
        
        public EProprietario(string nome, string cpf)
        {

            this.Nome = nome;
            this.Cpf = cpf;

            ROWID = getOwnerId(Cpf);

        }

        public void InsertProprietario()
        {
            //Se não encontrado nenhuma placa igual no banco de dados
            if (string.IsNullOrEmpty(ROWID))
            {
                insertNewRow();
                MessageBox.Show("Entrada " + Cpf + " inserida com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else //Caso encontre alguma entrada correspondente
            {
                UpdateRow();
                MessageBox.Show("Entrada " + Cpf + " atualizada com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void insertNewRow()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    cmd.CommandText = "INSERT INTO PROPRIETARIO(CPF, NOME) values (@CPF, @NOME)";

                    cmd.Parameters.AddWithValue("@CPF", Cpf);
                    cmd.Parameters.AddWithValue("@NOME", Nome);

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

                    cmd.CommandText = "UPDATE PROPRIETARIO SET CPF = @CPF, NOME = @NOME WHERE ROWID = @ROWID";

                    cmd.Parameters.AddWithValue("@CPF", Cpf);
                    cmd.Parameters.AddWithValue("@NOME", Nome);
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

        public static void DeleteRow(string cpf)
        {
            string ROWID = getOwnerId(cpf);
            if (!string.IsNullOrEmpty(ROWID))
            {
                if (ForeignKeyCheck(ROWID)) {

                    try
                    {
                        using (var cmd = new SQLiteCommand(DbConnection()))
                        {

                            cmd.CommandText = "DELETE FROM PROPRIETARIO Where ROWID=@ROWID";
                            cmd.Parameters.AddWithValue("@ROWID", ROWID);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Entrada " + cpf + " deletada!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                } else
                {
                    MessageBox.Show("Livre o cpf de carros e infrações primeiro", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
