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

                string buscarUltimo = "select top 1 * from PARAMETROS order by IDPARAMETROS desc";
                DataTable consul;

                consul = consulta.consultar(buscarUltimo);

                DataRow row = consul.Rows[0];

                if(row["USUARIO"].ToString().Trim()=="default")
                {
                    MessageBox.Show("Atencion esta ingresando en la cuenta por default", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    #region buscar usuario y contrasenia
                    string buscarUsuario1 = "select USUARIO from PARAMETROS where USUARIO = '" + usuario + "'";


                    DataTable consultarUsuario1 = consulta.consultar(buscarUsuario1);
                    if (consultarUsuario1.Rows.Count == 0)
                    {
                        MessageBox.Show("El usuario que ingreso no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string buscarPassword1 = "select CONTRASENIA from PARAMETROS where USUARIO = '" + usuario + "' and CONTRASENIA = '" + password + "'";
                        DataTable consultarContrasenia1 = consulta.consultar(buscarPassword1);
                        if (consultarContrasenia1.Rows.Count == 0)
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
                    #endregion
                }
                else
                {
                    #region buscar usuario y contrasenia
                    string buscarUsuario = "select USUARIO from PARAMETROS where USUARIO = '" + usuario + "'";


                    DataTable consultarUsuario = consulta.consultar(buscarUsuario);
                    if (consultarUsuario.Rows.Count == 0)
                    {
                        MessageBox.Show("El usuario que ingreso no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string buscarPassword = "select CONTRASENIA from PARAMETROS where USUARIO = '" + usuario + "' and CONTRASENIA = '" + password + "'";
                        DataTable consultarContrasenia = consulta.consultar(buscarPassword);
                        if (consultarContrasenia.Rows.Count == 0)
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
                    #endregion
                }





            }

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                string usuario, password;

                usuario = txtUser.Text;
                password = txtPassword.Text;
                if (usuario == "" || password == "")
                {
                    MessageBox.Show("Debe ingresar un usuario y password", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    string buscarUltimo = "select top 1 * from PARAMETROS order by IDPARAMETROS desc";
                    DataTable consul;

                    consul = consulta.consultar(buscarUltimo);

                    DataRow row = consul.Rows[0];

                    if (row["USUARIO"].ToString().Trim() == "default")
                    {
                        MessageBox.Show("Atencion esta ingresando en la cuenta por default", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        #region buscar usuario y contrasenia
                        string buscarUsuario1 = "select USUARIO from PARAMETROS where USUARIO = '" + usuario + "'";


                        DataTable consultarUsuario1 = consulta.consultar(buscarUsuario1);
                        if (consultarUsuario1.Rows.Count == 0)
                        {
                            MessageBox.Show("El usuario que ingreso no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string buscarPassword1 = "select CONTRASENIA from PARAMETROS where USUARIO = '" + usuario + "' and CONTRASENIA = '" + password + "'";
                            DataTable consultarContrasenia1 = consulta.consultar(buscarPassword1);
                            if (consultarContrasenia1.Rows.Count == 0)
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
                        #endregion
                    }
                    else
                    {
                        #region buscar usuario y contrasenia
                        string buscarUsuario = "select USUARIO from PARAMETROS where USUARIO = '" + usuario + "'";


                        DataTable consultarUsuario = consulta.consultar(buscarUsuario);
                        if (consultarUsuario.Rows.Count == 0)
                        {
                            MessageBox.Show("El usuario que ingreso no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string buscarPassword = "select CONTRASENIA from PARAMETROS where USUARIO = '" + usuario + "' and CONTRASENIA = '" + password + "'";
                            DataTable consultarContrasenia = consulta.consultar(buscarPassword);
                            if (consultarContrasenia.Rows.Count == 0)
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
                        #endregion
                    }





                }
            }

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si es la primera vez que ingresa al sistema ingrese las siguientes credenciales:\n"+
                "Usuario:default\nPassword:1234",
                                          "Confirmación",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
        }
    }
}
