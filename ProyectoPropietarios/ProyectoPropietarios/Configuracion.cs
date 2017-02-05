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
    public partial class Configuracion : Form
    {
        ConsultasBaseDatos consulta = new ConsultasBaseDatos();
        Validaciones validacion = new Validaciones();
        public Configuracion()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        #region elemntosForm
        private void button2_Click(object sender, EventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void Configuracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            // select top 1 * from tabla order by campo desc
            string buscarUltimo = "select top 1 * from PARAMETROS order by IDPARAMETROS desc";
            DataTable consul;

            consul = consulta.consultar(buscarUltimo);


            btnCrearParam.Visible = false;
            txtPass.Visible = false;
            btnGuardar.Visible = true;
            txtUsuario.Enabled = false;
            lblpass.Visible = false;
            DataRow row = consul.Rows[0];

            if (row["USUARIO"].ToString().Trim() == "default")
            {
                MessageBox.Show("No puede modificar la informacion para este usuario Por favor "+
                     "Cree un usuario nuevo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCrearParam.Visible = true;
                btnGuardar.Visible = false;
                txtUsuario.Enabled = true;
                lblpass.Visible = true;
                txtPass.Visible = true;
            }
            else
            {
                txtUsuario.Text = row["USUARIO"].ToString();
                txtPass.Text = row["CONTRASENIA"].ToString();
                txtNumFactura.Text = row["NUMEROFACTURA"].ToString();
                txtIva.Text = row["VALORIVA"].ToString();
            }


            // MessageBox.Show(txtAuxUser.Text, "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            





        }

        private void btnCrearParam_Click(object sender, EventArgs e)
        {
            string buscarUltimo = "select top 1 * from PARAMETROS order by IDPARAMETROS desc";
            DataTable consul;

            consul = consulta.consultar(buscarUltimo);

            DataRow row = consul.Rows[0];
            // INSERT INTO Customers(CustomerName, ContactName, Address, City, PostalCode, Country)
            //VALUES('Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway');

            if (row["USUARIO"].ToString().Trim() == "default")
            {
                if (txtIva.Text == "" || txtNumFactura.Text == "" || txtUsuario.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Hay campos vacios verifique porfavor que los campos marcados con  (*) se encuentren llenos correctamente \n Gracias.", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string crear = "insert INTO PARAMETROS VALUES (" + txtIva.Text + ",'" + txtNumFactura.Text + "','" + txtUsuario.Text + "','" + txtPass.Text + "')";
                    consulta.counsultaTodoTipo(crear);
                    MessageBox.Show("Se creo el usuario", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Por favor cierre el programa e inicie otra vez  ingresando las credenciales creadas \n Muchas Gracias!", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string eliminarDefault = "DELETE FROM PARAMETROS " +
                                "WHERE USUARIO = 'default'";
                    consulta.counsultaTodoTipo(eliminarDefault);
                    Modulos md = new Modulos();
                    md.Show();
                    this.Hide();
                }
               
                

            }
            else
            {
                MessageBox.Show("Ya no se permite crar mas cuentas para el sistema", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //            UPDATE Customers
            //SET ContactName = 'Alfred Schmidt', City = 'Frankfurt'
            //WHERE CustomerID = 1;
           
            

            string actualizar = "UPDATE PARAMETROS SET   NUMEROFACTURA = '" + txtNumFactura.Text + "' , VALORIVA = '" + txtIva.Text + "' WHERE USUARIO= '" + txtUsuario.Text + "'";

           consulta.counsultaTodoTipo(actualizar);
            MessageBox.Show("Datos actualizados correctamente", "Actualizar Parametros", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblpass_Click(object sender, EventArgs e)
        {

        }

        private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            validacion.soloNumeros(e);
        }
        #endregion

        private void txtNumFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }
    }
}
