using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex046
{
    public partial class Ex046 : Form
    {
        public Ex046()
        {
            InitializeComponent();
        }
        Calculo Calculo = new Calculo();    
        int lado1, lado2, area;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lado1=int.Parse(txtLado1.Text);
            lado2=int.Parse(txtLado2.Text);
            area = Calculo.Calcular(lado1, lado2);
            lblResultado.Text = area.ToString();
        }
    }
}
