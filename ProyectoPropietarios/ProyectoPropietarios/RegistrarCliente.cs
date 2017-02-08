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
    public partial class RegistrarCliente : Form
    {
        Validaciones validacion = new Validaciones();
        ConsultasBaseDatos consulta = new ConsultasBaseDatos();
        public RegistrarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
          
        }

        private void RegistrarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtNombreCliente.Text != "" || txtApellidoCliente.Text != "" || txtCedulaCliente.Text != "" || txtTelfCliente.Text != "" || txtCellCliente.Text != "" || txtDireccionCliente.Text != "")
            {
                DialogResult result1 = MessageBox.Show("Esta seguro de regresar?, tiene informacion que aún no a guardado",
                        "Confirmación",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Warning);
                if(DialogResult.Yes== result1)
                {
                    ClienteForm cf = new ClienteForm();
                    cf.Show();
                    this.Hide();
                }

            }
            else
            {
                ClienteForm cf = new ClienteForm();
                cf.Show();
                this.Hide();
            }

           
            
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txtTelfCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void txtCellCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
                DialogResult result1 = MessageBox.Show("Esta seguro de cancelar, se borraran los campos ingresados?",
                             "Confirmación",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Warning);
            if (DialogResult.Yes == result1)
            {
                txtNombreCliente.Text = "";
                txtApellidoCliente.Text = "";
                txtCedulaCliente.Text = "";
                txtTelfCliente.Text = "";
                txtCellCliente.Text = "";
                txtDireccionCliente.Text = "";


            }
            
            
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           bool validarCedula = validacion.validarCedula(txtCedulaCliente.Text);
            #region verificacion de campos obligatorios vacios
            if (txtNombreCliente.Text == "" || txtApellidoCliente.Text == "" || txtCedulaCliente.Text == "" ||
                txtTelfCliente.Text == "" || txtDireccionCliente.Text == ""||txtCellCliente.Text=="")
            {
                MessageBox.Show("Hay campos obligatorios vacios, porfavor verifique",
                                             "Confirmación",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
            }
            else
            {
                #region validarCedula
                if (validarCedula == true)
                {
                    #region buscar si existe el cliente
                    string buscarCedula = "select CEDULAREPRESENTANTE from REPRESENTANTE where CEDULAREPRESENTANTE = '" + txtCedulaCliente.Text + "' ";
                    DataTable consultarCedula = consulta.consultar(buscarCedula);
                    if (consultarCedula.Rows.Count == 0)
                    {
                        string nombreCliente = txtNombreCliente.Text +" "+ txtApellidoCliente.Text;
                        MessageBox.Show(nombreCliente,
                                           "Confirmación",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                        //INSERT INTO table_name
                        //VALUES(value1, value2, value3,...);
                        string crearCliente = "insert into REPRESENTANTE values(  '" + nombreCliente + "'"+
                            ", '" + txtCedulaCliente.Text + "'"+
                            ", '" + txtDireccionCliente.Text + "','" + txtTelfCliente.Text + "'"+
                            ", ' Activo ','" + txtCellCliente.Text + "' )";
                        consulta.counsultaTodoTipo(crearCliente);
                        MessageBox.Show("Cliente creado correctamente",
                                            "Confirmación",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);

                        txtNombreCliente.Text = "";
                        txtApellidoCliente.Text = "";
                        txtCedulaCliente.Text = "";
                        txtDireccionCliente.Text = "";
                        txtCellCliente.Text = "";
                        txtTelfCliente.Text = "";





                    }

                    else
                    {
                        MessageBox.Show("El cliente que ingreso ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    #endregion

                }
                else
                {
                    MessageBox.Show("Cedula Ingresada Inválida, porfavor verifique",
                                                 "Confirmación",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Warning);
                }
                #endregion


            }
            #endregion

        }
    }
}
