﻿using System;
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
    public partial class ClienteForm : Form
    {
        public ClienteForm()
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
            RegistrarCliente rc = new RegistrarCliente();
            rc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            DardeBajaCliente ec = new DardeBajaCliente();
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
            ModificarCliente mc = new ModificarCliente();
            mc.Show();
            this.Hide();
        }
    }
}
