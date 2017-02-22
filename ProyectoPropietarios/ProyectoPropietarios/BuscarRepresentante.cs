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
    public partial class BuscarRepresentante : Form
    {
        ConsultasBaseDatos consulta = new ConsultasBaseDatos();
        Validaciones validacion = new Validaciones();

        
        public BuscarRepresentante()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RepresentanteMain cf = new RepresentanteMain();
            cf.Show();
            this.Hide();
        }

        private void ModificarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            DataTable consultaRepresentante;
            DataRow filaRepresentante;
            
            // SELECT* FROM movimiento WHERE idmovimiento = (SELECT MAX(idmovimiento) FROM movimiento
            
          
                #region validacion de la cedula ingresada
                if (validacion.validarCedula(txtcedulaCliente.Text) == false)
                {
                    MessageBox.Show("Cédula inválida.!!!!\n Por favor verifique y vuelva a intentarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    txtcedulaCliente.Text = "";
                }
                    else
                    {

                    gbDatosObtenidos.Enabled = true;

                    #region llenar la caja de resultados obtenidos



                    filaRepresentante = consultaRepresentante.Rows[0];

                    txtNObtenido.Text = filaRepresentante["NOMBREREPRESENTANTE"].ToString().Trim();
                    txtCedulaObtenida.Text = filaRepresentante["CEDULAREPRESENTANTE"].ToString().Trim();
                    txtDirObtenida.Text = filaRepresentante["DIRECCIONREPRESENTANTE"].ToString().Trim();
                    txtTelObtenido.Text = filaRepresentante["TELEFONOREPRESENTANTE"].ToString().Trim();
                    txtCellobtenido.Text = filaRepresentante["CELULARREPRESENTANTE"].ToString().Trim();


                    txtcedulaCliente.Enabled = false;
                    btnBuscarCliente.Enabled = false;
                    btnNuevaBusqueda.Enabled = true;
                    #endregion
                }
                #endregion
            }

                #endregion
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            gbDatosObtenidos.Enabled = true;
            DataTable consultaRepresentante;
            DataRow filaRepresentante;

            // SELECT* FROM movimiento WHERE idmovimiento = (SELECT MAX(idmovimiento) FROM movimiento


            #region validacion de la cedula ingresada
           
            
            
                string buscarCliente = "select * from REPRESENTANTE WHERE CEDULAREPRESENTANTE = '" + txtcedulaCliente.Text + "'";
                consultaRepresentante = consulta.consultar(buscarCliente);
                #region llenar la caja de resultados obtenidos
                
                
    
                    filaRepresentante = consultaRepresentante.Rows[0];

            txtNObtenido.Text = filaRepresentante["NOMBREREPRESENTANTE"].ToString().Trim();
            txtCedulaObtenida.Text = filaRepresentante["CEDULAREPRESENTANTE"].ToString().Trim();
            txtDirObtenida.Text = filaRepresentante["DIRECCIONREPRESENTANTE"].ToString().Trim();
            txtTelObtenido.Text = filaRepresentante["TELEFONOREPRESENTANTE"].ToString().Trim();
            txtCellobtenido.Text = filaRepresentante["CELULARREPRESENTANTE"].ToString().Trim();

            
            txtcedulaCliente.Enabled = false;
            btnBuscarCliente.Enabled = false;
            btnNuevaBusqueda.Enabled = true;
            #endregion


            #endregion
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            //UPDATE Customers
            //SET ContactName = 'Alfred Schmidt', City = 'Frankfurt'
            //WHERE CustomerID = 1;
            if (validacion.validarCedula(txtCedulaObtenida.Text.Trim()) == false)
            {
                MessageBox.Show("Verifique e intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else
            {
                #region ActualizarCliente
                DataTable consultaRepresentante;
                DataRow filaRepresentante;
                string buscarCliente = "select * from REPRESENTANTE WHERE CEDULAREPRESENTANTE = '" + txtcedulaCliente.Text + "'";
                consultaRepresentante = consulta.consultar(buscarCliente);
                filaRepresentante = consultaRepresentante.Rows[0];
                string actualizarCliente = "update REPRESENTANTE SET NOMBREREPRESENTANTE='" + txtNObtenido.Text + "',CEDULAREPRESENTANTE='" + txtCedulaObtenida.Text + "',"
                    + "DIRECCIONREPRESENTANTE = '" + txtDirObtenida.Text + "',TELEFONOREPRESENTANTE='" + txtTelObtenido.Text + "',"
                    + "CELULARREPRESENTANTE='" + txtCellobtenido.Text + "' WHERE IDREPRESENTANTE= '" + filaRepresentante["IDREPRESENTANTE"] + "'";
                consulta.counsultaTodoTipo(actualizarCliente);
                #endregion
                MessageBox.Show("El cliente se actualizo correctamente", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNObtenido.Text = "";
                    txtCedulaObtenida.Text = "";
                txtDirObtenida.Text = "";
                txtTelObtenido.Text = "";
                txtCellobtenido.Text = "";
                gbDatosObtenidos.Enabled = false;
               
                txtcedulaCliente.Enabled = true;
                btnBuscarCliente.Enabled = true;
                btnNuevaBusqueda.Enabled = false;
                txtcedulaCliente.Text = "";



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que quiere cancelar, se perderan los datos ingresados",
             "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == resultado)
            {

                txtNObtenido.Text = "";
                txtCedulaObtenida.Text = "";
                txtDirObtenida.Text = "";
                txtTelObtenido.Text = "";
                txtCellobtenido.Text = "";
                gbDatosObtenidos.Enabled = false;
               
                txtcedulaCliente.Enabled = true;
                btnBuscarCliente.Enabled = true;
                btnNuevaBusqueda.Enabled = false;
                txtcedulaCliente.Text = "";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TalentoHumano pf = new TalentoHumano();
            pf.Show();
            this.Hide();
        }

        private void txtcedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txtNObtenido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtCedulaObtenida_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txtTelObtenido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txtCellobtenido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            txtNObtenido.Text = "";
            txtCedulaObtenida.Text = "";
            txtDirObtenida.Text = "";
            txtTelObtenido.Text = "";
            txtCellobtenido.Text = "";
            txtcedulaCliente.Enabled = true;
            btnBuscarCliente.Enabled = true;
            btnNuevaBusqueda.Enabled = false;
            txtcedulaCliente.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
