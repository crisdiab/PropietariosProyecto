using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPropietarios.Profesional
{
    public partial class ModificarProfesional : Form
    {
        public ModificarProfesional()
        {
            InitializeComponent();
        }

        private void pROFESIONALBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void ModificarProfesional_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.PROFESIONAL' Puede moverla o quitarla según sea necesario.
            this.pROFESIONALTableAdapter.Fill(this.grisGrisDataSet.PROFESIONAL);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROFESIONALBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grisGrisDataSet);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            TalentoHumano th = new TalentoHumano();
            th.Show();
            this.Hide();
        }
    }
}
