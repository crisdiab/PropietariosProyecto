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
    public partial class TalentoHumano : Form
    {
        public TalentoHumano()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profesional profesional = new Profesional();
            profesional.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AsignarServicio aservicio = new AsignarServicio();
            aservicio.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarProfesional ep = new EliminarProfesional();
            ep.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Modulos mod = new Modulos();
            mod.Show();
            this.Hide();
        }
    }
}
