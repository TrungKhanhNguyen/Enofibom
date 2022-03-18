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
            this.mapControl = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.trackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3.SuspendLayout();
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
            this.mapControl.Size = new System.Drawing.Size(709, 348);
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
            this.groupBox3.Size = new System.Drawing.Size(464, 212);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "History Check";
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
            this.txtCurrentValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCurrentValue.AutoSize = true;
            this.txtCurrentValue.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentValue.Location = new System.Drawing.Point(97, 183);
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
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 183);
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
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(383, 137);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 143);
            this.dataGridView1.TabIndex = 28;
            // 
            // trackBar1
            // 
            this.trackBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.trackBar1.HoverState.Parent = this.trackBar1;
            this.trackBar1.IndicateFocus = false;
            this.trackBar1.Location = new System.Drawing.Point(10, 155);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(448, 23);
            this.trackBar1.TabIndex = 29;
            this.trackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(91)))), ((int)(((byte)(121)))));
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapControl;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2TrackBar trackBar1;
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
    }
}
