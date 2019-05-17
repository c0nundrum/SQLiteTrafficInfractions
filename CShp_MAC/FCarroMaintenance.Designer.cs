namespace CShp_MAC
{
    partial class FCarroMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCarroMaintenance));
            this.numeroPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cpfProprietario = new System.Windows.Forms.TextBox();
            this.buscarImagem = new System.Windows.Forms.Button();
            this.adicionarEntrada = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.excluirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroPlaca
            // 
            this.numeroPlaca.Location = new System.Drawing.Point(137, 192);
            this.numeroPlaca.Name = "numeroPlaca";
            this.numeroPlaca.Size = new System.Drawing.Size(100, 20);
            this.numeroPlaca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero da Placa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imagem da Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF Proprietario";
            // 
            // cpfProprietario
            // 
            this.cpfProprietario.Location = new System.Drawing.Point(137, 218);
            this.cpfProprietario.Name = "cpfProprietario";
            this.cpfProprietario.Size = new System.Drawing.Size(100, 20);
            this.cpfProprietario.TabIndex = 5;
            // 
            // buscarImagem
            // 
            this.buscarImagem.Location = new System.Drawing.Point(137, 12);
            this.buscarImagem.Name = "buscarImagem";
            this.buscarImagem.Size = new System.Drawing.Size(100, 23);
            this.buscarImagem.TabIndex = 6;
            this.buscarImagem.Text = "Buscar Imagem";
            this.buscarImagem.UseVisualStyleBackColor = true;
            this.buscarImagem.Click += new System.EventHandler(this.buscarImagem_Click);
            // 
            // adicionarEntrada
            // 
            this.adicionarEntrada.Location = new System.Drawing.Point(137, 250);
            this.adicionarEntrada.Name = "adicionarEntrada";
            this.adicionarEntrada.Size = new System.Drawing.Size(100, 35);
            this.adicionarEntrada.TabIndex = 7;
            this.adicionarEntrada.Text = "Modificar / Adicionar";
            this.adicionarEntrada.UseVisualStyleBackColor = true;
            this.adicionarEntrada.Click += new System.EventHandler(this.adicionarEntrada_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CShp_MAC.Properties.Resources.Traffic_Ticket_Credit_Score;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 116);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(45, 256);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 9;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // FCarroMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 302);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adicionarEntrada);
            this.Controls.Add(this.buscarImagem);
            this.Controls.Add(this.cpfProprietario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeroPlaca);
            this.Name = "FCarroMaintenance";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeroPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cpfProprietario;
        private System.Windows.Forms.Button buscarImagem;
        private System.Windows.Forms.Button adicionarEntrada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button excluirButton;
    }
}