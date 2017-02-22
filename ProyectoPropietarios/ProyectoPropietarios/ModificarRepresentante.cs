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
    public partial class ModificarRepresentante : Form
    {
        Validaciones validar = new Validaciones();
        public ModificarRepresentante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepresentanteMain rm = new RepresentanteMain();
            rm.Show();
            this.Hide();
        }

        private void rEPRESENTANTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void ModificarRepresentante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.REPRESENTANTE' Puede moverla o quitarla según sea necesario.
            this.rEPRESENTANTETableAdapter.Fill(this.grisGrisDataSet.REPRESENTANTE);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rEPRESENTANTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grisGrisDataSet);
            MessageBox.Show("Representante modificado correctamente","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dIRECCIONREPRESENTANTETextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tELEFONOREPRESENTANTETextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }

        private void cELULARREPRESENTANTETextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }
    }
}
