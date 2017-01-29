using System;
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
    public partial class Profesional : Form
    {
        public Profesional()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            TalentoHumano th = new TalentoHumano();
            th.Show();
            this.Hide();
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            TalentoHumano th = new TalentoHumano();
            th.Show();
            this.Hide();

        }

        private void Profesional_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }
    }
}
