namespace ProyectoPropietarios
{
    partial class RegistrarProfesional
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreProfesional = new System.Windows.Forms.TextBox();
            this.txtCedulaProfesional = new System.Windows.Forms.TextBox();
            this.txtTituloProfesional = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTlfProfesional = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Titulo:";
            // 
            // txtNombreProfesional
            // 
            this.txtNombreProfesional.Location = new System.Drawing.Point(189, 98);
            this.txtNombreProfesional.Name = "txtNombreProfesional";
            this.txtNombreProfesional.Size = new System.Drawing.Size(157, 22);
            this.txtNombreProfesional.TabIndex = 8;
            this.txtNombreProfesional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProfesional_KeyPress);
            // 
            // txtCedulaProfesional
            // 
            this.txtCedulaProfesional.Location = new System.Drawing.Point(189, 144);
            this.txtCedulaProfesional.MaxLength = 10;
            this.txtCedulaProfesional.Name = "txtCedulaProfesional";
            this.txtCedulaProfesional.Size = new System.Drawing.Size(157, 22);
            this.txtCedulaProfesional.TabIndex = 9;
            this.txtCedulaProfesional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaProfesional_KeyPress);
            // 
            // txtTituloProfesional
            // 
            this.txtTituloProfesional.Location = new System.Drawing.Point(189, 228);
            this.txtTituloProfesional.Name = "txtTituloProfesional";
            this.txtTituloProfesional.Size = new System.Drawing.Size(157, 22);
            this.txtTituloProfesional.TabIndex = 10;
            this.txtTituloProfesional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTituloProfesional_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de Ingreso:";
            // 
            // dateFechaIngreso
            // 
            this.dateFechaIngreso.Enabled = false;
            this.dateFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaIngreso.Location = new System.Drawing.Point(199, 45);
            this.dateFechaIngreso.Name = "dateFechaIngreso";
            this.dateFechaIngreso.Size = new System.Drawing.Size(119, 22);
            this.dateFechaIngreso.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Télefono:";
            // 
            // txtTlfProfesional
            // 
            this.txtTlfProfesional.Location = new System.Drawing.Point(189, 185);
            this.txtTlfProfesional.MaxLength = 10;
            this.txtTlfProfesional.Name = "txtTlfProfesional";
            this.txtTlfProfesional.Size = new System.Drawing.Size(157, 22);
            this.txtTlfProfesional.TabIndex = 14;
            this.txtTlfProfesional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTlfProfesional_KeyPress);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.guardar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(246, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 92);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.retroceso;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Location = new System.Drawing.Point(68, 283);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(125, 92);
            this.btn_salir.TabIndex = 19;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Atrás";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Guardar";
            // 
            // RegistrarProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 476);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txtTlfProfesional);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateFechaIngreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTituloProfesional);
            this.Controls.Add(this.txtCedulaProfesional);
            this.Controls.Add(this.txtNombreProfesional);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarProfesional";
            this.Text = "RegistrarProfesional";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profesional_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreProfesional;
        private System.Windows.Forms.TextBox txtCedulaProfesional;
        private System.Windows.Forms.TextBox txtTituloProfesional;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateFechaIngreso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTlfProfesional;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}