﻿using System;
using csharp_Sqlite.Models;
using csharp_Sqlite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using CShp_MAC.Models;

namespace CShp_MAC
{
    public partial class Form1 : Form
    {
        byte[] data = null;

        public Form1()
        {
            InitializeComponent();
            //Cria o banco se não encontrado e exibe os dados no datagridView
            DalHelper.CriarBancoSQLite();
            DalHelper.CriarTabelaSQlite();
            DalHelper.CriarTabelaSQliteInfracoes();
            ExibirDados();
            setUpInfracoes();
            txtID.Text = DalHelper.generateRandomID().ToString();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void setUpInfracoes()
        {
            string[] infracoes = new string[]{"Dirigir veículo sem possuir CNH", "Dirigir veículo com CNH cassada",
            "Dirigir sob influência de álcool", "Recusar o teste do bafômetro", "Entregar direção a pessoa habilitada sem condições de dirigir",
            "Dirigir ameaçando os pedestres ou os demais veículos", "Realizar manobra perigosa",
            "Condutor envolvido em acidente que deixar de prestar socorro"};

            cbbInfracoesList.Items.AddRange(infracoes);
        }

        private void btnCriarBancoDados_Click(object sender, EventArgs e)
        {
            try
            {
                DalHelper.CriarBancoSQLite();
                btnCriarBancoDados.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            try
            {
                DalHelper.CriarTabelaSQlite();
                btnCriarTabela.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DalHelper.GetCarros();
                dgvDados.DataSource = dt;

                DataTable dtInfracoes = new DataTable();
                dtInfracoes = DalHelper.GetInfracoes();
                dgvInfracoes.DataSource = dtInfracoes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnExibirDados_Click(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void btnIncluirDados_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show("Informe os dados cliente a incluir");
                return;
            }
            try
            {
                Placa placa = new Placa();
                placa.ID = Convert.ToInt32(txtID.Text);
                placa.placaImg = data;
                placa.modelo = txtModelo.Text;
                placa.donoCPF = txtEmail.Text;
                placa.placaNumero = txtNome.Text;

                DalHelper.AddCarro(placa); 

                ExibirDados();
                LimpaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show("Informe os dados cliente a atualizar");
                return;
            }

            try
            {
                Placa placa = new Placa();
                placa.ID = Convert.ToInt32(txtID.Text);
                placa.placaImg = data;
                placa.modelo = txtModelo.Text;
                placa.donoCPF = txtEmail.Text;
                placa.placaNumero = txtNome.Text;

                DalHelper.Update(placa);
                ExibirDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnExcluirDados_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Informe o ID do cliente a ser Excluído");
                return;
            }
            try
            {
                int codigo = Convert.ToInt32(txtID.Text);
                DalHelper.Delete(codigo);
                ExibirDados();
                LimpaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnLocalizarDados_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Informe o CPF do cliente a ser Localizado");
                return;
            }
            try
            {
                DataTable dt = new DataTable();
                //int codigo = Convert.ToInt32(txtID.Text);
                string codigo = txtEmail.Text;

                dt = DalHelper.GetCarro(codigo);
                dgvDados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
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

        private bool Valida()
        {
            if (string.IsNullOrEmpty(txtID.Text) && string.IsNullOrEmpty(txtNome.Text) && string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtModelo.Text) && data == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void LimpaDados()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtModelo.Text = "";
            txtBoxByteString.Text = "";
            data = null;
        }

        private void setCarsForInfraction(string cpf)
        {
            cbbCarrosFromCPF.Items.Clear();

            List<string> carList = new List<string>();
            carList = DalHelper.getCarsFromCPF(cpf);

            string[] carListArray = carList.ToArray();

            cbbCarrosFromCPF.Items.AddRange(carListArray);
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDados.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtNome.Text = row.Cells["NUMERO"].Value.ToString();
                txtEmail.Text = row.Cells["CPF"].Value.ToString();
                txtModelo.Text = row.Cells["MODELO"].Value.ToString();

                //UPDATE Infraction List
                setCarsForInfraction(row.Cells["CPF"].Value.ToString());

            }
        }

        private void btnPathToImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPathBrowser = new OpenFileDialog();
            openPathBrowser.RestoreDirectory = true;
            openPathBrowser.DefaultExt = "jpg";
            openPathBrowser.Filter = "image files (*.jpg)|*.jpg";

            if (openPathBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openPathBrowser.FileName;
                imageToBytes(strfilename);
            }
        }

        private void imageToBytes(string path)
        {
            
            try
            {
                data = File.ReadAllBytes(path);
                txtBoxByteString.Text = path;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                data = null;
                txtBoxByteString.Text = "Erro de carregamento da imagem.";
            }

        }

        private void btnRandomId_Click(object sender, EventArgs e)
        {
            LimpaDados();
            txtID.Text = DalHelper.generateRandomID().ToString();
        }

        private void cbbInfracoesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
