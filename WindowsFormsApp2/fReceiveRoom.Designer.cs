﻿namespace WindowsFormsApp2
{
    partial class fReceiveRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReceiveRoom));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbRoom = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRoomType = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbRoomName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txbIDCard = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.txbFullName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.txbPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbAmountPeople = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbRoomTypeName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDateCheckOut = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txbDateCheckIn = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbIDBookRoom = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDetails = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridViewReceiveRoom = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnClose_ = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnReceiveRoom = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiveRoom)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1298, -5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 48;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            // 
            // cbRoom
            // 
            this.cbRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.ItemHeight = 24;
            this.cbRoom.Location = new System.Drawing.Point(36, 124);
            this.cbRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(269, 30);
            this.cbRoom.Style = MetroFramework.MetroColorStyle.Green;
            this.cbRoom.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(31, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Phòng:";
            // 
            // cbRoomType
            // 
            this.cbRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.ItemHeight = 24;
            this.cbRoomType.Location = new System.Drawing.Point(36, 58);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(269, 30);
            this.cbRoomType.Style = MetroFramework.MetroColorStyle.Green;
            this.cbRoomType.TabIndex = 52;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbRoom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbRoomType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(368, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(336, 185);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phòng trống";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(31, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Loại phòng:";
            // 
            // txbRoomName
            // 
            this.txbRoomName.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txbRoomName.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txbRoomName.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txbRoomName.BorderThickness = 1;
            this.txbRoomName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRoomName.Enabled = false;
            this.txbRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbRoomName.isPassword = false;
            this.txbRoomName.Location = new System.Drawing.Point(44, 202);
            this.txbRoomName.Margin = new System.Windows.Forms.Padding(5);
            this.txbRoomName.MaxLength = 32767;
            this.txbRoomName.Name = "txbRoomName";
            this.txbRoomName.Size = new System.Drawing.Size(271, 36);
            this.txbRoomName.TabIndex = 53;
            this.txbRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(41, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "Tên phòng:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txbRoomName);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txbIDCard);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.txbFullName);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.txbPrice);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txbAmountPeople);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txbRoomTypeName);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.txbDateCheckOut);
            this.groupBox6.Controls.Add(this.txbDateCheckIn);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox6.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox6.Location = new System.Drawing.Point(24, 244);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(680, 335);
            this.groupBox6.TabIndex = 52;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin nhận phòng";
            // 
            // txbIDCard
            // 
            this.txbIDCard.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txbIDCard.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txbIDCard.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txbIDCard.BorderThickness = 1;
            this.txbIDCard.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbIDCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDCard.Enabled = false;
            this.txbIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbIDCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbIDCard.isPassword = false;
            this.txbIDCard.Location = new System.Drawing.Point(44, 132);
            this.txbIDCard.Margin = new System.Windows.Forms.Padding(5);
            this.txbIDCard.MaxLength = 32767;
            this.txbIDCard.Name = "txbIDCard";
            this.txbIDCard.Size = new System.Drawing.Size(271, 36);
            this.txbIDCard.TabIndex = 50;
            this.txbIDCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SeaGreen;
            this.label15.Location = new System.Drawing.Point(41, 105);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 25);
            this.label15.TabIndex = 52;
            this.label15.Text = "Thẻ căn cước/ CMND:";
            // 
            // txbFullName
            // 
            this.txbFullName.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txbFullName.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txbFullName.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txbFullName.BorderThickness = 1;
            this.txbFullName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFullName.Enabled = false;
            this.txbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbFullName.isPassword = false;
            this.txbFullName.Location = new System.Drawing.Point(44, 66);
            this.txbFullName.Margin = new System.Windows.Forms.Padding(5);
            this.txbFullName.MaxLength = 32767;
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(271, 36);
            this.txbFullName.TabIndex = 49;
            this.txbFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SeaGreen;
            this.label16.Location = new System.Drawing.Point(41, 39);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 25);
            this.label16.TabIndex = 51;
            this.label16.Text = "Họ và tên:";
            // 
            // txbPrice
            // 
            this.txbPrice.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txbPrice.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txbPrice.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txbPrice.BorderThickness = 1;
            this.txbPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPrice.Enabled = false;
            this.txbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPrice.isPassword = false;
            this.txbPrice.Location = new System.Drawing.Point(365, 266);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txbPrice.MaxLength = 32767;
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(271, 36);
            this.txbPrice.TabIndex = 47;
            this.txbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SeaGreen;
            this.label10.Location = new System.Drawing.Point(360, 240);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 25);
            this.label10.TabIndex = 48;
            this.label10.Text = "Giá:";
            // 
            // txbAmountPeople
            // 
            this.txbAmountPeople.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txbAmountPeople.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txbAmountPeople.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txbAmountPeople.BorderThickness = 1;
            this.txbAmountPeople.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbAmountPeople.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAmountPeople.Enabled = false;
            this.txbAmountPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbAmountPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbAmountPeople.isPassword = false;
            this.txbAmountPeople.Location = new System.Drawing.Point(365, 199);
            this.txbAmountPeople.Margin = new System.Windows.Forms.Padding(5);
            this.txbAmountPeople.MaxLength = 32767;
            this.txbAmountPeople.Name = "txbAmountPeople";
            this.txbAmountPeople.Size = new System.Drawing.Size(271, 36);
            this.txbAmountPeople.TabIndex = 45;
            this.txbAmountPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(360, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 25);
            this.label8.TabIndex = 46;
            this.label8.Text = "Số lượng người tối đa:";
            // 
            // txbRoomTypeName
            // 
            this.txbRoomTypeName.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txbRoomTypeName.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txbRoomTypeName.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txbRoomTypeName.BorderThickness = 1;
            this.txbRoomTypeName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbRoomTypeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRoomTypeName.Enabled = false;
            this.txbRoomTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbRoomTypeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbRoomTypeName.isPassword = false;
            this.txbRoomTypeName.Location = new System.Drawing.Point(44, 266);
            this.txbRoomTypeName.Margin = new System.Windows.Forms.Padding(5);
            this.txbRoomTypeName.MaxLength = 32767;
            this.txbRoomTypeName.Name = "txbRoomTypeName";
            this.txbRoomTypeName.Size = new System.Drawing.Size(271, 36);
            this.txbRoomTypeName.TabIndex = 43;
            this.txbRoomTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(41, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Tên loại phòng:";
            // 
            // txbDateCheckOut
            // 
            this.txbDateCheckOut.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txbDateCheckOut.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txbDateCheckOut.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txbDateCheckOut.BorderThickness = 1;
            this.txbDateCheckOut.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbDateCheckOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDateCheckOut.Enabled = false;
            this.txbDateCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbDateCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDateCheckOut.isPassword = false;
            this.txbDateCheckOut.Location = new System.Drawing.Point(365, 133);
            this.txbDateCheckOut.Margin = new System.Windows.Forms.Padding(5);
            this.txbDateCheckOut.MaxLength = 32767;
            this.txbDateCheckOut.Name = "txbDateCheckOut";
            this.txbDateCheckOut.Size = new System.Drawing.Size(271, 36);
            this.txbDateCheckOut.TabIndex = 40;
            this.txbDateCheckOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbDateCheckIn
            // 
            this.txbDateCheckIn.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txbDateCheckIn.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txbDateCheckIn.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txbDateCheckIn.BorderThickness = 1;
            this.txbDateCheckIn.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbDateCheckIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDateCheckIn.Enabled = false;
            this.txbDateCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbDateCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbDateCheckIn.isPassword = false;
            this.txbDateCheckIn.Location = new System.Drawing.Point(365, 66);
            this.txbDateCheckIn.Margin = new System.Windows.Forms.Padding(5);
            this.txbDateCheckIn.MaxLength = 32767;
            this.txbDateCheckIn.Name = "txbDateCheckIn";
            this.txbDateCheckIn.Size = new System.Drawing.Size(271, 36);
            this.txbDateCheckIn.TabIndex = 36;
            this.txbDateCheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.SeaGreen;
            this.label19.Location = new System.Drawing.Point(360, 103);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 25);
            this.label19.TabIndex = 34;
            this.label19.Text = "Ngày trả:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.SeaGreen;
            this.label21.Location = new System.Drawing.Point(360, 37);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 25);
            this.label21.TabIndex = 32;
            this.label21.Text = "Ngày nhận:";
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
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.White;
            this.btnSearch.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSearch.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(33, 116);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(271, 49);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txbIDBookRoom);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Location = new System.Drawing.Point(24, 56);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(336, 185);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txbIDBookRoom
            // 
            this.txbIDBookRoom.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txbIDBookRoom.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txbIDBookRoom.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txbIDBookRoom.BorderThickness = 1;
            this.txbIDBookRoom.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txbIDBookRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDBookRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txbIDBookRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbIDBookRoom.isPassword = false;
            this.txbIDBookRoom.Location = new System.Drawing.Point(33, 63);
            this.txbIDBookRoom.Margin = new System.Windows.Forms.Padding(5);
            this.txbIDBookRoom.MaxLength = 32767;
            this.txbIDBookRoom.Name = "txbIDBookRoom";
            this.txbIDBookRoom.Size = new System.Drawing.Size(271, 36);
            this.txbIDBookRoom.TabIndex = 27;
            this.txbIDBookRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(28, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã đặt phòng:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(24, 42);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1293, 12);
            this.bunifuSeparator1.TabIndex = 49;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(26, -2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 46);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nhận Phòng";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox4.Location = new System.Drawing.Point(714, 56);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(604, 700);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách nhận phòng trong ngày";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDetails);
            this.panel2.Controls.Add(this.dataGridViewReceiveRoom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(4, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 665);
            this.panel2.TabIndex = 39;
            // 
            // btnDetails
            // 
            this.btnDetails.ActiveBorderThickness = 1;
            this.btnDetails.ActiveCornerRadius = 20;
            this.btnDetails.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDetails.ActiveForecolor = System.Drawing.Color.White;
            this.btnDetails.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDetails.BackColor = System.Drawing.SystemColors.Control;
            this.btnDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetails.BackgroundImage")));
            this.btnDetails.ButtonText = "Xem Chi Tiết";
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDetails.IdleBorderThickness = 1;
            this.btnDetails.IdleCornerRadius = 20;
            this.btnDetails.IdleFillColor = System.Drawing.Color.White;
            this.btnDetails.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDetails.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDetails.Location = new System.Drawing.Point(309, 607);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(271, 49);
            this.btnDetails.TabIndex = 48;
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewReceiveRoom
            // 
            this.dataGridViewReceiveRoom.AllowDrop = true;
            this.dataGridViewReceiveRoom.AllowUserToAddRows = false;
            this.dataGridViewReceiveRoom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.dataGridViewReceiveRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewReceiveRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReceiveRoom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewReceiveRoom.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReceiveRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReceiveRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewReceiveRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReceiveRoom.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewReceiveRoom.GridColor = System.Drawing.Color.White;
            this.dataGridViewReceiveRoom.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReceiveRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewReceiveRoom.Name = "dataGridViewReceiveRoom";
            this.dataGridViewReceiveRoom.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReceiveRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewReceiveRoom.RowHeadersVisible = false;
            this.dataGridViewReceiveRoom.RowHeadersWidth = 51;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReceiveRoom.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewReceiveRoom.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewReceiveRoom.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewReceiveRoom.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewReceiveRoom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewReceiveRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReceiveRoom.Size = new System.Drawing.Size(596, 596);
            this.dataGridViewReceiveRoom.StandardTab = true;
            this.dataGridViewReceiveRoom.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnClose_);
            this.groupBox5.Controls.Add(this.btnAddCustomer);
            this.groupBox5.Controls.Add(this.btnCancel);
            this.groupBox5.Controls.Add(this.btnReceiveRoom);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox5.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox5.Location = new System.Drawing.Point(22, 582);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(683, 174);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // btnClose_
            // 
            this.btnClose_.ActiveBorderThickness = 1;
            this.btnClose_.ActiveCornerRadius = 20;
            this.btnClose_.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnClose_.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose_.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose_.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose_.BackgroundImage")));
            this.btnClose_.ButtonText = "Đóng";
            this.btnClose_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose_.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose_.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose_.IdleBorderThickness = 1;
            this.btnClose_.IdleCornerRadius = 20;
            this.btnClose_.IdleFillColor = System.Drawing.Color.White;
            this.btnClose_.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClose_.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose_.Location = new System.Drawing.Point(365, 98);
            this.btnClose_.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClose_.Name = "btnClose_";
            this.btnClose_.Size = new System.Drawing.Size(271, 49);
            this.btnClose_.TabIndex = 48;
            this.btnClose_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.ActiveBorderThickness = 1;
            this.btnAddCustomer.ActiveCornerRadius = 20;
            this.btnAddCustomer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddCustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddCustomer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.BackgroundImage")));
            this.btnAddCustomer.ButtonText = "Thêm Khách Hàng";
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddCustomer.IdleBorderThickness = 1;
            this.btnAddCustomer.IdleCornerRadius = 20;
            this.btnAddCustomer.IdleFillColor = System.Drawing.Color.White;
            this.btnAddCustomer.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddCustomer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddCustomer.Location = new System.Drawing.Point(44, 37);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(271, 49);
            this.btnAddCustomer.TabIndex = 47;
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Hủy";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.Location = new System.Drawing.Point(44, 98);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(271, 49);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReceiveRoom
            // 
            this.btnReceiveRoom.ActiveBorderThickness = 1;
            this.btnReceiveRoom.ActiveCornerRadius = 20;
            this.btnReceiveRoom.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnReceiveRoom.ActiveForecolor = System.Drawing.Color.White;
            this.btnReceiveRoom.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnReceiveRoom.BackColor = System.Drawing.SystemColors.Control;
            this.btnReceiveRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReceiveRoom.BackgroundImage")));
            this.btnReceiveRoom.ButtonText = "Nhận Phòng";
            this.btnReceiveRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceiveRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveRoom.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReceiveRoom.IdleBorderThickness = 1;
            this.btnReceiveRoom.IdleCornerRadius = 20;
            this.btnReceiveRoom.IdleFillColor = System.Drawing.Color.White;
            this.btnReceiveRoom.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnReceiveRoom.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnReceiveRoom.Location = new System.Drawing.Point(365, 37);
            this.btnReceiveRoom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnReceiveRoom.Name = "btnReceiveRoom";
            this.btnReceiveRoom.Size = new System.Drawing.Size(271, 49);
            this.btnReceiveRoom.TabIndex = 45;
            this.btnReceiveRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fReceiveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 815);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Name = "fReceiveRoom";
            this.Text = "fReceiveRoom";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiveRoom)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private MetroFramework.Controls.MetroComboBox cbRoom;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cbRoomType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbRoomName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbIDCard;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbFullName;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPrice;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbAmountPeople;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbRoomTypeName;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbDateCheckOut;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbDateCheckIn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbIDBookRoom;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDetails;
        private System.Windows.Forms.DataGridView dataGridViewReceiveRoom;
        private System.Windows.Forms.GroupBox groupBox5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose_;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddCustomer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReceiveRoom;
    }
}