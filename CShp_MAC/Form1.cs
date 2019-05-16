using System;
using csharp_Sqlite;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using CShp_MAC.Models;
using System.Diagnostics;

namespace CShp_MAC
{
    public partial class Form1 : Form
    {

        string placaSelecionada = "";
        string cpfSelecionado = "";
        string dataSelecionada = "";
        string infracaoSelecionada = "";

        public Form1()
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
                DalHelper.CriarBancoSQLite();
                //Cria Tabelas
                DalHelper.CriarTableProprietarioSQlite();
                DalHelper.CriarTableCarroSQlite();
                DalHelper.CriarTableInfracoesSQlite();

            }
           
        }

        private void ExibirDados()
        {
            try
            {

                //Carros
                DataTable dt = new DataTable();
                dt = DalHelper.populateCarroTable();
                dgvDados.DataSource = dt;

                //Infracoes
                DataTable dtInfracoes = new DataTable();
                dtInfracoes = DalHelper.populateInfracoesTable();
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
                dt = DalHelper.filtraPlacasCarros(txtNumPlaca.Text);
                dgvDados.DataSource = dt;

            } else if (string.IsNullOrEmpty(txtNumPlaca.Text) && !string.IsNullOrEmpty(txtCPFCondutor.Text))
            {

                DataTable dt = new DataTable();
                dt = DalHelper.filtraCPFCarros(txtCPFCondutor.Text);
                dgvDados.DataSource = dt;

            } else if (!string.IsNullOrEmpty(txtNumPlaca.Text) && !string.IsNullOrEmpty(txtCPFCondutor.Text))
            {

                DataTable dt = new DataTable();
                dt = DalHelper.filtraCPFPlacasCarros(txtNumPlaca.Text, txtCPFCondutor.Text);
                dgvDados.DataSource = dt;

            }

        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            const string mensagem = "Deseja Encerrar ?";
            const string titulo = "Encerrar";
            var resultado = MessageBox.Show(mensagem, titulo,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void setCarsForInfraction(string cpf)
        {

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            


        }

            private void cbbInfracoesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void manterVeiculo_Click(object sender, EventArgs e)
        {
            Form2 carMaintenanceForm = new Form2();

            carMaintenanceForm.inicializaTextBox(placaSelecionada, cpfSelecionado);

            carMaintenanceForm.ShowDialog();

        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDados.Rows[e.RowIndex];

                placaSelecionada = row.Cells["PLACA_NUMBER"].Value.ToString();
                cpfSelecionado = row.Cells["CPF"].Value.ToString();

                Debug.WriteLine(placaSelecionada);
                Debug.WriteLine(cpfSelecionado);

                //UPDATE Infraction List
                DataTable dt = new DataTable();
                dt = DalHelper.filtraPlacasInfracoes(placaSelecionada);
                dgvInfracoes.DataSource = dt;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 infractionMaintenanceForm = new Form3(placaSelecionada, cpfSelecionado, dataSelecionada, infracaoSelecionada);

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
                dt = DalHelper.filtraPlacasInfracoes(txtNumPlaca.Text);
                dgvInfracoes.DataSource = dt;

            }
            else if (string.IsNullOrEmpty(txtNumPlaca.Text) && !string.IsNullOrEmpty(txtCPFCondutor.Text))
            {

                DataTable dt = new DataTable();
                dt = DalHelper.filtraCPFInfracoes(txtCPFCondutor.Text);
                dgvInfracoes.DataSource = dt;

            }
            else if (!string.IsNullOrEmpty(txtNumPlaca.Text) && !string.IsNullOrEmpty(txtCPFCondutor.Text))
            {

                DataTable dt = new DataTable();
                dt = DalHelper.filtraCPFPlacasInfracoes(txtNumPlaca.Text, txtCPFCondutor.Text);
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

                Debug.WriteLine(dataSelecionada);
                Debug.WriteLine(infracaoSelecionada);


            }
        }
    }
}
