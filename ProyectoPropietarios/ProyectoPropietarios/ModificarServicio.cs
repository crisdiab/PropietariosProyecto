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
    public partial class ModificarServicio : Form
    {
        public ModificarServicio()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            SerivcioPrincipal sp = new SerivcioPrincipal();
            sp.Show();
            this.Hide();
        }

        private void ModificarServicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void sERVICIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sERVICIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grisGrisDataSet);

        }

        private void ModificarServicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.SERVICIO' Puede moverla o quitarla según sea necesario.
            this.sERVICIOTableAdapter.Fill(this.grisGrisDataSet.SERVICIO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sERVICIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grisGrisDataSet);
            MessageBox.Show("Servicio modificado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
