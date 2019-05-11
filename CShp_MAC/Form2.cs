using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using csharp_Sqlite;

namespace CShp_MAC
{
    public partial class Form2 : Form
    {

        byte[] data = null;

        private bool valida()
        {
            if(!string.IsNullOrEmpty(cpfProprietario.Text) && !string.IsNullOrEmpty(numeroPlaca.Text) && data != null)
            {

                return true;

            } else
            {

                return false;

            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        public void inicializaTextBox(string numPlaca, string cpf)
        {
            numeroPlaca.Text = numPlaca;

            cpfProprietario.Text = cpf;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adicionarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                if (valida())
                {
                    Models.Placa placa = new Models.Placa();
                    placa.placaImg = data;
                    placa.donoCPF = cpfProprietario.Text;
                    placa.placaNumero = numeroPlaca.Text;

                    DalHelper.AddCarro(placa);

                    this.Close();

                } else
                {
                    MessageBox.Show("Por favor passe todas as informações necessárias", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buscarImagem_Click(object sender, EventArgs e)
        {
            //Dialógo para buscar a imagem
            OpenFileDialog openPathBrowser = new OpenFileDialog();
            openPathBrowser.RestoreDirectory = true;
            openPathBrowser.DefaultExt = "jpg";
            openPathBrowser.Filter = "image files (*.jpg)|*.jpg";

            if (openPathBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openPathBrowser.FileName;

                //Transforma a imagem em bytes
                imageToBytes(strfilename);

                //Faz um preview da imagem para mostrar
                changeDisplayImage(strfilename);
            }

        }

        private void changeDisplayImage(string filePath)
        {

            //Muda  e mostra a imagem na tela
            Image i = Image.FromFile(filePath);
            pictureBox1.BackgroundImage = i;

        }

        private void imageToBytes(string path)
        {

            try
            {
                data = File.ReadAllBytes(path);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                data = null;
            }

        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            //Retorna o ROWID para a exclusão
            string placaId = DalHelper.getIdFromPlaca(numeroPlaca.Text);

            //Se não retornar vazio
            if (!string.IsNullOrEmpty(placaId))
            {
                DalHelper.deleteCarro(placaId);
                this.Close();

            } else
            {
                //Caso retorne vazio mostra a mensagem de eroo
                MessageBox.Show("Carro não encontrado", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
