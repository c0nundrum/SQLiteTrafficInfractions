namespace CShp_MAC
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.atualizarBtn = new System.Windows.Forms.Button();
            this.excluirBtn = new System.Windows.Forms.Button();
            this.infracoesCBB = new System.Windows.Forms.ComboBox();
            this.carroTxtBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.infracaoData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cpf Condutor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carro Condutor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Infracoes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data";
            // 
            // atualizarBtn
            // 
            this.atualizarBtn.Location = new System.Drawing.Point(244, 216);
            this.atualizarBtn.Name = "atualizarBtn";
            this.atualizarBtn.Size = new System.Drawing.Size(118, 23);
            this.atualizarBtn.TabIndex = 4;
            this.atualizarBtn.Text = "Atualizar / Adicionar";
            this.atualizarBtn.UseVisualStyleBackColor = true;
            this.atualizarBtn.Click += new System.EventHandler(this.atualizarBtn_Click);
            // 
            // excluirBtn
            // 
            this.excluirBtn.Location = new System.Drawing.Point(126, 216);
            this.excluirBtn.Name = "excluirBtn";
            this.excluirBtn.Size = new System.Drawing.Size(75, 23);
            this.excluirBtn.TabIndex = 5;
            this.excluirBtn.Text = "Excluir";
            this.excluirBtn.UseVisualStyleBackColor = true;
            this.excluirBtn.Click += new System.EventHandler(this.excluirBtn_Click);
            // 
            // infracoesCBB
            // 
            this.infracoesCBB.FormattingEnabled = true;
            this.infracoesCBB.Location = new System.Drawing.Point(126, 100);
            this.infracoesCBB.Name = "infracoesCBB";
            this.infracoesCBB.Size = new System.Drawing.Size(236, 21);
            this.infracoesCBB.TabIndex = 6;
            this.infracoesCBB.SelectedIndexChanged += new System.EventHandler(this.infracoesCBB_SelectedIndexChanged);
            // 
            // carroTxtBox
            // 
            this.carroTxtBox.Enabled = false;
            this.carroTxtBox.Location = new System.Drawing.Point(126, 62);
            this.carroTxtBox.Name = "carroTxtBox";
            this.carroTxtBox.Size = new System.Drawing.Size(236, 20);
            this.carroTxtBox.TabIndex = 7;
            this.carroTxtBox.Text = "Carro Placa";
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Location = new System.Drawing.Point(126, 26);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(236, 20);
            this.cpfTextBox.TabIndex = 8;
            // 
            // infracaoData
            // 
            this.infracaoData.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.infracaoData.Location = new System.Drawing.Point(126, 132);
            this.infracaoData.Name = "infracaoData";
            this.infracaoData.Size = new System.Drawing.Size(205, 20);
            this.infracaoData.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 266);
            this.Controls.Add(this.infracaoData);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(this.carroTxtBox);
            this.Controls.Add(this.infracoesCBB);
            this.Controls.Add(this.excluirBtn);
            this.Controls.Add(this.atualizarBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button atualizarBtn;
        private System.Windows.Forms.Button excluirBtn;
        private System.Windows.Forms.ComboBox infracoesCBB;
        private System.Windows.Forms.TextBox carroTxtBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.DateTimePicker infracaoData;
    }
}