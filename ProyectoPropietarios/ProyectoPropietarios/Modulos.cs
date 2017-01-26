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
    public partial class Modulos : Form
    {
        public Modulos()
        {
            InitializeComponent();
        }

        private void Modulos_Load(object sender, EventArgs e)
        {

        }

        private void Modulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TalentoHumano th = new TalentoHumano();
            th.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_Facturacion_Click(object sender, EventArgs e)
        {
            Facturacion facturacion = new Facturacion();
            facturacion.Show();
            this.Hide();
        }

        private void btn_servicios_Click(object sender, EventArgs e)
        {

        }
    }
}
