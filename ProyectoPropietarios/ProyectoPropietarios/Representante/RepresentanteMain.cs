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
    public partial class RepresentanteMain : Form
    {
        public RepresentanteMain()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

      

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            RegistrarRepresentante rc = new RegistrarRepresentante();
            rc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            DardeBajaRepresentante ec = new DardeBajaRepresentante();
            ec.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cliente md = new Cliente();
            md.Show();
            this.Hide();
        }

        private void ClienteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            BuscarRepresentante mc = new BuscarRepresentante();
            mc.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            BuscarRepresentante mc = new BuscarRepresentante();
            mc.Show();
            this.Hide();
        }

        private void btnDardeBaja_Click(object sender, EventArgs e)
        {
            DardeBajaRepresentante ec = new DardeBajaRepresentante();
            ec.Show();
            this.Hide();
        }
    }
}
