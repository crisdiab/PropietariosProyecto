﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPropietarios
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Facturacion md = new Facturacion();
            md.Show();
            this.Hide();
        }
    }
}
