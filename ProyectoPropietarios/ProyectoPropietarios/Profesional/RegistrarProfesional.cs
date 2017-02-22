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
    public partial class RegistrarProfesional : Form
    {
        Validaciones validar = new Validaciones();
        ConsultasBaseDatos consulta = new ConsultasBaseDatos();
        public RegistrarProfesional()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            TalentoHumano th = new TalentoHumano();
            th.Show();
            this.Hide();
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            TalentoHumano th = new TalentoHumano();
            th.Show();
            this.Hide();

        }

        private void Profesional_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validarCedula = validar.validarCedula(txtCedulaProfesional.Text);
            #region verificar campos vacios
            if (txtNombreProfesional.Text==""&&txtCedulaProfesional.Text==""&&
                txtTlfProfesional.Text==""&&txtTituloProfesional.Text=="")
            {
                MessageBox.Show("Hay campos obligatorios que necesita llenar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                #region validar cedula
                if (validarCedula == false)
                {
                    MessageBox.Show("Cédula ingresada inválida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }else
                {
                    #region buscar representante
                    string buscarCedula = "select CEDULAREPRESENTANTE from REPRESENTANTE where CEDULAREPRESENTANTE = '" + txtCedulaProfesional.Text + "' ";
                    DataTable consultarCedula = consulta.consultar(buscarCedula);
                    if (consultarCedula.Rows.Count == 0)
                    {
                        string crearProfesional = "insert into REPRESENTANTE values(  '" + txtNombreProfesional.Text + "'" +
                          ", '" + txtCedulaProfesional.Text + "'" +
                          ", '" + txtTituloProfesional.Text + "','" + txtTlfProfesional.Text + "'" +
                          ", ' Activo ','"+ dateFechaIngreso.Text+"' )";
                        consulta.counsultaTodoTipo(crearProfesional);
                        MessageBox.Show("Profesional agregado correctamente",
                                            "Confirmación",
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("El profesional que ingresó ya se encuentra registrado en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    #endregion
                }


                #endregion
            }
            #endregion
        }

        private void txtNombreProfesional_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e);
        }

        private void txtCedulaProfesional_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }

        private void txtTlfProfesional_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }

        private void txtTituloProfesional_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e);
        }
    }
}
