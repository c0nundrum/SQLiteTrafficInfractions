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
            this.btnLocalizarDados = new System.Windows.Forms.Button();
            this.txtCPFCondutor = new System.Windows.Forms.MaskedTextBox();
            this.txtNumPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.dgvInfracoes = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfracoes)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.manterVeiculo);
            this.panel1.Controls.Add(this.btnLocalizarDados);
            this.panel1.Controls.Add(this.txtCPFCondutor);
            this.panel1.Controls.Add(this.txtNumPlaca);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgvDados);
            this.panel1.Controls.Add(this.EmailLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 261);
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
            // btnLocalizarDados
            // 
            this.btnLocalizarDados.Location = new System.Drawing.Point(318, 35);
            this.btnLocalizarDados.Name = "btnLocalizarDados";
            this.btnLocalizarDados.Size = new System.Drawing.Size(188, 23);
            this.btnLocalizarDados.TabIndex = 6;
            this.btnLocalizarDados.Text = "Filtrar";
            this.btnLocalizarDados.UseVisualStyleBackColor = true;
            this.btnLocalizarDados.Click += new System.EventHandler(this.btnLocalizarDados_Click);
            // 
            // txtCPFCondutor
            // 
            this.txtCPFCondutor.Location = new System.Drawing.Point(638, 11);
            this.txtCPFCondutor.Name = "txtCPFCondutor";
            this.txtCPFCondutor.Size = new System.Drawing.Size(100, 20);
            this.txtCPFCondutor.TabIndex = 18;
            // 
            // txtNumPlaca
            // 
            this.txtNumPlaca.Location = new System.Drawing.Point(146, 11);
            this.txtNumPlaca.Name = "txtNumPlaca";
            this.txtNumPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtNumPlaca.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "NUM PLACA";
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(91, 64);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(667, 167);
            this.dgvDados.TabIndex = 6;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(540, 16);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(92, 13);
            this.EmailLbl.TabIndex = 2;
            this.EmailLbl.Text = "CPF CONDUTOR";
            this.EmailLbl.Click += new System.EventHandler(this.label3_Click);
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
            this.panel3.Controls.Add(this.dgvInfracoes);
            this.panel3.Location = new System.Drawing.Point(794, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 261);
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
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.ClientSize = new System.Drawing.Size(1345, 295);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfracoes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Button btnLocalizarDados;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtNumPlaca;
        private System.Windows.Forms.MaskedTextBox txtCPFCondutor;
        private System.Windows.Forms.DataGridView dgvInfracoes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button manterVeiculo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

