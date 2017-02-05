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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteForm cliente = new ClienteForm();
            cliente.Show();

            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PacienteForm paciente = new PacienteForm();
            paciente.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }
    }
}
