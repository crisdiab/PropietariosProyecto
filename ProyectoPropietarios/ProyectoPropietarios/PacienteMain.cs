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
    public partial class PacienteMain : Form
    {
        public PacienteMain()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RegistrarPaciente rp = new RegistrarPaciente();
            rp.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ModificarPaciente mp = new ModificarPaciente();
            mp.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DardeBajaPaciente ep = new DardeBajaPaciente();
            ep.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cliente md = new Cliente();
            md.Show();
            this.Hide();
        }

        private void PacienteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarPaciente bp = new buscarPaciente();
            bp.Show();
            this.Hide();
        }
    }
}
