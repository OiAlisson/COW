namespace COW
{
    partial class FormLogin
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
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaL = new System.Windows.Forms.TextBox();
            this.lblSenhaL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPFL = new System.Windows.Forms.TextBox();
            this.lblCPFL = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 50);
            this.button3.TabIndex = 35;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Funcionário",
            "Admin"});
            this.comboBox1.Location = new System.Drawing.Point(150, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 33);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.Text = "Selecione Sua função";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 39);
            this.label3.TabIndex = 33;
            this.label3.Text = "COW";
            // 
            // txtSenhaL
            // 
            this.txtSenhaL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaL.Location = new System.Drawing.Point(231, 322);
            this.txtSenhaL.Name = "txtSenhaL";
            this.txtSenhaL.Size = new System.Drawing.Size(192, 31);
            this.txtSenhaL.TabIndex = 30;
            // 
            // lblSenhaL
            // 
            this.lblSenhaL.AutoSize = true;
            this.lblSenhaL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaL.Location = new System.Drawing.Point(145, 322);
            this.lblSenhaL.Name = "lblSenhaL";
            this.lblSenhaL.Size = new System.Drawing.Size(80, 25);
            this.lblSenhaL.TabIndex = 29;
            this.lblSenhaL.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cadastre-se";
            // 
            // txtCPFL
            // 
            this.txtCPFL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFL.Location = new System.Drawing.Point(231, 285);
            this.txtCPFL.Name = "txtCPFL";
            this.txtCPFL.Size = new System.Drawing.Size(192, 31);
            this.txtCPFL.TabIndex = 28;
            // 
            // lblCPFL
            // 
            this.lblCPFL.AutoSize = true;
            this.lblCPFL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFL.Location = new System.Drawing.Point(145, 285);
            this.lblCPFL.Name = "lblCPFL";
            this.lblCPFL.Size = new System.Drawing.Size(60, 25);
            this.lblCPFL.TabIndex = 27;
            this.lblCPFL.Text = "CPF:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(315, 451);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 18);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "AQUI";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 533);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaL);
            this.Controls.Add(this.lblSenhaL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCPFL);
            this.Controls.Add(this.lblCPFL);
            this.Controls.Add(this.linkLabel1);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaL;
        private System.Windows.Forms.Label lblSenhaL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPFL;
        private System.Windows.Forms.Label lblCPFL;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}