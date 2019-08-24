using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace caixaeletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(textBox1.Text);
            //100 50 20 10 5 2 1
            int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };
            for (int i = 0; i < cedulas.Length; i++) {
                int qtdcedulas = valor / cedulas[i];
                if (i == 0) label8.Text=""+ qtdcedulas;
                if (i == 1) label7.Text = "" + qtdcedulas;
                if (i == 2) label6.Text = "" + qtdcedulas;
                if (i == 3) label5.Text = "" + qtdcedulas;
                if (i == 4) label4.Text = "" + qtdcedulas;
                if (i == 5) label3.Text = "" + qtdcedulas;
                if (i == 6) label2.Text = "" + qtdcedulas;
                valor = valor %cedulas[i];
            }
        }
    }
}
