namespace Enofibom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mapControl = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnClearHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchHistory = new Guna.UI2.WinForms.Guna2Button();
            this.txtCurrentValue = new System.Windows.Forms.Label();
            this.dpToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dpFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.txtSearchHistory = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSISDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Radius = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapControl
            // 
            this.mapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapControl.Bearing = 0F;
            this.mapControl.CanDragMap = true;
            this.mapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapControl.GrayScaleMode = false;
            this.mapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapControl.LevelsKeepInMemory = 5;
            this.mapControl.Location = new System.Drawing.Point(5, 6);
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
            this.mapControl.Size = new System.Drawing.Size(709, 284);
            this.mapControl.TabIndex = 2;
            this.mapControl.Zoom = 0D;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Controls.Add(this.btnClearHistory);
            this.groupBox3.Controls.Add(this.btnSearchHistory);
            this.groupBox3.Controls.Add(this.txtCurrentValue);
            this.groupBox3.Controls.Add(this.dpToDate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dpFromDate);
            this.groupBox3.Controls.Add(this.lblToDate);
            this.groupBox3.Controls.Add(this.lblFromDate);
            this.groupBox3.Controls.Add(this.txtSearchHistory);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 241);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "History Check";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(10, 156);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(448, 45);
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
            this.btnClearHistory.Location = new System.Drawing.Point(239, 96);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.ShadowDecoration.Parent = this.btnClearHistory;
            this.btnClearHistory.Size = new System.Drawing.Size(101, 30);
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
            this.btnSearchHistory.Location = new System.Drawing.Point(128, 96);
            this.btnSearchHistory.Name = "btnSearchHistory";
            this.btnSearchHistory.ShadowDecoration.Parent = this.btnSearchHistory;
            this.btnSearchHistory.Size = new System.Drawing.Size(101, 30);
            this.btnSearchHistory.TabIndex = 26;
            this.btnSearchHistory.Text = "Search";
            this.btnSearchHistory.Click += new System.EventHandler(this.btnSearchHistory_Click);
            // 
            // txtCurrentValue
            // 
            this.txtCurrentValue.AutoSize = true;
            this.txtCurrentValue.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentValue.Location = new System.Drawing.Point(97, 211);
            this.txtCurrentValue.Name = "txtCurrentValue";
            this.txtCurrentValue.Size = new System.Drawing.Size(109, 15);
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
            this.dpToDate.Location = new System.Drawing.Point(239, 60);
            this.dpToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpToDate.Name = "dpToDate";
            this.dpToDate.ShadowDecoration.Parent = this.dpToDate;
            this.dpToDate.ShowUpDown = true;
            this.dpToDate.Size = new System.Drawing.Size(219, 30);
            this.dpToDate.TabIndex = 24;
            this.dpToDate.Value = new System.DateTime(2022, 1, 5, 23, 6, 47, 450);
            this.dpToDate.ValueChanged += new System.EventHandler(this.dpToDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Current Value:";
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
            this.dpFromDate.Location = new System.Drawing.Point(10, 60);
            this.dpFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpFromDate.Name = "dpFromDate";
            this.dpFromDate.ShadowDecoration.Parent = this.dpFromDate;
            this.dpFromDate.ShowUpDown = true;
            this.dpFromDate.Size = new System.Drawing.Size(219, 30);
            this.dpFromDate.TabIndex = 23;
            this.dpFromDate.Value = new System.DateTime(2022, 1, 5, 23, 6, 47, 450);
            this.dpFromDate.ValueChanged += new System.EventHandler(this.dpFromDate_ValueChanged);
            // 
            // lblToDate
            // 
            this.lblToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(383, 138);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(75, 15);
            this.lblToDate.TabIndex = 18;
            this.lblToDate.Text = "12/01/2022";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(7, 137);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(75, 15);
            this.lblFromDate.TabIndex = 17;
            this.lblFromDate.Text = "12/12/2021";
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
            this.txtSearchHistory.Location = new System.Drawing.Point(10, 24);
            this.txtSearchHistory.Name = "txtSearchHistory";
            this.txtSearchHistory.PasswordChar = '\0';
            this.txtSearchHistory.PlaceholderText = "List phone numbers: 0924998787;748374847";
            this.txtSearchHistory.SelectedText = "";
            this.txtSearchHistory.ShadowDecoration.Parent = this.txtSearchHistory;
            this.txtSearchHistory.Size = new System.Drawing.Size(448, 30);
            this.txtSearchHistory.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IMSI,
            this.MSISDN,
            this.CGI,
            this.Kind,
            this.Lat,
            this.Lon,
            this.Radius,
            this.PlanName,
            this.IMEI,
            this.locStamp,
            this.eventStamp});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(6, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Size = new System.Drawing.Size(1184, 207);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(723, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 506);
            this.panel1.TabIndex = 29;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IMSI
            // 
            this.IMSI.DataPropertyName = "IMSI";
            this.IMSI.HeaderText = "IMSI";
            this.IMSI.Name = "IMSI";
            this.IMSI.ReadOnly = true;
            // 
            // MSISDN
            // 
            this.MSISDN.DataPropertyName = "MSISDN";
            this.MSISDN.HeaderText = "MSISDN";
            this.MSISDN.Name = "MSISDN";
            this.MSISDN.ReadOnly = true;
            // 
            // CGI
            // 
            this.CGI.DataPropertyName = "CGI";
            this.CGI.HeaderText = "CGI";
            this.CGI.Name = "CGI";
            this.CGI.ReadOnly = true;
            // 
            // Kind
            // 
            this.Kind.DataPropertyName = "Kind";
            this.Kind.HeaderText = "Kind";
            this.Kind.Name = "Kind";
            this.Kind.ReadOnly = true;
            // 
            // Lat
            // 
            this.Lat.DataPropertyName = "Lat";
            this.Lat.HeaderText = "Lat";
            this.Lat.Name = "Lat";
            this.Lat.ReadOnly = true;
            // 
            // Lon
            // 
            this.Lon.DataPropertyName = "Lon";
            this.Lon.HeaderText = "Lon";
            this.Lon.Name = "Lon";
            this.Lon.ReadOnly = true;
            // 
            // Radius
            // 
            this.Radius.DataPropertyName = "Radius";
            this.Radius.HeaderText = "Radius";
            this.Radius.Name = "Radius";
            this.Radius.ReadOnly = true;
            // 
            // PlanName
            // 
            this.PlanName.DataPropertyName = "PlanName";
            this.PlanName.HeaderText = "PlaneName";
            this.PlanName.Name = "PlanName";
            this.PlanName.ReadOnly = true;
            // 
            // IMEI
            // 
            this.IMEI.DataPropertyName = "IMEI";
            this.IMEI.HeaderText = "IMEI";
            this.IMEI.Name = "IMEI";
            this.IMEI.ReadOnly = true;
            // 
            // locStamp
            // 
            this.locStamp.DataPropertyName = "locStamp";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm";
            this.locStamp.DefaultCellStyle = dataGridViewCellStyle2;
            this.locStamp.HeaderText = "locStamp";
            this.locStamp.Name = "locStamp";
            this.locStamp.ReadOnly = true;
            // 
            // eventStamp
            // 
            this.eventStamp.DataPropertyName = "eventStamp";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy HH:mm";
            this.eventStamp.DefaultCellStyle = dataGridViewCellStyle3;
            this.eventStamp.HeaderText = "eventStamp";
            this.eventStamp.Name = "eventStamp";
            this.eventStamp.ReadOnly = true;
            // 
            // HistoryMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mapControl);
            this.Name = "HistoryMap";
            this.Size = new System.Drawing.Size(1193, 506);
            this.Load += new System.EventHandler(this.HistoryMap_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapControl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnClearHistory;
        private Guna.UI2.WinForms.Guna2Button btnSearchHistory;
        private System.Windows.Forms.Label txtCurrentValue;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpToDate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSISDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Radius;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn locStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventStamp;
    }
}
