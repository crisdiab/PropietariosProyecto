namespace ProyectoPropietarios
{
    partial class EliminarFactura
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
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grisGrisDataSet = new ProyectoPropietarios.GrisGrisDataSet();
            this.buscarFechaFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarFechaFacturaTableAdapter = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.buscarFechaFacturaTableAdapter();
            this.tableAdapterManager = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.TableAdapterManager();
            this.buscarfacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarfacturaTableAdapter = new ProyectoPropietarios.GrisGrisDataSetTableAdapters.buscarfacturaTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.numfactToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.numfactToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.buscarfacturaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarFechaFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarfacturaBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscarfacturaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 30);
            this.button3.TabIndex = 28;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 241);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos facturas ";
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
            // buscarfacturaBindingSource
            // 
            this.buscarfacturaBindingSource.DataMember = "buscarfactura";
            this.buscarfacturaBindingSource.DataSource = this.grisGrisDataSet;
            // 
            // buscarfacturaTableAdapter
            // 
            this.buscarfacturaTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numfactToolStripLabel,
            this.numfactToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(316, 46);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(308, 27);
            this.fillToolStrip.TabIndex = 30;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // numfactToolStripLabel
            // 
            this.numfactToolStripLabel.Name = "numfactToolStripLabel";
            this.numfactToolStripLabel.Size = new System.Drawing.Size(138, 24);
            this.numfactToolStripLabel.Text = "Número de Factura:";
            // 
            // numfactToolStripTextBox
            // 
            this.numfactToolStripTextBox.Name = "numfactToolStripTextBox";
            this.numfactToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(56, 24);
            this.fillToolStripButton.Text = "Buscar";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_4);
            // 
            // buscarfacturaDataGridView
            // 
            this.buscarfacturaDataGridView.AutoGenerateColumns = false;
            this.buscarfacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscarfacturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.buscarfacturaDataGridView.DataSource = this.buscarfacturaBindingSource;
            this.buscarfacturaDataGridView.Location = new System.Drawing.Point(316, 85);
            this.buscarfacturaDataGridView.Name = "buscarfacturaDataGridView";
            this.buscarfacturaDataGridView.RowTemplate.Height = 24;
            this.buscarfacturaDataGridView.Size = new System.Drawing.Size(300, 220);
            this.buscarfacturaDataGridView.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDFACTURA";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDFACTURA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDREPRESENTANTE";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDREPRESENTANTE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NUMEROFACTURA";
            this.dataGridViewTextBoxColumn3.HeaderText = "NUMEROFACTURA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FECHAFACTURA";
            this.dataGridViewTextBoxColumn4.HeaderText = "FECHAFACTURA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SUBTOTALFACTURA";
            this.dataGridViewTextBoxColumn5.HeaderText = "SUBTOTALFACTURA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "VALORIVA";
            this.dataGridViewTextBoxColumn6.HeaderText = "VALORIVA";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TOTALFACTURA";
            this.dataGridViewTextBoxColumn7.HeaderText = "TOTALFACTURA";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ESTADOFACTURA";
            this.dataGridViewTextBoxColumn8.HeaderText = "ESTADOFACTURA";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // EliminarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 449);
            this.Controls.Add(this.buscarfacturaDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Name = "EliminarFactura";
            this.Text = "Anular Factura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EliminarFactura_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grisGrisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarFechaFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarfacturaBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscarfacturaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private GrisGrisDataSet grisGrisDataSet;
        private System.Windows.Forms.BindingSource buscarFechaFacturaBindingSource;
        private GrisGrisDataSetTableAdapters.buscarFechaFacturaTableAdapter buscarFechaFacturaTableAdapter;
        private GrisGrisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource buscarfacturaBindingSource;
        private GrisGrisDataSetTableAdapters.buscarfacturaTableAdapter buscarfacturaTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel numfactToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox numfactToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView buscarfacturaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}