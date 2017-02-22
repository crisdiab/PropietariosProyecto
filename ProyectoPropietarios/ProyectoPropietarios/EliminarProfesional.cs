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
    public partial class EliminarProfesional : Form
    {
        public EliminarProfesional()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TalentoHumano th = new TalentoHumano();
            th.Show();
            this.Hide();
        }

        private void EliminarProfesional_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void pROFESIONALBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void EliminarProfesional_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.PROFESIONAL' Puede moverla o quitarla según sea necesario.
            this.pROFESIONALTableAdapter.Fill(this.grisGrisDataSet.PROFESIONAL);

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            TalentoHumano th = new TalentoHumano();
            th.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROFESIONALBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grisGrisDataSet);
            MessageBox.Show("Profesional actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
