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
        #region botonesDeIngreso
        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
           

            
        }

        private void Btn_Ingresar_Hover(object sender, EventArgs e)
        {

            this.Btn_Ingresar.Visible = false;
            this.button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int usuario = Cmb_Usuarios.SelectedIndex;
           
            switch (usuario)
            {

                case 0:
                    MessageBox.Show("Bienvenido Ingreso como Administrador");
                    Frm_Administrador admin = new Frm_Administrador();
                    admin.Show();
                    this.Hide();
                    break;
                case 1:
                    MessageBox.Show("Bienvenido Ingreso como Profesor");
                    Frm_Profesor profesor = new Frm_Profesor();
                    profesor.Show();
                    this.Hide();
                    break;
                case 2:
                    MessageBox.Show("Bienvenido Ingreso como Secretario");
                    Frm_Secretario secretario = new Frm_Secretario();
                    secretario.Show();
                    this.Hide();
                    break;
                 default:
                    MessageBox.Show("Debe seleccionar un rol");
                    break;


            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.Btn_Ingresar.Visible = true;
            this.button1.Visible = false;
        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            const string message =
        "Esta Seguro de querer salir?";
            const string caption = "Salir";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
               
                
            }
            
        }

       

       


    }
}
