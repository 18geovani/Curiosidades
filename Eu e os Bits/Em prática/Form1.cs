using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Em_prática
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] vector = new int[5];
        string[] vector2 = new string[5];

        private void Fechar_Click(object sender, EventArgs e)
        {
            Encerrar();
        }
        private void Encerrar()
        {
            Application.Exit();
        }

        private void txtNumeros_TextChanged(object sender, EventArgs e)
        {
            for (int i=0; i<=5; i++)
            {
                vector2[i] = txtNumeros.Text;
            }
            
        }
    }
}
