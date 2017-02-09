namespace ProyectoPropietarios
{
    partial class DardeBajaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DardeBajaCliente));
            System.Windows.Forms.Label nOMBREREPRESENTANTELabel;
            System.Windows.Forms.Label cEDULAREPRESENTANTELabel;
            System.Windows.Forms.Label eSTADOREPRESENTANTELabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grisGrisDataSet = new ProyectoPropietarios.GrisGrisDataSet();
            this.rEPRESENTANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPRESENTANTETableAdapter = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.REPRESENTANTETableAdapter();
            this.tableAdapterManager = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.TableAdapterManager();
            this.rEPRESENTANTEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.rEPRESENTANTEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.nOMBREREPRESENTANTETextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cEDULAREPRESENTANTETextEdit = new DevExpress.XtraEditors.TextEdit();
            this.eSTADOREPRESENTANTEComboBox = new System.Windows.Forms.ComboBox();
            this.rEPRESENTANTEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            nOMBREREPRESENTANTELabel = new System.Windows.Forms.Label();
            cEDULAREPRESENTANTELabel = new System.Windows.Forms.Label();
            eSTADOREPRESENTANTELabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPRESENTANTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPRESENTANTEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPRESENTANTEBindingNavigator)).BeginInit();
            this.rEPRESENTANTEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOMBREREPRESENTANTETextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDULAREPRESENTANTETextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(eSTADOREPRESENTANTELabel);
            this.groupBox1.Controls.Add(this.eSTADOREPRESENTANTEComboBox);
            this.groupBox1.Controls.Add(cEDULAREPRESENTANTELabel);
            this.groupBox1.Controls.Add(this.cEDULAREPRESENTANTETextEdit);
            this.groupBox1.Controls.Add(nOMBREREPRESENTANTELabel);
            this.groupBox1.Controls.Add(this.nOMBREREPRESENTANTETextEdit);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(277, 171);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.retroceso;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(87, 271);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(96, 64);
            this.btnRegresar.TabIndex = 24;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(105, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Regresar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.tableAdapterManager.SERVICIOTableAdapter = null;
            this.tableAdapterManager.TIPOCENTROEDUCACIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoPropietarios.GrisGrisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rEPRESENTANTEDataGridView
            // 
            this.rEPRESENTANTEDataGridView.AllowUserToAddRows = false;
            this.rEPRESENTANTEDataGridView.AllowUserToDeleteRows = false;
            this.rEPRESENTANTEDataGridView.AutoGenerateColumns = false;
            this.rEPRESENTANTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rEPRESENTANTEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.rEPRESENTANTEDataGridView.DataSource = this.rEPRESENTANTEBindingSource;
            this.rEPRESENTANTEDataGridView.Location = new System.Drawing.Point(318, 81);
            this.rEPRESENTANTEDataGridView.Name = "rEPRESENTANTEDataGridView";
            this.rEPRESENTANTEDataGridView.RowTemplate.Height = 24;
            this.rEPRESENTANTEDataGridView.Size = new System.Drawing.Size(743, 296);
            this.rEPRESENTANTEDataGridView.TabIndex = 30;
            this.rEPRESENTANTEDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rEPRESENTANTEDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDREPRESENTANTE";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDREPRESENTANTE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBREREPRESENTANTE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBREREPRESENTANTE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CEDULAREPRESENTANTE";
            this.dataGridViewTextBoxColumn3.HeaderText = "CEDULAREPRESENTANTE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIRECCIONREPRESENTANTE";
            this.dataGridViewTextBoxColumn4.HeaderText = "DIRECCIONREPRESENTANTE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TELEFONOREPRESENTANTE";
            this.dataGridViewTextBoxColumn5.HeaderText = "TELEFONOREPRESENTANTE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ESTADOREPRESENTANTE";
            this.dataGridViewTextBoxColumn6.HeaderText = "ESTADOREPRESENTANTE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CELULARREPRESENTANTE";
            this.dataGridViewTextBoxColumn7.HeaderText = "CELULARREPRESENTANTE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
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
            this.bindingNavigatorPositionItem.ReadOnly = true;
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Visible = false;
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
            this.rEPRESENTANTEBindingNavigator.Size = new System.Drawing.Size(1125, 27);
            this.rEPRESENTANTEBindingNavigator.TabIndex = 30;
            this.rEPRESENTANTEBindingNavigator.Text = "bindingNavigator1";
            // 
            // nOMBREREPRESENTANTELabel
            // 
            nOMBREREPRESENTANTELabel.AutoSize = true;
            nOMBREREPRESENTANTELabel.Location = new System.Drawing.Point(6, 35);
            nOMBREREPRESENTANTELabel.Name = "nOMBREREPRESENTANTELabel";
            nOMBREREPRESENTANTELabel.Size = new System.Drawing.Size(58, 17);
            nOMBREREPRESENTANTELabel.TabIndex = 0;
            nOMBREREPRESENTANTELabel.Text = "Nombre";
            // 
            // nOMBREREPRESENTANTETextEdit
            // 
            this.nOMBREREPRESENTANTETextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rEPRESENTANTEBindingSource, "NOMBREREPRESENTANTE", true));
            this.nOMBREREPRESENTANTETextEdit.Enabled = false;
            this.nOMBREREPRESENTANTETextEdit.Location = new System.Drawing.Point(96, 30);
            this.nOMBREREPRESENTANTETextEdit.Name = "nOMBREREPRESENTANTETextEdit";
            this.nOMBREREPRESENTANTETextEdit.Size = new System.Drawing.Size(143, 22);
            this.nOMBREREPRESENTANTETextEdit.TabIndex = 1;
            // 
            // cEDULAREPRESENTANTELabel
            // 
            cEDULAREPRESENTANTELabel.AutoSize = true;
            cEDULAREPRESENTANTELabel.Location = new System.Drawing.Point(11, 69);
            cEDULAREPRESENTANTELabel.Name = "cEDULAREPRESENTANTELabel";
            cEDULAREPRESENTANTELabel.Size = new System.Drawing.Size(52, 17);
            cEDULAREPRESENTANTELabel.TabIndex = 2;
            cEDULAREPRESENTANTELabel.Text = "Cedula";
            // 
            // cEDULAREPRESENTANTETextEdit
            // 
            this.cEDULAREPRESENTANTETextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rEPRESENTANTEBindingSource, "CEDULAREPRESENTANTE", true));
            this.cEDULAREPRESENTANTETextEdit.Enabled = false;
            this.cEDULAREPRESENTANTETextEdit.Location = new System.Drawing.Point(96, 66);
            this.cEDULAREPRESENTANTETextEdit.Name = "cEDULAREPRESENTANTETextEdit";
            this.cEDULAREPRESENTANTETextEdit.Size = new System.Drawing.Size(143, 22);
            this.cEDULAREPRESENTANTETextEdit.TabIndex = 3;
            // 
            // eSTADOREPRESENTANTELabel
            // 
            eSTADOREPRESENTANTELabel.AutoSize = true;
            eSTADOREPRESENTANTELabel.Location = new System.Drawing.Point(6, 111);
            eSTADOREPRESENTANTELabel.Name = "eSTADOREPRESENTANTELabel";
            eSTADOREPRESENTANTELabel.Size = new System.Drawing.Size(56, 17);
            eSTADOREPRESENTANTELabel.TabIndex = 4;
            eSTADOREPRESENTANTELabel.Text = "Estado:";
            // 
            // eSTADOREPRESENTANTEComboBox
            // 
            this.eSTADOREPRESENTANTEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rEPRESENTANTEBindingSource, "ESTADOREPRESENTANTE", true));
            this.eSTADOREPRESENTANTEComboBox.FormattingEnabled = true;
            this.eSTADOREPRESENTANTEComboBox.Items.AddRange(new object[] {
            "Activo",
            "InActivo"});
            this.eSTADOREPRESENTANTEComboBox.Location = new System.Drawing.Point(96, 104);
            this.eSTADOREPRESENTANTEComboBox.Name = "eSTADOREPRESENTANTEComboBox";
            this.eSTADOREPRESENTANTEComboBox.Size = new System.Drawing.Size(121, 24);
            this.eSTADOREPRESENTANTEComboBox.TabIndex = 5;
            // 
            // rEPRESENTANTEBindingNavigatorSaveItem
            // 
            this.rEPRESENTANTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rEPRESENTANTEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rEPRESENTANTEBindingNavigatorSaveItem.Image")));
            this.rEPRESENTANTEBindingNavigatorSaveItem.Name = "rEPRESENTANTEBindingNavigatorSaveItem";
            this.rEPRESENTANTEBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.rEPRESENTANTEBindingNavigatorSaveItem.Text = "Guardar datos";
            this.rEPRESENTANTEBindingNavigatorSaveItem.Click += new System.EventHandler(this.rEPRESENTANTEBindingNavigatorSaveItem_Click_1);
            // 
            // DardeBajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 407);
            this.Controls.Add(this.rEPRESENTANTEDataGridView);
            this.Controls.Add(this.rEPRESENTANTEBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DardeBajaCliente";
            this.Text = "Dar de Baja o Habilitar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EliminarCliente_FormClosing);
            this.Load += new System.EventHandler(this.DardeBajaCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPRESENTANTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPRESENTANTEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPRESENTANTEBindingNavigator)).EndInit();
            this.rEPRESENTANTEBindingNavigator.ResumeLayout(false);
            this.rEPRESENTANTEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOMBREREPRESENTANTETextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDULAREPRESENTANTETextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label2;
        private GrisGrisDataSet grisGrisDataSet;
        private System.Windows.Forms.BindingSource rEPRESENTANTEBindingSource;
        private GrisGrisDataSetTableAdapters.REPRESENTANTETableAdapter rEPRESENTANTETableAdapter;
        private GrisGrisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView rEPRESENTANTEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox eSTADOREPRESENTANTEComboBox;
        private DevExpress.XtraEditors.TextEdit cEDULAREPRESENTANTETextEdit;
        private DevExpress.XtraEditors.TextEdit nOMBREREPRESENTANTETextEdit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator rEPRESENTANTEBindingNavigator;
        private System.Windows.Forms.ToolStripButton rEPRESENTANTEBindingNavigatorSaveItem;
    }
}