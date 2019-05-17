using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace CShp_MAC
{
    public partial class FProprietariosMaintenance : Form
    {

        private string NomeSelecionado = "";
        private string CpfSelecionado = "";

        public FProprietariosMaintenance()
        {
            InitializeComponent();
        }

        private bool valida()
        {
            if (!string.IsNullOrEmpty(CpfTxtBox.Text))
            {

                return true;

            }
            else
            {

                return false;

            }
        }

        private void filtraBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (string.IsNullOrEmpty(nomeTxtBox.Text) && string.IsNullOrEmpty(CpfTxtBox.Text))
            {

                dt = Models.DAL.populateProprietarioTable();

            }
            else if (!string.IsNullOrEmpty(nomeTxtBox.Text) && string.IsNullOrEmpty(CpfTxtBox.Text))
            {

                dt = Models.DAL.filtraProprietarioNome(nomeTxtBox.Text);

            }
            else if (string.IsNullOrEmpty(nomeTxtBox.Text) && !string.IsNullOrEmpty(CpfTxtBox.Text))
            {

                dt = Models.DAL.filtraProprietarioCPF(CpfTxtBox.Text);

            }
            else if (!string.IsNullOrEmpty(nomeTxtBox.Text) && !string.IsNullOrEmpty(CpfTxtBox.Text))
            {

                dt = Models.DAL.filtraProprietarioCPFNome(CpfTxtBox.Text, nomeTxtBox.Text);

            }

            proprietarioDados.DataSource = dt;

        }

        private void proprietarioDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.proprietarioDados.Rows[e.RowIndex];

                NomeSelecionado = row.Cells["NOME"].Value.ToString();
                CpfSelecionado = row.Cells["CPF"].Value.ToString();

                Debug.WriteLine(NomeSelecionado);
                Debug.WriteLine(CpfSelecionado);

                //UPDATE Infraction List

                nomeTxtBox.Text = NomeSelecionado;
                CpfTxtBox.Text = CpfSelecionado;

            }
        }

        private void addProprietario_Click(object sender, EventArgs e)
        {
            if (valida())
            {

                Models.EProprietario proprietario = new Models.EProprietario(nomeTxtBox.Text, CpfTxtBox.Text);
                proprietario.InsertProprietario();

            }
            else
            {
                MessageBox.Show("Por favor, insira um cpf.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void delProprietarioBtn_Click(object sender, EventArgs e)
        {
            if (valida())
            {

                Models.EProprietario.DeleteRow(CpfTxtBox.Text);

            }
            else
            {
                MessageBox.Show("Por favor, insira um cpf.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
