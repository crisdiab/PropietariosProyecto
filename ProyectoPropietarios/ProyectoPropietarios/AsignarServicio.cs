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
    public partial class AsignarServicio : Form
    {
        Validaciones validar = new Validaciones();
        ConsultasBaseDatos consulta = new ConsultasBaseDatos();
        string idProfesional;
        public AsignarServicio()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            TalentoHumano th= new TalentoHumano();
            th.Show();
            this.Hide();

        }

        private void AsignarServicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void AsignarServicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.SERVICIO' Puede moverla o quitarla según sea necesario.
            this.sERVICIOTableAdapter.Fill(this.grisGrisDataSet.SERVICIO);
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.SERVICIO' Puede moverla o quitarla según sea necesario.
            this.sERVICIOTableAdapter.Fill(this.grisGrisDataSet.SERVICIO);

        }

        private void sERVICIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sERVICIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grisGrisDataSet);

        }

        private void sERVICIOBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sERVICIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grisGrisDataSet);

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            TalentoHumano th = new TalentoHumano();
            th.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            DataTable consultaProfesional;
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
                consultaProfesional = consulta.consultar(buscarProfesional);
                #region buscar el cliente si esta o no r egistrado
                if (consultaProfesional.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontro al cliente", "Resultado de busqueda", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtcedulaCliente.Text = "";
                }
                else
                {

                    gbServicios.Enabled = true;

                    #region llenar la caja de resultados obtenidos



                    filaProfesional = consultaProfesional.Rows[0];

                    txtProfesionalObtenido.Text = filaProfesional["NOMBREPROFESIONAL"].ToString().Trim();
                    txidProfesional.Text =  filaProfesional["IDPROFESIONAL"].ToString().Trim();
                   


                    txtcedulaCliente.Enabled = false;
                    btnBuscarCliente.Enabled = false;
                    btnNuevaBusqueda.Enabled = true;
                    #endregion
                }
                #endregion
            }

            #endregion
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region buscar si existe el cliente
            string buscarAsignacion = "select IDPROFESIONAL,IDSERVICIO from SERVICIOSPORPROFESIONAL where IDPROFESIONAL = '" + txidProfesional.Text + "' and IDSERVICIO= '"+ txtIdServicio.Text + "'";
            DataTable consultarCedula = consulta.consultar(buscarAsignacion);
            if (consultarCedula.Rows.Count == 0)
            {
                


                //INSERT INTO table_name
                //VALUES(value1, value2, value3,...);
                string crearAsignacion = "insert into SERVICIOSPORPROFESIONAL values(  '" + txidProfesional.Text + "'" +
                    ", '" +  txtIdServicio.Text + "' )";
                consulta.counsultaTodoTipo(crearAsignacion);
                MessageBox.Show("Asignación registrada correctamente",
                                    "Confirmación",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);

              
                //





            }

            else
            {
                MessageBox.Show("El servicio elegido ya fue asignado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            #endregion
        }

        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            txtcedulaCliente.Enabled = true;
            btnBuscarCliente.Enabled = true;
            btnNuevaBusqueda.Enabled = false;
            txtcedulaCliente.Text = "";
            gbServicios.Enabled = false;
            txtProfesionalObtenido.Text = "";
            
        }
    }
}
