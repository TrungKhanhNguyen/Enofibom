
using Enofibom.Properties;

namespace Enofibom
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mapControl = new GMap.NET.WindowsForms.GMapControl();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCountLeft = new System.Windows.Forms.Label();
            this.numericTimer = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkAuto = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchMSISDN = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearMark = new Guna.UI2.WinForms.Guna2Button();
            this.txtMarkLon = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddMark = new Guna.UI2.WinForms.Guna2Button();
            this.txtMarkLat = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtHistoryPlaneName = new System.Windows.Forms.Label();
            this.txtHistoryLon = new System.Windows.Forms.Label();
            this.txtHistoryKind = new System.Windows.Forms.Label();
            this.txtHistoryMSISDN = new System.Windows.Forms.Label();
            this.txtHistoryRadius = new System.Windows.Forms.Label();
            this.txtHistoryLat = new System.Windows.Forms.Label();
            this.txtHistoryCGI = new System.Windows.Forms.Label();
            this.txtHistoryIMSI = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridHistory = new System.Windows.Forms.DataGridView();
            this.btnClearHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchHistory = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchHistory = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHistoryReqTime = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSISDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).BeginInit();
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
            this.mapControl.Location = new System.Drawing.Point(-2, 0);
            this.mapControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.mapControl.Size = new System.Drawing.Size(1037, 1266);
            this.mapControl.TabIndex = 0;
            this.mapControl.Zoom = 0D;
            this.mapControl.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.mapControl_OnMarkerClick);
            this.mapControl.Load += new System.EventHandler(this.mapControl_Load);
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(210, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(850, 0);
            this.guna2TabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(644, 1061);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(91)))), ((int)(((byte)(121)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(91)))), ((int)(((byte)(121)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(91)))), ((int)(((byte)(121)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(91)))), ((int)(((byte)(121)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(210, 40);
            this.guna2TabControl1.TabIndex = 1;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(91)))), ((int)(((byte)(121)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCountLeft);
            this.tabPage1.Controls.Add(this.numericTimer);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkAuto);
            this.tabPage1.Controls.Add(this.dataGrid1);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.txtSearchMSISDN);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(636, 1013);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Online";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCountLeft
            // 
            this.lblCountLeft.AutoSize = true;
            this.lblCountLeft.Location = new System.Drawing.Point(8, 15);
            this.lblCountLeft.Name = "lblCountLeft";
            this.lblCountLeft.Size = new System.Drawing.Size(48, 15);
            this.lblCountLeft.TabIndex = 17;
            this.lblCountLeft.Text = "label20";
            // 
            // numericTimer
            // 
            this.numericTimer.BackColor = System.Drawing.Color.Transparent;
            this.numericTimer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericTimer.DisabledState.Parent = this.numericTimer;
            this.numericTimer.FocusedState.Parent = this.numericTimer;
            this.numericTimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericTimer.ForeColor = System.Drawing.Color.Black;
            this.numericTimer.Location = new System.Drawing.Point(508, 9);
            this.numericTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numericTimer.Size = new System.Drawing.Size(80, 37);
            this.numericTimer.TabIndex = 16;
            this.numericTimer.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericTimer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "(m)";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPlanName);
            this.groupBox1.Controls.Add(this.txtLon);
            this.groupBox1.Controls.Add(this.txtKind);
            this.groupBox1.Controls.Add(this.txtMSISDN);
            this.groupBox1.Controls.Add(this.txtRadius);
            this.groupBox1.Controls.Add(this.txtLat);
            this.groupBox1.Controls.Add(this.txtCGI);
            this.groupBox1.Controls.Add(this.txtIMSI);
            this.groupBox1.Controls.Add(this.lblPlanName);
            this.groupBox1.Controls.Add(this.lblRadius);
            this.groupBox1.Controls.Add(this.lblLon);
            this.groupBox1.Controls.Add(this.lblLat);
            this.groupBox1.Controls.Add(this.lblKind);
            this.groupBox1.Controls.Add(this.lblMSISDN);
            this.groupBox1.Controls.Add(this.lblCGI);
            this.groupBox1.Controls.Add(this.lblIMSI);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 505);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(632, 483);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Detail";
            // 
            // txtPlanName
            // 
            this.txtPlanName.AutoSize = true;
            this.txtPlanName.Location = new System.Drawing.Point(444, 234);
            this.txtPlanName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(0, 17);
            this.txtPlanName.TabIndex = 15;
            // 
            // txtLon
            // 
            this.txtLon.AutoSize = true;
            this.txtLon.Location = new System.Drawing.Point(442, 169);
            this.txtLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLon.Name = "txtLon";
            this.txtLon.Size = new System.Drawing.Size(0, 17);
            this.txtLon.TabIndex = 14;
            // 
            // txtKind
            // 
            this.txtKind.AutoSize = true;
            this.txtKind.Location = new System.Drawing.Point(441, 105);
            this.txtKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtKind.Name = "txtKind";
            this.txtKind.Size = new System.Drawing.Size(0, 17);
            this.txtKind.TabIndex = 13;
            // 
            // txtMSISDN
            // 
            this.txtMSISDN.AutoSize = true;
            this.txtMSISDN.Location = new System.Drawing.Point(441, 48);
            this.txtMSISDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMSISDN.Name = "txtMSISDN";
            this.txtMSISDN.Size = new System.Drawing.Size(0, 17);
            this.txtMSISDN.TabIndex = 12;
            // 
            // txtRadius
            // 
            this.txtRadius.AutoSize = true;
            this.txtRadius.Location = new System.Drawing.Point(129, 234);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(0, 17);
            this.txtRadius.TabIndex = 11;
            // 
            // txtLat
            // 
            this.txtLat.AutoSize = true;
            this.txtLat.Location = new System.Drawing.Point(129, 169);
            this.txtLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(0, 17);
            this.txtLat.TabIndex = 10;
            // 
            // txtCGI
            // 
            this.txtCGI.AutoSize = true;
            this.txtCGI.Location = new System.Drawing.Point(129, 105);
            this.txtCGI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCGI.Name = "txtCGI";
            this.txtCGI.Size = new System.Drawing.Size(0, 17);
            this.txtCGI.TabIndex = 9;
            // 
            // txtIMSI
            // 
            this.txtIMSI.AutoSize = true;
            this.txtIMSI.Location = new System.Drawing.Point(129, 48);
            this.txtIMSI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtIMSI.Name = "txtIMSI";
            this.txtIMSI.Size = new System.Drawing.Size(0, 17);
            this.txtIMSI.TabIndex = 8;
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanName.Location = new System.Drawing.Point(326, 234);
            this.lblPlanName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(73, 17);
            this.lblPlanName.TabIndex = 7;
            this.lblPlanName.Text = "PlanName:";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(40, 234);
            this.lblRadius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(51, 17);
            this.lblRadius.TabIndex = 6;
            this.lblRadius.Text = "Radius:";
            // 
            // lblLon
            // 
            this.lblLon.AutoSize = true;
            this.lblLon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLon.Location = new System.Drawing.Point(384, 169);
            this.lblLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(33, 17);
            this.lblLon.TabIndex = 5;
            this.lblLon.Text = "Lon:";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(75, 169);
            this.lblLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(29, 17);
            this.lblLat.TabIndex = 4;
            this.lblLat.Text = "Lat:";
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKind.Location = new System.Drawing.Point(375, 105);
            this.lblKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(38, 17);
            this.lblKind.TabIndex = 3;
            this.lblKind.Text = "Kind:";
            // 
            // lblMSISDN
            // 
            this.lblMSISDN.AutoSize = true;
            this.lblMSISDN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSISDN.Location = new System.Drawing.Point(342, 48);
            this.lblMSISDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSISDN.Name = "lblMSISDN";
            this.lblMSISDN.Size = new System.Drawing.Size(60, 17);
            this.lblMSISDN.TabIndex = 2;
            this.lblMSISDN.Text = "MSISDN:";
            // 
            // lblCGI
            // 
            this.lblCGI.AutoSize = true;
            this.lblCGI.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCGI.Location = new System.Drawing.Point(69, 105);
            this.lblCGI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCGI.Name = "lblCGI";
            this.lblCGI.Size = new System.Drawing.Size(32, 17);
            this.lblCGI.TabIndex = 1;
            this.lblCGI.Text = "CGI:";
            // 
            // lblIMSI
            // 
            this.lblIMSI.AutoSize = true;
            this.lblIMSI.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMSI.Location = new System.Drawing.Point(62, 48);
            this.lblIMSI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIMSI.Name = "lblIMSI";
            this.lblIMSI.Size = new System.Drawing.Size(38, 17);
            this.lblIMSI.TabIndex = 0;
            this.lblIMSI.Text = "IMSI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tự động quét";
            // 
            // checkAuto
            // 
            this.checkAuto.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.checkAuto.CheckedState.BorderRadius = 2;
            this.checkAuto.CheckedState.BorderThickness = 0;
            this.checkAuto.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.checkAuto.CheckedState.Parent = this.checkAuto;
            this.checkAuto.Location = new System.Drawing.Point(330, 12);
            this.checkAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkAuto.Name = "checkAuto";
            this.checkAuto.ShadowDecoration.Parent = this.checkAuto;
            this.checkAuto.Size = new System.Drawing.Size(30, 31);
            this.checkAuto.TabIndex = 12;
            this.checkAuto.Text = "ACb";
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
            this.dataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSISDN,
            this.Lat,
            this.Lng});
            this.dataGrid1.Location = new System.Drawing.Point(0, 171);
            this.dataGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowTemplate.Height = 30;
            this.dataGrid1.Size = new System.Drawing.Size(632, 325);
            this.dataGrid1.TabIndex = 11;
            this.dataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid1_CellContentClick);
            this.dataGrid1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid1_CellContentDoubleClick);
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClear.BorderRadius = 2;
            this.btnClear.BorderThickness = 1;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.DisabledState.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.ImageSize = new System.Drawing.Size(16, 16);
            this.btnClear.Location = new System.Drawing.Point(334, 115);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(183, 46);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 2;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.DisabledState.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(142, 115);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(183, 46);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchMSISDN
            // 
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
            this.txtSearchMSISDN.Location = new System.Drawing.Point(0, 60);
            this.txtSearchMSISDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchMSISDN.Name = "txtSearchMSISDN";
            this.txtSearchMSISDN.PasswordChar = '\0';
            this.txtSearchMSISDN.PlaceholderText = "List phone numbers: 0924998787,748374847";
            this.txtSearchMSISDN.SelectedText = "";
            this.txtSearchMSISDN.ShadowDecoration.Parent = this.txtSearchMSISDN;
            this.txtSearchMSISDN.Size = new System.Drawing.Size(632, 46);
            this.txtSearchMSISDN.TabIndex = 8;
            this.txtSearchMSISDN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchMSISDN_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridHistory);
            this.tabPage2.Controls.Add(this.btnClearHistory);
            this.tabPage2.Controls.Add(this.btnSearchHistory);
            this.tabPage2.Controls.Add(this.txtSearchHistory);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(636, 1013);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Offline";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnClearMark);
            this.groupBox3.Controls.Add(this.txtMarkLon);
            this.groupBox3.Controls.Add(this.btnAddMark);
            this.groupBox3.Controls.Add(this.txtMarkLat);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 812);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(632, 191);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Location Manual Detect ";
            // 
            // btnClearMark
            // 
            this.btnClearMark.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClearMark.BorderRadius = 2;
            this.btnClearMark.BorderThickness = 1;
            this.btnClearMark.CheckedState.Parent = this.btnClearMark;
            this.btnClearMark.CustomImages.Parent = this.btnClearMark;
            this.btnClearMark.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearMark.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearMark.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearMark.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearMark.DisabledState.Parent = this.btnClearMark;
            this.btnClearMark.Enabled = false;
            this.btnClearMark.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClearMark.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnClearMark.HoverState.Parent = this.btnClearMark;
            this.btnClearMark.ImageSize = new System.Drawing.Size(16, 16);
            this.btnClearMark.Location = new System.Drawing.Point(328, 117);
            this.btnClearMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearMark.Name = "btnClearMark";
            this.btnClearMark.ShadowDecoration.Parent = this.btnClearMark;
            this.btnClearMark.Size = new System.Drawing.Size(183, 46);
            this.btnClearMark.TabIndex = 22;
            this.btnClearMark.Text = "Clear";
            this.btnClearMark.Click += new System.EventHandler(this.btnClearMark_Click);
            // 
            // txtMarkLon
            // 
            this.txtMarkLon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarkLon.DefaultText = "";
            this.txtMarkLon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMarkLon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMarkLon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMarkLon.DisabledState.Parent = this.txtMarkLon;
            this.txtMarkLon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMarkLon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMarkLon.FocusedState.Parent = this.txtMarkLon;
            this.txtMarkLon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarkLon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMarkLon.HoverState.Parent = this.txtMarkLon;
            this.txtMarkLon.Location = new System.Drawing.Point(328, 45);
            this.txtMarkLon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMarkLon.Name = "txtMarkLon";
            this.txtMarkLon.PasswordChar = '\0';
            this.txtMarkLon.PlaceholderText = "Longitude";
            this.txtMarkLon.SelectedText = "";
            this.txtMarkLon.ShadowDecoration.Parent = this.txtMarkLon;
            this.txtMarkLon.Size = new System.Drawing.Size(298, 52);
            this.txtMarkLon.TabIndex = 1;
            // 
            // btnAddMark
            // 
            this.btnAddMark.BorderRadius = 2;
            this.btnAddMark.CheckedState.Parent = this.btnAddMark;
            this.btnAddMark.CustomImages.Parent = this.btnAddMark;
            this.btnAddMark.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMark.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMark.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMark.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMark.DisabledState.Parent = this.btnAddMark;
            this.btnAddMark.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.btnAddMark.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMark.ForeColor = System.Drawing.Color.White;
            this.btnAddMark.HoverState.Parent = this.btnAddMark;
            this.btnAddMark.Location = new System.Drawing.Point(130, 117);
            this.btnAddMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMark.Name = "btnAddMark";
            this.btnAddMark.ShadowDecoration.Parent = this.btnAddMark;
            this.btnAddMark.Size = new System.Drawing.Size(183, 46);
            this.btnAddMark.TabIndex = 21;
            this.btnAddMark.Text = "Add";
            this.btnAddMark.Click += new System.EventHandler(this.btnAddMark_Click);
            // 
            // txtMarkLat
            // 
            this.txtMarkLat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarkLat.DefaultText = "";
            this.txtMarkLat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMarkLat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMarkLat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMarkLat.DisabledState.Parent = this.txtMarkLat;
            this.txtMarkLat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMarkLat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMarkLat.FocusedState.Parent = this.txtMarkLat;
            this.txtMarkLat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarkLat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMarkLat.HoverState.Parent = this.txtMarkLat;
            this.txtMarkLat.Location = new System.Drawing.Point(15, 45);
            this.txtMarkLat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMarkLat.Name = "txtMarkLat";
            this.txtMarkLat.PasswordChar = '\0';
            this.txtMarkLat.PlaceholderText = "Latitude";
            this.txtMarkLat.SelectedText = "";
            this.txtMarkLat.ShadowDecoration.Parent = this.txtMarkLat;
            this.txtMarkLat.Size = new System.Drawing.Size(298, 52);
            this.txtMarkLat.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtHistoryReqTime);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtHistoryPlaneName);
            this.groupBox2.Controls.Add(this.txtHistoryLon);
            this.groupBox2.Controls.Add(this.txtHistoryKind);
            this.groupBox2.Controls.Add(this.txtHistoryMSISDN);
            this.groupBox2.Controls.Add(this.txtHistoryRadius);
            this.groupBox2.Controls.Add(this.txtHistoryLat);
            this.groupBox2.Controls.Add(this.txtHistoryCGI);
            this.groupBox2.Controls.Add(this.txtHistoryIMSI);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 436);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(638, 366);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location Detail";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 295);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 17);
            this.label19.TabIndex = 16;
            this.label19.Text = "Req Time:";
            // 
            // txtHistoryPlaneName
            // 
            this.txtHistoryPlaneName.AutoSize = true;
            this.txtHistoryPlaneName.Location = new System.Drawing.Point(444, 234);
            this.txtHistoryPlaneName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHistoryPlaneName.Name = "txtHistoryPlaneName";
            this.txtHistoryPlaneName.Size = new System.Drawing.Size(0, 17);
            this.txtHistoryPlaneName.TabIndex = 15;
            // 
            // txtHistoryLon
            // 
            this.txtHistoryLon.AutoSize = true;
            this.txtHistoryLon.Location = new System.Drawing.Point(442, 169);
            this.txtHistoryLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHistoryLon.Name = "txtHistoryLon";
            this.txtHistoryLon.Size = new System.Drawing.Size(0, 17);
            this.txtHistoryLon.TabIndex = 14;
            // 
            // txtHistoryKind
            // 
            this.txtHistoryKind.AutoSize = true;
            this.txtHistoryKind.Location = new System.Drawing.Point(441, 105);
            this.txtHistoryKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHistoryKind.Name = "txtHistoryKind";
            this.txtHistoryKind.Size = new System.Drawing.Size(0, 17);
            this.txtHistoryKind.TabIndex = 13;
            // 
            // txtHistoryMSISDN
            // 
            this.txtHistoryMSISDN.AutoSize = true;
            this.txtHistoryMSISDN.Location = new System.Drawing.Point(441, 48);
            this.txtHistoryMSISDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHistoryMSISDN.Name = "txtHistoryMSISDN";
            this.txtHistoryMSISDN.Size = new System.Drawing.Size(0, 17);
            this.txtHistoryMSISDN.TabIndex = 12;
            // 
            // txtHistoryRadius
            // 
            this.txtHistoryRadius.AutoSize = true;
            this.txtHistoryRadius.Location = new System.Drawing.Point(129, 234);
            this.txtHistoryRadius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHistoryRadius.Name = "txtHistoryRadius";
            this.txtHistoryRadius.Size = new System.Drawing.Size(0, 17);
            this.txtHistoryRadius.TabIndex = 11;
            // 
            // txtHistoryLat
            // 
            this.txtHistoryLat.AutoSize = true;
            this.txtHistoryLat.Location = new System.Drawing.Point(129, 169);
            this.txtHistoryLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHistoryLat.Name = "txtHistoryLat";
            this.txtHistoryLat.Size = new System.Drawing.Size(0, 17);
            this.txtHistoryLat.TabIndex = 10;
            // 
            // txtHistoryCGI
            // 
            this.txtHistoryCGI.AutoSize = true;
            this.txtHistoryCGI.Location = new System.Drawing.Point(129, 105);
            this.txtHistoryCGI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHistoryCGI.Name = "txtHistoryCGI";
            this.txtHistoryCGI.Size = new System.Drawing.Size(0, 17);
            this.txtHistoryCGI.TabIndex = 9;
            // 
            // txtHistoryIMSI
            // 
            this.txtHistoryIMSI.AutoSize = true;
            this.txtHistoryIMSI.Location = new System.Drawing.Point(129, 48);
            this.txtHistoryIMSI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHistoryIMSI.Name = "txtHistoryIMSI";
            this.txtHistoryIMSI.Size = new System.Drawing.Size(0, 17);
            this.txtHistoryIMSI.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(326, 234);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "PlanName:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 234);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Radius:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(384, 169);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Lon:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(75, 169);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Lat:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(375, 105);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Kind:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(342, 48);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "MSISDN:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(69, 105);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "CGI:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(62, 48);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "IMSI:";
            // 
            // dataGridHistory
            // 
            this.dataGridHistory.AllowUserToAddRows = false;
            this.dataGridHistory.AllowUserToDeleteRows = false;
            this.dataGridHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHistory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridHistory.Location = new System.Drawing.Point(0, 171);
            this.dataGridHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridHistory.Name = "dataGridHistory";
            this.dataGridHistory.ReadOnly = true;
            this.dataGridHistory.RowTemplate.Height = 30;
            this.dataGridHistory.Size = new System.Drawing.Size(632, 255);
            this.dataGridHistory.TabIndex = 18;
            this.dataGridHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHistory_CellContentClick);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClearHistory.BorderRadius = 2;
            this.btnClearHistory.BorderThickness = 1;
            this.btnClearHistory.CheckedState.Parent = this.btnClearHistory;
            this.btnClearHistory.CustomImages.Parent = this.btnClearHistory;
            this.btnClearHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearHistory.DisabledState.Parent = this.btnClearHistory;
            this.btnClearHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClearHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnClearHistory.HoverState.Parent = this.btnClearHistory;
            this.btnClearHistory.ImageSize = new System.Drawing.Size(16, 16);
            this.btnClearHistory.Location = new System.Drawing.Point(334, 115);
            this.btnClearHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.ShadowDecoration.Parent = this.btnClearHistory;
            this.btnClearHistory.Size = new System.Drawing.Size(183, 46);
            this.btnClearHistory.TabIndex = 17;
            this.btnClearHistory.Text = "Clear";
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // btnSearchHistory
            // 
            this.btnSearchHistory.BorderRadius = 2;
            this.btnSearchHistory.CheckedState.Parent = this.btnSearchHistory;
            this.btnSearchHistory.CustomImages.Parent = this.btnSearchHistory;
            this.btnSearchHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchHistory.DisabledState.Parent = this.btnSearchHistory;
            this.btnSearchHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.btnSearchHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchHistory.ForeColor = System.Drawing.Color.White;
            this.btnSearchHistory.HoverState.Parent = this.btnSearchHistory;
            this.btnSearchHistory.Location = new System.Drawing.Point(142, 115);
            this.btnSearchHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchHistory.Name = "btnSearchHistory";
            this.btnSearchHistory.ShadowDecoration.Parent = this.btnSearchHistory;
            this.btnSearchHistory.Size = new System.Drawing.Size(183, 46);
            this.btnSearchHistory.TabIndex = 16;
            this.btnSearchHistory.Text = "Search";
            this.btnSearchHistory.Click += new System.EventHandler(this.btnSearchHistory_Click);
            // 
            // txtSearchHistory
            // 
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
            this.txtSearchHistory.Location = new System.Drawing.Point(0, 60);
            this.txtSearchHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchHistory.Name = "txtSearchHistory";
            this.txtSearchHistory.PasswordChar = '\0';
            this.txtSearchHistory.PlaceholderText = "List phone numbers: 0924998787,748374847";
            this.txtSearchHistory.SelectedText = "";
            this.txtSearchHistory.ShadowDecoration.Parent = this.txtSearchHistory;
            this.txtSearchHistory.Size = new System.Drawing.Size(632, 46);
            this.txtSearchHistory.TabIndex = 15;
            // 
            // txtHistoryReqTime
            // 
            this.txtHistoryReqTime.AutoSize = true;
            this.txtHistoryReqTime.Location = new System.Drawing.Point(121, 295);
            this.txtHistoryReqTime.Name = "txtHistoryReqTime";
            this.txtHistoryReqTime.Size = new System.Drawing.Size(0, 17);
            this.txtHistoryReqTime.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MSISDN";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.FillWeight = 120F;
            this.dataGridViewTextBoxColumn1.HeaderText = "MSISDN";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Lat";
            this.dataGridViewTextBoxColumn2.HeaderText = "Lat";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Lon";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // MSISDN
            // 
            this.MSISDN.DataPropertyName = "MSISDN";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSISDN.DefaultCellStyle = dataGridViewCellStyle1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1494, 1061);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.mapControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapControl;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchMSISDN;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.DataGridView dataGrid1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox checkAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblLon;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.Label lblMSISDN;
        private System.Windows.Forms.Label lblCGI;
        private System.Windows.Forms.Label lblIMSI;
        private System.Windows.Forms.Label txtPlanName;
        private System.Windows.Forms.Label txtLon;
        private System.Windows.Forms.Label txtKind;
        private System.Windows.Forms.Label txtMSISDN;
        private System.Windows.Forms.Label txtRadius;
        private System.Windows.Forms.Label txtLat;
        private System.Windows.Forms.Label txtCGI;
        private System.Windows.Forms.Label txtIMSI;
        private System.Windows.Forms.Label lblPlanName;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label txtHistoryPlaneName;
        private System.Windows.Forms.Label txtHistoryLon;
        private System.Windows.Forms.Label txtHistoryKind;
        private System.Windows.Forms.Label txtHistoryMSISDN;
        private System.Windows.Forms.Label txtHistoryRadius;
        private System.Windows.Forms.Label txtHistoryLat;
        private System.Windows.Forms.Label txtHistoryCGI;
        private System.Windows.Forms.Label txtHistoryIMSI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridHistory;
        private Guna.UI2.WinForms.Guna2Button btnClearHistory;
        private Guna.UI2.WinForms.Guna2Button btnSearchHistory;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchHistory;
        private Guna.UI2.WinForms.Guna2TextBox txtMarkLon;
        private Guna.UI2.WinForms.Guna2TextBox txtMarkLat;
        private Guna.UI2.WinForms.Guna2Button btnClearMark;
        private Guna.UI2.WinForms.Guna2Button btnAddMark;
        private System.Windows.Forms.Label lblCountLeft;
        private System.Windows.Forms.Label txtHistoryReqTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSISDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lng;
    }
}

