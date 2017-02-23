namespace ProyectoPropietarios
{
    partial class ReporteFinanciero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteFinanciero));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grisGrisDataSet = new ProyectoPropietarios.GrisGrisDataSet();
            this.buscarFechaFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarFechaFacturaTableAdapter = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.buscarFechaFacturaTableAdapter();
            this.tableAdapterManager = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.TableAdapterManager();
            this.buscarFechaFacturaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.buscarFechaFacturaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.fechainicioToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fechainicioToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fechafinToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fechafinToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.buscarFechaFacturaDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridtotalfactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarFechaFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarFechaFacturaBindingNavigator)).BeginInit();
            this.buscarFechaFacturaBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscarFechaFacturaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total Ingresos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-118, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.retroceso;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(125, 349);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grisGrisDataSet
            // 
            this.grisGrisDataSet.DataSetName = "GrisGrisDataSet";
            this.grisGrisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarFechaFacturaBindingSource
            // 
            this.buscarFechaFacturaBindingSource.DataMember = "buscarFechaFactura";
            this.buscarFechaFacturaBindingSource.DataSource = this.grisGrisDataSet;
            // 
            // buscarFechaFacturaTableAdapter
            // 
            this.buscarFechaFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CENTROEDUCACIONTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.SERVICIOTableAdapter = null;
            this.tableAdapterManager.TIPOCENTROEDUCACIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoPropietarios.GrisGrisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buscarFechaFacturaBindingNavigator
            // 
            this.buscarFechaFacturaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.buscarFechaFacturaBindingNavigator.BindingSource = this.buscarFechaFacturaBindingSource;
            this.buscarFechaFacturaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.buscarFechaFacturaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.buscarFechaFacturaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.buscarFechaFacturaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.buscarFechaFacturaBindingNavigatorSaveItem});
            this.buscarFechaFacturaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.buscarFechaFacturaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.buscarFechaFacturaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.buscarFechaFacturaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.buscarFechaFacturaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.buscarFechaFacturaBindingNavigator.Name = "buscarFechaFacturaBindingNavigator";
            this.buscarFechaFacturaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.buscarFechaFacturaBindingNavigator.Size = new System.Drawing.Size(830, 27);
            this.buscarFechaFacturaBindingNavigator.TabIndex = 21;
            this.buscarFechaFacturaBindingNavigator.Text = "bindingNavigator1";
            this.buscarFechaFacturaBindingNavigator.Visible = false;
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
            // buscarFechaFacturaBindingNavigatorSaveItem
            // 
            this.buscarFechaFacturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buscarFechaFacturaBindingNavigatorSaveItem.Enabled = false;
            this.buscarFechaFacturaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarFechaFacturaBindingNavigatorSaveItem.Image")));
            this.buscarFechaFacturaBindingNavigatorSaveItem.Name = "buscarFechaFacturaBindingNavigatorSaveItem";
            this.buscarFechaFacturaBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.buscarFechaFacturaBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechainicioToolStripLabel,
            this.fechainicioToolStripTextBox,
            this.fechafinToolStripLabel,
            this.fechafinToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(12, 48);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(421, 27);
            this.fillToolStrip.TabIndex = 22;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // fechainicioToolStripLabel
            // 
            this.fechainicioToolStripLabel.Name = "fechainicioToolStripLabel";
            this.fechainicioToolStripLabel.Size = new System.Drawing.Size(84, 24);
            this.fechainicioToolStripLabel.Text = "fechainicio:";
            // 
            // fechainicioToolStripTextBox
            // 
            this.fechainicioToolStripTextBox.Name = "fechainicioToolStripTextBox";
            this.fechainicioToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fechafinToolStripLabel
            // 
            this.fechafinToolStripLabel.Name = "fechafinToolStripLabel";
            this.fechafinToolStripLabel.Size = new System.Drawing.Size(65, 24);
            this.fechafinToolStripLabel.Text = "fechafin:";
            // 
            // fechafinToolStripTextBox
            // 
            this.fechafinToolStripTextBox.Name = "fechafinToolStripTextBox";
            this.fechafinToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(56, 24);
            this.fillToolStripButton.Text = "Buscar";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // buscarFechaFacturaDataGridView
            // 
            this.buscarFechaFacturaDataGridView.AutoGenerateColumns = false;
            this.buscarFechaFacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscarFechaFacturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.gridtotalfactura,
            this.dataGridViewTextBoxColumn8});
            this.buscarFechaFacturaDataGridView.DataSource = this.buscarFechaFacturaBindingSource;
            this.buscarFechaFacturaDataGridView.Location = new System.Drawing.Point(12, 122);
            this.buscarFechaFacturaDataGridView.Name = "buscarFechaFacturaDataGridView";
            this.buscarFechaFacturaDataGridView.RowTemplate.Height = 24;
            this.buscarFechaFacturaDataGridView.Size = new System.Drawing.Size(430, 220);
            this.buscarFechaFacturaDataGridView.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Regresar";
            // 
            // txtIngresos
            // 
            this.txtIngresos.Enabled = false;
            this.txtIngresos.Location = new System.Drawing.Point(638, 209);
            this.txtIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(132, 22);
            this.txtIngresos.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 57);
            this.button1.TabIndex = 25;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDFACTURA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
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
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NUMEROFACTURA";
            this.dataGridViewTextBoxColumn3.HeaderText = "NUMERO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 98;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FECHAFACTURA";
            this.dataGridViewTextBoxColumn4.HeaderText = "FECHA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 82;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SUBTOTALFACTURA";
            this.dataGridViewTextBoxColumn5.HeaderText = "SUBTOTALFACTURA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "VALORIVA";
            this.dataGridViewTextBoxColumn6.HeaderText = "VALORIVA";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // gridtotalfactura
            // 
            this.gridtotalfactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gridtotalfactura.DataPropertyName = "TOTALFACTURA";
            this.gridtotalfactura.HeaderText = "TOTAL";
            this.gridtotalfactura.Name = "gridtotalfactura";
            this.gridtotalfactura.Width = 83;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ESTADOFACTURA";
            this.dataGridViewTextBoxColumn8.HeaderText = "ESTADOFACTURA";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // ReporteFinanciero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoPropietarios.Properties.Resources.fondo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIngresos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buscarFechaFacturaDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.buscarFechaFacturaBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReporteFinanciero";
            this.Text = "ReporteFinanciero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReporteFinanciero_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarFechaFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarFechaFacturaBindingNavigator)).EndInit();
            this.buscarFechaFacturaBindingNavigator.ResumeLayout(false);
            this.buscarFechaFacturaBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscarFechaFacturaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private GrisGrisDataSet grisGrisDataSet;
        private System.Windows.Forms.BindingSource buscarFechaFacturaBindingSource;
        private GrisGrisDataSetTableAdapters.buscarFechaFacturaTableAdapter buscarFechaFacturaTableAdapter;
        private GrisGrisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator buscarFechaFacturaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton buscarFechaFacturaBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel fechainicioToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fechainicioToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel fechafinToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fechafinToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView buscarFechaFacturaDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridtotalfactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}