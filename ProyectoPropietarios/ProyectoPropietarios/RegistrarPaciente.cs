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
        private int idRepresentante=0;
        public RegistrarPaciente()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtNombrePaciente.Text != "" || txtCedula.Text != "" || txtUEducativa.Text != ""
                || comboEscolaridad.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Esta seguro que quiere regresar, se perderan los datos ingresados",
             "Regresar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == resultado)
                {
                    PacienteMain pf = new PacienteMain();
                    pf.Show();
                    this.Hide();
                }
            }
            else
            {
                PacienteMain pf = new PacienteMain();
                pf.Show();
                this.Hide();
            }
            
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
            
            DataTable consultaRepresentante;
            DataRow filaRepresentante;
            // SELECT* FROM movimiento WHERE idmovimiento = (SELECT MAX(idmovimiento) FROM movimiento
            #region recuperar el ultimo representante ingresado

            if (txtcedulaCliente.Text == "")
            {
                string recuperarUltimoRepresentante = "select*from REPRESENTANTE WHERE IDREPRESENTANTE =(SELECT MAX(IDREPRESENTANTE) FROM REPRESENTANTE)";

                consultaRepresentante = consulta.consultar(recuperarUltimoRepresentante);

                filaRepresentante = consultaRepresentante.Rows[0];

                idRepresentante = Convert.ToInt32(filaRepresentante["IDREPRESENTANTE"].ToString().Trim());

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
                    string buscarCliente = "select * from REPRESENTANTE WHERE CEDULAREPRESENTANTE = '" + txtcedulaCliente.Text + "'";
                    consultaRepresentante = consulta.consultar(buscarCliente);
                    #region buscar el cliente si esta o no r egistrado
                    if (consultaRepresentante.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontro al cliente", "Resultado de busqueda", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string recuperarUltimoRepresentante = "select*from REPRESENTANTE WHERE CEDULAREPRESENTANTE = '"+txtcedulaCliente.Text+"'";

                       DataTable consultaRepresentante2 = consulta.consultar(recuperarUltimoRepresentante);

                       DataRow filaRepresentante2 = consultaRepresentante2.Rows[0];
                        if (filaRepresentante2["ESTADOREPRESENTANTE"].ToString().Trim() == "Activo")
                        {
                            idRepresentante = Convert.ToInt32(filaRepresentante2["IDREPRESENTANTE"].ToString().Trim());

                            txtcedulaCliente.Text = filaRepresentante2["CEDULAREPRESENTANTE"].ToString().Trim();
                            txtNombreEncontrado.Text = filaRepresentante2["NOMBREREPRESENTANTE"].ToString().Trim();
                            btnAceptar.Enabled = true;
                            txtcedulaCliente.Enabled = false;
                            btnBuscarCliente.Enabled = false;
                            btnNuevaBusqueda.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("El cliente esta dado de baja", "Resultado de busqueda", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                        }

                       
                    }
                    #endregion
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
            gBdatosPaciente.Enabled = false;
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
            validacion.soloNumeros(e);
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {


           
            if (txtNombrePaciente.Text == "" || txtCedula.Text == "" || txtUEducativa.Text == ""
                || comboEscolaridad.Text == "")
            {
                MessageBox.Show("Hay campos obligatorios que se encuentran vacios, verifique porfavor", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                #region validar cedula antes de guardar
                if (validacion.validarCedula(txtCedula.Text) == false)
                {
                    MessageBox.Show("Porfavor verifique e intentelo de nuevo", "Confirmacion", MessageBoxButtons.OK);
                }
                else
                {
                    string fecha = dateFechaNacimiento.Text;
                    string[] anioNac = separarFecha(fecha, '/');
                    DateTime fechaActual = DateTime.Now;
                    string[] anioActual = separarFecha(fechaActual.ToString("d"), '/');
                    txtEdad.Text = calcularEdad(anioNac[2], anioActual[2]);

                    string stringBuscarCedula = "select CEDULAPACIENTE FROM PACIENTE WHERE CEDULAPACIENTE = '"+ txtCedula.Text+"'";
                    DataTable tablaPaciente = consulta.consultar(stringBuscarCedula);

                    if (tablaPaciente.Rows.Count == 0)
                    {

                        #region buscar id del centro
                        string buscarTipoCentro = "select * FROM TIPOCENTROEDUCACION WHERE NOMBRETIPOCENTRO='"+comboEscolaridad.Text.Trim()+"'";
                        DataTable tablaTipocentro = consulta.consultar(buscarTipoCentro);
                        
                        DataRow filaTipocentro = tablaTipocentro.Rows[0];
                       
                        int idCentro = Convert.ToInt32(filaTipocentro["IDCENTRO"].ToString().Trim());

                        int otro = idCentro + idCentro;
                        MessageBox.Show(otro.ToString(), "fua", MessageBoxButtons.OK);
                        #endregion
                        #region crear centro educativo y obtener el id creado
                        string crearCentro = "insert into CENTROEDUCACION VALUES('"+idCentro+"','"+txtUEducativa.Text+"')";

                        consulta.counsultaTodoTipo(crearCentro);

                        string obteneridCreadodeUE = "select * from CENTROEDUCACION WHERE IDCENTROEDUCACION = (SELECT MAX(IDCENTROEDUCACION) FROM CENTROEDUCACION)";
                        DataTable consultarCE = consulta.consultar(obteneridCreadodeUE);
                        DataRow filaCE = consultarCE.Rows[0];

                        int idCentroEduc =Convert.ToInt32( filaCE["IDCENTROEDUCACION"].ToString().Trim());
                        #endregion
                        #region creacion del paciente
                        string crearPaciente = "insert into PACIENTE VALUES('"+idRepresentante+ "','" + idCentroEduc + "','" + txtNombrePaciente.Text+ "','" +txtCedula.Text  + "',"+
                            "'" +txtEdad.Text + "','" + txtEncargadoDECE.Text+ "','" + txtNref1.Text+ "','" +txtTelref1.Text + "','" + txtNref2.Text+ "','" +txttelref2.Text +"',"+
                            "'Activo','" + fecha+"')";

                        consulta.counsultaTodoTipo(crearPaciente);
                        #endregion

                        MessageBox.Show("Paciente creado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombrePaciente.Text = "";
                        txtCedula.Text = "";
                        txtEdad.Text = "";
                        txtUEducativa.Text = "";
                        txtNref1.Text = "";
                        txtTelref1.Text = "";
                        txtNref2.Text = "";
                        txttelref2.Text = "";
                        gBdatosPaciente.Enabled = false;
                        btnAceptar.Enabled = false;
                        btnNuevaBusqueda.Enabled = false;
                        btnBuscarCliente.Enabled = true;
                        txtcedulaCliente.Enabled = true;
                        txtcedulaCliente.Text = "";
                        txtEncargadoDECE.Text = "";
                        comboEscolaridad.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El paciente que ingreso ya se encuentra registrado en el sistema",
                            "Notificacion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        txtNombrePaciente.Text = "";
                        txtCedula.Text = "";
                        txtEdad.Text = "";
                        txtUEducativa.Text = "";
                        txtNref1.Text = "";
                        txtTelref1.Text = "";
                        txtNref2.Text = "";
                        txttelref2.Text = "";
                        gBdatosPaciente.Enabled = false;
                        btnAceptar.Enabled = false;
                        btnNuevaBusqueda.Enabled = false;
                        btnBuscarCliente.Enabled = true;
                        txtcedulaCliente.Enabled = true;
                        txtcedulaCliente.Text = "";
                        txtEncargadoDECE.Text = "";
                        comboEscolaridad.Text = "";
                    }
                }
                

                #endregion
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que quiere cancelar, se perderan los datos ingresados",
              "Cancelar",MessageBoxButtons.YesNo,MessageBoxIcon.Question  );

            if (DialogResult.Yes == resultado)
            {
                txtNombrePaciente.Text = "";
                txtCedula.Text = "";
                txtEdad.Text = "";
                txtUEducativa.Text = "";
                txtNref1.Text = "";
                txtTelref1.Text = "";
                txtNref2.Text = "";
                txttelref2.Text = "";
                gBdatosPaciente.Enabled = false;
                btnAceptar.Enabled = false;
                btnNuevaBusqueda.Enabled = false;
                btnBuscarCliente.Enabled = true;
                txtcedulaCliente.Enabled = true;
                txtcedulaCliente.Text = "";
                txtEncargadoDECE.Text = "";
            }
        }
    }
}
