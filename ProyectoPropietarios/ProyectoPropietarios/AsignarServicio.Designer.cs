namespace ProyectoPropietarios
{
    partial class AsignarServicio
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarServicio));
            this.gbServicios = new System.Windows.Forms.GroupBox();
            this.sERVICIODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERVICIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grisGrisDataSet = new ProyectoPropietarios.GrisGrisDataSet();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevaBusqueda = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcedulaCliente = new System.Windows.Forms.TextBox();
            this.sERVICIOTableAdapter = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.SERVICIOTableAdapter();
            this.tableAdapterManager = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.TableAdapterManager();
            this.sERVICIOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sERVICIOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreServicio = new DevExpress.XtraEditors.TextEdit();
            this.txtIdServicio = new DevExpress.XtraEditors.SpinEdit();
            this.txtProfesionalObtenido = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txidProfesional = new System.Windows.Forms.TextBox();
            nOMBRESERVICIOLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.gbServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingNavigator)).BeginInit();
            this.sERVICIOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreServicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdServicio.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nOMBRESERVICIOLabel
            // 
            nOMBRESERVICIOLabel.AutoSize = true;
            nOMBRESERVICIOLabel.Location = new System.Drawing.Point(7, 81);
            nOMBRESERVICIOLabel.Name = "nOMBRESERVICIOLabel";
            nOMBRESERVICIOLabel.Size = new System.Drawing.Size(58, 17);
            nOMBRESERVICIOLabel.TabIndex = 88;
            nOMBRESERVICIOLabel.Text = "Servicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(718, 363);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 17);
            label4.TabIndex = 90;
            label4.Text = "Atras";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(856, 367);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(61, 17);
            label6.TabIndex = 92;
            label6.Text = "Guardar";
            // 
            // gbServicios
            // 
            this.gbServicios.BackColor = System.Drawing.Color.Transparent;
            this.gbServicios.Controls.Add(this.sERVICIODataGridView);
            this.gbServicios.Enabled = false;
            this.gbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServicios.Location = new System.Drawing.Point(37, 190);
            this.gbServicios.Name = "gbServicios";
            this.gbServicios.Size = new System.Drawing.Size(607, 224);
            this.gbServicios.TabIndex = 17;
            this.gbServicios.TabStop = false;
            this.gbServicios.Text = "Servicios";
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
            this.sERVICIODataGridView.Location = new System.Drawing.Point(24, 43);
            this.sERVICIODataGridView.Name = "sERVICIODataGridView";
            this.sERVICIODataGridView.RowTemplate.Height = 24;
            this.sERVICIODataGridView.Size = new System.Drawing.Size(450, 165);
            this.sERVICIODataGridView.TabIndex = 88;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDSERVICIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 56;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRESERVICIO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 108;
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
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // sERVICIOBindingSource
            // 
            this.sERVICIOBindingSource.DataMember = "SERVICIO";
            this.sERVICIOBindingSource.DataSource = this.grisGrisDataSet;
            // 
            // grisGrisDataSet
            // 
            this.grisGrisDataSet.DataSetName = "GrisGrisDataSet";
            this.grisGrisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(844, 304);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 60);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.retroceso;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Location = new System.Drawing.Point(706, 308);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(86, 52);
            this.btnAtras.TabIndex = 29;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnNuevaBusqueda);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcedulaCliente);
            this.groupBox1.Location = new System.Drawing.Point(37, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 119);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Profesional";
            // 
            // btnNuevaBusqueda
            // 
            this.btnNuevaBusqueda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNuevaBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevaBusqueda.Enabled = false;
            this.btnNuevaBusqueda.Location = new System.Drawing.Point(482, 44);
            this.btnNuevaBusqueda.Name = "btnNuevaBusqueda";
            this.btnNuevaBusqueda.Size = new System.Drawing.Size(100, 58);
            this.btnNuevaBusqueda.TabIndex = 72;
            this.btnNuevaBusqueda.Text = "Nueva Búsqueda";
            this.btnNuevaBusqueda.UseVisualStyleBackColor = false;
            this.btnNuevaBusqueda.Click += new System.EventHandler(this.btnNuevaBusqueda_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.btnBuscarCliente.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.buscar1;
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCliente.Location = new System.Drawing.Point(400, 49);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(66, 48);
            this.btnBuscarCliente.TabIndex = 70;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Cedula";
            // 
            // txtcedulaCliente
            // 
            this.txtcedulaCliente.Location = new System.Drawing.Point(138, 67);
            this.txtcedulaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtcedulaCliente.Name = "txtcedulaCliente";
            this.txtcedulaCliente.Size = new System.Drawing.Size(237, 22);
            this.txtcedulaCliente.TabIndex = 69;
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
            this.sERVICIOBindingNavigator.Size = new System.Drawing.Size(1142, 25);
            this.sERVICIOBindingNavigator.TabIndex = 88;
            this.sERVICIOBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sERVICIOBindingNavigatorSaveItem
            // 
            this.sERVICIOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sERVICIOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sERVICIOBindingNavigatorSaveItem.Image")));
            this.sERVICIOBindingNavigatorSaveItem.Name = "sERVICIOBindingNavigatorSaveItem";
            this.sERVICIOBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.sERVICIOBindingNavigatorSaveItem.Text = "Guardar datos";
            this.sERVICIOBindingNavigatorSaveItem.Visible = false;
            this.sERVICIOBindingNavigatorSaveItem.Click += new System.EventHandler(this.sERVICIOBindingNavigatorSaveItem_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "nombre";
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sERVICIOBindingSource, "NOMBRESERVICIO", true));
            this.txtNombreServicio.Enabled = false;
            this.txtNombreServicio.Location = new System.Drawing.Point(86, 81);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(151, 22);
            this.txtNombreServicio.TabIndex = 89;
            // 
            // txtIdServicio
            // 
            this.txtIdServicio.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sERVICIOBindingSource, "IDSERVICIO", true));
            this.txtIdServicio.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtIdServicio.Enabled = false;
            this.txtIdServicio.Location = new System.Drawing.Point(696, 28);
            this.txtIdServicio.Name = "txtIdServicio";
            this.txtIdServicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIdServicio.Size = new System.Drawing.Size(100, 22);
            this.txtIdServicio.TabIndex = 90;
            this.txtIdServicio.Visible = false;
            // 
            // txtProfesionalObtenido
            // 
            this.txtProfesionalObtenido.Enabled = false;
            this.txtProfesionalObtenido.Location = new System.Drawing.Point(86, 53);
            this.txtProfesionalObtenido.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfesionalObtenido.Name = "txtProfesionalObtenido";
            this.txtProfesionalObtenido.Size = new System.Drawing.Size(151, 22);
            this.txtProfesionalObtenido.TabIndex = 73;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtProfesionalObtenido);
            this.groupBox3.Controls.Add(this.txtNombreServicio);
            this.groupBox3.Controls.Add(nOMBRESERVICIOLabel);
            this.groupBox3.Location = new System.Drawing.Point(696, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 181);
            this.groupBox3.TabIndex = 91;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servicios por Profesional";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txidProfesional
            // 
            this.txidProfesional.Enabled = false;
            this.txidProfesional.Location = new System.Drawing.Point(829, 31);
            this.txidProfesional.Margin = new System.Windows.Forms.Padding(4);
            this.txidProfesional.Name = "txidProfesional";
            this.txidProfesional.Size = new System.Drawing.Size(151, 22);
            this.txidProfesional.TabIndex = 90;
            this.txidProfesional.Visible = false;
            // 
            // AsignarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 438);
            this.Controls.Add(this.txidProfesional);
            this.Controls.Add(label6);
            this.Controls.Add(label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtIdServicio);
            this.Controls.Add(this.sERVICIOBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbServicios);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAtras);
            this.Name = "AsignarServicio";
            this.Text = "AsignarServicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AsignarServicio_FormClosing);
            this.Load += new System.EventHandler(this.AsignarServicio_Load);
            this.gbServicios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingNavigator)).EndInit();
            this.sERVICIOBindingNavigator.ResumeLayout(false);
            this.sERVICIOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreServicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdServicio.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbServicios;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevaBusqueda;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcedulaCliente;
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
        private System.Windows.Forms.DataGridView sERVICIODataGridView;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtNombreServicio;
        private DevExpress.XtraEditors.SpinEdit txtIdServicio;
        private System.Windows.Forms.TextBox txtProfesionalObtenido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox txidProfesional;
    }
}