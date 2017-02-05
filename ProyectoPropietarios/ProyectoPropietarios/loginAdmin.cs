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
    public partial class loginAdmin : Form
    {
        ConsultasBaseDatos consulta = new ConsultasBaseDatos();
        public loginAdmin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modulos mod = new Modulos();
            mod.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adminUser = txtUserAdmin.Text;
            string pass = txtUserPass.Text;
            string buscarUsuario = "select USUARIO from PARAMETROS where USUARIO = '" + adminUser + "'";


            DataTable consultarUsuario = consulta.consultar(buscarUsuario);

            if (consultarUsuario.Rows.Count == 0)
            {
                MessageBox.Show("No existe ningun usuario admin", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string buscarPass = "select USUARIO, CONTRASENIA from PARAMETROS where USUARIO = '" + adminUser + "' and CONTRASENIA = '" + pass + "'";


                DataTable consultarpass = consulta.consultar(buscarPass);
                if (consultarpass.Rows.Count == 0)
                {
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Acceso concedido", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Configuracion conf = new Configuracion();
                    conf.Show();
                    this.Hide();
                }
            
            }
            
        }
    }
}
