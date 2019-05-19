using CShp_MAC.Models;
using System;
using System.Windows.Forms;

namespace CShp_MAC
{
    public partial class FInfracoesMaintenance : Form
    {
        public FInfracoesMaintenance(string carroPlaca, string cpfCondutor, string dataSelecionada, string infracaoSelecionada)
        {
            
            InitializeComponent();

            setUpInfracoesLista();

            infracaoData.Format = DateTimePickerFormat.Custom;
            infracaoData.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            carroTxtBox.Text = carroPlaca;
            cpfTextBox.Text = cpfCondutor;

            infracaoData.Text = dataSelecionada;
            infracoesCBB.Text = infracaoSelecionada;

        }

        private bool valida(string infracaoSelecionada)
        {
            if (!string.IsNullOrEmpty(cpfTextBox.Text) && !string.IsNullOrEmpty(carroTxtBox.Text) && !string.IsNullOrEmpty(infracaoData.Text) && !string.IsNullOrEmpty(infracaoSelecionada))
            {

                return true;

            }
            else
            {

                return false;

            }
        }

        private void setUpInfracoesLista()
        {
            string[] infracoes = new string[]{"Dirigir veículo sem possuir CNH", "Dirigir veículo com CNH cassada",
            "Dirigir sob influência de álcool", "Recusar o teste do bafômetro", "Entregar direção a pessoa habilitada sem condições de dirigir",
            "Dirigir ameaçando os pedestres ou os demais veículos", "Realizar manobra perigosa",
            "Condutor envolvido em acidente que deixar de prestar socorro"};

            infracoesCBB.Items.AddRange(infracoes);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void infracoesCBB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void atualizarBtn_Click(object sender, EventArgs e)
        {
            string infracaoSelecionada = "";

            try
            {
                infracaoSelecionada = infracoesCBB.Items[infracoesCBB.SelectedIndex].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor, selecione a Infração", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (valida(infracaoSelecionada))
            {

                EInfracao infracao = new EInfracao(infracaoSelecionada, infracaoData.Text, carroTxtBox.Text, cpfTextBox.Text);
                infracao.InsertInfracao();
                this.Close();


            } else
            {
                MessageBox.Show("Por favor, forneça a infração, a data e o cpf do infrator", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {

                EInfracao.DeleteRow(infracoesCBB.Text, infracaoData.Text, cpfTextBox.Text);
                this.Close();

        }
    }
}
