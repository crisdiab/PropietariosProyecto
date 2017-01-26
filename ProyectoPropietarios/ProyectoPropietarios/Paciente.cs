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
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RegistrarPaciente registroPaciente = new RegistrarPaciente();
            registroPaciente.Show();
            this.Hide();
        }

        private void Paciente_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Paciente_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ModificarPaciente modificacionPaciente = new ModificarPaciente();
            modificacionPaciente.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Modulos modulos = new Modulos();
            modulos.Show();
            this.Hide();
        }
    }
}
