using csharp_Sqlite;
using CShp_MAC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShp_MAC
{
    public partial class Form3 : Form
    {
        public Form3(string carroPlaca, string cpfCondutor, string dataSelecionada, string infracaoSelecionada)
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

                MessageBox.Show("Por favor, forneça todas as informações", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (valida(infracaoSelecionada))
            {
                Infracao infracao = new Infracao();

                infracao.cpfNumero = cpfTextBox.Text;
                infracao.placaNumero = carroTxtBox.Text;
                infracao.data = infracaoData.Text;
                infracao.infracao = infracaoSelecionada;

                DalHelper.insertInfracoes(infracao);
                this.Close();

            } else
            {
                MessageBox.Show("Por favor, forneça todas as informações", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            //Retorna o ROWID para a exclusão
            string infracaoID = DalHelper.getIdFromInfraction(infracoesCBB.Text, infracaoData.Text, cpfTextBox.Text);

            //Se não retornar vazio
            if (!string.IsNullOrEmpty(infracaoID))
            {
                DalHelper.deleteInfracao(infracaoID);
                this.Close();

            }
            else
            {
                //Caso retorne vazio mostra a mensagem de eroo
                MessageBox.Show("Infracao não encontrada", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
