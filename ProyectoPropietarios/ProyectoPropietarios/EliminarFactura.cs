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
    public partial class EliminarFactura : Form
    {
        public EliminarFactura()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Facturacion fact = new Facturacion();
            fact.Show();
            this.Hide();
        }

        private void EliminarFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
           

        }

        private void fechainicioToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
           

        }

        private void fillToolStripButton_Click_3(object sender, EventArgs e)
        {
           

        }

        private void fillToolStripButton_Click_4(object sender, EventArgs e)
        {
            try
            {
                this.buscarfacturaTableAdapter.Fill(this.grisGrisDataSet.buscarfactura, numfactToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
