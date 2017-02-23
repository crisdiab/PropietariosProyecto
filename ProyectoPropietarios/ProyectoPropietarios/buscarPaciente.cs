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
    public partial class buscarPaciente : Form
    {
        public buscarPaciente()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PacienteMain pm = new PacienteMain();
            pm.Show();
            this.Hide();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.buscarPacienteTableAdapter.Fill(this.grisGrisDataSet.buscarPaciente, new System.Nullable<int>(((int)(System.Convert.ChangeType(cedulaToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
