﻿using System;
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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReporteFinanciero rf = new ReporteFinanciero();
            rf.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ReporteAcademico ra = new ReporteAcademico();
            ra.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void Reportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Modulos md = new Modulos();
            md.Show();
            this.Hide();
        }

        private void cENTROEDUCACIONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cENTROEDUCACIONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grisGrisDataSet);

        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'grisGrisDataSet.CENTROEDUCACION' Puede moverla o quitarla según sea necesario.
            this.cENTROEDUCACIONTableAdapter.Fill(this.grisGrisDataSet.CENTROEDUCACION);

        }
    }
}
