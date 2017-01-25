namespace ProyectoPropietarios
{
    partial class PantallaInicial
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicial));
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.Cmb_Usuarios = new System.Windows.Forms.ComboBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.LOGIN = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(196, 156);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(64, 20);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(196, 200);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(78, 20);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password";
            // 
            // Cmb_Usuarios
            // 
            this.Cmb_Usuarios.FormattingEnabled = true;
            this.Cmb_Usuarios.Items.AddRange(new object[] {
            "Administrador",
            "Profesor",
            "Secretario"});
            this.Cmb_Usuarios.Location = new System.Drawing.Point(295, 252);
            this.Cmb_Usuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cmb_Usuarios.Name = "Cmb_Usuarios";
            this.Cmb_Usuarios.Size = new System.Drawing.Size(136, 28);
            this.Cmb_Usuarios.TabIndex = 2;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(295, 200);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(136, 26);
            this.Txt_Password.TabIndex = 3;
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(196, 252);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(33, 20);
            this.lbl_Rol.TabIndex = 5;
            this.lbl_Rol.Text = "Rol";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(295, 156);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(136, 26);
            this.Txt_Usuario.TabIndex = 6;
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSize = true;
            this.LOGIN.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(135, 44);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(256, 75);
            this.LOGIN.TabIndex = 7;
            this.LOGIN.Text = "LOGIN";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(221, 314);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 75);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.logBig;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(347, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 86);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 144);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 184);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.logSmall;
            this.Btn_Ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Ingresar.Location = new System.Drawing.Point(369, 319);
            this.Btn_Ingresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(128, 64);
            this.Btn_Ingresar.TabIndex = 4;
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            this.Btn_Ingresar.MouseHover += new System.EventHandler(this.Btn_Ingresar_Hover);
            // 
            // PantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 408);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.lbl_Rol);
            this.Controls.Add(this.Btn_Ingresar);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Cmb_Usuarios);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Usuario);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PantallaInicial";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.ComboBox Cmb_Usuarios;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label LOGIN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
    }
}

