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
    public partial class PantallaInicial : Form
    {
        public PantallaInicial()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            int usuario = Cmb_Usuarios.SelectedIndex;
            MessageBox.Show("Selecciono " + usuario);
            switch (usuario) { 
            
                case 0:
                    MessageBox.Show("Ingreso como Administrador");
                    Frm_Administrador admin = new Frm_Administrador();
                    admin.Show();
                    this.Hide();
                    break;
            
            }

            
        }

        private void Btn_Ingresar_Hover(object sender, EventArgs e)
        {

            this.Btn_Ingresar.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.logBig));
        }

       
            
       
    }
}
