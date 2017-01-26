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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_crearFact_Click(object sender, EventArgs e)
        {
            Factura fact = new Factura();
            fact.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recibo recibo = new Recibo();
            recibo.Show();
            this.Hide();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Modulos modulos = new Modulos();
            modulos.Show();
            this.Hide();
        }

        private void btn_modificarFact_Click(object sender, EventArgs e)
        {
            EliminarFactura ef = new EliminarFactura();
            ef.Show();
            this.Hide();
        }
    }
}
