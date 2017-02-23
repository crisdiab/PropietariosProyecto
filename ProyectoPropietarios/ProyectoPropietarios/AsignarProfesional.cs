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
    public partial class AsignarProfesional : Form
    {
        public AsignarProfesional()
        {
            InitializeComponent();
        }

        private void AsignarProfesional_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.PROFESIONAL' Puede moverla o quitarla según sea necesario.
            this.pROFESIONALTableAdapter.Fill(this.grisGrisDataSet.PROFESIONAL);
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.PROFESIONAL' Puede moverla o quitarla según sea necesario.
            this.pROFESIONALTableAdapter.Fill(this.grisGrisDataSet.PROFESIONAL);
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.buscarAsigando' Puede moverla o quitarla según sea necesario.
            this.buscarAsigandoTableAdapter.Fill(this.grisGrisDataSet.buscarAsigando);

        }
    }
}
