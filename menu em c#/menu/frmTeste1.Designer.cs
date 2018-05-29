namespace WindowsFormsApplication1
{
    partial class frmTeste1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEND = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tblNome = new System.Windows.Forms.TextBox();
            this.tblCPF = new System.Windows.Forms.TextBox();
            this.tblEND = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tblEND);
            this.groupBox1.Controls.Add(this.tblCPF);
            this.groupBox1.Controls.Add(this.tblNome);
            this.groupBox1.Controls.Add(this.txtEND);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // txtEND
            // 
            this.txtEND.AutoSize = true;
            this.txtEND.Location = new System.Drawing.Point(17, 131);
            this.txtEND.Name = "txtEND";
            this.txtEND.Size = new System.Drawing.Size(33, 13);
            this.txtEND.TabIndex = 2;
            this.txtEND.Text = "END:";
            // 
            // txtCPF
            // 
            this.txtCPF.AutoSize = true;
            this.txtCPF.Location = new System.Drawing.Point(17, 85);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(30, 13);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(17, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(38, 13);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(33, 218);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(168, 218);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // tblNome
            // 
            this.tblNome.Location = new System.Drawing.Point(20, 54);
            this.tblNome.Name = "tblNome";
            this.tblNome.Size = new System.Drawing.Size(210, 20);
            this.tblNome.TabIndex = 3;
            // 
            // tblCPF
            // 
            this.tblCPF.Location = new System.Drawing.Point(20, 102);
            this.tblCPF.Name = "tblCPF";
            this.tblCPF.Size = new System.Drawing.Size(210, 20);
            this.tblCPF.TabIndex = 4;
            // 
            // tblEND
            // 
            this.tblEND.Location = new System.Drawing.Point(20, 147);
            this.tblEND.Name = "tblEND";
            this.tblEND.Size = new System.Drawing.Size(210, 20);
            this.tblEND.TabIndex = 5;
            // 
            // frmTeste1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTeste1";
            this.Text = "frmTeste1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTeste1_FormClosing_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtEND;
        private System.Windows.Forms.Label txtCPF;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.TextBox tblEND;
        private System.Windows.Forms.TextBox tblCPF;
        private System.Windows.Forms.TextBox tblNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
    }
}