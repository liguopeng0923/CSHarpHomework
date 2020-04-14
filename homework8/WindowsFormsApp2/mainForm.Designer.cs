namespace WindowsFormsApp2
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.alterButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.selectGroupBox = new System.Windows.Forms.GroupBox();
            this.selectTextBox = new System.Windows.Forms.TextBox();
            this.selectComboBox = new System.Windows.Forms.ComboBox();
            this.selectResultButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderId1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemDataGridView = new System.Windows.Forms.DataGridView();
            this.commodityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commodityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commodityValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.selectGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.alterButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.exportButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.importButton, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 55);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.Location = new System.Drawing.Point(44, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 30);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "添加订单";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.Location = new System.Drawing.Point(223, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(90, 30);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "查询订单";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // alterButton
            // 
            this.alterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alterButton.Location = new System.Drawing.Point(402, 12);
            this.alterButton.Name = "alterButton";
            this.alterButton.Size = new System.Drawing.Size(90, 30);
            this.alterButton.TabIndex = 2;
            this.alterButton.Text = "修改订单";
            this.alterButton.UseVisualStyleBackColor = true;
            this.alterButton.Click += new System.EventHandler(this.alterButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exportButton.Location = new System.Drawing.Point(581, 12);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(90, 30);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "导出订单";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importButton.Location = new System.Drawing.Point(761, 12);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(90, 30);
            this.importButton.TabIndex = 4;
            this.importButton.Text = "导入订单";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // selectGroupBox
            // 
            this.selectGroupBox.Controls.Add(this.selectTextBox);
            this.selectGroupBox.Controls.Add(this.selectComboBox);
            this.selectGroupBox.Controls.Add(this.selectResultButton);
            this.selectGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectGroupBox.Location = new System.Drawing.Point(0, 55);
            this.selectGroupBox.Name = "selectGroupBox";
            this.selectGroupBox.Size = new System.Drawing.Size(896, 55);
            this.selectGroupBox.TabIndex = 3;
            this.selectGroupBox.TabStop = false;
            // 
            // selectTextBox
            // 
            this.selectTextBox.Location = new System.Drawing.Point(173, 18);
            this.selectTextBox.Name = "selectTextBox";
            this.selectTextBox.Size = new System.Drawing.Size(383, 25);
            this.selectTextBox.TabIndex = 2;
            // 
            // selectComboBox
            // 
            this.selectComboBox.DisplayMember = "Order1";
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Items.AddRange(new object[] {
            "订单号",
            "商品名",
            "顾客名",
            "总价"});
            this.selectComboBox.Location = new System.Drawing.Point(25, 18);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.Size = new System.Drawing.Size(121, 23);
            this.selectComboBox.TabIndex = 1;
            this.selectComboBox.ValueMember = "Order1";
            // 
            // selectResultButton
            // 
            this.selectResultButton.Location = new System.Drawing.Point(628, 18);
            this.selectResultButton.Name = "selectResultButton";
            this.selectResultButton.Size = new System.Drawing.Size(75, 23);
            this.selectResultButton.TabIndex = 0;
            this.selectResultButton.Text = "查询";
            this.selectResultButton.UseVisualStyleBackColor = true;
            this.selectResultButton.Click += new System.EventHandler(this.selectResultButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.orderDataGridView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.orderItemDataGridView, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 116);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(881, 383);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId1DataGridViewTextBoxColumn,
            this.guestNameDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGridView.Location = new System.Drawing.Point(3, 3);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowTemplate.Height = 27;
            this.orderDataGridView.Size = new System.Drawing.Size(434, 377);
            this.orderDataGridView.TabIndex = 0;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView_CellContentClick);
            // 
            // orderId1DataGridViewTextBoxColumn
            // 
            this.orderId1DataGridViewTextBoxColumn.DataPropertyName = "OrderId1";
            this.orderId1DataGridViewTextBoxColumn.HeaderText = "OrderId1";
            this.orderId1DataGridViewTextBoxColumn.Name = "orderId1DataGridViewTextBoxColumn";
            // 
            // guestNameDataGridViewTextBoxColumn
            // 
            this.guestNameDataGridViewTextBoxColumn.DataPropertyName = "GuestName";
            this.guestNameDataGridViewTextBoxColumn.HeaderText = "GuestName";
            this.guestNameDataGridViewTextBoxColumn.Name = "guestNameDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(ConsoleApp1.OrderItem);
            // 
            // orderItemDataGridView
            // 
            this.orderItemDataGridView.AutoGenerateColumns = false;
            this.orderItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commodityIdDataGridViewTextBoxColumn,
            this.commodityNameDataGridViewTextBoxColumn,
            this.commodityValueDataGridViewTextBoxColumn});
            this.orderItemDataGridView.DataSource = this.orderItemBindingSource;
            this.orderItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItemDataGridView.Location = new System.Drawing.Point(443, 3);
            this.orderItemDataGridView.Name = "orderItemDataGridView";
            this.orderItemDataGridView.RowTemplate.Height = 27;
            this.orderItemDataGridView.Size = new System.Drawing.Size(435, 377);
            this.orderItemDataGridView.TabIndex = 1;
            this.orderItemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderItemDataGridView_CellContentClick);
            // 
            // commodityIdDataGridViewTextBoxColumn
            // 
            this.commodityIdDataGridViewTextBoxColumn.DataPropertyName = "CommodityId";
            this.commodityIdDataGridViewTextBoxColumn.HeaderText = "CommodityId";
            this.commodityIdDataGridViewTextBoxColumn.Name = "commodityIdDataGridViewTextBoxColumn";
            // 
            // commodityNameDataGridViewTextBoxColumn
            // 
            this.commodityNameDataGridViewTextBoxColumn.DataPropertyName = "CommodityName";
            this.commodityNameDataGridViewTextBoxColumn.HeaderText = "CommodityName";
            this.commodityNameDataGridViewTextBoxColumn.Name = "commodityNameDataGridViewTextBoxColumn";
            // 
            // commodityValueDataGridViewTextBoxColumn
            // 
            this.commodityValueDataGridViewTextBoxColumn.DataPropertyName = "CommodityValue";
            this.commodityValueDataGridViewTextBoxColumn.HeaderText = "CommodityValue";
            this.commodityValueDataGridViewTextBoxColumn.Name = "commodityValueDataGridViewTextBoxColumn";
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataMember = "CommoditiesList";
            this.orderItemBindingSource.DataSource = this.orderBindingSource;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 499);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.selectGroupBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.selectGroupBox.ResumeLayout(false);
            this.selectGroupBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button alterButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.GroupBox selectGroupBox;
        private System.Windows.Forms.TextBox selectTextBox;
        private System.Windows.Forms.ComboBox selectComboBox;
        private System.Windows.Forms.Button selectResultButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.DataGridView orderItemDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn commodityIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn commodityNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn commodityValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource orderItemBindingSource;
        public System.Windows.Forms.BindingSource orderBindingSource;
    }
}

