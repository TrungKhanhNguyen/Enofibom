
namespace Enofibom
{
    partial class MapUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mapControl = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCountLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericTimer = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkAuto = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.MSISDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchMSISDN = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIMEI = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEventStamp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlanName = new System.Windows.Forms.Label();
            this.txtLon = new System.Windows.Forms.Label();
            this.txtKind = new System.Windows.Forms.Label();
            this.txtMSISDN = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.Label();
            this.txtCGI = new System.Windows.Forms.Label();
            this.txtIMSI = new System.Windows.Forms.Label();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblLon = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblKind = new System.Windows.Forms.Label();
            this.lblMSISDN = new System.Windows.Forms.Label();
            this.lblCGI = new System.Windows.Forms.Label();
            this.lblIMSI = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLocationStamp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.mapControl.Location = new System.Drawing.Point(3, 3);
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
            this.mapControl.Size = new System.Drawing.Size(714, 782);
            this.mapControl.TabIndex = 1;
            this.mapControl.Zoom = 0D;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.lblCountLeft);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericTimer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkAuto);
            this.groupBox1.Controls.Add(this.dataGrid1);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearchMSISDN);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 285);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "...";
            // 
            // lblCountLeft
            // 
            this.lblCountLeft.AutoSize = true;
            this.lblCountLeft.Location = new System.Drawing.Point(5, 27);
            this.lblCountLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountLeft.Name = "lblCountLeft";
            this.lblCountLeft.Size = new System.Drawing.Size(0, 17);
            this.lblCountLeft.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "(m)";
            // 
            // numericTimer
            // 
            this.numericTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericTimer.BackColor = System.Drawing.Color.Transparent;
            this.numericTimer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericTimer.DisabledState.Parent = this.numericTimer;
            this.numericTimer.FocusedState.Parent = this.numericTimer;
            this.numericTimer.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTimer.ForeColor = System.Drawing.Color.Black;
            this.numericTimer.Location = new System.Drawing.Point(367, 19);
            this.numericTimer.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTimer.Name = "numericTimer";
            this.numericTimer.ShadowDecoration.Parent = this.numericTimer;
            this.numericTimer.Size = new System.Drawing.Size(55, 24);
            this.numericTimer.TabIndex = 23;
            this.numericTimer.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericTimer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tự động quét";
            // 
            // checkAuto
            // 
            this.checkAuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkAuto.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.checkAuto.CheckedState.BorderRadius = 2;
            this.checkAuto.CheckedState.BorderThickness = 0;
            this.checkAuto.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.checkAuto.CheckedState.Parent = this.checkAuto;
            this.checkAuto.Location = new System.Drawing.Point(248, 20);
            this.checkAuto.Name = "checkAuto";
            this.checkAuto.ShadowDecoration.Parent = this.checkAuto;
            this.checkAuto.Size = new System.Drawing.Size(22, 20);
            this.checkAuto.TabIndex = 21;
            this.checkAuto.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkAuto.UncheckedState.BorderRadius = 2;
            this.checkAuto.UncheckedState.BorderThickness = 0;
            this.checkAuto.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.checkAuto.UncheckedState.Parent = this.checkAuto;
            this.checkAuto.CheckedChanged += new System.EventHandler(this.checkAuto_CheckedChanged);
            // 
            // dataGrid1
            // 
            this.dataGrid1.AllowUserToAddRows = false;
            this.dataGrid1.AllowUserToDeleteRows = false;
            this.dataGrid1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSISDN,
            this.Lat,
            this.Lng});
            this.dataGrid1.Location = new System.Drawing.Point(6, 122);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowTemplate.Height = 30;
            this.dataGrid1.Size = new System.Drawing.Size(452, 153);
            this.dataGrid1.TabIndex = 20;
            this.dataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid1_CellContentClick);
            this.dataGrid1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid1_CellContentDoubleClick);
            // 
            // MSISDN
            // 
            this.MSISDN.DataPropertyName = "MSISDN";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSISDN.DefaultCellStyle = dataGridViewCellStyle2;
            this.MSISDN.FillWeight = 120F;
            this.MSISDN.HeaderText = "MSISDN";
            this.MSISDN.MinimumWidth = 100;
            this.MSISDN.Name = "MSISDN";
            this.MSISDN.ReadOnly = true;
            this.MSISDN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Lat
            // 
            this.Lat.DataPropertyName = "Lat";
            this.Lat.HeaderText = "Lat";
            this.Lat.Name = "Lat";
            this.Lat.ReadOnly = true;
            // 
            // Lng
            // 
            this.Lng.DataPropertyName = "Lon";
            this.Lng.HeaderText = "Lng";
            this.Lng.Name = "Lng";
            this.Lng.ReadOnly = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClear.BorderRadius = 2;
            this.btnClear.BorderThickness = 1;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Image = global::Enofibom.Properties.Resources.broom_48px_102;
            this.btnClear.ImageSize = new System.Drawing.Size(16, 16);
            this.btnClear.Location = new System.Drawing.Point(248, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(101, 30);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BorderRadius = 2;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::Enofibom.Properties.Resources.search_48px;
            this.btnSearch.Location = new System.Drawing.Point(141, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(101, 30);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchMSISDN
            // 
            this.txtSearchMSISDN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchMSISDN.BorderRadius = 2;
            this.txtSearchMSISDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchMSISDN.DefaultText = "";
            this.txtSearchMSISDN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchMSISDN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchMSISDN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchMSISDN.DisabledState.Parent = this.txtSearchMSISDN;
            this.txtSearchMSISDN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchMSISDN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMSISDN.FocusedState.Parent = this.txtSearchMSISDN;
            this.txtSearchMSISDN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMSISDN.ForeColor = System.Drawing.Color.Black;
            this.txtSearchMSISDN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMSISDN.HoverState.Parent = this.txtSearchMSISDN;
            this.txtSearchMSISDN.Location = new System.Drawing.Point(6, 50);
            this.txtSearchMSISDN.Name = "txtSearchMSISDN";
            this.txtSearchMSISDN.PasswordChar = '\0';
            this.txtSearchMSISDN.PlaceholderText = "List phone numbers: 0924998787;748374847";
            this.txtSearchMSISDN.SelectedText = "";
            this.txtSearchMSISDN.ShadowDecoration.Parent = this.txtSearchMSISDN;
            this.txtSearchMSISDN.Size = new System.Drawing.Size(452, 30);
            this.txtSearchMSISDN.TabIndex = 17;
            this.txtSearchMSISDN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchMSISDN_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.txtLocationStamp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtIMEI);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEventStamp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPlanName);
            this.groupBox2.Controls.Add(this.txtLon);
            this.groupBox2.Controls.Add(this.txtKind);
            this.groupBox2.Controls.Add(this.txtMSISDN);
            this.groupBox2.Controls.Add(this.txtRadius);
            this.groupBox2.Controls.Add(this.txtLat);
            this.groupBox2.Controls.Add(this.txtCGI);
            this.groupBox2.Controls.Add(this.txtIMSI);
            this.groupBox2.Controls.Add(this.lblPlanName);
            this.groupBox2.Controls.Add(this.lblRadius);
            this.groupBox2.Controls.Add(this.lblLon);
            this.groupBox2.Controls.Add(this.lblLat);
            this.groupBox2.Controls.Add(this.lblKind);
            this.groupBox2.Controls.Add(this.lblMSISDN);
            this.groupBox2.Controls.Add(this.lblCGI);
            this.groupBox2.Controls.Add(this.lblIMSI);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 491);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location Detail";
            // 
            // txtIMEI
            // 
            this.txtIMEI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIMEI.AutoSize = true;
            this.txtIMEI.Location = new System.Drawing.Point(107, 207);
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.Size = new System.Drawing.Size(0, 17);
            this.txtIMEI.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "IMEI:";
            // 
            // txtEventStamp
            // 
            this.txtEventStamp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEventStamp.AutoSize = true;
            this.txtEventStamp.Location = new System.Drawing.Point(108, 172);
            this.txtEventStamp.Name = "txtEventStamp";
            this.txtEventStamp.Size = new System.Drawing.Size(0, 17);
            this.txtEventStamp.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "EventStamp:";
            // 
            // txtPlanName
            // 
            this.txtPlanName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPlanName.AutoSize = true;
            this.txtPlanName.Location = new System.Drawing.Point(343, 137);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(0, 17);
            this.txtPlanName.TabIndex = 15;
            // 
            // txtLon
            // 
            this.txtLon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLon.AutoSize = true;
            this.txtLon.Location = new System.Drawing.Point(343, 103);
            this.txtLon.Name = "txtLon";
            this.txtLon.Size = new System.Drawing.Size(0, 17);
            this.txtLon.TabIndex = 14;
            // 
            // txtKind
            // 
            this.txtKind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKind.AutoSize = true;
            this.txtKind.Location = new System.Drawing.Point(343, 68);
            this.txtKind.Name = "txtKind";
            this.txtKind.Size = new System.Drawing.Size(0, 17);
            this.txtKind.TabIndex = 13;
            // 
            // txtMSISDN
            // 
            this.txtMSISDN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMSISDN.AutoSize = true;
            this.txtMSISDN.Location = new System.Drawing.Point(343, 34);
            this.txtMSISDN.Name = "txtMSISDN";
            this.txtMSISDN.Size = new System.Drawing.Size(0, 17);
            this.txtMSISDN.TabIndex = 12;
            // 
            // txtRadius
            // 
            this.txtRadius.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRadius.AutoSize = true;
            this.txtRadius.Location = new System.Drawing.Point(108, 137);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(0, 17);
            this.txtRadius.TabIndex = 11;
            // 
            // txtLat
            // 
            this.txtLat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLat.AutoSize = true;
            this.txtLat.Location = new System.Drawing.Point(108, 103);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(0, 17);
            this.txtLat.TabIndex = 10;
            // 
            // txtCGI
            // 
            this.txtCGI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCGI.AutoSize = true;
            this.txtCGI.Location = new System.Drawing.Point(108, 68);
            this.txtCGI.Name = "txtCGI";
            this.txtCGI.Size = new System.Drawing.Size(0, 17);
            this.txtCGI.TabIndex = 9;
            // 
            // txtIMSI
            // 
            this.txtIMSI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIMSI.AutoSize = true;
            this.txtIMSI.Location = new System.Drawing.Point(108, 34);
            this.txtIMSI.Name = "txtIMSI";
            this.txtIMSI.Size = new System.Drawing.Size(0, 17);
            this.txtIMSI.TabIndex = 8;
            // 
            // lblPlanName
            // 
            this.lblPlanName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanName.Location = new System.Drawing.Point(264, 137);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(73, 17);
            this.lblPlanName.TabIndex = 7;
            this.lblPlanName.Text = "PlanName:";
            // 
            // lblRadius
            // 
            this.lblRadius.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(49, 137);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(51, 17);
            this.lblRadius.TabIndex = 6;
            this.lblRadius.Text = "Radius:";
            // 
            // lblLon
            // 
            this.lblLon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLon.AutoSize = true;
            this.lblLon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLon.Location = new System.Drawing.Point(303, 103);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(33, 17);
            this.lblLon.TabIndex = 5;
            this.lblLon.Text = "Lon:";
            // 
            // lblLat
            // 
            this.lblLat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(72, 103);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(29, 17);
            this.lblLat.TabIndex = 4;
            this.lblLat.Text = "Lat:";
            // 
            // lblKind
            // 
            this.lblKind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKind.AutoSize = true;
            this.lblKind.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKind.Location = new System.Drawing.Point(299, 68);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(38, 17);
            this.lblKind.TabIndex = 3;
            this.lblKind.Text = "Kind:";
            // 
            // lblMSISDN
            // 
            this.lblMSISDN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMSISDN.AutoSize = true;
            this.lblMSISDN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSISDN.Location = new System.Drawing.Point(277, 34);
            this.lblMSISDN.Name = "lblMSISDN";
            this.lblMSISDN.Size = new System.Drawing.Size(60, 17);
            this.lblMSISDN.TabIndex = 2;
            this.lblMSISDN.Text = "MSISDN:";
            // 
            // lblCGI
            // 
            this.lblCGI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCGI.AutoSize = true;
            this.lblCGI.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCGI.Location = new System.Drawing.Point(68, 68);
            this.lblCGI.Name = "lblCGI";
            this.lblCGI.Size = new System.Drawing.Size(32, 17);
            this.lblCGI.TabIndex = 1;
            this.lblCGI.Text = "CGI:";
            // 
            // lblIMSI
            // 
            this.lblIMSI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIMSI.AutoSize = true;
            this.lblIMSI.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMSI.Location = new System.Drawing.Point(63, 34);
            this.lblIMSI.Name = "lblIMSI";
            this.lblIMSI.Size = new System.Drawing.Size(38, 17);
            this.lblIMSI.TabIndex = 0;
            this.lblIMSI.Text = "IMSI:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(723, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 788);
            this.panel1.TabIndex = 17;
            // 
            // txtLocationStamp
            // 
            this.txtLocationStamp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLocationStamp.AutoSize = true;
            this.txtLocationStamp.Location = new System.Drawing.Point(345, 172);
            this.txtLocationStamp.Name = "txtLocationStamp";
            this.txtLocationStamp.Size = new System.Drawing.Size(0, 17);
            this.txtLocationStamp.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "LocationStamp:";
            // 
            // MapUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mapControl);
            this.Name = "MapUserControl";
            this.Size = new System.Drawing.Size(1193, 788);
            this.Load += new System.EventHandler(this.MapUserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericTimer;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox checkAuto;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSISDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lng;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchMSISDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtPlanName;
        private System.Windows.Forms.Label txtLon;
        private System.Windows.Forms.Label txtKind;
        private System.Windows.Forms.Label txtMSISDN;
        private System.Windows.Forms.Label txtRadius;
        private System.Windows.Forms.Label txtLat;
        private System.Windows.Forms.Label txtCGI;
        private System.Windows.Forms.Label txtIMSI;
        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblLon;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.Label lblMSISDN;
        private System.Windows.Forms.Label lblCGI;
        private System.Windows.Forms.Label lblIMSI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCountLeft;
        private System.Windows.Forms.Label txtEventStamp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtIMEI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtLocationStamp;
        private System.Windows.Forms.Label label4;
    }
}
