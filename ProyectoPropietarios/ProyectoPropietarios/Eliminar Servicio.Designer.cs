namespace ProyectoPropietarios
{
    partial class Eliminar_Servicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar_Servicio));
            System.Windows.Forms.Label nOMBRESERVICIOLabel;
            System.Windows.Forms.Label eSTADOSERVICIOLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.eSTADOSERVICIOComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nOMBRESERVICIOLabel = new System.Windows.Forms.Label();
            eSTADOSERVICIOLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingNavigator)).BeginInit();
            this.sERVICIOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOMBRESERVICIOTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(eSTADOSERVICIOLabel);
            this.groupBox1.Controls.Add(this.eSTADOSERVICIOComboBox);
            this.groupBox1.Controls.Add(nOMBRESERVICIOLabel);
            this.groupBox1.Controls.Add(this.nOMBRESERVICIOTextEdit);
            this.groupBox1.Location = new System.Drawing.Point(17, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(322, 160);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicio";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.retroceso;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(43, 269);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 64);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Regresar";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.guardar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(182, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 67);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Guardar";
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
            this.sERVICIOBindingNavigator.Size = new System.Drawing.Size(703, 27);
            this.sERVICIOBindingNavigator.TabIndex = 30;
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
            this.sERVICIODataGridView.Location = new System.Drawing.Point(374, 63);
            this.sERVICIODataGridView.Name = "sERVICIODataGridView";
            this.sERVICIODataGridView.RowTemplate.Height = 24;
            this.sERVICIODataGridView.Size = new System.Drawing.Size(322, 220);
            this.sERVICIODataGridView.TabIndex = 30;
            // 
            // nOMBRESERVICIOLabel
            // 
            nOMBRESERVICIOLabel.AutoSize = true;
            nOMBRESERVICIOLabel.Location = new System.Drawing.Point(6, 42);
            nOMBRESERVICIOLabel.Name = "nOMBRESERVICIOLabel";
            nOMBRESERVICIOLabel.Size = new System.Drawing.Size(135, 17);
            nOMBRESERVICIOLabel.TabIndex = 0;
            nOMBRESERVICIOLabel.Text = "NOMBRESERVICIO:";
            // 
            // nOMBRESERVICIOTextEdit
            // 
            this.nOMBRESERVICIOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sERVICIOBindingSource, "NOMBRESERVICIO", true));
            this.nOMBRESERVICIOTextEdit.Location = new System.Drawing.Point(147, 39);
            this.nOMBRESERVICIOTextEdit.Name = "nOMBRESERVICIOTextEdit";
            this.nOMBRESERVICIOTextEdit.Size = new System.Drawing.Size(100, 22);
            this.nOMBRESERVICIOTextEdit.TabIndex = 1;
            // 
            // eSTADOSERVICIOLabel
            // 
            eSTADOSERVICIOLabel.AutoSize = true;
            eSTADOSERVICIOLabel.Location = new System.Drawing.Point(9, 78);
            eSTADOSERVICIOLabel.Name = "eSTADOSERVICIOLabel";
            eSTADOSERVICIOLabel.Size = new System.Drawing.Size(132, 17);
            eSTADOSERVICIOLabel.TabIndex = 2;
            eSTADOSERVICIOLabel.Text = "ESTADOSERVICIO:";
            // 
            // eSTADOSERVICIOComboBox
            // 
            this.eSTADOSERVICIOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sERVICIOBindingSource, "ESTADOSERVICIO", true));
            this.eSTADOSERVICIOComboBox.FormattingEnabled = true;
            this.eSTADOSERVICIOComboBox.Items.AddRange(new object[] {
            "Activo",
            "InActivo"});
            this.eSTADOSERVICIOComboBox.Location = new System.Drawing.Point(147, 75);
            this.eSTADOSERVICIOComboBox.Name = "eSTADOSERVICIOComboBox";
            this.eSTADOSERVICIOComboBox.Size = new System.Drawing.Size(121, 24);
            this.eSTADOSERVICIOComboBox.TabIndex = 3;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRECIOSERVICIO";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRECIOSERVICIO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ESTADOSERVICIO";
            this.dataGridViewTextBoxColumn4.HeaderText = "ESTADOSERVICIO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Eliminar_Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 396);
            this.Controls.Add(this.sERVICIODataGridView);
            this.Controls.Add(this.sERVICIOBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Name = "Eliminar_Servicio";
            this.Text = "Dar de Baja o Habilitar Servicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Eliminar_Servicio_FormClosing);
            this.Load += new System.EventHandler(this.Eliminar_Servicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingNavigator)).EndInit();
            this.sERVICIOBindingNavigator.ResumeLayout(false);
            this.sERVICIOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOMBRESERVICIOTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ComboBox eSTADOSERVICIOComboBox;
        private DevExpress.XtraEditors.TextEdit nOMBRESERVICIOTextEdit;
        private System.Windows.Forms.DataGridView sERVICIODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}