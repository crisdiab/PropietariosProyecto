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
    public partial class Eliminar_Servicio : Form
    {
        public Eliminar_Servicio()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SerivcioPrincipal sp = new SerivcioPrincipal();
            sp.Show();
            this.Hide();
        }

        private void Eliminar_Servicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void sERVICIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Eliminar_Servicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.SERVICIO' Puede moverla o quitarla según sea necesario.
            this.sERVICIOTableAdapter.Fill(this.grisGrisDataSet.SERVICIO);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sERVICIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grisGrisDataSet);
            MessageBox.Show("Servicio actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
