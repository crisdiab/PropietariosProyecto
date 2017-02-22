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
    public partial class TalentoHumano : Form
    {
        public TalentoHumano()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarProfesional profesional = new RegistrarProfesional();
            profesional.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AsignarServicio aservicio = new AsignarServicio();
            aservicio.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarProfesional ep = new EliminarProfesional();
            ep.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Modulos mod = new Modulos();
            mod.Show();
            this.Hide();
        }

        private void TalentoHumano_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModificarProfesional mp = new ModificarProfesional();
            mp.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BuscarProfesional bp = new BuscarProfesional();
            bp.Show();
            this.Hide();
        }
    }
}
