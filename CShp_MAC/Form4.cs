﻿using csharp_Sqlite;
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
    public partial class Form4 : Form
    {
        public Form4(string cpf)
        {
            InitializeComponent();

            cpfBox.Text = cpf;
        }

        private void cpfBox_TextChanged(object sender, EventArgs e)
        {

        }

        private bool valida()
        {
            //if (!string.IsNullOrEmpty(nomeTxtBox.Text) && !string.IsNullOrEmpty(cpfBox.Text))
            if (!string.IsNullOrEmpty(cpfBox.Text))
            {

                return true;

            }
            else
            {

                return false;

            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (valida())
            {

                this.DialogResult = DialogResult.OK;
                Models.EProprietario proprietario = new Models.EProprietario(nomeTxtBox.Text, cpfBox.Text);
                proprietario.InsertProprietario();

                //DalHelper.insertProprietario(nomeTxtBox.Text, cpfBox.Text);
                this.Close();

            } else
            {

                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("String vazia", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
