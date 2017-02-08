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
    public partial class RegistrarPaciente : Form
    {
        ConsultasBaseDatos consulta = new ConsultasBaseDatos();
        Validaciones validacion = new Validaciones();
        public RegistrarPaciente()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PacienteForm pf = new PacienteForm();
            pf.Show();
            this.Hide();
        }

        private void RegistrarPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            gBdatosPaciente.Enabled = true;

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string idRepresentante;
            DataTable consultaRepresentante;
            DataRow filaRepresentante;
            // SELECT* FROM movimiento WHERE idmovimiento = (SELECT MAX(idmovimiento) FROM movimiento
            #region recuperar el ultimo representante ingresado

            if (txtcedulaCliente.Text == "")
            {
                string recuperarUltimoRepresentante = "select*from REPRESENTANTE WHERE IDREPRESENTANTE =(SELECT MAX(IDREPRESENTANTE) FROM REPRESENTANTE)";

                consultaRepresentante = consulta.consultar(recuperarUltimoRepresentante);

                filaRepresentante = consultaRepresentante.Rows[0];

                idRepresentante = filaRepresentante["IDREPRESENTANTE"].ToString().Trim();

                txtcedulaCliente.Text = filaRepresentante["CEDULAREPRESENTANTE"].ToString().Trim();
                txtNombreEncontrado.Text = filaRepresentante["NOMBREREPRESENTANTE"].ToString().Trim();
                btnAceptar.Enabled = true;
                txtcedulaCliente.Enabled = false;
                btnBuscarCliente.Enabled = false;
                btnNuevaBusqueda.Enabled = true;
            }
            #endregion
            else
            {
                #region validacion de la cedula ingresada
                if (validacion.validarCedula(txtcedulaCliente.Text) == false)
                {
                    MessageBox.Show("Pro favor verifique y vuelva a intentarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcedulaCliente.Text = "";
                }
                else
                {
                    string buscarCliente = "select CEDULAREPRESENTANTE from REPRESENTANTE WHERE CEDULAREPRESENTANTE = '" + txtcedulaCliente.Text + "'";
                    consultaRepresentante = consulta.consultar(buscarCliente);
                    if (consultaRepresentante.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontro al cliente", "Resultado de busqueda", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string recuperarUltimoRepresentante = "select*from REPRESENTANTE WHERE IDREPRESENTANTE =(SELECT MAX(IDREPRESENTANTE) FROM REPRESENTANTE)";

                        consultaRepresentante = consulta.consultar(recuperarUltimoRepresentante);

                        filaRepresentante = consultaRepresentante.Rows[0];

                        idRepresentante = filaRepresentante["IDREPRESENTANTE"].ToString().Trim();

                        txtcedulaCliente.Text = filaRepresentante["CEDULAREPRESENTANTE"].ToString().Trim();
                        txtNombreEncontrado.Text = filaRepresentante["NOMBREREPRESENTANTE"].ToString().Trim();
                        btnAceptar.Enabled = true;
                        txtcedulaCliente.Enabled = false;
                        btnBuscarCliente.Enabled = false;
                        btnNuevaBusqueda.Enabled = true;
                    }
                }

                #endregion
            }



        }

        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            txtcedulaCliente.Text = "";
            btnBuscarCliente.Enabled = true;
            btnAceptar.Enabled = false;
            txtcedulaCliente.Enabled = true;
        }

        private void txNombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtEncargadoDECE_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtNref1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtNref2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtTelref1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txttelref2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {


            MessageBox.Show("3fasdf", "Confirmacion", MessageBoxButtons.OK);
            if (txtNombrePaciente.Text == "" || txtCedula.Text == "" || txtUEducativa.Text == ""
                || comboEscolaridad.Text == "")
            {
                MessageBox.Show("Hay campos obligatorios que se encuentran vacios, verifique porfavor", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string fecha = dateFechaNacimiento.Text;
                
                string[] anioNac = separarFecha(fecha, '/');
                DateTime fechaActual = DateTime.Now;
                string[] anioActual = separarFecha(fechaActual.ToString("d"),'/');
                txtEdad.Text = calcularEdad( anioNac[2], anioActual[2]);
            }

        }
        private string[] separarFecha(string fecha, char delimiter)
        {
            

            return fecha.Split(delimiter);
        }
        private string calcularEdad(string anioNacimiento, string anioActual)
        {
            string edad = "";


            edad = (Convert.ToInt32(anioActual) - Convert.ToInt32(anioNacimiento)).ToString();

            return edad;
        }

    }
}
