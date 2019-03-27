namespace CShp_MAC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.NomeLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnLocalizarDados = new System.Windows.Forms.Button();
            this.btnExcluirDados = new System.Windows.Forms.Button();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.btnIncluirDados = new System.Windows.Forms.Button();
            this.btnExibirDados = new System.Windows.Forms.Button();
            this.btnCriarTabela = new System.Windows.Forms.Button();
            this.btnCriarBancoDados = new System.Windows.Forms.Button();
            this.btnPathToImage = new System.Windows.Forms.Button();
            this.txtBoxByteString = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtModelo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBoxByteString);
            this.panel1.Controls.Add(this.btnPathToImage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvDados);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.EmailLbl);
            this.panel1.Controls.Add(this.NomeLbl);
            this.panel1.Controls.Add(this.IdLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 247);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PLACA IMAGEM";
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(19, 13);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(739, 143);
            this.dgvDados.TabIndex = 6;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 217);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 194);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(113, 169);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 3;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(15, 220);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(92, 13);
            this.EmailLbl.TabIndex = 2;
            this.EmailLbl.Text = "CPF CONDUTOR";
            this.EmailLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // NomeLbl
            // 
            this.NomeLbl.AutoSize = true;
            this.NomeLbl.Location = new System.Drawing.Point(16, 197);
            this.NomeLbl.Name = "NomeLbl";
            this.NomeLbl.Size = new System.Drawing.Size(41, 13);
            this.NomeLbl.TabIndex = 1;
            this.NomeLbl.Text = "PLACA";
            this.NomeLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(16, 172);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(18, 13);
            this.IdLbl.TabIndex = 0;
            this.IdLbl.Text = "ID";
            this.IdLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEncerrar);
            this.panel2.Controls.Add(this.btnLocalizarDados);
            this.panel2.Controls.Add(this.btnExcluirDados);
            this.panel2.Controls.Add(this.btnAtualizarDados);
            this.panel2.Controls.Add(this.btnIncluirDados);
            this.panel2.Controls.Add(this.btnExibirDados);
            this.panel2.Controls.Add(this.btnCriarTabela);
            this.panel2.Controls.Add(this.btnCriarBancoDados);
            this.panel2.Location = new System.Drawing.Point(12, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 173);
            this.panel2.TabIndex = 1;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(281, 117);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(188, 23);
            this.btnEncerrar.TabIndex = 7;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnLocalizarDados
            // 
            this.btnLocalizarDados.Location = new System.Drawing.Point(281, 88);
            this.btnLocalizarDados.Name = "btnLocalizarDados";
            this.btnLocalizarDados.Size = new System.Drawing.Size(188, 23);
            this.btnLocalizarDados.TabIndex = 6;
            this.btnLocalizarDados.Text = "LocalizarDados";
            this.btnLocalizarDados.UseVisualStyleBackColor = true;
            this.btnLocalizarDados.Click += new System.EventHandler(this.btnLocalizarDados_Click);
            // 
            // btnExcluirDados
            // 
            this.btnExcluirDados.Location = new System.Drawing.Point(281, 59);
            this.btnExcluirDados.Name = "btnExcluirDados";
            this.btnExcluirDados.Size = new System.Drawing.Size(188, 23);
            this.btnExcluirDados.TabIndex = 5;
            this.btnExcluirDados.Text = "ExcluirDados";
            this.btnExcluirDados.UseVisualStyleBackColor = true;
            this.btnExcluirDados.Click += new System.EventHandler(this.btnExcluirDados_Click);
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.Location = new System.Drawing.Point(281, 30);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(188, 23);
            this.btnAtualizarDados.TabIndex = 4;
            this.btnAtualizarDados.Text = "AtualizarDados";
            this.btnAtualizarDados.UseVisualStyleBackColor = true;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // btnIncluirDados
            // 
            this.btnIncluirDados.Location = new System.Drawing.Point(56, 117);
            this.btnIncluirDados.Name = "btnIncluirDados";
            this.btnIncluirDados.Size = new System.Drawing.Size(188, 23);
            this.btnIncluirDados.TabIndex = 3;
            this.btnIncluirDados.Text = "IncluirDados";
            this.btnIncluirDados.UseVisualStyleBackColor = true;
            this.btnIncluirDados.Click += new System.EventHandler(this.btnIncluirDados_Click);
            // 
            // btnExibirDados
            // 
            this.btnExibirDados.Location = new System.Drawing.Point(56, 88);
            this.btnExibirDados.Name = "btnExibirDados";
            this.btnExibirDados.Size = new System.Drawing.Size(188, 23);
            this.btnExibirDados.TabIndex = 2;
            this.btnExibirDados.Text = "ExibirDados";
            this.btnExibirDados.UseVisualStyleBackColor = true;
            this.btnExibirDados.Click += new System.EventHandler(this.btnExibirDados_Click);
            // 
            // btnCriarTabela
            // 
            this.btnCriarTabela.Location = new System.Drawing.Point(56, 59);
            this.btnCriarTabela.Name = "btnCriarTabela";
            this.btnCriarTabela.Size = new System.Drawing.Size(188, 23);
            this.btnCriarTabela.TabIndex = 1;
            this.btnCriarTabela.Text = "CriarTabela";
            this.btnCriarTabela.UseVisualStyleBackColor = true;
            this.btnCriarTabela.Click += new System.EventHandler(this.btnCriarTabela_Click);
            // 
            // btnCriarBancoDados
            // 
            this.btnCriarBancoDados.Location = new System.Drawing.Point(56, 30);
            this.btnCriarBancoDados.Name = "btnCriarBancoDados";
            this.btnCriarBancoDados.Size = new System.Drawing.Size(188, 23);
            this.btnCriarBancoDados.TabIndex = 0;
            this.btnCriarBancoDados.Text = "Criar DB";
            this.btnCriarBancoDados.UseVisualStyleBackColor = true;
            this.btnCriarBancoDados.Click += new System.EventHandler(this.btnCriarBancoDados_Click);
            // 
            // btnPathToImage
            // 
            this.btnPathToImage.Location = new System.Drawing.Point(322, 192);
            this.btnPathToImage.Name = "btnPathToImage";
            this.btnPathToImage.Size = new System.Drawing.Size(124, 23);
            this.btnPathToImage.TabIndex = 8;
            this.btnPathToImage.Text = "Procurar";
            this.btnPathToImage.UseVisualStyleBackColor = true;
            this.btnPathToImage.Click += new System.EventHandler(this.btnPathToImage_Click);
            // 
            // txtBoxByteString
            // 
            this.txtBoxByteString.Enabled = false;
            this.txtBoxByteString.Location = new System.Drawing.Point(322, 217);
            this.txtBoxByteString.Name = "txtBoxByteString";
            this.txtBoxByteString.Size = new System.Drawing.Size(124, 20);
            this.txtBoxByteString.TabIndex = 9;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(322, 169);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(124, 20);
            this.txtModelo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "MODELO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Infracoes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label NomeLbl;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnLocalizarDados;
        private System.Windows.Forms.Button btnExcluirDados;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.Button btnIncluirDados;
        private System.Windows.Forms.Button btnExibirDados;
        private System.Windows.Forms.Button btnCriarTabela;
        private System.Windows.Forms.Button btnCriarBancoDados;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPathToImage;
        private System.Windows.Forms.TextBox txtBoxByteString;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

