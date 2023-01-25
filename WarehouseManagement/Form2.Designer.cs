using System.Windows.Forms;

namespace WarehouseManagement
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.finToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.materialListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transfersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rawToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.finToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.outToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.warehousemanagementDataSet = new WarehouseManagement.warehousemanagementDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new WarehouseManagement.warehousemanagementDataSetTableAdapters.clientTableAdapter();
            this.rawmaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawmaterialTableAdapter = new WarehouseManagement.warehousemanagementDataSetTableAdapters.rawmaterialTableAdapter();
            this.finiteproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finiteproductTableAdapter = new WarehouseManagement.warehousemanagementDataSetTableAdapters.finiteproductTableAdapter();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorTableAdapter = new WarehouseManagement.warehousemanagementDataSetTableAdapters.vendorTableAdapter();
            this.transferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transferTableAdapter = new WarehouseManagement.warehousemanagementDataSetTableAdapters.transferTableAdapter();
            this.boxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boxTableAdapter = new WarehouseManagement.warehousemanagementDataSetTableAdapters.boxTableAdapter();
            this.inboundorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inboundorderTableAdapter = new WarehouseManagement.warehousemanagementDataSetTableAdapters.inboundorderTableAdapter();
            this.outboundorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outboundorderTableAdapter = new WarehouseManagement.warehousemanagementDataSetTableAdapters.outboundorderTableAdapter();
            this.receptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receptionTableAdapter = new WarehouseManagement.warehousemanagementDataSetTableAdapters.receptionTableAdapter();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseTableAdapter = new WarehouseManagement.warehousemanagementDataSetTableAdapters.warehouseTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousemanagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawmaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finiteproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inboundorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outboundorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.insertToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.vendorToolStripMenuItem,
            this.transferToolStripMenuItem,
            this.receptionToolStripMenuItem,
            this.warehouseToolStripMenuItem1,
            this.boxToolStripMenuItem,
            this.deliveryToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawToolStripMenuItem1,
            this.finToolStripMenuItem1});
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.materialToolStripMenuItem.Text = "Material";
            // 
            // rawToolStripMenuItem1
            // 
            this.rawToolStripMenuItem1.Name = "rawToolStripMenuItem1";
            this.rawToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.rawToolStripMenuItem1.Text = "Raw";
            this.rawToolStripMenuItem1.Click += new System.EventHandler(this.rawToolStripMenuItem1_Click);
            // 
            // finToolStripMenuItem1
            // 
            this.finToolStripMenuItem1.Name = "finToolStripMenuItem1";
            this.finToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.finToolStripMenuItem1.Text = "Fin";
            this.finToolStripMenuItem1.Click += new System.EventHandler(this.finToolStripMenuItem1_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outToolStripMenuItem1,
            this.inToolStripMenuItem1});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // outToolStripMenuItem1
            // 
            this.outToolStripMenuItem1.Name = "outToolStripMenuItem1";
            this.outToolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.outToolStripMenuItem1.Text = "Out";
            // 
            // inToolStripMenuItem1
            // 
            this.inToolStripMenuItem1.Name = "inToolStripMenuItem1";
            this.inToolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.inToolStripMenuItem1.Text = "In";
            this.inToolStripMenuItem1.Click += new System.EventHandler(this.inToolStripMenuItem1_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.vendorToolStripMenuItem.Text = "Vendor";
            this.vendorToolStripMenuItem.Click += new System.EventHandler(this.vendorToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // receptionToolStripMenuItem
            // 
            this.receptionToolStripMenuItem.Name = "receptionToolStripMenuItem";
            this.receptionToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.receptionToolStripMenuItem.Text = "Reception";
            this.receptionToolStripMenuItem.Click += new System.EventHandler(this.receptionToolStripMenuItem_Click);
            // 
            // warehouseToolStripMenuItem1
            // 
            this.warehouseToolStripMenuItem1.Name = "warehouseToolStripMenuItem1";
            this.warehouseToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.warehouseToolStripMenuItem1.Text = "Warehouse";
            this.warehouseToolStripMenuItem1.Click += new System.EventHandler(this.warehouseToolStripMenuItem1_Click);
            // 
            // boxToolStripMenuItem
            // 
            this.boxToolStripMenuItem.Name = "boxToolStripMenuItem";
            this.boxToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.boxToolStripMenuItem.Text = "Box";
            this.boxToolStripMenuItem.Click += new System.EventHandler(this.boxToolStripMenuItem_Click);
            // 
            // deliveryToolStripMenuItem
            // 
            this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
            this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deliveryToolStripMenuItem.Text = "Delivery";
            this.deliveryToolStripMenuItem.Click += new System.EventHandler(this.deliveryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialListToolStripMenuItem,
            this.boxesToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.transfersToolStripMenuItem,
            this.deliveriesToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.vendorsToolStripMenuItem,
            this.warehouseToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem2.Text = "View Data";
            // 
            // materialListToolStripMenuItem
            // 
            this.materialListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawToolStripMenuItem,
            this.finToolStripMenuItem});
            this.materialListToolStripMenuItem.Name = "materialListToolStripMenuItem";
            this.materialListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materialListToolStripMenuItem.Text = "Material List";
            // 
            // rawToolStripMenuItem
            // 
            this.rawToolStripMenuItem.Name = "rawToolStripMenuItem";
            this.rawToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.rawToolStripMenuItem.Text = "Raw";
            this.rawToolStripMenuItem.Click += new System.EventHandler(this.rawToolStripMenuItem_Click);
            // 
            // finToolStripMenuItem
            // 
            this.finToolStripMenuItem.Name = "finToolStripMenuItem";
            this.finToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.finToolStripMenuItem.Text = "Fin";
            this.finToolStripMenuItem.Click += new System.EventHandler(this.finToolStripMenuItem_Click);
            // 
            // boxesToolStripMenuItem
            // 
            this.boxesToolStripMenuItem.Name = "boxesToolStripMenuItem";
            this.boxesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.boxesToolStripMenuItem.Text = "Boxes";
            this.boxesToolStripMenuItem.Click += new System.EventHandler(this.boxesToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inToolStripMenuItem,
            this.outToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.inToolStripMenuItem.Text = "In";
            this.inToolStripMenuItem.Click += new System.EventHandler(this.inToolStripMenuItem_Click);
            // 
            // outToolStripMenuItem
            // 
            this.outToolStripMenuItem.Name = "outToolStripMenuItem";
            this.outToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.outToolStripMenuItem.Text = "Out";
            this.outToolStripMenuItem.Click += new System.EventHandler(this.outToolStripMenuItem_Click);
            // 
            // transfersToolStripMenuItem
            // 
            this.transfersToolStripMenuItem.Name = "transfersToolStripMenuItem";
            this.transfersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transfersToolStripMenuItem.Text = "Transfers";
            this.transfersToolStripMenuItem.Click += new System.EventHandler(this.transfersToolStripMenuItem_Click);
            // 
            // deliveriesToolStripMenuItem
            // 
            this.deliveriesToolStripMenuItem.Name = "deliveriesToolStripMenuItem";
            this.deliveriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deliveriesToolStripMenuItem.Text = "Deliveries";
            this.deliveriesToolStripMenuItem.Click += new System.EventHandler(this.deliveriesToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // vendorsToolStripMenuItem
            // 
            this.vendorsToolStripMenuItem.Name = "vendorsToolStripMenuItem";
            this.vendorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendorsToolStripMenuItem.Text = "Vendors";
            this.vendorsToolStripMenuItem.Click += new System.EventHandler(this.vendorsToolStripMenuItem_Click);
            // 
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.warehouseToolStripMenuItem.Text = "Warehouse";
            this.warehouseToolStripMenuItem.Click += new System.EventHandler(this.warehouseToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorToolStripMenuItem1,
            this.clientToolStripMenuItem1,
            this.vendorToolStripMenuItem2,
            this.orderToolStripMenuItem1});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // vendorToolStripMenuItem1
            // 
            this.vendorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawToolStripMenuItem2,
            this.finToolStripMenuItem2});
            this.vendorToolStripMenuItem1.Name = "vendorToolStripMenuItem1";
            this.vendorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.vendorToolStripMenuItem1.Text = "Material";
            // 
            // rawToolStripMenuItem2
            // 
            this.rawToolStripMenuItem2.Name = "rawToolStripMenuItem2";
            this.rawToolStripMenuItem2.Size = new System.Drawing.Size(96, 22);
            this.rawToolStripMenuItem2.Text = "Raw";
            this.rawToolStripMenuItem2.Click += new System.EventHandler(this.rawToolStripMenuItem2_Click);
            // 
            // finToolStripMenuItem2
            // 
            this.finToolStripMenuItem2.Name = "finToolStripMenuItem2";
            this.finToolStripMenuItem2.Size = new System.Drawing.Size(96, 22);
            this.finToolStripMenuItem2.Text = "Fin";
            this.finToolStripMenuItem2.Click += new System.EventHandler(this.finToolStripMenuItem2_Click);
            // 
            // clientToolStripMenuItem1
            // 
            this.clientToolStripMenuItem1.Name = "clientToolStripMenuItem1";
            this.clientToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientToolStripMenuItem1.Text = "Client";
            this.clientToolStripMenuItem1.Click += new System.EventHandler(this.clientToolStripMenuItem1_Click);
            // 
            // vendorToolStripMenuItem2
            // 
            this.vendorToolStripMenuItem2.Name = "vendorToolStripMenuItem2";
            this.vendorToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.vendorToolStripMenuItem2.Text = "Vendor";
            this.vendorToolStripMenuItem2.Click += new System.EventHandler(this.vendorToolStripMenuItem2_Click);
            // 
            // orderToolStripMenuItem1
            // 
            this.orderToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inToolStripMenuItem2,
            this.outToolStripMenuItem2});
            this.orderToolStripMenuItem1.Name = "orderToolStripMenuItem1";
            this.orderToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.orderToolStripMenuItem1.Text = "Order";
            // 
            // inToolStripMenuItem2
            // 
            this.inToolStripMenuItem2.Name = "inToolStripMenuItem2";
            this.inToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.inToolStripMenuItem2.Text = "In";
            this.inToolStripMenuItem2.Click += new System.EventHandler(this.inToolStripMenuItem2_Click);
            // 
            // outToolStripMenuItem2
            // 
            this.outToolStripMenuItem2.Name = "outToolStripMenuItem2";
            this.outToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.outToolStripMenuItem2.Text = "Out";
            this.outToolStripMenuItem2.Click += new System.EventHandler(this.outToolStripMenuItem2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.Location = new System.Drawing.Point(358, 47);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(397, 159);
            this.dataGridView1.TabIndex = 1;
            // 
            // warehousemanagementDataSet
            // 
            this.warehousemanagementDataSet.DataSetName = "warehousemanagementDataSet";
            this.warehousemanagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.warehousemanagementDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // rawmaterialBindingSource
            // 
            this.rawmaterialBindingSource.DataMember = "rawmaterial";
            this.rawmaterialBindingSource.DataSource = this.warehousemanagementDataSet;
            // 
            // rawmaterialTableAdapter
            // 
            this.rawmaterialTableAdapter.ClearBeforeFill = true;
            // 
            // finiteproductBindingSource
            // 
            this.finiteproductBindingSource.DataMember = "finiteproduct";
            this.finiteproductBindingSource.DataSource = this.warehousemanagementDataSet;
            // 
            // finiteproductTableAdapter
            // 
            this.finiteproductTableAdapter.ClearBeforeFill = true;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "vendor";
            this.vendorBindingSource.DataSource = this.warehousemanagementDataSet;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // transferBindingSource
            // 
            this.transferBindingSource.DataMember = "transfer";
            this.transferBindingSource.DataSource = this.warehousemanagementDataSet;
            // 
            // transferTableAdapter
            // 
            this.transferTableAdapter.ClearBeforeFill = true;
            // 
            // boxBindingSource
            // 
            this.boxBindingSource.DataMember = "box";
            this.boxBindingSource.DataSource = this.warehousemanagementDataSet;
            // 
            // boxTableAdapter
            // 
            this.boxTableAdapter.ClearBeforeFill = true;
            // 
            // inboundorderBindingSource
            // 
            this.inboundorderBindingSource.DataMember = "inboundorder";
            this.inboundorderBindingSource.DataSource = this.warehousemanagementDataSet;
            // 
            // inboundorderTableAdapter
            // 
            this.inboundorderTableAdapter.ClearBeforeFill = true;
            // 
            // outboundorderBindingSource
            // 
            this.outboundorderBindingSource.DataMember = "outboundorder";
            this.outboundorderBindingSource.DataSource = this.warehousemanagementDataSet;
            // 
            // outboundorderTableAdapter
            // 
            this.outboundorderTableAdapter.ClearBeforeFill = true;
            // 
            // receptionBindingSource
            // 
            this.receptionBindingSource.DataMember = "reception";
            this.receptionBindingSource.DataSource = this.warehousemanagementDataSet;
            // 
            // receptionTableAdapter
            // 
            this.receptionTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataMember = "warehouse";
            this.warehouseBindingSource.DataSource = this.warehousemanagementDataSet;
            // 
            // warehouseTableAdapter
            // 
            this.warehouseTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(814, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Export to Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Location = new System.Drawing.Point(814, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hide Grid";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(146, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 20);
            this.textBox4.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 28);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(146, 196);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(180, 20);
            this.textBox5.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 631);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Warehouse Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousemanagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawmaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finiteproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inboundorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outboundorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem finToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem materialListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transfersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rawToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem finToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem outToolStripMenuItem2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private warehousemanagementDataSet warehousemanagementDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private warehousemanagementDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource rawmaterialBindingSource;
        private warehousemanagementDataSetTableAdapters.rawmaterialTableAdapter rawmaterialTableAdapter;
        private System.Windows.Forms.BindingSource finiteproductBindingSource;
        private warehousemanagementDataSetTableAdapters.finiteproductTableAdapter finiteproductTableAdapter;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private warehousemanagementDataSetTableAdapters.vendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.BindingSource transferBindingSource;
        private warehousemanagementDataSetTableAdapters.transferTableAdapter transferTableAdapter;
        private System.Windows.Forms.BindingSource boxBindingSource;
        private warehousemanagementDataSetTableAdapters.boxTableAdapter boxTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem boxesToolStripMenuItem;
        private System.Windows.Forms.BindingSource inboundorderBindingSource;
        private warehousemanagementDataSetTableAdapters.inboundorderTableAdapter inboundorderTableAdapter;
        private System.Windows.Forms.BindingSource outboundorderBindingSource;
        private warehousemanagementDataSetTableAdapters.outboundorderTableAdapter outboundorderTableAdapter;
        private System.Windows.Forms.BindingSource receptionBindingSource;
        private warehousemanagementDataSetTableAdapters.receptionTableAdapter receptionTableAdapter;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private warehousemanagementDataSetTableAdapters.warehouseTableAdapter warehouseTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button3;
        private Label label5;
        private TextBox textBox5;
        private ToolStripMenuItem transferToolStripMenuItem;
        private ToolStripMenuItem receptionToolStripMenuItem;
        private ToolStripMenuItem warehouseToolStripMenuItem1;
        private ToolStripMenuItem boxToolStripMenuItem;
        private ToolStripMenuItem deliveryToolStripMenuItem;
    }
}