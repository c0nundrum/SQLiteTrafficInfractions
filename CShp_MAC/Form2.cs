﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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

                    Models.ECarro carro = new Models.ECarro(data, cpfProprietario.Text, numeroPlaca.Text);
                    carro.InsertCarro();

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

               Models.ECarro.DeleteRow(numeroPlaca.Text);
               this.Close();
        
        }
    }
}
