using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text;

            /*
             * ----------------------Contains----------------------------
            if (texto.Contains("Arlindo"))
            {
                MessageBox.Show("Contém «Arlindo»");
            }
            else
            {
                MessageBox.Show("Não Contém «Arlindo»");
            }
            */

            /*
             *----------------------------- LastIndexOf e IndexOf ----------------------------------
            int indice = texto.LastIndexOf('a');
            MessageBox.Show("Índice: " + indice);
            */

            /*
             * ------------------------ Insert e Replace -------------------------------
             * 
            if (texto.EndsWith("o"))
            {
                string n = texto.Replace("Arlindo", "António");
                MessageBox.Show(n.Insert(0, " Doctor "));
                
            }
            else if (texto.EndsWith("a"))
            {
               // Nnoiva = texto.Replace("Calunge", "Arlindo");
                MessageBox.Show(texto.Insert(0, " Doctora "));
                
            }
            
             * 
             * 
             */
            /*
            string[] texto2 = texto.Split(' ');
            foreach (string s in texto2)
            {
                lbltexto.Text += " || " + s;
            }
            
            string[] Nomes = texto.Split('n');
            foreach(string Nome in Nomes)
            {
                lbltexto.Text += " *|* " + Nome;
            }
            */

            /*---------------Convertendo Números-------------------
            int num;
            int.TryParse(texto, out num);
            lbltexto.Text = num.ToString();
            */
            /*
             * if(int.TryParse(texto, out num))
            {
                lbltexto.Text = n.ToString();
            }
            else
            {
                lbltexto.Text = "Erro na conversão";
            }
             * */
            int num = int.Parse(txtTexto.Text);

            // Covertendo para hexadecimal (UTF-16)
            //lbltexto.Text = num.ToString("X");

            // Covertendo para Decimal (UTF-16)
            //lbltexto.Text = num.ToString("D");

            // Covertendo para Valor monetário
            //lbltexto.Text = num.ToString("C");

            //Covertendo para valor flotuante
            //lbltexto.Text = num.ToString("F");

            /*
            double n;
            if(double.TryParse(texto, out n))
            {
                lbltexto.Text = n.ToString();
            }
            else
            {
                lbltexto.Text = "Erro na conversão";
            }
            */
        }
        ///////////////////////////    // DA AVALIAÇÂO    ////////////////////////////

        string[] palavras = { };
        string[] Palavra = { };


        private void btnOcultar_Click(object sender, EventArgs e)
        {
            txtTexto.PasswordChar = '*';
           
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            txtTexto.PasswordChar = '\0'; //Mudar para visível os caracteres
        }
        int i = 0;
        private void btnView_Click(object sender, EventArgs e)
        {
            //inicialmente i é igual a 0 no 1º click passará a ser 1
            // sempre q i for ímpar será possível ver a palavra pass
            // sempre for par não será
            i++;
            if (i % 2 == 0)
            {
                txtTexto.PasswordChar = '*';
            }
            else
            {
                txtTexto.PasswordChar = '\0';
            }
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < palavras.Length; i++) 
            { 
                palavras[i] = txtTexto.Text;
                Palavra = palavras[i].Split(' ');
                Palavra[0].ToUpper();
                txtTexto.Text = Palavra[0];
            }
          
            
          
        }
    }
}
