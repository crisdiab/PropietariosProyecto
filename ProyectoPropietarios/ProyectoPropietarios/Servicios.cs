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
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        private void rEPRESENTANTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.SERVICIO' Puede moverla o quitarla según sea necesario.
            this.sERVICIOTableAdapter.Fill(this.grisGrisDataSet.SERVICIO);
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.REPRESENTANTE' Puede moverla o quitarla según sea necesario.
            this.rEPRESENTANTETableAdapter.Fill(this.grisGrisDataSet.REPRESENTANTE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerivcioPrincipal sp = new SerivcioPrincipal();
            sp.Show();
            this.Hide();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNombreServicio.Enabled = true;
            PrecioServicio.Enabled = true;
            txtNombreServicio.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rEPRESENTANTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grisGrisDataSet);
            txtNombreServicio.Enabled = false;
            PrecioServicio.Enabled = false;
            MessageBox.Show("Servicio agreado al sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
