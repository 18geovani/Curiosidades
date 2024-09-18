using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double compra = double.Parse(TextValor.Text);

            double prestação = compra / 5;

            LblResult.Text = ($" Pode pagar em até: {prestação}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextValor.Text = " ";
            LblResult.Text = "";
        }
    }
}
