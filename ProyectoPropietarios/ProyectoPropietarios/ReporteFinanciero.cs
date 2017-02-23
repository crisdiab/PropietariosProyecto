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
    public partial class ReporteFinanciero : Form
    {
        public ReporteFinanciero()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes();
            r.Show();
            this.Hide();
        }

        private void ReporteFinanciero_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.buscarFechaFacturaTableAdapter.Fill(this.grisGrisDataSet.buscarFechaFactura, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fechainicioToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fechafinToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sumaIngresos = 0;
            foreach (DataGridViewRow row in buscarFechaFacturaDataGridView.Rows)
            {
                 sumaIngresos += Convert.ToDouble(row.Cells["gridtotalfactura"].Value);

                 

            }
            txtIngresos.Text = sumaIngresos.ToString();
        }
    }
}
