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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manterVeiculo = new System.Windows.Forms.Button();
            this.btnRandomId = new System.Windows.Forms.Button();
            this.btnLocalizarDados = new System.Windows.Forms.Button();
            this.txtCPFCondutor = new System.Windows.Forms.MaskedTextBox();
            this.txtNumPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxByteString = new System.Windows.Forms.TextBox();
            this.btnPathToImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnExcluirDados = new System.Windows.Forms.Button();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.btnIncluirDados = new System.Windows.Forms.Button();
            this.dgvInfracoes = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.cbbCarrosFromCPF = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbInfracoesList = new System.Windows.Forms.ComboBox();
            this.txtReaderCPF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTxTData = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfracoes)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.manterVeiculo);
            this.panel1.Controls.Add(this.btnRandomId);
            this.panel1.Controls.Add(this.btnLocalizarDados);
            this.panel1.Controls.Add(this.txtCPFCondutor);
            this.panel1.Controls.Add(this.txtNumPlaca);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBoxByteString);
            this.panel1.Controls.Add(this.btnPathToImage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvDados);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.EmailLbl);
            this.panel1.Controls.Add(this.IdLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 327);
            this.panel1.TabIndex = 0;
            // 
            // manterVeiculo
            // 
            this.manterVeiculo.Location = new System.Drawing.Point(15, 64);
            this.manterVeiculo.Name = "manterVeiculo";
            this.manterVeiculo.Size = new System.Drawing.Size(70, 47);
            this.manterVeiculo.TabIndex = 19;
            this.manterVeiculo.Text = "Manter Veículos";
            this.manterVeiculo.UseVisualStyleBackColor = true;
            this.manterVeiculo.Click += new System.EventHandler(this.manterVeiculo_Click);
            // 
            // btnRandomId
            // 
            this.btnRandomId.Location = new System.Drawing.Point(724, 288);
            this.btnRandomId.Name = "btnRandomId";
            this.btnRandomId.Size = new System.Drawing.Size(34, 23);
            this.btnRandomId.TabIndex = 2;
            this.btnRandomId.Text = "id";
            this.btnRandomId.UseVisualStyleBackColor = true;
            this.btnRandomId.Click += new System.EventHandler(this.btnRandomId_Click);
            // 
            // btnLocalizarDados
            // 
            this.btnLocalizarDados.Location = new System.Drawing.Point(260, 35);
            this.btnLocalizarDados.Name = "btnLocalizarDados";
            this.btnLocalizarDados.Size = new System.Drawing.Size(188, 23);
            this.btnLocalizarDados.TabIndex = 6;
            this.btnLocalizarDados.Text = "Filtrar";
            this.btnLocalizarDados.UseVisualStyleBackColor = true;
            this.btnLocalizarDados.Click += new System.EventHandler(this.btnLocalizarDados_Click);
            // 
            // txtCPFCondutor
            // 
            this.txtCPFCondutor.Location = new System.Drawing.Point(314, 9);
            this.txtCPFCondutor.Name = "txtCPFCondutor";
            this.txtCPFCondutor.Size = new System.Drawing.Size(100, 20);
            this.txtCPFCondutor.TabIndex = 18;
            // 
            // txtNumPlaca
            // 
            this.txtNumPlaca.Location = new System.Drawing.Point(91, 9);
            this.txtNumPlaca.Name = "txtNumPlaca";
            this.txtNumPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtNumPlaca.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "CAMINHO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "NUM PLACA";
            // 
            // txtBoxByteString
            // 
            this.txtBoxByteString.Enabled = false;
            this.txtBoxByteString.Location = new System.Drawing.Point(350, 290);
            this.txtBoxByteString.Name = "txtBoxByteString";
            this.txtBoxByteString.Size = new System.Drawing.Size(278, 20);
            this.txtBoxByteString.TabIndex = 9;
            // 
            // btnPathToImage
            // 
            this.btnPathToImage.Location = new System.Drawing.Point(350, 252);
            this.btnPathToImage.Name = "btnPathToImage";
            this.btnPathToImage.Size = new System.Drawing.Size(172, 23);
            this.btnPathToImage.TabIndex = 8;
            this.btnPathToImage.Text = "Procurar";
            this.btnPathToImage.UseVisualStyleBackColor = true;
            this.btnPathToImage.Click += new System.EventHandler(this.btnPathToImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PLACA IMAGEM";
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(91, 64);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(667, 167);
            this.dgvDados.TabIndex = 6;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(658, 290);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(61, 20);
            this.txtID.TabIndex = 3;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(215, 14);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(92, 13);
            this.EmailLbl.TabIndex = 2;
            this.EmailLbl.Text = "CPF CONDUTOR";
            this.EmailLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(634, 293);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(18, 13);
            this.IdLbl.TabIndex = 0;
            this.IdLbl.Text = "ID";
            this.IdLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEncerrar);
            this.panel2.Controls.Add(this.btnExcluirDados);
            this.panel2.Controls.Add(this.btnAtualizarDados);
            this.panel2.Controls.Add(this.btnIncluirDados);
            this.panel2.Location = new System.Drawing.Point(12, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 170);
            this.panel2.TabIndex = 1;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(260, 105);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(188, 23);
            this.btnEncerrar.TabIndex = 7;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnExcluirDados
            // 
            this.btnExcluirDados.Location = new System.Drawing.Point(260, 47);
            this.btnExcluirDados.Name = "btnExcluirDados";
            this.btnExcluirDados.Size = new System.Drawing.Size(188, 23);
            this.btnExcluirDados.TabIndex = 5;
            this.btnExcluirDados.Text = "ExcluirDados";
            this.btnExcluirDados.UseVisualStyleBackColor = true;
            this.btnExcluirDados.Click += new System.EventHandler(this.btnExcluirDados_Click);
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.Location = new System.Drawing.Point(260, 18);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(188, 23);
            this.btnAtualizarDados.TabIndex = 4;
            this.btnAtualizarDados.Text = "AtualizarDados";
            this.btnAtualizarDados.UseVisualStyleBackColor = true;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // btnIncluirDados
            // 
            this.btnIncluirDados.Location = new System.Drawing.Point(35, 105);
            this.btnIncluirDados.Name = "btnIncluirDados";
            this.btnIncluirDados.Size = new System.Drawing.Size(188, 23);
            this.btnIncluirDados.TabIndex = 3;
            this.btnIncluirDados.Text = "IncluirDados";
            this.btnIncluirDados.UseVisualStyleBackColor = true;
            this.btnIncluirDados.Click += new System.EventHandler(this.btnIncluirDados_Click);
            // 
            // dgvInfracoes
            // 
            this.dgvInfracoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfracoes.Location = new System.Drawing.Point(109, 64);
            this.dgvInfracoes.Name = "dgvInfracoes";
            this.dgvInfracoes.Size = new System.Drawing.Size(402, 167);
            this.dgvInfracoes.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.cbbCarrosFromCPF);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbbInfracoesList);
            this.panel3.Controls.Add(this.txtReaderCPF);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.mskTxTData);
            this.panel3.Controls.Add(this.dgvInfracoes);
            this.panel3.Location = new System.Drawing.Point(794, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 519);
            this.panel3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 24;
            this.button3.Text = "Manter Infracoes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbbCarrosFromCPF
            // 
            this.cbbCarrosFromCPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCarrosFromCPF.FormattingEnabled = true;
            this.cbbCarrosFromCPF.Location = new System.Drawing.Point(287, 403);
            this.cbbCarrosFromCPF.Name = "cbbCarrosFromCPF";
            this.cbbCarrosFromCPF.Size = new System.Drawing.Size(224, 21);
            this.cbbCarrosFromCPF.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "CARRO";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Incluir Infracao";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "INFRACOES";
            // 
            // cbbInfracoesList
            // 
            this.cbbInfracoesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbInfracoesList.FormattingEnabled = true;
            this.cbbInfracoesList.Location = new System.Drawing.Point(287, 363);
            this.cbbInfracoesList.Name = "cbbInfracoesList";
            this.cbbInfracoesList.Size = new System.Drawing.Size(224, 21);
            this.cbbInfracoesList.TabIndex = 20;
            this.cbbInfracoesList.SelectedIndexChanged += new System.EventHandler(this.cbbInfracoesList_SelectedIndexChanged);
            // 
            // txtReaderCPF
            // 
            this.txtReaderCPF.Enabled = false;
            this.txtReaderCPF.Location = new System.Drawing.Point(55, 403);
            this.txtReaderCPF.Name = "txtReaderCPF";
            this.txtReaderCPF.Size = new System.Drawing.Size(100, 20);
            this.txtReaderCPF.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "DATA";
            // 
            // mskTxTData
            // 
            this.mskTxTData.Location = new System.Drawing.Point(55, 364);
            this.mskTxTData.Mask = "00/00/0000 90:00";
            this.mskTxTData.Name = "mskTxTData";
            this.mskTxTData.Size = new System.Drawing.Size(100, 20);
            this.mskTxTData.TabIndex = 3;
            this.mskTxTData.ValidatingType = typeof(System.DateTime);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 560);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfracoes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnLocalizarDados;
        private System.Windows.Forms.Button btnExcluirDados;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.Button btnIncluirDados;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPathToImage;
        private System.Windows.Forms.TextBox txtBoxByteString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtNumPlaca;
        private System.Windows.Forms.MaskedTextBox txtCPFCondutor;
        private System.Windows.Forms.Button btnRandomId;
        private System.Windows.Forms.DataGridView dgvInfracoes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTxTData;
        private System.Windows.Forms.TextBox txtReaderCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbInfracoesList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbbCarrosFromCPF;
        private System.Windows.Forms.Button manterVeiculo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

