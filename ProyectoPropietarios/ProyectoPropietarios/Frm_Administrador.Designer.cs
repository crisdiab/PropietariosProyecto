namespace ProyectoPropietarios
{
    partial class Frm_Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProfesionalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarEstudianteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProfesionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteFinancieroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteAcademicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editarToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(479, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem1.Text = "Inicio";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarEstudianteToolStripMenuItem,
            this.editarProfesionalToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(144, 24);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProfesionalToolStripMenuItem1,
            this.ingresarEstudianteToolStripMenuItem1});
            this.nuevoToolStripMenuItem.Image = global::ProyectoPropietarios.Properties.Resources.archivo_nuevo;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // ingresarProfesionalToolStripMenuItem1
            // 
            this.ingresarProfesionalToolStripMenuItem1.Name = "ingresarProfesionalToolStripMenuItem1";
            this.ingresarProfesionalToolStripMenuItem1.Size = new System.Drawing.Size(209, 24);
            this.ingresarProfesionalToolStripMenuItem1.Text = "Ingresar Profesional";
            this.ingresarProfesionalToolStripMenuItem1.Click += new System.EventHandler(this.ingresarProfesionalToolStripMenuItem1_Click);
            // 
            // ingresarEstudianteToolStripMenuItem1
            // 
            this.ingresarEstudianteToolStripMenuItem1.Name = "ingresarEstudianteToolStripMenuItem1";
            this.ingresarEstudianteToolStripMenuItem1.Size = new System.Drawing.Size(209, 24);
            this.ingresarEstudianteToolStripMenuItem1.Text = "Ingresar Estudiante";
            this.ingresarEstudianteToolStripMenuItem1.Click += new System.EventHandler(this.ingresarEstudianteToolStripMenuItem1_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Image = global::ProyectoPropietarios.Properties.Resources.logout;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // editarEstudianteToolStripMenuItem
            // 
            this.editarEstudianteToolStripMenuItem.Image = global::ProyectoPropietarios.Properties.Resources.editar;
            this.editarEstudianteToolStripMenuItem.Name = "editarEstudianteToolStripMenuItem";
            this.editarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.editarEstudianteToolStripMenuItem.Text = "Editar Estudiante";
            // 
            // editarProfesionalToolStripMenuItem
            // 
            this.editarProfesionalToolStripMenuItem.Image = global::ProyectoPropietarios.Properties.Resources.editar;
            this.editarProfesionalToolStripMenuItem.Name = "editarProfesionalToolStripMenuItem";
            this.editarProfesionalToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.editarProfesionalToolStripMenuItem.Text = "Editar Profesional";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteFinancieroToolStripMenuItem,
            this.reporteAcademicoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteFinancieroToolStripMenuItem
            // 
            this.reporteFinancieroToolStripMenuItem.Name = "reporteFinancieroToolStripMenuItem";
            this.reporteFinancieroToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.reporteFinancieroToolStripMenuItem.Text = "Reporte Financiero";
            // 
            // reporteAcademicoToolStripMenuItem
            // 
            this.reporteAcademicoToolStripMenuItem.Name = "reporteAcademicoToolStripMenuItem";
            this.reporteAcademicoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.reporteAcademicoToolStripMenuItem.Text = "Reporte Academico";
            // 
            // Frm_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 305);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Administrador";
            this.Text = "Frm_Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProfesionalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresarEstudianteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProfesionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteFinancieroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteAcademicoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}