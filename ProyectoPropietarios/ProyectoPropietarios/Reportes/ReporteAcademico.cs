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
    public partial class ReporteAcademico : Form
    {
        public ReporteAcademico()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Reportes re = new Reportes();
            re.Show();
            this.Hide();

        }

        private void ReporteAcademico_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }
    }
}
