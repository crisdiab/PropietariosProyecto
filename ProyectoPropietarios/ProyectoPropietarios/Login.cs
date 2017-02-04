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
    public partial class Login : Form
    {

        ConsultasBaseDatos consulta = new ConsultasBaseDatos();
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pBoxIngresar_Click(object sender, EventArgs e)
        {
            string usuario, password;

            usuario = txtUser.Text;
            password = txtPassword.Text;
            if(usuario== ""||password=="")
            {
                MessageBox.Show("Debe ingresar un usuario y password", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string buscarUsuario = "select USUARIO from PARAMETROS where USUARIO = '" + usuario + "'";


                DataTable consultarUsuario = consulta.consultar(buscarUsuario);

                if(consultarUsuario.Rows.Count == 0)
                {
                    MessageBox.Show("El usuario que ingreso no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string buscarPassword = "select CONTRASENIA from PARAMETROS where CONTRASENIA = '" + password + "'";
                    DataTable consultarContrasenia = consulta.consultar(buscarPassword);
                    if(consultarContrasenia.Rows.Count == 0)
                    {
                        MessageBox.Show("El password ingresado es inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Credenciales correctas", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Modulos md = new Modulos();
                        md.Show();
                        this.Hide();
                    }
                    
                }

                
            }

        }

        
    }
}
