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
    public partial class RegistrarPaciente : Form
    {
        public RegistrarPaciente()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PacienteForm pf = new PacienteForm();
            pf.Show();
            this.Hide();
        }

        private void RegistrarPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }
    }
}
