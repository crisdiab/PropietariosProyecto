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
    public partial class Factura : Form
    {
        Validaciones validacion = new Validaciones();
        ConsultasBaseDatos consulta = new ConsultasBaseDatos();
        string representanteID;
        string parametroId;
        public Factura()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Facturacion md = new Facturacion();
            md.Show();
            this.Hide();
        }

        private void Factura_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void sERVICIOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sERVICIOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grisGrisDataSet);

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.PARAMETROS' Puede moverla o quitarla según sea necesario.
            this.pARAMETROSTableAdapter.Fill(this.grisGrisDataSet.PARAMETROS);
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.PARAMETROS' Puede moverla o quitarla según sea necesario.
            this.pARAMETROSTableAdapter.Fill(this.grisGrisDataSet.PARAMETROS);
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.SERVICIO' Puede moverla o quitarla según sea necesario.
            this.sERVICIOTableAdapter.Fill(this.grisGrisDataSet.SERVICIO);

        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CantidadIngresada.Text) == 0)
            {
                MessageBox.Show("Debe ingresar una cantidad");
            }else
            {

                int Total = 0;
                Total = Convert.ToInt32(CantidadIngresada.Text) * Convert.ToInt32(txtPrecioSeleccionado.Text);

                GridDetalles.Rows.Add(CantidadIngresada.Text, txtServicioSeleccionado.Text, txtPrecioSeleccionado.Text, Total,iDSERVICIOSpinEdit.Text);
            }
            
            
            
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
                    MessageBox.Show("No se encontró al cliente", "Resultado de busqueda", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtcedulaCliente.Text = "";
                }
                else
                {

                    grupodetalle.Enabled = true;

                    #region llenar la caja de resultados obtenidos



                    filaRepresentante = consultaRepresentante.Rows[0];

                    representanteID = filaRepresentante["IDREPRESENTANTE"].ToString().Trim();
                    txtClienteObtenido.Text = filaRepresentante["NOMBREREPRESENTANTE"].ToString().Trim();
                    txtCedulaObtenida.Text = filaRepresentante["CEDULAREPRESENTANTE"].ToString().Trim();
                    txtDireccionObtenida.Text = filaRepresentante["DIRECCIONREPRESENTANTE"].ToString().Trim();
                    btnNueva.Enabled = false;


                    txtcedulaCliente.Enabled = false;
                    btnBuscarCliente.Enabled = false;
                    btnNuevaBusqueda.Enabled = true;
                    #endregion
                }
                #endregion
            }

            #endregion
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            gbServicios.Visible = true;
            btnAgregarServicio.Visible = false;

        }

        private void btnCerraragregar_Click(object sender, EventArgs e)
        {
            gbServicios.Visible = false;
            btnAgregarServicio.Visible = true;
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            int TotalFactura = 0;
            foreach (DataGridViewRow row in GridDetalles.Rows)
            {
                
                row.Cells["VtotalDetalle"].Value = (Convert.ToInt32(row.Cells["CantidadDetalle"].Value)) * Convert.ToInt32(row.Cells["VunitarioDetalle"].Value) ;

            }
            foreach (DataGridViewRow row in GridDetalles.Rows)
            {

                TotalFactura +=Convert.ToInt32( row.Cells["VtotalDetalle"].Value);

            }
            txtSutFactura.Text = TotalFactura.ToString();
            double a = Convert.ToDouble(txtSutFactura.Text);
            double vIva = Convert.ToDouble(txtIvaPArametros.Text) / 100;
            txtValorIva.Text =(a*vIva).ToString();
            double t = Convert.ToDouble(txtValorIva.Text);
            txtTotalFactura.Text = (t + a).ToString();
            btnAgregarDetalle.Enabled = false;
            gbServicios.Visible = false;
            btnCalcularTotal.Enabled = false;
            btnNuevaBusqueda.Enabled = false;
            btnNueva.Enabled = true;
            btnCrearfactura.Enabled = true;
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            grupoBuscarCliente.Enabled = true;

            string buscarUltimoFactura = "select top 1 * from PARAMETROS order by IDPARAMETROS desc";
            DataTable tablaFactura;

            tablaFactura = consulta.consultar(buscarUltimoFactura);
            DataTable consul;

            consul = consulta.consultar(buscarUltimoFactura);

            DataRow parametros =consul.Rows[0];
            txtNumeroFactura.Text = parametros["NUMEROFACTURA"].ToString().Trim();

            txtIvaPArametros.Text = parametros["VALORIVA"].ToString().Trim();
            parametroId = parametros["IDPARAMETROS"].ToString().Trim();







            //llenar numero de factura

            txtcedulaCliente.Enabled = true;
            txtcedulaCliente.Text = "";
            grupodetalle.Enabled = false;
            btnBuscarCliente.Enabled = true;
            btnAgregarDetalle.Enabled = true;
            gbServicios.Visible = false;
            GridDetalles.Rows.Clear();
            GridDetalles.Refresh();
            txtcedulaCliente.Text = "";
            txtClienteObtenido.Text = "";
            txtDireccionObtenida.Text = "";
            txtCedulaObtenida.Text = "";


        }

        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            txtcedulaCliente.Enabled = true;
            txtcedulaCliente.Text = "";
            grupodetalle.Enabled = false;
            btnBuscarCliente.Enabled = true;
            btnAgregarDetalle.Enabled = true;
            gbServicios.Visible = false;
            GridDetalles.Rows.Clear();
            GridDetalles.Refresh();
            txtcedulaCliente.Text = "";
            txtClienteObtenido.Text = "";
            txtDireccionObtenida.Text = "";
            txtCedulaObtenida.Text = "";
        }

        private void btnCrearfactura_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro de continuar se guardará la factura con el siguiente valor"+txtTotalFactura.Text,
            "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == resultado)
            {
                #region crear factura
                string crearFactura = "insert into FACTURA values(  '" + representanteID + "'" +
                      ", '" + txtNumeroFactura.Text + "'" +
                      ", '" + FECHAfACTURA.Text + "','" + txtSutFactura.Text + "'" +
                      ", ' "+txtValorIva.Text+" ','" + txtTotalFactura.Text + "','Activa' )";
                consulta.counsultaTodoTipo(crearFactura);
                MessageBox.Show("Factura ingresada correctamente al sistema",
                                    "Confirmación",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);



                #endregion

                #region crear detalle
                string buscarUltimo = "select top 1 * from FACTURA order by IDFACTURA desc";
                DataTable consul;

                consul = consulta.consultar(buscarUltimo);

                DataRow filaFact = consul.Rows[0];

                string facturaId = filaFact["IDFACTURA"].ToString().Trim();
                string nuevoNum = (Convert.ToInt32(filaFact["NUMEROFACTURA"].ToString().Trim())+1).ToString();

                string actualizarNumFact = "UPDATE PARAMETROS SET NUMEROFACTURA = '" + nuevoNum + "' WHERE IDPARAMETROS = '"+parametroId+"' ";

                consulta.counsultaTodoTipo(actualizarNumFact);
               

                #endregion
            }
            else if (DialogResult.No == resultado)
            {
                btnAgregarServicio.Enabled = true;
                btnCalcularTotal.Enabled = true;
            }
        }
    }
}
