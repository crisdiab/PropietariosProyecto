namespace ProyectoPropietarios
{
    partial class DardeBajaPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DardeBajaPaciente));
            System.Windows.Forms.Label nOMBREPACIENTELabel;
            System.Windows.Forms.Label cEDULAPACIENTELabel;
            System.Windows.Forms.Label eSTADOPACIENTELabel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.button3 = new System.Windows.Forms.Button();
            this.grisGrisDataSet = new ProyectoPropietarios.GrisGrisDataSet();
            this.pACIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pACIENTETableAdapter = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.PACIENTETableAdapter();
            this.tableAdapterManager = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.TableAdapterManager();
            this.pACIENTEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pACIENTEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pACIENTEDataGridView = new System.Windows.Forms.DataGridView();
            this.nOMBREPACIENTETextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cEDULAPACIENTETextEdit = new DevExpress.XtraEditors.TextEdit();
            this.eSTADOPACIENTEComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            nOMBREPACIENTELabel = new System.Windows.Forms.Label();
            cEDULAPACIENTELabel = new System.Windows.Forms.Label();
            eSTADOPACIENTELabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTEBindingNavigator)).BeginInit();
            this.pACIENTEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOMBREPACIENTETextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDULAPACIENTETextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.retroceso;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(55, 259);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 64);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // grisGrisDataSet
            // 
            this.grisGrisDataSet.DataSetName = "GrisGrisDataSet";
            this.grisGrisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pACIENTEBindingSource
            // 
            this.pACIENTEBindingSource.DataMember = "PACIENTE";
            this.pACIENTEBindingSource.DataSource = this.grisGrisDataSet;
            // 
            // pACIENTETableAdapter
            // 
            this.pACIENTETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CENTROEDUCACIONTableAdapter = null;
            this.tableAdapterManager.DETALLEFACTURATableAdapter = null;
            this.tableAdapterManager.DETALLERECIBOTableAdapter = null;
            this.tableAdapterManager.FACTURATableAdapter = null;
            this.tableAdapterManager.PACIENTESXPROFESIONALTableAdapter = null;
            this.tableAdapterManager.PACIENTETableAdapter = this.pACIENTETableAdapter;
            this.tableAdapterManager.PARAMETROSTableAdapter = null;
            this.tableAdapterManager.PROFESIONALTableAdapter = null;
            this.tableAdapterManager.RECIBOTableAdapter = null;
            this.tableAdapterManager.REPRESENTANTETableAdapter = null;
            this.tableAdapterManager.SERVICIOSPORPROFESIONALTableAdapter = null;
            this.tableAdapterManager.SERVICIOSXPACIENTETableAdapter = null;
            this.tableAdapterManager.SERVICIOTableAdapter = null;
            this.tableAdapterManager.TIPOCENTROEDUCACIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoPropietarios.GrisGrisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pACIENTEBindingNavigator
            // 
            this.pACIENTEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pACIENTEBindingNavigator.BindingSource = this.pACIENTEBindingSource;
            this.pACIENTEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pACIENTEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pACIENTEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pACIENTEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pACIENTEBindingNavigatorSaveItem});
            this.pACIENTEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pACIENTEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pACIENTEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pACIENTEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pACIENTEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pACIENTEBindingNavigator.Name = "pACIENTEBindingNavigator";
            this.pACIENTEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pACIENTEBindingNavigator.Size = new System.Drawing.Size(699, 27);
            this.pACIENTEBindingNavigator.TabIndex = 22;
            this.pACIENTEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
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
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
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
            // pACIENTEBindingNavigatorSaveItem
            // 
            this.pACIENTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pACIENTEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pACIENTEBindingNavigatorSaveItem.Image")));
            this.pACIENTEBindingNavigatorSaveItem.Name = "pACIENTEBindingNavigatorSaveItem";
            this.pACIENTEBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.pACIENTEBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pACIENTEBindingNavigatorSaveItem.Visible = false;
            this.pACIENTEBindingNavigatorSaveItem.Click += new System.EventHandler(this.pACIENTEBindingNavigatorSaveItem_Click);
            // 
            // pACIENTEDataGridView
            // 
            this.pACIENTEDataGridView.AutoGenerateColumns = false;
            this.pACIENTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pACIENTEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.pACIENTEDataGridView.DataSource = this.pACIENTEBindingSource;
            this.pACIENTEDataGridView.Location = new System.Drawing.Point(301, 68);
            this.pACIENTEDataGridView.Name = "pACIENTEDataGridView";
            this.pACIENTEDataGridView.RowTemplate.Height = 24;
            this.pACIENTEDataGridView.Size = new System.Drawing.Size(300, 220);
            this.pACIENTEDataGridView.TabIndex = 22;
            // 
            // nOMBREPACIENTELabel
            // 
            nOMBREPACIENTELabel.AutoSize = true;
            nOMBREPACIENTELabel.Location = new System.Drawing.Point(39, 125);
            nOMBREPACIENTELabel.Name = "nOMBREPACIENTELabel";
            nOMBREPACIENTELabel.Size = new System.Drawing.Size(58, 17);
            nOMBREPACIENTELabel.TabIndex = 22;
            nOMBREPACIENTELabel.Text = "Nombre";
            // 
            // nOMBREPACIENTETextEdit
            // 
            this.nOMBREPACIENTETextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pACIENTEBindingSource, "NOMBREPACIENTE", true));
            this.nOMBREPACIENTETextEdit.Enabled = false;
            this.nOMBREPACIENTETextEdit.Location = new System.Drawing.Point(154, 122);
            this.nOMBREPACIENTETextEdit.Name = "nOMBREPACIENTETextEdit";
            this.nOMBREPACIENTETextEdit.Size = new System.Drawing.Size(100, 22);
            this.nOMBREPACIENTETextEdit.TabIndex = 23;
            // 
            // cEDULAPACIENTELabel
            // 
            cEDULAPACIENTELabel.AutoSize = true;
            cEDULAPACIENTELabel.Location = new System.Drawing.Point(39, 167);
            cEDULAPACIENTELabel.Name = "cEDULAPACIENTELabel";
            cEDULAPACIENTELabel.Size = new System.Drawing.Size(52, 17);
            cEDULAPACIENTELabel.TabIndex = 23;
            cEDULAPACIENTELabel.Text = "Cedula";
            cEDULAPACIENTELabel.Click += new System.EventHandler(this.cEDULAPACIENTELabel_Click);
            // 
            // cEDULAPACIENTETextEdit
            // 
            this.cEDULAPACIENTETextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pACIENTEBindingSource, "CEDULAPACIENTE", true));
            this.cEDULAPACIENTETextEdit.Enabled = false;
            this.cEDULAPACIENTETextEdit.Location = new System.Drawing.Point(154, 164);
            this.cEDULAPACIENTETextEdit.Name = "cEDULAPACIENTETextEdit";
            this.cEDULAPACIENTETextEdit.Size = new System.Drawing.Size(100, 22);
            this.cEDULAPACIENTETextEdit.TabIndex = 24;
            // 
            // eSTADOPACIENTELabel1
            // 
            eSTADOPACIENTELabel1.AutoSize = true;
            eSTADOPACIENTELabel1.Location = new System.Drawing.Point(39, 213);
            eSTADOPACIENTELabel1.Name = "eSTADOPACIENTELabel1";
            eSTADOPACIENTELabel1.Size = new System.Drawing.Size(52, 17);
            eSTADOPACIENTELabel1.TabIndex = 25;
            eSTADOPACIENTELabel1.Text = "Estado";
            // 
            // eSTADOPACIENTEComboBox
            // 
            this.eSTADOPACIENTEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pACIENTEBindingSource, "ESTADOPACIENTE", true));
            this.eSTADOPACIENTEComboBox.FormattingEnabled = true;
            this.eSTADOPACIENTEComboBox.Items.AddRange(new object[] {
            "Activo",
            "InActivo"});
            this.eSTADOPACIENTEComboBox.Location = new System.Drawing.Point(154, 210);
            this.eSTADOPACIENTEComboBox.Name = "eSTADOPACIENTEComboBox";
            this.eSTADOPACIENTEComboBox.Size = new System.Drawing.Size(121, 24);
            this.eSTADOPACIENTEComboBox.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(80, 325);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 17);
            label1.TabIndex = 27;
            label1.Text = "Regresar";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDPACIENTE";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDPACIENTE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDREPRESENTANTE";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDREPRESENTANTE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDCENTROEDUCACION";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDCENTROEDUCACION";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NOMBREPACIENTE";
            this.dataGridViewTextBoxColumn4.HeaderText = "NOMBREPACIENTE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CEDULAPACIENTE";
            this.dataGridViewTextBoxColumn5.HeaderText = "CEDULAPACIENTE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EDADPACIENTE";
            this.dataGridViewTextBoxColumn6.HeaderText = "EDADPACIENTE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ENCARGADODECE";
            this.dataGridViewTextBoxColumn7.HeaderText = "ENCARGADODECE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NOMBREREFERENCIA1";
            this.dataGridViewTextBoxColumn8.HeaderText = "NOMBREREFERENCIA1";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TELEFONOREFERENCIA1";
            this.dataGridViewTextBoxColumn9.HeaderText = "TELEFONOREFERENCIA1";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NOMBREREFERENCIA2";
            this.dataGridViewTextBoxColumn10.HeaderText = "NOMBREREFERENCIA2";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TELEFONOREFERENCIA2";
            this.dataGridViewTextBoxColumn11.HeaderText = "TELEFONOREFERENCIA2";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ESTADOPACIENTE";
            this.dataGridViewTextBoxColumn12.HeaderText = "ESTADOPACIENTE";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "FECHANACIMIENTOPACIENTE";
            this.dataGridViewTextBoxColumn13.HeaderText = "FECHANACIMIENTOPACIENTE";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.guardar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(181, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 64);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(196, 326);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 17);
            label2.TabIndex = 29;
            label2.Text = "Guardar";
            // 
            // DardeBajaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 377);
            this.Controls.Add(label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(label1);
            this.Controls.Add(eSTADOPACIENTELabel1);
            this.Controls.Add(this.eSTADOPACIENTEComboBox);
            this.Controls.Add(cEDULAPACIENTELabel);
            this.Controls.Add(this.cEDULAPACIENTETextEdit);
            this.Controls.Add(nOMBREPACIENTELabel);
            this.Controls.Add(this.nOMBREPACIENTETextEdit);
            this.Controls.Add(this.pACIENTEDataGridView);
            this.Controls.Add(this.pACIENTEBindingNavigator);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DardeBajaPaciente";
            this.Text = "Dar de baja o Habilitar pacientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EliminarPaciente_FormClosing);
            this.Load += new System.EventHandler(this.EliminarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTEBindingNavigator)).EndInit();
            this.pACIENTEBindingNavigator.ResumeLayout(false);
            this.pACIENTEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOMBREPACIENTETextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEDULAPACIENTETextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private GrisGrisDataSet grisGrisDataSet;
        private System.Windows.Forms.BindingSource pACIENTEBindingSource;
        private GrisGrisDataSetTableAdapters.PACIENTETableAdapter pACIENTETableAdapter;
        private GrisGrisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pACIENTEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pACIENTEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pACIENTEDataGridView;
        private DevExpress.XtraEditors.TextEdit nOMBREPACIENTETextEdit;
        private DevExpress.XtraEditors.TextEdit cEDULAPACIENTETextEdit;
        private System.Windows.Forms.ComboBox eSTADOPACIENTEComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button button1;
    }
}