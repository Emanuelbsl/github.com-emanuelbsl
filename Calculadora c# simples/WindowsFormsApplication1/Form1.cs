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

        double V;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_visor.Text += 0;
            txt_hist.Text  += 0;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_visor.Text += 7;
            txt_hist.Text  += 7;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_visor.Text += 8;
            txt_hist.Text  += 8;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_visor.Text += 9;
            txt_hist.Text  += 9;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_visor.Text += 4;
            txt_hist.Text  += 4;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_visor.Text += 5;
            txt_hist.Text  += 5;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_visor.Text += 6;
            txt_hist.Text  += 6;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_visor.Text += 1;
            txt_hist.Text  += 1;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_visor.Text += 2;
            txt_hist.Text  += 2;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_visor.Text += 3;
            txt_hist.Text  += 3;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            btn_igual.PerformClick();
            operador = "/";
            txt_visor.Clear();
            txt_hist.Text += "/";

        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            btn_igual.PerformClick();
            operador = "+";
            txt_visor.Clear();
            txt_hist.Text += "+";

        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            btn_igual.PerformClick();
            operador = "-";
            txt_visor.Clear();
            txt_hist.Text += "-";

        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            btn_igual.PerformClick();
            operador = "*";
            txt_visor.Clear();
            txt_hist.Text += "*";
    
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            switch(operador){
                case "+": txt_visor.Text = (V + Double.Parse(txt_visor.Text)).ToString(); break;
                case "-": txt_visor.Text = (V - Double.Parse(txt_visor.Text)).ToString(); break;
                case "/": txt_visor.Text = (V / Double.Parse(txt_visor.Text)).ToString(); break;
                case "*": txt_visor.Text = (V * Double.Parse(txt_visor.Text)).ToString(); break;
            }
       
            V = Double.Parse(txt_visor.Text);
            operador = "";
        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            txt_visor.Text = "";
            txt_hist.Text = "";
        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {
            V = Double.Parse(txt_visor.Text);
            txt_visor.Text = (V + ",");
            txt_hist.Text += (".");
        }
    }
}
