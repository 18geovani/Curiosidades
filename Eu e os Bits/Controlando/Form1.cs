using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using Controlos.UsuárioCont;

namespace Controlos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Home inicio = new Home();
            AddUsuarioCont(inicio);
        }
        private void AddUsuarioCont(UserControl usuariocont) //Add o controle do usuário
        {
            usuariocont.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(usuariocont);
            usuariocont.BringToFront();

        }
        //Add o controle Perfil
        private void AddUserView(UserControl userview)
        {
            userview.Dock = DockStyle.Right;
            panelContainer.Controls.Add(userview);
            userview.BringToFront();
        }
        //Controles
        private void Button1_Click(object sender, EventArgs e)
        {
            Home inicio = new Home();
            AddUsuarioCont(inicio);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Entrada ent = new Entrada();
            AddUsuarioCont(ent);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Saída env = new Saída();
            AddUsuarioCont(env);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Definições def = new Definições();
            AddUsuarioCont(def);
        }

        private void BtnImage_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            AddUserView(perfil);
        }

    }
}
