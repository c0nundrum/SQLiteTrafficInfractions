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
            this.filtrarInfracoesBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfracoes)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.manterVeiculo);
            this.panel1.Controls.Add(this.dgvDados);
            this.panel1.Location = new System.Drawing.Point(265, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 335);
            this.panel1.TabIndex = 0;
            // 
            // manterVeiculo
            // 
            this.manterVeiculo.Location = new System.Drawing.Point(3, 3);
            this.manterVeiculo.Name = "manterVeiculo";
            this.manterVeiculo.Size = new System.Drawing.Size(85, 329);
            this.manterVeiculo.TabIndex = 19;
            this.manterVeiculo.Text = "Manter Veículos";
            this.manterVeiculo.UseVisualStyleBackColor = true;
            this.manterVeiculo.Click += new System.EventHandler(this.manterVeiculo_Click);
            // 
            // btnLocalizarDados
            // 
            this.btnLocalizarDados.Location = new System.Drawing.Point(3, 135);
            this.btnLocalizarDados.Name = "btnLocalizarDados";
            this.btnLocalizarDados.Size = new System.Drawing.Size(252, 200);
            this.btnLocalizarDados.TabIndex = 6;
            this.btnLocalizarDados.Text = "Filtrar Carros";
            this.btnLocalizarDados.UseVisualStyleBackColor = true;
            this.btnLocalizarDados.Click += new System.EventHandler(this.btnLocalizarDados_Click);
            // 
            // txtCPFCondutor
            // 
            this.txtCPFCondutor.Location = new System.Drawing.Point(3, 98);
            this.txtCPFCondutor.Name = "txtCPFCondutor";
            this.txtCPFCondutor.Size = new System.Drawing.Size(252, 20);
            this.txtCPFCondutor.TabIndex = 18;
            // 
            // txtNumPlaca
            // 
            this.txtNumPlaca.Location = new System.Drawing.Point(3, 42);
            this.txtNumPlaca.Name = "txtNumPlaca";
            this.txtNumPlaca.Size = new System.Drawing.Size(252, 20);
            this.txtNumPlaca.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "NUM PLACA";
            // 
            // dgvDados
            // 
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(91, 3);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(974, 329);
            this.dgvDados.TabIndex = 6;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(93, 82);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(92, 13);
            this.EmailLbl.TabIndex = 2;
            this.EmailLbl.Text = "CPF CONDUTOR";
            this.EmailLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvInfracoes
            // 
            this.dgvInfracoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfracoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfracoes.Location = new System.Drawing.Point(91, 3);
            this.dgvInfracoes.Name = "dgvInfracoes";
            this.dgvInfracoes.Size = new System.Drawing.Size(971, 229);
            this.dgvInfracoes.TabIndex = 2;
            this.dgvInfracoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfracoes_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.dgvInfracoes);
            this.panel3.Location = new System.Drawing.Point(265, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1068, 235);
            this.panel3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 229);
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
            // filtrarInfracoesBtn
            // 
            this.filtrarInfracoesBtn.Location = new System.Drawing.Point(0, 341);
            this.filtrarInfracoesBtn.Name = "filtrarInfracoesBtn";
            this.filtrarInfracoesBtn.Size = new System.Drawing.Size(255, 232);
            this.filtrarInfracoesBtn.TabIndex = 20;
            this.filtrarInfracoesBtn.Text = "Filtrar Infracoes";
            this.filtrarInfracoesBtn.UseVisualStyleBackColor = true;
            this.filtrarInfracoesBtn.Click += new System.EventHandler(this.filtrarInfracoesBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.filtrarInfracoesBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnLocalizarDados);
            this.panel2.Controls.Add(this.txtNumPlaca);
            this.panel2.Controls.Add(this.txtCPFCondutor);
            this.panel2.Controls.Add(this.EmailLbl);
            this.panel2.Location = new System.Drawing.Point(4, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 576);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfracoes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button filtrarInfracoesBtn;
        private System.Windows.Forms.Panel panel2;
    }
}

