namespace ProyectoPropietarios
{
    partial class Facturacion
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
            this.btn_crearFact = new System.Windows.Forms.Button();
            this.btn_modificarFact = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_crearFact
            // 
            this.btn_crearFact.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.factura1;
            this.btn_crearFact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_crearFact.Location = new System.Drawing.Point(78, 80);
            this.btn_crearFact.Name = "btn_crearFact";
            this.btn_crearFact.Size = new System.Drawing.Size(147, 131);
            this.btn_crearFact.TabIndex = 0;
            this.btn_crearFact.UseVisualStyleBackColor = true;
            this.btn_crearFact.Click += new System.EventHandler(this.btn_crearFact_Click);
            // 
            // btn_modificarFact
            // 
            this.btn_modificarFact.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.anularFact;
            this.btn_modificarFact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificarFact.Location = new System.Drawing.Point(301, 80);
            this.btn_modificarFact.Name = "btn_modificarFact";
            this.btn_modificarFact.Size = new System.Drawing.Size(143, 132);
            this.btn_modificarFact.TabIndex = 1;
            this.btn_modificarFact.UseVisualStyleBackColor = true;
            this.btn_modificarFact.Click += new System.EventHandler(this.btn_modificarFact_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.retroceso;
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Home.Location = new System.Drawing.Point(220, 260);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(81, 75);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(100, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Crear Factura";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Anular Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Atras";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 415);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_modificarFact);
            this.Controls.Add(this.btn_crearFact);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Facturacion_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crearFact;
        private System.Windows.Forms.Button btn_modificarFact;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}