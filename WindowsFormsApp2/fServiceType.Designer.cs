namespace WindowsFormsApp2
{
    partial class fServiceType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fServiceType));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveServiceType = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCLose1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnInsert = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdateServiceType = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelName = new System.Windows.Forms.Label();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingServiceType = new System.Windows.Forms.BindingNavigator(this.components);
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewServiceType = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txbSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.comboboxID = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupServiceType = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingServiceType)).BeginInit();
            this.bindingServiceType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceType)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupServiceType.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveServiceType
            // 
            this.saveServiceType.FileName = "Danh sách loại dịch vụ";
            this.saveServiceType.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCLose1);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.btnUpdateServiceType);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(270, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 181);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnCLose1
            // 
            this.btnCLose1.ActiveBorderThickness = 1;
            this.btnCLose1.ActiveCornerRadius = 20;
            this.btnCLose1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCLose1.ActiveForecolor = System.Drawing.Color.White;
            this.btnCLose1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCLose1.BackColor = System.Drawing.SystemColors.Control;
            this.btnCLose1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCLose1.BackgroundImage")));
            this.btnCLose1.ButtonText = "Đóng";
            this.btnCLose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCLose1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnCLose1.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCLose1.IdleBorderThickness = 1;
            this.btnCLose1.IdleCornerRadius = 20;
            this.btnCLose1.IdleFillColor = System.Drawing.Color.White;
            this.btnCLose1.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCLose1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCLose1.Location = new System.Drawing.Point(26, 121);
            this.btnCLose1.Margin = new System.Windows.Forms.Padding(6);
            this.btnCLose1.Name = "btnCLose1";
            this.btnCLose1.Size = new System.Drawing.Size(175, 40);
            this.btnCLose1.TabIndex = 25;
            this.btnCLose1.TabStop = false;
            this.btnCLose1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInsert
            // 
            this.btnInsert.ActiveBorderThickness = 1;
            this.btnInsert.ActiveCornerRadius = 20;
            this.btnInsert.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnInsert.ActiveForecolor = System.Drawing.Color.White;
            this.btnInsert.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnInsert.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.ButtonText = "Thêm";
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnInsert.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnInsert.IdleBorderThickness = 1;
            this.btnInsert.IdleCornerRadius = 20;
            this.btnInsert.IdleFillColor = System.Drawing.Color.White;
            this.btnInsert.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnInsert.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnInsert.Location = new System.Drawing.Point(26, 21);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(6);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(175, 40);
            this.btnInsert.TabIndex = 26;
            this.btnInsert.TabStop = false;
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateServiceType
            // 
            this.btnUpdateServiceType.ActiveBorderThickness = 1;
            this.btnUpdateServiceType.ActiveCornerRadius = 20;
            this.btnUpdateServiceType.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateServiceType.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdateServiceType.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateServiceType.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateServiceType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateServiceType.BackgroundImage")));
            this.btnUpdateServiceType.ButtonText = "Cập Nhật";
            this.btnUpdateServiceType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateServiceType.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnUpdateServiceType.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateServiceType.IdleBorderThickness = 1;
            this.btnUpdateServiceType.IdleCornerRadius = 20;
            this.btnUpdateServiceType.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdateServiceType.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnUpdateServiceType.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateServiceType.Location = new System.Drawing.Point(26, 71);
            this.btnUpdateServiceType.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateServiceType.Name = "btnUpdateServiceType";
            this.btnUpdateServiceType.Size = new System.Drawing.Size(175, 40);
            this.btnUpdateServiceType.TabIndex = 8;
            this.btnUpdateServiceType.TabStop = false;
            this.btnUpdateServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(270, 119);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(778, 14);
            this.bunifuSeparator1.TabIndex = 63;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelName.Location = new System.Drawing.Point(274, 82);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(329, 46);
            this.labelName.TabIndex = 62;
            this.labelName.Text = "Quản Lí Loại Dịch Vụ";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "Xuất";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.AutoSize = false;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(30, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.AutoSize = false;
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(30, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.AutoSize = false;
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(30, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.AutoSize = false;
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(30, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingServiceType
            // 
            this.bindingServiceType.AddNewItem = null;
            this.bindingServiceType.CountItem = this.bindingNavigatorCountItem;
            this.bindingServiceType.DeleteItem = null;
            this.bindingServiceType.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingServiceType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1});
            this.bindingServiceType.Location = new System.Drawing.Point(3, 30);
            this.bindingServiceType.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingServiceType.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingServiceType.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingServiceType.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingServiceType.Name = "bindingServiceType";
            this.bindingServiceType.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingServiceType.Size = new System.Drawing.Size(543, 25);
            this.bindingServiceType.TabIndex = 29;
            this.bindingServiceType.Text = "bindingNavigator1";
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "name";
            this.colName.FillWeight = 90F;
            this.colName.HeaderText = "Tên loại dịch vụ";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // dataGridViewServiceType
            // 
            this.dataGridViewServiceType.AllowUserToAddRows = false;
            this.dataGridViewServiceType.AllowUserToDeleteRows = false;
            this.dataGridViewServiceType.AllowUserToResizeRows = false;
            this.dataGridViewServiceType.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewServiceType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServiceType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewServiceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServiceType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewServiceType.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewServiceType.GridColor = System.Drawing.Color.White;
            this.dataGridViewServiceType.Location = new System.Drawing.Point(3, 55);
            this.dataGridViewServiceType.Name = "dataGridViewServiceType";
            this.dataGridViewServiceType.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServiceType.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewServiceType.RowHeadersVisible = false;
            this.dataGridViewServiceType.RowHeadersWidth = 51;
            this.dataGridViewServiceType.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewServiceType.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewServiceType.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewServiceType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServiceType.Size = new System.Drawing.Size(543, 425);
            this.dataGridViewServiceType.TabIndex = 28;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colID.DataPropertyName = "id";
            this.colID.HeaderText = "Mã loại dịch vụ";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 174;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txbSearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Location = new System.Drawing.Point(270, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 140);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveBorderThickness = 1;
            this.btnSearch.ActiveCornerRadius = 20;
            this.btnSearch.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearch.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.ButtonText = "Tìm Kiếm";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.White;
            this.btnSearch.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSearch.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(26, 85);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(175, 40);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbSearch
            // 
            this.txbSearch.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txbSearch.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txbSearch.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txbSearch.BorderThickness = 1;
            this.txbSearch.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbSearch.isPassword = false;
            this.txbSearch.Location = new System.Drawing.Point(26, 46);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbSearch.MaxLength = 32767;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(175, 29);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(26, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã/Tên loại dịch vụ:";
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.Red;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.Red;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Huỷ Tìm";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.Red;
            this.btnCancel.IdleLineColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(26, 85);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 40);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.TabStop = false;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1032, 81);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 58;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            // 
            // comboboxID
            // 
            this.comboboxID.FormattingEnabled = true;
            this.comboboxID.ItemHeight = 24;
            this.comboboxID.Location = new System.Drawing.Point(26, 48);
            this.comboboxID.Name = "comboboxID";
            this.comboboxID.Size = new System.Drawing.Size(175, 30);
            this.comboboxID.Style = MetroFramework.MetroColorStyle.Green;
            this.comboboxID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(26, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên loại dịch vụ:";
            // 
            // txbName
            // 
            this.txbName.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txbName.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txbName.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txbName.BorderThickness = 1;
            this.txbName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbName.isPassword = false;
            this.txbName.Location = new System.Drawing.Point(26, 106);
            this.txbName.Margin = new System.Windows.Forms.Padding(0);
            this.txbName.MaxLength = 32767;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(175, 29);
            this.txbName.TabIndex = 1;
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label16.ForeColor = System.Drawing.Color.SeaGreen;
            this.label16.Location = new System.Drawing.Point(26, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 25);
            this.label16.TabIndex = 22;
            this.label16.Text = "Mã loại dịch vụ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewServiceType);
            this.groupBox1.Controls.Add(this.bindingServiceType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(499, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 483);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Loại Dịch Vụ";
            // 
            // groupServiceType
            // 
            this.groupServiceType.Controls.Add(this.comboboxID);
            this.groupServiceType.Controls.Add(this.label1);
            this.groupServiceType.Controls.Add(this.txbName);
            this.groupServiceType.Controls.Add(this.label16);
            this.groupServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupServiceType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupServiceType.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupServiceType.Location = new System.Drawing.Point(270, 271);
            this.groupServiceType.Name = "groupServiceType";
            this.groupServiceType.Size = new System.Drawing.Size(223, 160);
            this.groupServiceType.TabIndex = 60;
            this.groupServiceType.TabStop = false;
            this.groupServiceType.Text = "Thông tin loại dịch vụ";
            // 
            // fServiceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 695);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupServiceType);
            this.Name = "fServiceType";
            this.Text = "fServiceType";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingServiceType)).EndInit();
            this.bindingServiceType.ResumeLayout(false);
            this.bindingServiceType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceType)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupServiceType.ResumeLayout(false);
            this.groupServiceType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveServiceType;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCLose1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnInsert;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdateServiceType;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.BindingNavigator bindingServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridView dataGridViewServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbSearch;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupServiceType;
        private MetroFramework.Controls.MetroComboBox comboboxID;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbName;
        private System.Windows.Forms.Label label16;
    }
}