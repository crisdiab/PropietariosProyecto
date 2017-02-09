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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicios));
            System.Windows.Forms.Label nOMBRESERVICIOLabel;
            System.Windows.Forms.Label pRECIOSERVICIOLabel;
            System.Windows.Forms.Label eSTADOSERVICIOLabel;
            this.grisGrisDataSet = new ProyectoPropietarios.GrisGrisDataSet();
            this.rEPRESENTANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPRESENTANTETableAdapter = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.REPRESENTANTETableAdapter();
            this.tableAdapterManager = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.TableAdapterManager();
            this.rEPRESENTANTEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.rEPRESENTANTEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sERVICIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICIOTableAdapter = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.SERVICIOTableAdapter();
            this.nOMBRESERVICIOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pRECIOSERVICIOSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.eSTADOSERVICIOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            nOMBRESERVICIOLabel = new System.Windows.Forms.Label();
            pRECIOSERVICIOLabel = new System.Windows.Forms.Label();
            eSTADOSERVICIOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPRESENTANTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPRESENTANTEBindingNavigator)).BeginInit();
            this.rEPRESENTANTEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOMBRESERVICIOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRECIOSERVICIOSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOSERVICIOTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.rEPRESENTANTEBindingNavigator.Size = new System.Drawing.Size(333, 27);
            this.rEPRESENTANTEBindingNavigator.TabIndex = 2;
            this.rEPRESENTANTEBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            this.bindingNavigatorCountItem.Visible = false;
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
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
            // rEPRESENTANTEBindingNavigatorSaveItem
            // 
            this.rEPRESENTANTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rEPRESENTANTEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rEPRESENTANTEBindingNavigatorSaveItem.Image")));
            this.rEPRESENTANTEBindingNavigatorSaveItem.Name = "rEPRESENTANTEBindingNavigatorSaveItem";
            this.rEPRESENTANTEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.rEPRESENTANTEBindingNavigatorSaveItem.Text = "Guardar datos";
            this.rEPRESENTANTEBindingNavigatorSaveItem.Click += new System.EventHandler(this.rEPRESENTANTEBindingNavigatorSaveItem_Click);
            // 
            // sERVICIOBindingSource
            // 
            this.sERVICIOBindingSource.DataMember = "SERVICIO";
            this.sERVICIOBindingSource.DataSource = this.grisGrisDataSet;
            // 
            // sERVICIOTableAdapter
            // 
            this.sERVICIOTableAdapter.ClearBeforeFill = true;
            // 
            // nOMBRESERVICIOLabel
            // 
            nOMBRESERVICIOLabel.AutoSize = true;
            nOMBRESERVICIOLabel.Location = new System.Drawing.Point(30, 52);
            nOMBRESERVICIOLabel.Name = "nOMBRESERVICIOLabel";
            nOMBRESERVICIOLabel.Size = new System.Drawing.Size(135, 17);
            nOMBRESERVICIOLabel.TabIndex = 5;
            nOMBRESERVICIOLabel.Text = "NOMBRESERVICIO:";
            // 
            // nOMBRESERVICIOTextEdit
            // 
            this.nOMBRESERVICIOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sERVICIOBindingSource, "NOMBRESERVICIO", true));
            this.nOMBRESERVICIOTextEdit.Location = new System.Drawing.Point(171, 49);
            this.nOMBRESERVICIOTextEdit.Name = "nOMBRESERVICIOTextEdit";
            this.nOMBRESERVICIOTextEdit.Size = new System.Drawing.Size(100, 22);
            this.nOMBRESERVICIOTextEdit.TabIndex = 6;
            // 
            // pRECIOSERVICIOLabel
            // 
            pRECIOSERVICIOLabel.AutoSize = true;
            pRECIOSERVICIOLabel.Location = new System.Drawing.Point(30, 80);
            pRECIOSERVICIOLabel.Name = "pRECIOSERVICIOLabel";
            pRECIOSERVICIOLabel.Size = new System.Drawing.Size(126, 17);
            pRECIOSERVICIOLabel.TabIndex = 7;
            pRECIOSERVICIOLabel.Text = "PRECIOSERVICIO:";
            // 
            // pRECIOSERVICIOSpinEdit
            // 
            this.pRECIOSERVICIOSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sERVICIOBindingSource, "PRECIOSERVICIO", true));
            this.pRECIOSERVICIOSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pRECIOSERVICIOSpinEdit.Location = new System.Drawing.Point(171, 77);
            this.pRECIOSERVICIOSpinEdit.Name = "pRECIOSERVICIOSpinEdit";
            this.pRECIOSERVICIOSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pRECIOSERVICIOSpinEdit.Size = new System.Drawing.Size(100, 22);
            this.pRECIOSERVICIOSpinEdit.TabIndex = 8;
            // 
            // eSTADOSERVICIOTextEdit
            // 
            this.eSTADOSERVICIOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sERVICIOBindingSource, "ESTADOSERVICIO", true));
            this.eSTADOSERVICIOTextEdit.Location = new System.Drawing.Point(171, 105);
            this.eSTADOSERVICIOTextEdit.Name = "eSTADOSERVICIOTextEdit";
            this.eSTADOSERVICIOTextEdit.Size = new System.Drawing.Size(100, 22);
            this.eSTADOSERVICIOTextEdit.TabIndex = 10;
            // 
            // eSTADOSERVICIOLabel
            // 
            eSTADOSERVICIOLabel.AutoSize = true;
            eSTADOSERVICIOLabel.Location = new System.Drawing.Point(30, 108);
            eSTADOSERVICIOLabel.Name = "eSTADOSERVICIOLabel";
            eSTADOSERVICIOLabel.Size = new System.Drawing.Size(132, 17);
            eSTADOSERVICIOLabel.TabIndex = 9;
            eSTADOSERVICIOLabel.Text = "ESTADOSERVICIO:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.retroceso;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(112, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Regresar";
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(333, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(nOMBRESERVICIOLabel);
            this.Controls.Add(this.nOMBRESERVICIOTextEdit);
            this.Controls.Add(pRECIOSERVICIOLabel);
            this.Controls.Add(this.pRECIOSERVICIOSpinEdit);
            this.Controls.Add(eSTADOSERVICIOLabel);
            this.Controls.Add(this.eSTADOSERVICIOTextEdit);
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
            ((System.ComponentModel.ISupportInitialize)(this.nOMBRESERVICIOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRECIOSERVICIOSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTADOSERVICIOTextEdit.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit nOMBRESERVICIOTextEdit;
        private DevExpress.XtraEditors.SpinEdit pRECIOSERVICIOSpinEdit;
        private DevExpress.XtraEditors.TextEdit eSTADOSERVICIOTextEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}