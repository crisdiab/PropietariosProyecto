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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_crearFact
            // 
            this.btn_crearFact.Location = new System.Drawing.Point(237, 99);
            this.btn_crearFact.Name = "btn_crearFact";
            this.btn_crearFact.Size = new System.Drawing.Size(103, 41);
            this.btn_crearFact.TabIndex = 0;
            this.btn_crearFact.Text = "Crear Factura";
            this.btn_crearFact.UseVisualStyleBackColor = true;
            this.btn_crearFact.Click += new System.EventHandler(this.btn_crearFact_Click);
            // 
            // btn_modificarFact
            // 
            this.btn_modificarFact.Location = new System.Drawing.Point(241, 252);
            this.btn_modificarFact.Name = "btn_modificarFact";
            this.btn_modificarFact.Size = new System.Drawing.Size(112, 44);
            this.btn_modificarFact.TabIndex = 1;
            this.btn_modificarFact.Text = "Anular Factura";
            this.btn_modificarFact.UseVisualStyleBackColor = true;
            this.btn_modificarFact.Click += new System.EventHandler(this.btn_modificarFact_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(496, 29);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(70, 61);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crear Recibo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_modificarFact);
            this.Controls.Add(this.btn_crearFact);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_crearFact;
        private System.Windows.Forms.Button btn_modificarFact;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button button1;
    }
}