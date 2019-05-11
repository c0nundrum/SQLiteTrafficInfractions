using System;
using csharp_Sqlite;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using CShp_MAC.Models;

namespace CShp_MAC
{
    public partial class Form1 : Form
    {

        string placaSelecionada = "";
        string cpfSelecionado = "";

        public Form1()
        {
            InitializeComponent();

            //Cria o banco e tabelas se não encontrados
            createDatabaseFile();

            //Cria lista de infracoes
            setUpInfracoesLista();

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

        private void setUpInfracoesLista()
        {
            string[] infracoes = new string[]{"Dirigir veículo sem possuir CNH", "Dirigir veículo com CNH cassada",
            "Dirigir sob influência de álcool", "Recusar o teste do bafômetro", "Entregar direção a pessoa habilitada sem condições de dirigir",
            "Dirigir ameaçando os pedestres ou os demais veículos", "Realizar manobra perigosa",
            "Condutor envolvido em acidente que deixar de prestar socorro"};

            //cbbInfracoesList.Items.AddRange(infracoes);
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

        //private void btnIncluirDados_Click(object sender, EventArgs e)
        //{
        //    if (!Valida())
        //    {
            //    MessageBox.Show("Informe os dados cliente a incluir");
            //    return;
            //}
            //try
            //{
            //    Placa placa = new Placa();
            //    placa.ID = Convert.ToInt32(txtID.Text);
            //    placa.placaImg = data;
            //    //placa.modelo = txtModelo.Text;
            //    placa.donoCPF = txtCPFCondutor.Text;
            //    placa.placaNumero = txtNumPlaca.Text;

        //        DalHelper.AddCarro(placa); 

        //        ExibirDados();
        //        LimpaDados();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro : " + ex.Message);
        //    }
        //}

        //private void btnAtualizarDados_Click(object sender, EventArgs e)
        //{
        //    if (!Valida())
        //    {
        //        MessageBox.Show("Informe os dados cliente a atualizar");
        //        return;
        //    }

        //    try
        //    {
        //        Placa placa = new Placa();
        //        placa.ID = Convert.ToInt32(txtID.Text);
        //        placa.placaImg = data;
        //        //placa.modelo = txtModelo.Text;
        //        placa.donoCPF = txtCPFCondutor.Text;
        //        placa.placaNumero = txtNumPlaca.Text;

        //        DalHelper.Update(placa);
        //        ExibirDados();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro : " + ex.Message);
        //    }
        //}

        //private void btnExcluirDados_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtID.Text))
        //    {
        //        MessageBox.Show("Informe o ID do cliente a ser Excluído");
        //        return;
        //    }
        //    try
        //    {
        //        int codigo = Convert.ToInt32(txtID.Text);
        //        DalHelper.Delete(codigo);
        //        ExibirDados();
        //        LimpaDados();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro : " + ex.Message);
        //    }
        //}

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

            }



            //if (string.IsNullOrEmpty(txtEmail.Text))
            //{
            //    MessageBox.Show("Informe o CPF do cliente a ser Localizado");
            //    return;
            //}
            //try
            //{
            //    DataTable dt = new DataTable();
            //    //int codigo = Convert.ToInt32(txtID.Text);
            //    string codigo = txtEmail.Text;

                //    dt = DalHelper.GetCarro(codigo);
                //    dgvDados.DataSource = dt;
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Erro : " + ex.Message);
                //}
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



        //private void LimpaDados()
        //{
        //    txtID.Text = "";
        //    txtNumPlaca.Text = "";
        //    txtCPFCondutor.Text = "";
        //    //txtModelo.Text = "";
        //    txtBoxByteString.Text = "";
        //    data = null;
        //}

        private void setCarsForInfraction(string cpf)
        {
            //cbbCarrosFromCPF.Items.Clear();

            //List<string> carList = new List<string>();
            //carList = DalHelper.getCarsFromCPF(cpf);

            //string[] carListArray = carList.ToArray();

            //cbbCarrosFromCPF.Items.AddRange(carListArray);
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //    if (e.RowIndex >= 0)
            //    {
            //        DataGridViewRow row = this.dgvDados.Rows[e.RowIndex];
            //        txtID.Text = row.Cells["ID"].Value.ToString();
            //        txtNumPlaca.Text = row.Cells["NUMERO"].Value.ToString();
            //        txtCPFCondutor.Text = row.Cells["CPF"].Value.ToString();
            //        //txtModelo.Text = row.Cells["MODELO"].Value.ToString();

            //        txtReaderCPF.Text = row.Cells["CPF"].Value.ToString();

            //        //UPDATE Infraction List
            //        setCarsForInfraction(row.Cells["CPF"].Value.ToString());

            //    }


         }

            //private void btnPathToImage_Click(object sender, EventArgs e)
            //{
            //    OpenFileDialog openPathBrowser = new OpenFileDialog();
            //    openPathBrowser.RestoreDirectory = true;
            //    openPathBrowser.DefaultExt = "jpg";
            //    openPathBrowser.Filter = "image files (*.jpg)|*.jpg";

            //    if (openPathBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        string strfilename = openPathBrowser.FileName;
            //        imageToBytes(strfilename);
            //    }
            //}

            //private void imageToBytes(string path)
            //{

            //    try
            //    {
            //        data = File.ReadAllBytes(path);
            //        txtBoxByteString.Text = path;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.ToString());
            //        data = null;
            //        txtBoxByteString.Text = "Erro de carregamento da imagem.";
            //    }

            //}

            //private void btnRandomId_Click(object sender, EventArgs e)
            //{
            //    LimpaDados();
            //    //txtID.Text = DalHelper.generateRandomID().ToString();
            //}

            private void cbbInfracoesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void manterVeiculo_Click(object sender, EventArgs e)
        {
            Form2 carMaintenanceForm = new Form2();

            carMaintenanceForm.inicializaTextBox(placaSelecionada, cpfSelecionado);

            carMaintenanceForm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 infractionMaintenanceForm = new Form3();

            infractionMaintenanceForm.Show();
        }
    }
}
