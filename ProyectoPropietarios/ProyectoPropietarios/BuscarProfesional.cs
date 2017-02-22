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
    public partial class BuscarProfesional : Form
    {
        Validaciones validar = new Validaciones();
        ConsultasBaseDatos consulta = new ConsultasBaseDatos();

        public BuscarProfesional()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {


            DataTable consultarProfesional;
            DataRow filaProfesional;

            // SELECT* FROM movimiento WHERE idmovimiento = (SELECT MAX(idmovimiento) FROM movimiento


            #region validacion de la cedula ingresada
            if (validar.validarCedula(txtcedulaCliente.Text) == false)
            {
                MessageBox.Show("Cédula inválida.!!!!\n Por favor verifique y vuelva a intentarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcedulaCliente.Text = "";
            }
            else
            {
                string buscarProfesional = "select * from PROFESIONAL WHERE CEDULAPROFESIONAL = '" + txtcedulaCliente.Text + "'";
                consultarProfesional = consulta.consultar(buscarProfesional);
                #region buscar el profesional si esta o no r egistrado
                if (consultarProfesional.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontro al profesional", "Resultado de busqueda", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtcedulaCliente.Text = "";
                }
                else
                {

                    gbDatosObtenidos.Enabled = true;

                    #region llenar la caja de resultados obtenidos



                    filaProfesional = consultarProfesional.Rows[0];

                    txtNObtenido.Text = filaProfesional["NOMBREPROFESIONAL"].ToString().Trim();
                    txtCedulaObtenida.Text = filaProfesional["CEDULAPROFESIONAL"].ToString().Trim();
                   
                    txtTelObtenido.Text = filaProfesional["TELEFONOPROFESIONAL"].ToString().Trim();
                    txtTituloObtenido.Text = filaProfesional["TITULOPROFESIONAL"].ToString().Trim();


                    txtcedulaCliente.Enabled = false;
                    btnBuscarCliente.Enabled = false;
                    btnNuevaBusqueda.Enabled = true;
                    #endregion
                }
                #endregion
            }

            #endregion
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TalentoHumano th = new TalentoHumano();
            th.Show();
            this.Hide();
        }

        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            txtcedulaCliente.Enabled = true;
            btnBuscarCliente.Enabled = true;
            btnNuevaBusqueda.Enabled = false;
            txtcedulaCliente.Text = "";
            txtNObtenido.Text = "";
            txtCedulaObtenida.Text = "";
            txtTelObtenido.Text = "";
            txtTituloObtenido.Text = "";
        }
    }
}
