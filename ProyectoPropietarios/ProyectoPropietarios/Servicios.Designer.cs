namespace ProyectoPropietarios
{
    partial class Servicios
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
            System.Windows.Forms.Label nOMBRESERVICIOLabel;
            System.Windows.Forms.Label pRECIOSERVICIOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicios));
            this.grisGrisDataSet = new ProyectoPropietarios.GrisGrisDataSet();
            this.rEPRESENTANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPRESENTANTETableAdapter = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.REPRESENTANTETableAdapter();
            this.tableAdapterManager = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.TableAdapterManager();
            this.sERVICIOTableAdapter = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.SERVICIOTableAdapter();
            this.rEPRESENTANTEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rEPRESENTANTEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sERVICIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNombreServicio = new DevExpress.XtraEditors.TextEdit();
            this.PrecioServicio = new DevExpress.XtraEditors.SpinEdit();
            this.txtestadoServicio = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            nOMBRESERVICIOLabel = new System.Windows.Forms.Label();
            pRECIOSERVICIOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPRESENTANTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPRESENTANTEBindingNavigator)).BeginInit();
            this.rEPRESENTANTEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreServicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioServicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtestadoServicio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nOMBRESERVICIOLabel
            // 
            nOMBRESERVICIOLabel.AutoSize = true;
            nOMBRESERVICIOLabel.Location = new System.Drawing.Point(38, 99);
            nOMBRESERVICIOLabel.Name = "nOMBRESERVICIOLabel";
            nOMBRESERVICIOLabel.Size = new System.Drawing.Size(135, 17);
            nOMBRESERVICIOLabel.TabIndex = 5;
            nOMBRESERVICIOLabel.Text = "NOMBRESERVICIO:";
            // 
            // pRECIOSERVICIOLabel
            // 
            pRECIOSERVICIOLabel.AutoSize = true;
            pRECIOSERVICIOLabel.Location = new System.Drawing.Point(38, 127);
            pRECIOSERVICIOLabel.Name = "pRECIOSERVICIOLabel";
            pRECIOSERVICIOLabel.Size = new System.Drawing.Size(126, 17);
            pRECIOSERVICIOLabel.TabIndex = 7;
            pRECIOSERVICIOLabel.Text = "PRECIOSERVICIO:";
            // 
            // grisGrisDataSet
            // 
            this.grisGrisDataSet.DataSetName = "GrisGrisDataSet";
            this.grisGrisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEPRESENTANTEBindingSource
            // 
            this.rEPRESENTANTEBindingSource.DataMember = "REPRESENTANTE";
            this.rEPRESENTANTEBindingSource.DataSource = this.grisGrisDataSet;
            // 
            // rEPRESENTANTETableAdapter
            // 
            this.rEPRESENTANTETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CENTROEDUCACIONTableAdapter = null;
            this.tableAdapterManager.DETALLEFACTURATableAdapter = null;
            this.tableAdapterManager.DETALLERECIBOTableAdapter = null;
            this.tableAdapterManager.FACTURATableAdapter = null;
            this.tableAdapterManager.PACIENTESXPROFESIONALTableAdapter = null;
            this.tableAdapterManager.PACIENTETableAdapter = null;
            this.tableAdapterManager.PARAMETROSTableAdapter = null;
            this.tableAdapterManager.PROFESIONALTableAdapter = null;
            this.tableAdapterManager.RECIBOTableAdapter = null;
            this.tableAdapterManager.REPRESENTANTETableAdapter = this.rEPRESENTANTETableAdapter;
            this.tableAdapterManager.SERVICIOSPORPROFESIONALTableAdapter = null;
            this.tableAdapterManager.SERVICIOSXPACIENTETableAdapter = null;
            this.tableAdapterManager.SERVICIOTableAdapter = this.sERVICIOTableAdapter;
            this.tableAdapterManager.TIPOCENTROEDUCACIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoPropietarios.GrisGrisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sERVICIOTableAdapter
            // 
            this.sERVICIOTableAdapter.ClearBeforeFill = true;
            // 
            // rEPRESENTANTEBindingNavigator
            // 
            this.rEPRESENTANTEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rEPRESENTANTEBindingNavigator.BindingSource = this.rEPRESENTANTEBindingSource;
            this.rEPRESENTANTEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rEPRESENTANTEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rEPRESENTANTEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rEPRESENTANTEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rEPRESENTANTEBindingNavigatorSaveItem});
            this.rEPRESENTANTEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rEPRESENTANTEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rEPRESENTANTEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rEPRESENTANTEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rEPRESENTANTEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rEPRESENTANTEBindingNavigator.Name = "rEPRESENTANTEBindingNavigator";
            this.rEPRESENTANTEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rEPRESENTANTEBindingNavigator.Size = new System.Drawing.Size(445, 27);
            this.rEPRESENTANTEBindingNavigator.TabIndex = 2;
            this.rEPRESENTANTEBindingNavigator.Text = "bindingNavigator1";
            this.rEPRESENTANTEBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            this.bindingNavigatorCountItem.Visible = false;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            this.bindingNavigatorMoveFirstItem.Visible = false;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            this.bindingNavigatorMovePreviousItem.Visible = false;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            this.bindingNavigatorPositionItem.Visible = false;
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            this.bindingNavigatorMoveNextItem.Visible = false;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            this.bindingNavigatorMoveLastItem.Visible = false;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // rEPRESENTANTEBindingNavigatorSaveItem
            // 
            this.rEPRESENTANTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rEPRESENTANTEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rEPRESENTANTEBindingNavigatorSaveItem.Image")));
            this.rEPRESENTANTEBindingNavigatorSaveItem.Name = "rEPRESENTANTEBindingNavigatorSaveItem";
            this.rEPRESENTANTEBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.rEPRESENTANTEBindingNavigatorSaveItem.Text = "Guardar datos";
            this.rEPRESENTANTEBindingNavigatorSaveItem.Click += new System.EventHandler(this.rEPRESENTANTEBindingNavigatorSaveItem_Click);
            // 
            // sERVICIOBindingSource
            // 
            this.sERVICIOBindingSource.DataMember = "SERVICIO";
            this.sERVICIOBindingSource.DataSource = this.grisGrisDataSet;
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sERVICIOBindingSource, "NOMBRESERVICIO", true));
            this.txtNombreServicio.Enabled = false;
            this.txtNombreServicio.Location = new System.Drawing.Point(179, 96);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(100, 22);
            this.txtNombreServicio.TabIndex = 6;
            // 
            // PrecioServicio
            // 
            this.PrecioServicio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sERVICIOBindingSource, "PRECIOSERVICIO", true));
            this.PrecioServicio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PrecioServicio.Enabled = false;
            this.PrecioServicio.Location = new System.Drawing.Point(179, 124);
            this.PrecioServicio.Name = "PrecioServicio";
            this.PrecioServicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PrecioServicio.Size = new System.Drawing.Size(100, 22);
            this.PrecioServicio.TabIndex = 8;
            // 
            // txtestadoServicio
            // 
            this.txtestadoServicio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sERVICIOBindingSource, "ESTADOSERVICIO", true));
            this.txtestadoServicio.EditValue = "Activo";
            this.txtestadoServicio.Location = new System.Drawing.Point(179, 152);
            this.txtestadoServicio.Name = "txtestadoServicio";
            this.txtestadoServicio.Size = new System.Drawing.Size(100, 22);
            this.txtestadoServicio.TabIndex = 10;
            this.txtestadoServicio.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.retroceso;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(67, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 67);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Regresar";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.guardar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(179, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 67);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Guardar";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(65, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 44);
            this.button3.TabIndex = 15;
            this.button3.Text = "Nuevo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 340);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(nOMBRESERVICIOLabel);
            this.Controls.Add(this.txtNombreServicio);
            this.Controls.Add(pRECIOSERVICIOLabel);
            this.Controls.Add(this.PrecioServicio);
            this.Controls.Add(this.txtestadoServicio);
            this.Controls.Add(this.rEPRESENTANTEBindingNavigator);
            this.Name = "Servicios";
            this.Text = "Servicio";
            this.Load += new System.EventHandler(this.Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPRESENTANTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPRESENTANTEBindingNavigator)).EndInit();
            this.rEPRESENTANTEBindingNavigator.ResumeLayout(false);
            this.rEPRESENTANTEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreServicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioServicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtestadoServicio.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GrisGrisDataSet grisGrisDataSet;
        private System.Windows.Forms.BindingSource rEPRESENTANTEBindingSource;
        private GrisGrisDataSetTableAdapters.REPRESENTANTETableAdapter rEPRESENTANTETableAdapter;
        private GrisGrisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rEPRESENTANTEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rEPRESENTANTEBindingNavigatorSaveItem;
        private GrisGrisDataSetTableAdapters.SERVICIOTableAdapter sERVICIOTableAdapter;
        private System.Windows.Forms.BindingSource sERVICIOBindingSource;
        private DevExpress.XtraEditors.TextEdit txtNombreServicio;
        private DevExpress.XtraEditors.SpinEdit PrecioServicio;
        private DevExpress.XtraEditors.TextEdit txtestadoServicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}