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
    public partial class DardeBajaCliente : Form
    {
        public DardeBajaCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteForm cf = new ClienteForm();
            cf.Show();
            this.Hide();
        }

        private void EliminarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rEPRESENTANTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rEPRESENTANTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grisGrisDataSet);

        }

        private void rEPRESENTANTEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.rEPRESENTANTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grisGrisDataSet);

        }

        private void DardeBajaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.REPRESENTANTE' Puede moverla o quitarla según sea necesario.
            this.rEPRESENTANTETableAdapter.Fill(this.grisGrisDataSet.REPRESENTANTE);

        }

        private void rEPRESENTANTEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
