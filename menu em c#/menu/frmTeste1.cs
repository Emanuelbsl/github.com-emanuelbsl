using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmTeste1 : Form
    {
        public frmTeste1()
        {
            InitializeComponent();
        }

        private void frmTeste1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Siar", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro Efetuado com Sucesso!!\n\n Nome: "+tblNome.Text+"\nCPF:" + tblCPF.Text + "\n END: " + tblEND.Text);
            this.Close();
        }

    }
}
