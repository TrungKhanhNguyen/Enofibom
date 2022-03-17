
namespace Enofibom
{
    partial class TargetManage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtIMSI = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIMEI = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTargetName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMSISDN = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MSISDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRequest = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.txtIMSI);
            this.groupBox1.Controls.Add(this.txtIMEI);
            this.groupBox1.Controls.Add(this.txtTargetName);
            this.groupBox1.Controls.Add(this.txtMSISDN);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1216, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // chkActive
            // 
            this.chkActive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkActive.AutoSize = true;
            this.chkActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.chkActive.CheckedState.BorderRadius = 0;
            this.chkActive.CheckedState.BorderThickness = 0;
            this.chkActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(147)))), ((int)(((byte)(55)))));
            this.chkActive.Location = new System.Drawing.Point(1035, 51);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(67, 21);
            this.chkActive.TabIndex = 10;
            this.chkActive.Text = "Active";
            this.chkActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkActive.UncheckedState.BorderRadius = 2;
            this.chkActive.UncheckedState.BorderThickness = 0;
            this.chkActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtIMSI
            // 
            this.txtIMSI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIMSI.BorderRadius = 5;
            this.txtIMSI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIMSI.DefaultText = "";
            this.txtIMSI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIMSI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIMSI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIMSI.DisabledState.Parent = this.txtIMSI;
            this.txtIMSI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIMSI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIMSI.FocusedState.Parent = this.txtIMSI;
            this.txtIMSI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIMSI.ForeColor = System.Drawing.Color.Black;
            this.txtIMSI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIMSI.HoverState.Parent = this.txtIMSI;
            this.txtIMSI.Location = new System.Drawing.Point(794, 43);
            this.txtIMSI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIMSI.Name = "txtIMSI";
            this.txtIMSI.PasswordChar = '\0';
            this.txtIMSI.PlaceholderText = "IMSI";
            this.txtIMSI.SelectedText = "";
            this.txtIMSI.ShadowDecoration.Parent = this.txtIMSI;
            this.txtIMSI.Size = new System.Drawing.Size(218, 46);
            this.txtIMSI.TabIndex = 8;
            // 
            // txtIMEI
            // 
            this.txtIMEI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIMEI.BorderRadius = 5;
            this.txtIMEI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIMEI.DefaultText = "";
            this.txtIMEI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIMEI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIMEI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIMEI.DisabledState.Parent = this.txtIMEI;
            this.txtIMEI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIMEI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIMEI.FocusedState.Parent = this.txtIMEI;
            this.txtIMEI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIMEI.ForeColor = System.Drawing.Color.Black;
            this.txtIMEI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIMEI.HoverState.Parent = this.txtIMEI;
            this.txtIMEI.Location = new System.Drawing.Point(567, 43);
            this.txtIMEI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.PasswordChar = '\0';
            this.txtIMEI.PlaceholderText = "IMEI";
            this.txtIMEI.SelectedText = "";
            this.txtIMEI.ShadowDecoration.Parent = this.txtIMEI;
            this.txtIMEI.Size = new System.Drawing.Size(218, 46);
            this.txtIMEI.TabIndex = 7;
            // 
            // txtTargetName
            // 
            this.txtTargetName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTargetName.BorderRadius = 5;
            this.txtTargetName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTargetName.DefaultText = "";
            this.txtTargetName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTargetName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTargetName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTargetName.DisabledState.Parent = this.txtTargetName;
            this.txtTargetName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTargetName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTargetName.FocusedState.Parent = this.txtTargetName;
            this.txtTargetName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTargetName.ForeColor = System.Drawing.Color.Black;
            this.txtTargetName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTargetName.HoverState.Parent = this.txtTargetName;
            this.txtTargetName.Location = new System.Drawing.Point(340, 43);
            this.txtTargetName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTargetName.Name = "txtTargetName";
            this.txtTargetName.PasswordChar = '\0';
            this.txtTargetName.PlaceholderText = "Target name";
            this.txtTargetName.SelectedText = "";
            this.txtTargetName.ShadowDecoration.Parent = this.txtTargetName;
            this.txtTargetName.Size = new System.Drawing.Size(218, 46);
            this.txtTargetName.TabIndex = 6;
            // 
            // txtMSISDN
            // 
            this.txtMSISDN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMSISDN.BorderRadius = 5;
            this.txtMSISDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMSISDN.DefaultText = "";
            this.txtMSISDN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMSISDN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMSISDN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMSISDN.DisabledState.Parent = this.txtMSISDN;
            this.txtMSISDN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMSISDN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMSISDN.FocusedState.Parent = this.txtMSISDN;
            this.txtMSISDN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMSISDN.ForeColor = System.Drawing.Color.Black;
            this.txtMSISDN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMSISDN.HoverState.Parent = this.txtMSISDN;
            this.txtMSISDN.Location = new System.Drawing.Point(114, 43);
            this.txtMSISDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMSISDN.Name = "txtMSISDN";
            this.txtMSISDN.PasswordChar = '\0';
            this.txtMSISDN.PlaceholderText = "MSISDN";
            this.txtMSISDN.SelectedText = "";
            this.txtMSISDN.ShadowDecoration.Parent = this.txtMSISDN;
            this.txtMSISDN.Size = new System.Drawing.Size(218, 46);
            this.txtMSISDN.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BorderRadius = 3;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(163)))), ((int)(((byte)(15)))));
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::Enofibom.Properties.Resources.plus___48px;
            this.btnAdd.ImageSize = new System.Drawing.Size(16, 16);
            this.btnAdd.Location = new System.Drawing.Point(345, 134);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(134, 45);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BorderRadius = 3;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.Silver;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Image = global::Enofibom.Properties.Resources.broom_48px;
            this.btnClear.ImageSize = new System.Drawing.Size(16, 16);
            this.btnClear.Location = new System.Drawing.Point(772, 134);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(134, 45);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BorderRadius = 3;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(134)))), ((int)(((byte)(1)))));
            this.btnSave.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = global::Enofibom.Properties.Resources.Done_48px;
            this.btnSave.ImageSize = new System.Drawing.Size(16, 16);
            this.btnSave.Location = new System.Drawing.Point(488, 134);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(134, 45);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BorderRadius = 3;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::Enofibom.Properties.Resources.trash_48px;
            this.btnDelete.ImageSize = new System.Drawing.Size(16, 16);
            this.btnDelete.Location = new System.Drawing.Point(630, 134);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(134, 45);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSISDN,
            this.Id,
            this.IMEI,
            this.IMSI,
            this.TargetName,
            this.IsRequest,
            this.IsActive});
            this.dataGridView1.Location = new System.Drawing.Point(4, 188);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Size = new System.Drawing.Size(1216, 629);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MSISDN
            // 
            this.MSISDN.DataPropertyName = "MSISDN";
            this.MSISDN.HeaderText = "MSISDN";
            this.MSISDN.Name = "MSISDN";
            this.MSISDN.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IMEI
            // 
            this.IMEI.DataPropertyName = "IMEI";
            this.IMEI.HeaderText = "IMEI";
            this.IMEI.Name = "IMEI";
            this.IMEI.ReadOnly = true;
            // 
            // IMSI
            // 
            this.IMSI.DataPropertyName = "IMSI";
            this.IMSI.HeaderText = "IMSI";
            this.IMSI.Name = "IMSI";
            this.IMSI.ReadOnly = true;
            // 
            // TargetName
            // 
            this.TargetName.DataPropertyName = "TargetName";
            this.TargetName.HeaderText = "TargetName";
            this.TargetName.Name = "TargetName";
            this.TargetName.ReadOnly = true;
            // 
            // IsRequest
            // 
            this.IsRequest.DataPropertyName = "IsRequest";
            this.IsRequest.HeaderText = "IsRequest";
            this.IsRequest.Name = "IsRequest";
            this.IsRequest.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1106, 157);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Visible = false;
            // 
            // TargetManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TargetManage";
            this.Size = new System.Drawing.Size(1226, 822);
            this.Load += new System.EventHandler(this.TargetManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtIMSI;
        private Guna.UI2.WinForms.Guna2TextBox txtIMEI;
        private Guna.UI2.WinForms.Guna2TextBox txtTargetName;
        private Guna.UI2.WinForms.Guna2TextBox txtMSISDN;
        private Guna.UI2.WinForms.Guna2CheckBox chkActive;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSISDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsRequest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
    }
}
