namespace ProyectoPropietarios
{
    partial class ModificarServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarServicio));
            System.Windows.Forms.Label nOMBRESERVICIOLabel;
            System.Windows.Forms.Label pRECIOSERVICIOLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grisGrisDataSet = new ProyectoPropietarios.GrisGrisDataSet();
            this.sERVICIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICIOTableAdapter = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.SERVICIOTableAdapter();
            this.tableAdapterManager = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.TableAdapterManager();
            this.sERVICIOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sERVICIOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sERVICIODataGridView = new System.Windows.Forms.DataGridView();
            this.nOMBRESERVICIOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pRECIOSERVICIOSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nOMBRESERVICIOLabel = new System.Windows.Forms.Label();
            pRECIOSERVICIOLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingNavigator)).BeginInit();
            this.sERVICIOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOMBRESERVICIOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRECIOSERVICIOSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.retroceso;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Location = new System.Drawing.Point(36, 299);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(84, 71);
            this.btn_salir.TabIndex = 21;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nOMBRESERVICIOLabel);
            this.groupBox1.Controls.Add(this.nOMBRESERVICIOTextEdit);
            this.groupBox1.Controls.Add(pRECIOSERVICIOLabel);
            this.groupBox1.Controls.Add(this.pRECIOSERVICIOSpinEdit);
            this.groupBox1.Location = new System.Drawing.Point(26, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 178);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicio";
            // 
            // grisGrisDataSet
            // 
            this.grisGrisDataSet.DataSetName = "GrisGrisDataSet";
            this.grisGrisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.REPRESENTANTETableAdapter = null;
            this.tableAdapterManager.SERVICIOSPORPROFESIONALTableAdapter = null;
            this.tableAdapterManager.SERVICIOSXPACIENTETableAdapter = null;
            this.tableAdapterManager.SERVICIOTableAdapter = this.sERVICIOTableAdapter;
            this.tableAdapterManager.TIPOCENTROEDUCACIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoPropietarios.GrisGrisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sERVICIOBindingNavigator
            // 
            this.sERVICIOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sERVICIOBindingNavigator.BindingSource = this.sERVICIOBindingSource;
            this.sERVICIOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sERVICIOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sERVICIOBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sERVICIOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sERVICIOBindingNavigatorSaveItem});
            this.sERVICIOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sERVICIOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sERVICIOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sERVICIOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sERVICIOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sERVICIOBindingNavigator.Name = "sERVICIOBindingNavigator";
            this.sERVICIOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sERVICIOBindingNavigator.Size = new System.Drawing.Size(718, 27);
            this.sERVICIOBindingNavigator.TabIndex = 23;
            this.sERVICIOBindingNavigator.Text = "bindingNavigator1";
            this.sERVICIOBindingNavigator.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
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
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
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
            // 
            // sERVICIOBindingNavigatorSaveItem
            // 
            this.sERVICIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sERVICIOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sERVICIOBindingNavigatorSaveItem.Image")));
            this.sERVICIOBindingNavigatorSaveItem.Name = "sERVICIOBindingNavigatorSaveItem";
            this.sERVICIOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sERVICIOBindingNavigatorSaveItem.Text = "Guardar datos";
            this.sERVICIOBindingNavigatorSaveItem.Click += new System.EventHandler(this.sERVICIOBindingNavigatorSaveItem_Click);
            // 
            // sERVICIODataGridView
            // 
            this.sERVICIODataGridView.AutoGenerateColumns = false;
            this.sERVICIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sERVICIODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.sERVICIODataGridView.DataSource = this.sERVICIOBindingSource;
            this.sERVICIODataGridView.Location = new System.Drawing.Point(313, 70);
            this.sERVICIODataGridView.Name = "sERVICIODataGridView";
            this.sERVICIODataGridView.RowTemplate.Height = 24;
            this.sERVICIODataGridView.Size = new System.Drawing.Size(335, 220);
            this.sERVICIODataGridView.TabIndex = 23;
            // 
            // nOMBRESERVICIOLabel
            // 
            nOMBRESERVICIOLabel.AutoSize = true;
            nOMBRESERVICIOLabel.Location = new System.Drawing.Point(6, 86);
            nOMBRESERVICIOLabel.Name = "nOMBRESERVICIOLabel";
            nOMBRESERVICIOLabel.Size = new System.Drawing.Size(72, 17);
            nOMBRESERVICIOLabel.TabIndex = 2;
            nOMBRESERVICIOLabel.Text = "NOMBRE:";
            // 
            // nOMBRESERVICIOTextEdit
            // 
            this.nOMBRESERVICIOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sERVICIOBindingSource, "NOMBRESERVICIO", true));
            this.nOMBRESERVICIOTextEdit.Location = new System.Drawing.Point(84, 83);
            this.nOMBRESERVICIOTextEdit.Name = "nOMBRESERVICIOTextEdit";
            this.nOMBRESERVICIOTextEdit.Size = new System.Drawing.Size(100, 22);
            this.nOMBRESERVICIOTextEdit.TabIndex = 3;
            // 
            // pRECIOSERVICIOLabel
            // 
            pRECIOSERVICIOLabel.AutoSize = true;
            pRECIOSERVICIOLabel.Location = new System.Drawing.Point(6, 114);
            pRECIOSERVICIOLabel.Name = "pRECIOSERVICIOLabel";
            pRECIOSERVICIOLabel.Size = new System.Drawing.Size(63, 17);
            pRECIOSERVICIOLabel.TabIndex = 4;
            pRECIOSERVICIOLabel.Text = "PRECIO:";
            // 
            // pRECIOSERVICIOSpinEdit
            // 
            this.pRECIOSERVICIOSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sERVICIOBindingSource, "PRECIOSERVICIO", true));
            this.pRECIOSERVICIOSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.pRECIOSERVICIOSpinEdit.Location = new System.Drawing.Point(84, 111);
            this.pRECIOSERVICIOSpinEdit.Name = "pRECIOSERVICIOSpinEdit";
            this.pRECIOSERVICIOSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pRECIOSERVICIOSpinEdit.Size = new System.Drawing.Size(100, 22);
            this.pRECIOSERVICIOSpinEdit.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.guardar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(189, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 71);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 373);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 17);
            label1.TabIndex = 6;
            label1.Text = "Regresar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(202, 373);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 17);
            label2.TabIndex = 25;
            label2.Text = "Guardar";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDSERVICIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRESERVICIO";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 97;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRECIOSERVICIO";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRECIO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ESTADOSERVICIO";
            this.dataGridViewTextBoxColumn4.HeaderText = "ESTADOSERVICIO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // ModificarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 455);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sERVICIODataGridView);
            this.Controls.Add(this.sERVICIOBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_salir);
            this.Name = "ModificarServicio";
            this.Text = "ModificarServicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarServicio_FormClosing);
            this.Load += new System.EventHandler(this.ModificarServicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingNavigator)).EndInit();
            this.sERVICIOBindingNavigator.ResumeLayout(false);
            this.sERVICIOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOMBRESERVICIOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRECIOSERVICIOSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private GrisGrisDataSet grisGrisDataSet;
        private System.Windows.Forms.BindingSource sERVICIOBindingSource;
        private GrisGrisDataSetTableAdapters.SERVICIOTableAdapter sERVICIOTableAdapter;
        private GrisGrisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sERVICIOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sERVICIOBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.TextEdit nOMBRESERVICIOTextEdit;
        private DevExpress.XtraEditors.SpinEdit pRECIOSERVICIOSpinEdit;
        private System.Windows.Forms.DataGridView sERVICIODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
    }
}