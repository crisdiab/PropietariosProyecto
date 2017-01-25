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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (Pbar1.Value < 100)
            {
                this.Pbar1.Increment(2);
                label1.Text = "Cargando el sistema al " + Pbar1.Value.ToString() + "%";

            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                Login lg = new Login();
                
                lg.Show();
            }

        }

        private void Pbar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
