﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlos
{
    public partial class Perfil : UserControl
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void FecharPerfil_Click(object sender, EventArgs e)
        {
           this.Hide();
        }
    }
}
