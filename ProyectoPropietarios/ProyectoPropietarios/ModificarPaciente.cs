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
    public partial class ModificarPaciente : Form
    {
        Validaciones validacion = new Validaciones();
        public ModificarPaciente()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PacienteMain pf = new PacienteMain();
            pf.Show();
            this.Hide();
        }

        private void ModificarPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void pACIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           


        }

        private void ModificarPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.CENTROEDUCACION' Puede moverla o quitarla según sea necesario.
            //this.cENTROEDUCACIONTableAdapter.Fill(this.grisGrisDataSet.CENTROEDUCACION);
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.PACIENTE' Puede moverla o quitarla según sea necesario.
            this.pACIENTETableAdapter.Fill(this.grisGrisDataSet.PACIENTE);

        }

        private void nOMBREPACIENTETextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void eNCARGADODECETextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void nOMBREREFERENCIA1TextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void tELEFONOREFERENCIA1TextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void nOMBREREFERENCIA2TextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void tELEFONOREFERENCIA2TextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PacienteMain pf = new PacienteMain();
            pf.Show();
            this.Hide();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pACIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grisGrisDataSet);
           
           
            DateTime fechaActual = DateTime.Now;
            string[] anioActual = separarFecha(fechaActual.ToString("d"), '/');
            // eDADPACIENTETextEdit.Text = calcularEdad(anioNac[2], anioActual[2]);
            MessageBox.Show("Datos Modificados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.uNIR_TABLASTableAdapter.Fill(this.grisGrisDataSet.UNIR_TABLAS, cEDULAPACIENTEToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cEDULAPACIENTEToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void nOMBRECENTROTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void nOMBREREFERENCIA1TextEdit_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void nOMBREREFERENCIA2TextEdit_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validacion.soloLetras(e);
        }

        private void tELEFONOREFERENCIA1TextEdit_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }

        private void nOMBREREFERENCIA21TextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.soloNumeros(e);
        }
    }
}
