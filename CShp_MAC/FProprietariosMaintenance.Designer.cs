namespace CShp_MAC
{
    partial class FProprietariosMaintenance
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
            this.proprietarioDados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTxtBox = new System.Windows.Forms.TextBox();
            this.CpfTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filtraBtn = new System.Windows.Forms.Button();
            this.addProprietario = new System.Windows.Forms.Button();
            this.delProprietarioBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proprietarioDados)).BeginInit();
            this.SuspendLayout();
            // 
            // proprietarioDados
            // 
            this.proprietarioDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proprietarioDados.Location = new System.Drawing.Point(12, 35);
            this.proprietarioDados.Name = "proprietarioDados";
            this.proprietarioDados.Size = new System.Drawing.Size(776, 307);
            this.proprietarioDados.TabIndex = 0;
            this.proprietarioDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proprietarioDados_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Proprietarios:";
            // 
            // nomeTxtBox
            // 
            this.nomeTxtBox.Location = new System.Drawing.Point(57, 359);
            this.nomeTxtBox.Name = "nomeTxtBox";
            this.nomeTxtBox.Size = new System.Drawing.Size(328, 20);
            this.nomeTxtBox.TabIndex = 2;
            // 
            // CpfTxtBox
            // 
            this.CpfTxtBox.Location = new System.Drawing.Point(57, 396);
            this.CpfTxtBox.Name = "CpfTxtBox";
            this.CpfTxtBox.Size = new System.Drawing.Size(328, 20);
            this.CpfTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cpf:";
            // 
            // filtraBtn
            // 
            this.filtraBtn.Location = new System.Drawing.Point(391, 359);
            this.filtraBtn.Name = "filtraBtn";
            this.filtraBtn.Size = new System.Drawing.Size(157, 57);
            this.filtraBtn.TabIndex = 6;
            this.filtraBtn.Text = "Filtra Condutores";
            this.filtraBtn.UseVisualStyleBackColor = true;
            this.filtraBtn.Click += new System.EventHandler(this.filtraBtn_Click);
            // 
            // addProprietario
            // 
            this.addProprietario.Location = new System.Drawing.Point(554, 359);
            this.addProprietario.Name = "addProprietario";
            this.addProprietario.Size = new System.Drawing.Size(120, 57);
            this.addProprietario.TabIndex = 7;
            this.addProprietario.Text = "Adiciona / Mantem Proprietario";
            this.addProprietario.UseVisualStyleBackColor = true;
            this.addProprietario.Click += new System.EventHandler(this.addProprietario_Click);
            // 
            // delProprietarioBtn
            // 
            this.delProprietarioBtn.Location = new System.Drawing.Point(680, 362);
            this.delProprietarioBtn.Name = "delProprietarioBtn";
            this.delProprietarioBtn.Size = new System.Drawing.Size(108, 54);
            this.delProprietarioBtn.TabIndex = 8;
            this.delProprietarioBtn.Text = "Remove Proprietario";
            this.delProprietarioBtn.UseVisualStyleBackColor = true;
            this.delProprietarioBtn.Click += new System.EventHandler(this.delProprietarioBtn_Click);
            // 
            // FProprietariosMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.delProprietarioBtn);
            this.Controls.Add(this.addProprietario);
            this.Controls.Add(this.filtraBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CpfTxtBox);
            this.Controls.Add(this.nomeTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proprietarioDados);
            this.Name = "FProprietariosMaintenance";
            this.Text = "FProprietariosMaintenance";
            ((System.ComponentModel.ISupportInitialize)(this.proprietarioDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView proprietarioDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTxtBox;
        private System.Windows.Forms.TextBox CpfTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button filtraBtn;
        private System.Windows.Forms.Button addProprietario;
        private System.Windows.Forms.Button delProprietarioBtn;
    }
}