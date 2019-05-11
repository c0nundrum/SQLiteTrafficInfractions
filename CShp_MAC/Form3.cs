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
        public Form3(string carroPlaca, string cpfCondutor)
        {
            
            InitializeComponent();

            setUpInfracoesLista();

            carroTxtBox.Text = carroPlaca;
            cpfTextBox.Text = cpfCondutor;

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
            string infracaoSelecionada = infracoesCBB.Items[infracoesCBB.SelectedIndex].ToString();

            Infracao infracao = new Infracao();

            infracao.cpfNumero = cpfTextBox.Text;
            infracao.placaNumero = carroTxtBox.Text;
            infracao.data = infracaoData.Text;
            infracao.infracao = infracaoSelecionada;

            DalHelper.insertInfracoes(infracao);

        }
    }
}
