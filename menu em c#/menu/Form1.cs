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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data :" + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void text1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeste1 tst1 = new frmTeste1();
            tst1.MdiParent = this;
            tst1.Show();
        }

        private void tool_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora:" + DateTime.Now.ToString("HH:mm:ss");
        }

        private void tool_form_Click(object sender, EventArgs e)
        {
            frmTeste1 tst1 = new frmTeste1();
            tst1.MdiParent = this;
            tst1.Show();
        }

        private void tool_like_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Like");
        }

       
    }
}
