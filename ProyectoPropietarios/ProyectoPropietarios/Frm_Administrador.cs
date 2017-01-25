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
    public partial class Frm_Administrador : Form
    {
        public Frm_Administrador()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaInicial PInicial = new PantallaInicial();
            PInicial.Visible = true;
        }

        private void ingresarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AyudaAdmin ay = new AyudaAdmin();
            ay.Show();
        }

        private void ingresarProfesionalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_DatosProfesional dp = new FRM_DatosProfesional();
            dp.Show();
        }

        private void ingresarEstudianteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_DatosPaciente dp = new FRM_DatosPaciente();
            dp.Show();
        }
    }
}
