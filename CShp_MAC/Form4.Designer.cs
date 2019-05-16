namespace CShp_MAC
{
    partial class Form4
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
            this.cpfLbl = new System.Windows.Forms.Label();
            this.cpfBox = new System.Windows.Forms.TextBox();
            this.nomeLBL = new System.Windows.Forms.Label();
            this.nomeTxtBox = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cpfLbl
            // 
            this.cpfLbl.AutoSize = true;
            this.cpfLbl.Location = new System.Drawing.Point(57, 62);
            this.cpfLbl.Name = "cpfLbl";
            this.cpfLbl.Size = new System.Drawing.Size(30, 13);
            this.cpfLbl.TabIndex = 0;
            this.cpfLbl.Text = "CPF:";
            // 
            // cpfBox
            // 
            this.cpfBox.Location = new System.Drawing.Point(93, 59);
            this.cpfBox.Name = "cpfBox";
            this.cpfBox.Size = new System.Drawing.Size(155, 20);
            this.cpfBox.TabIndex = 1;
            this.cpfBox.Text = "cpf number";
            this.cpfBox.TextChanged += new System.EventHandler(this.cpfBox_TextChanged);
            // 
            // nomeLBL
            // 
            this.nomeLBL.AutoSize = true;
            this.nomeLBL.Location = new System.Drawing.Point(45, 111);
            this.nomeLBL.Name = "nomeLBL";
            this.nomeLBL.Size = new System.Drawing.Size(42, 13);
            this.nomeLBL.TabIndex = 2;
            this.nomeLBL.Text = "NOME:";
            // 
            // nomeTxtBox
            // 
            this.nomeTxtBox.Location = new System.Drawing.Point(93, 108);
            this.nomeTxtBox.Name = "nomeTxtBox";
            this.nomeTxtBox.Size = new System.Drawing.Size(155, 20);
            this.nomeTxtBox.TabIndex = 3;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(173, 156);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 4;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(92, 156);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 214);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.nomeTxtBox);
            this.Controls.Add(this.nomeLBL);
            this.Controls.Add(this.cpfBox);
            this.Controls.Add(this.cpfLbl);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cpfLbl;
        private System.Windows.Forms.TextBox cpfBox;
        private System.Windows.Forms.Label nomeLBL;
        private System.Windows.Forms.TextBox nomeTxtBox;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}