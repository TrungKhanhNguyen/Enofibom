﻿namespace Enofibom
{
    partial class HistoryMap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mapControl = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkShowMap = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnClearHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchHistory = new Guna.UI2.WinForms.Guna2Button();
            this.txtCurrentValue = new System.Windows.Forms.Label();
            this.dpToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.dpFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.txtSearchHistory = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RequestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disappearedFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Radius = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSISDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl
            // 
            this.mapControl.Bearing = 0F;
            this.mapControl.CanDragMap = true;
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapControl.GrayScaleMode = false;
            this.mapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapControl.LevelsKeepInMemory = 5;
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mapControl.MarkersEnabled = true;
            this.mapControl.MaxZoom = 2;
            this.mapControl.MinZoom = 2;
            this.mapControl.MouseWheelZoomEnabled = true;
            this.mapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapControl.Name = "mapControl";
            this.mapControl.NegativeMode = false;
            this.mapControl.PolygonsEnabled = true;
            this.mapControl.RetryLoadTile = 0;
            this.mapControl.RoutesEnabled = true;
            this.mapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapControl.ShowTileGridLines = false;
            this.mapControl.Size = new System.Drawing.Size(964, 349);
            this.mapControl.TabIndex = 2;
            this.mapControl.Zoom = 0D;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.chkShowMap);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Controls.Add(this.btnClearHistory);
            this.groupBox3.Controls.Add(this.btnSearchHistory);
            this.groupBox3.Controls.Add(this.txtCurrentValue);
            this.groupBox3.Controls.Add(this.dpToDate);
            this.groupBox3.Controls.Add(this.lblCurrentValue);
            this.groupBox3.Controls.Add(this.dpFromDate);
            this.groupBox3.Controls.Add(this.lblToDate);
            this.groupBox3.Controls.Add(this.lblFromDate);
            this.groupBox3.Controls.Add(this.txtSearchHistory);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(619, 327);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "History Check";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Enofibom.Properties.Resources.icons8_help_16;
            this.pictureBox1.Location = new System.Drawing.Point(585, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // chkShowMap
            // 
            this.chkShowMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowMap.AutoSize = true;
            this.chkShowMap.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowMap.Location = new System.Drawing.Point(462, 27);
            this.chkShowMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkShowMap.Name = "chkShowMap";
            this.chkShowMap.Size = new System.Drawing.Size(116, 26);
            this.chkShowMap.TabIndex = 29;
            this.chkShowMap.Text = "Show map";
            this.chkShowMap.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(13, 226);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(597, 56);
            this.trackBar1.TabIndex = 28;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClearHistory.BorderRadius = 2;
            this.btnClearHistory.BorderThickness = 1;
            this.btnClearHistory.CheckedState.Parent = this.btnClearHistory;
            this.btnClearHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearHistory.CustomImages.Parent = this.btnClearHistory;
            this.btnClearHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClearHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnClearHistory.HoverState.Parent = this.btnClearHistory;
            this.btnClearHistory.Image = global::Enofibom.Properties.Resources.broom_48px_102;
            this.btnClearHistory.ImageSize = new System.Drawing.Size(16, 16);
            this.btnClearHistory.Location = new System.Drawing.Point(319, 153);
            this.btnClearHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.ShadowDecoration.Parent = this.btnClearHistory;
            this.btnClearHistory.Size = new System.Drawing.Size(135, 37);
            this.btnClearHistory.TabIndex = 27;
            this.btnClearHistory.Text = "Clear";
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // btnSearchHistory
            // 
            this.btnSearchHistory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchHistory.BorderRadius = 2;
            this.btnSearchHistory.CheckedState.Parent = this.btnSearchHistory;
            this.btnSearchHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchHistory.CustomImages.Parent = this.btnSearchHistory;
            this.btnSearchHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(91)))), ((int)(((byte)(121)))));
            this.btnSearchHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchHistory.ForeColor = System.Drawing.Color.White;
            this.btnSearchHistory.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.btnSearchHistory.HoverState.Parent = this.btnSearchHistory;
            this.btnSearchHistory.Image = global::Enofibom.Properties.Resources.search_48px;
            this.btnSearchHistory.Location = new System.Drawing.Point(171, 153);
            this.btnSearchHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchHistory.Name = "btnSearchHistory";
            this.btnSearchHistory.ShadowDecoration.Parent = this.btnSearchHistory;
            this.btnSearchHistory.Size = new System.Drawing.Size(135, 37);
            this.btnSearchHistory.TabIndex = 26;
            this.btnSearchHistory.Text = "Search";
            this.btnSearchHistory.Click += new System.EventHandler(this.btnSearchHistory_Click);
            // 
            // txtCurrentValue
            // 
            this.txtCurrentValue.AutoSize = true;
            this.txtCurrentValue.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentValue.Location = new System.Drawing.Point(147, 294);
            this.txtCurrentValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCurrentValue.Name = "txtCurrentValue";
            this.txtCurrentValue.Size = new System.Drawing.Size(169, 22);
            this.txtCurrentValue.TabIndex = 20;
            this.txtCurrentValue.Text = "12/12/2021 08:20";
            // 
            // dpToDate
            // 
            this.dpToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpToDate.BorderRadius = 3;
            this.dpToDate.BorderThickness = 1;
            this.dpToDate.Checked = true;
            this.dpToDate.CheckedState.Parent = this.dpToDate;
            this.dpToDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dpToDate.FillColor = System.Drawing.Color.White;
            this.dpToDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpToDate.HoverState.Parent = this.dpToDate;
            this.dpToDate.Location = new System.Drawing.Point(319, 108);
            this.dpToDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpToDate.Name = "dpToDate";
            this.dpToDate.ShadowDecoration.Parent = this.dpToDate;
            this.dpToDate.ShowUpDown = true;
            this.dpToDate.Size = new System.Drawing.Size(292, 37);
            this.dpToDate.TabIndex = 24;
            this.dpToDate.Value = new System.DateTime(2022, 1, 5, 23, 6, 47, 450);
            this.dpToDate.ValueChanged += new System.EventHandler(this.dpToDate_ValueChanged);
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentValue.Location = new System.Drawing.Point(9, 294);
            this.lblCurrentValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(127, 22);
            this.lblCurrentValue.TabIndex = 19;
            this.lblCurrentValue.Text = "Current Value:";
            // 
            // dpFromDate
            // 
            this.dpFromDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpFromDate.BorderRadius = 3;
            this.dpFromDate.BorderThickness = 1;
            this.dpFromDate.Checked = true;
            this.dpFromDate.CheckedState.Parent = this.dpFromDate;
            this.dpFromDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dpFromDate.FillColor = System.Drawing.Color.White;
            this.dpFromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFromDate.HoverState.Parent = this.dpFromDate;
            this.dpFromDate.Location = new System.Drawing.Point(13, 108);
            this.dpFromDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpFromDate.Name = "dpFromDate";
            this.dpFromDate.ShadowDecoration.Parent = this.dpFromDate;
            this.dpFromDate.ShowUpDown = true;
            this.dpFromDate.Size = new System.Drawing.Size(292, 37);
            this.dpFromDate.TabIndex = 23;
            this.dpFromDate.Value = new System.DateTime(2022, 1, 5, 23, 6, 47, 450);
            this.dpFromDate.ValueChanged += new System.EventHandler(this.dpFromDate_ValueChanged);
            // 
            // lblToDate
            // 
            this.lblToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(440, 202);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(169, 22);
            this.lblToDate.TabIndex = 18;
            this.lblToDate.Text = "12/01/2022 14:00";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(9, 202);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(169, 22);
            this.lblFromDate.TabIndex = 17;
            this.lblFromDate.Text = "12/12/2021 12:00";
            // 
            // txtSearchHistory
            // 
            this.txtSearchHistory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchHistory.BorderRadius = 2;
            this.txtSearchHistory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchHistory.DefaultText = "";
            this.txtSearchHistory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchHistory.DisabledState.Parent = this.txtSearchHistory;
            this.txtSearchHistory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchHistory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchHistory.FocusedState.Parent = this.txtSearchHistory;
            this.txtSearchHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchHistory.ForeColor = System.Drawing.Color.Black;
            this.txtSearchHistory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchHistory.HoverState.Parent = this.txtSearchHistory;
            this.txtSearchHistory.Location = new System.Drawing.Point(13, 60);
            this.txtSearchHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchHistory.Name = "txtSearchHistory";
            this.txtSearchHistory.PasswordChar = '\0';
            this.txtSearchHistory.PlaceholderText = "List phone numbers: 0924998787;748374847";
            this.txtSearchHistory.SelectedText = "";
            this.txtSearchHistory.ShadowDecoration.Parent = this.txtSearchHistory;
            this.txtSearchHistory.Size = new System.Drawing.Size(597, 37);
            this.txtSearchHistory.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRecords);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(964, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 623);
            this.panel1.TabIndex = 29;
            // 
            // txtRecords
            // 
            this.txtRecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRecords.AutoSize = true;
            this.txtRecords.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecords.Location = new System.Drawing.Point(105, 345);
            this.txtRecords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRecords.Name = "txtRecords";
            this.txtRecords.Size = new System.Drawing.Size(21, 22);
            this.txtRecords.TabIndex = 24;
            this.txtRecords.Text = "0";
            this.txtRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Records:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IMSI,
            this.MSISDN,
            this.CGI,
            this.TAC,
            this.Kind,
            this.Lat,
            this.Lon,
            this.Radius,
            this.PlanName,
            this.IMEI,
            this.locStamp,
            this.eventStamp,
            this.Presence,
            this.presentFlag,
            this.disappearedFlag,
            this.RequestTime});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 349);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Size = new System.Drawing.Size(964, 274);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // RequestTime
            // 
            this.RequestTime.DataPropertyName = "RequestTime";
            dataGridViewCellStyle22.Format = "dd/MM/yyyy HH:mm";
            this.RequestTime.DefaultCellStyle = dataGridViewCellStyle22;
            this.RequestTime.HeaderText = "RequestTime";
            this.RequestTime.MinimumWidth = 6;
            this.RequestTime.Name = "RequestTime";
            this.RequestTime.ReadOnly = true;
            // 
            // disappearedFlag
            // 
            this.disappearedFlag.DataPropertyName = "disappearedFlag";
            dataGridViewCellStyle21.Format = "dd/MM/yyyy HH:mm";
            this.disappearedFlag.DefaultCellStyle = dataGridViewCellStyle21;
            this.disappearedFlag.HeaderText = "disappearedFlag";
            this.disappearedFlag.MinimumWidth = 6;
            this.disappearedFlag.Name = "disappearedFlag";
            this.disappearedFlag.ReadOnly = true;
            // 
            // presentFlag
            // 
            this.presentFlag.DataPropertyName = "presentFlag";
            dataGridViewCellStyle20.Format = "dd/MM/yyyy HH:mm";
            this.presentFlag.DefaultCellStyle = dataGridViewCellStyle20;
            this.presentFlag.HeaderText = "presentFlag";
            this.presentFlag.MinimumWidth = 6;
            this.presentFlag.Name = "presentFlag";
            this.presentFlag.ReadOnly = true;
            // 
            // Presence
            // 
            this.Presence.DataPropertyName = "Presence";
            this.Presence.HeaderText = "Presence";
            this.Presence.MinimumWidth = 6;
            this.Presence.Name = "Presence";
            this.Presence.ReadOnly = true;
            // 
            // eventStamp
            // 
            this.eventStamp.DataPropertyName = "eventStamp";
            dataGridViewCellStyle19.Format = "dd/MM/yyyy HH:mm";
            this.eventStamp.DefaultCellStyle = dataGridViewCellStyle19;
            this.eventStamp.HeaderText = "eventStamp";
            this.eventStamp.MinimumWidth = 6;
            this.eventStamp.Name = "eventStamp";
            this.eventStamp.ReadOnly = true;
            // 
            // locStamp
            // 
            this.locStamp.DataPropertyName = "locStamp";
            dataGridViewCellStyle18.Format = "dd/MM/yyyy HH:mm";
            this.locStamp.DefaultCellStyle = dataGridViewCellStyle18;
            this.locStamp.HeaderText = "locStamp";
            this.locStamp.MinimumWidth = 6;
            this.locStamp.Name = "locStamp";
            this.locStamp.ReadOnly = true;
            // 
            // IMEI
            // 
            this.IMEI.DataPropertyName = "IMEI";
            this.IMEI.HeaderText = "IMEI";
            this.IMEI.MinimumWidth = 6;
            this.IMEI.Name = "IMEI";
            this.IMEI.ReadOnly = true;
            // 
            // PlanName
            // 
            this.PlanName.DataPropertyName = "PlanName";
            this.PlanName.HeaderText = "PlanName";
            this.PlanName.MinimumWidth = 6;
            this.PlanName.Name = "PlanName";
            this.PlanName.ReadOnly = true;
            // 
            // Radius
            // 
            this.Radius.DataPropertyName = "Radius";
            this.Radius.HeaderText = "Radius";
            this.Radius.MinimumWidth = 6;
            this.Radius.Name = "Radius";
            this.Radius.ReadOnly = true;
            // 
            // Lon
            // 
            this.Lon.DataPropertyName = "Lon";
            this.Lon.HeaderText = "Lon";
            this.Lon.MinimumWidth = 6;
            this.Lon.Name = "Lon";
            this.Lon.ReadOnly = true;
            // 
            // Lat
            // 
            this.Lat.DataPropertyName = "Lat";
            this.Lat.HeaderText = "Lat";
            this.Lat.MinimumWidth = 6;
            this.Lat.Name = "Lat";
            this.Lat.ReadOnly = true;
            // 
            // Kind
            // 
            this.Kind.DataPropertyName = "Kind";
            this.Kind.HeaderText = "Kind";
            this.Kind.MinimumWidth = 6;
            this.Kind.Name = "Kind";
            this.Kind.ReadOnly = true;
            // 
            // TAC
            // 
            this.TAC.DataPropertyName = "TAC";
            this.TAC.HeaderText = "TAC";
            this.TAC.MinimumWidth = 6;
            this.TAC.Name = "TAC";
            this.TAC.ReadOnly = true;
            // 
            // CGI
            // 
            this.CGI.DataPropertyName = "CGI";
            this.CGI.HeaderText = "CGI";
            this.CGI.MinimumWidth = 6;
            this.CGI.Name = "CGI";
            this.CGI.ReadOnly = true;
            // 
            // MSISDN
            // 
            this.MSISDN.DataPropertyName = "MSISDN";
            this.MSISDN.HeaderText = "MSISDN";
            this.MSISDN.MinimumWidth = 6;
            this.MSISDN.Name = "MSISDN";
            this.MSISDN.ReadOnly = true;
            // 
            // IMSI
            // 
            this.IMSI.DataPropertyName = "IMSI";
            this.IMSI.HeaderText = "IMSI";
            this.IMSI.MinimumWidth = 6;
            this.IMSI.Name = "IMSI";
            this.IMSI.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // HistoryMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HistoryMap";
            this.Size = new System.Drawing.Size(1591, 623);
            this.Load += new System.EventHandler(this.HistoryMap_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapControl;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2Button btnClearHistory;
        private Guna.UI2.WinForms.Guna2Button btnSearchHistory;
        private System.Windows.Forms.Label txtCurrentValue;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpToDate;
        private System.Windows.Forms.Label lblCurrentValue;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox chkShowMap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSISDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Radius;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn locStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presence;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn disappearedFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestTime;
    }
}
