using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using CShp_MAC.Models;
using System.Diagnostics;
using System.Drawing;

namespace CShp_MAC
{
    public partial class FMainWindow : Form
    {

        string placaSelecionada = "";
        string cpfSelecionado = "";
        string dataSelecionada = "";
        string infracaoSelecionada = "";
        byte[] data = null;

        public FMainWindow()
        {

            InitializeComponent();

            //Cria o banco e tabelas se não encontrados
            createDatabaseFile();

        }

        //Metodos de Interface
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Metodos de conexão

        private void createDatabaseFile()
        {

            string curFile = @"D:\dados\Cadastro.sqlite";
            if (File.Exists(curFile)) {

                Console.WriteLine("Database found!");

            } else {

                Console.WriteLine("Database not found, creating Cadastro.sqlite!");
                DAL.CriarBancoSQLite();
                //Cria Tabelas
                DAL.CriarTableProprietarioSQlite();
                DAL.CriarTableCarroSQlite();
                DAL.CriarTableInfracoesSQlite();

            }
           
        }

        private void ExibirDados()
        {
            try
            {

                //Carros
                DataTable dt = new DataTable();
                dt = DAL.populateCarroTable();
                dgvDados.DataSource = dt;

                //Infracoes
                DataTable dtInfracoes = new DataTable();
                dtInfracoes = DAL.populateInfracoesTable();
                dgvInfracoes.DataSource = dtInfracoes;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnLocalizarDados_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNumPlaca.Text) && string.IsNullOrEmpty(txtCPFCondutor.Text))
            {

                //Exibe todos os Dados se não houver digitado
                ExibirDados();

            } else if (!string.IsNullOrEmpty(txtNumPlaca.Text) && string.IsNullOrEmpty(txtCPFCondutor.Text))
            {

                DataTable dt = new DataTable();
                dt = DAL.filtraPlacasCarros(txtNumPlaca.Text);
                dgvDados.DataSource = dt;

            } else if (string.IsNullOrEmpty(txtNumPlaca.Text) && !string.IsNullOrEmpty(txtCPFCondutor.Text))
            {

                DataTable dt = new DataTable();
                dt = DAL.filtraCPFCarros(txtCPFCondutor.Text);
                dgvDados.DataSource = dt;

            } else if (!string.IsNullOrEmpty(txtNumPlaca.Text) && !string.IsNullOrEmpty(txtCPFCondutor.Text))
            {

                DataTable dt = new DataTable();
                dt = DAL.filtraCPFPlacasCarros(txtNumPlaca.Text, txtCPFCondutor.Text);
                dgvDados.DataSource = dt;

            }

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   }

        private void cbbInfracoesList_SelectedIndexChanged(object sender, EventArgs e)
        {   }

        private void manterVeiculo_Click(object sender, EventArgs e)
        {
            FCarroMaintenance carMaintenanceForm = new FCarroMaintenance();

            carMaintenanceForm.inicializaTextBox(placaSelecionada, cpfSelecionado, imageBox.BackgroundImage);

            carMaintenanceForm.ShowDialog();

        }


        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDados.Rows[e.RowIndex];

                placaSelecionada = row.Cells["PLACA_NUMBER"].Value.ToString();
                cpfSelecionado = row.Cells["CPF"].Value.ToString();

                data = (Byte[])(row.Cells["PLACA"].Value);
                var stream = new MemoryStream(data);


                imageBox.BackgroundImage = Image.FromStream(stream);

                Debug.WriteLine(placaSelecionada);
                Debug.WriteLine(cpfSelecionado);

                //UPDATE Infraction List
                DataTable dt = new DataTable();
                dt = DAL.filtraPlacasInfracoes(placaSelecionada);
                dgvInfracoes.DataSource = dt;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FInfracoesMaintenance infractionMaintenanceForm = new FInfracoesMaintenance(placaSelecionada, cpfSelecionado, dataSelecionada, infracaoSelecionada);

            infractionMaintenanceForm.Show();
        }

        private void filtrarInfracoesBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNumPlaca.Text) && string.IsNullOrEmpty(txtCPFCondutor.Text))
            {

                //Exibe todos os Dados se não houver digitado
                ExibirDados();

            }
            else if (!string.IsNullOrEmpty(txtNumPlaca.Text) && string.IsNullOrEmpty(txtCPFCondutor.Text))
            {

                DataTable dt = new DataTable();
                dt = DAL.filtraPlacasInfracoes(txtNumPlaca.Text);
                dgvInfracoes.DataSource = dt;

            }
            else if (string.IsNullOrEmpty(txtNumPlaca.Text) && !string.IsNullOrEmpty(txtCPFCondutor.Text))
            {

                DataTable dt = new DataTable();
                dt = DAL.filtraCPFInfracoes(txtCPFCondutor.Text);
                dgvInfracoes.DataSource = dt;

            }
            else if (!string.IsNullOrEmpty(txtNumPlaca.Text) && !string.IsNullOrEmpty(txtCPFCondutor.Text))
            {

                DataTable dt = new DataTable();
                dt = DAL.filtraCPFPlacasInfracoes(txtNumPlaca.Text, txtCPFCondutor.Text);
                dgvInfracoes.DataSource = dt;

            }

        }

        private void dgvInfracoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvInfracoes.Rows[e.RowIndex];

                dataSelecionada = row.Cells["DATA"].Value.ToString();
                infracaoSelecionada = row.Cells["INFRACOES"].Value.ToString();
                cpfSelecionado = row.Cells["CPF"].Value.ToString(); ;

                Debug.WriteLine(dataSelecionada);
                Debug.WriteLine(infracaoSelecionada);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FProprietariosMaintenance proprietarioForm = new FProprietariosMaintenance();
            proprietarioForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nomeFiltro_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = DAL.filtraCarroNome(nomeTxtBox.Text);
            dgvDados.DataSource = dt;

            DataTable dtInfracoes = new DataTable();
            dtInfracoes = DAL.filtraInfracaoNome(nomeTxtBox.Text);
            dgvInfracoes.DataSource = dtInfracoes;

        }
    }
}
