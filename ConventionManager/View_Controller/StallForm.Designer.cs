namespace ConventionManager.View_Controller
{
    partial class StallForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StallForm));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocationCode = new System.Windows.Forms.TextBox();
            this.lblLocationCode = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtResources = new System.Windows.Forms.TextBox();
            this.lblResources = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtStallType = new System.Windows.Forms.TextBox();
            this.lblStallType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvStall = new System.Windows.Forms.DataGridView();
            this.StallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StallLocationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StallCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StallResources = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StallStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StallEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StallType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exhibitors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStall)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(173, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtLocationCode
            // 
            this.txtLocationCode.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationCode.Location = new System.Drawing.Point(173, 120);
            this.txtLocationCode.Name = "txtLocationCode";
            this.txtLocationCode.Size = new System.Drawing.Size(146, 26);
            this.txtLocationCode.TabIndex = 3;
            // 
            // lblLocationCode
            // 
            this.lblLocationCode.AutoSize = true;
            this.lblLocationCode.BackColor = System.Drawing.Color.Transparent;
            this.lblLocationCode.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationCode.Location = new System.Drawing.Point(13, 127);
            this.lblLocationCode.Name = "lblLocationCode";
            this.lblLocationCode.Size = new System.Drawing.Size(113, 21);
            this.lblLocationCode.TabIndex = 2;
            this.lblLocationCode.Text = "Location Code";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(173, 181);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(146, 26);
            this.txtCapacity.TabIndex = 5;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.BackColor = System.Drawing.Color.Transparent;
            this.lblCapacity.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(13, 190);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(72, 21);
            this.lblCapacity.TabIndex = 4;
            this.lblCapacity.Text = "Capacity";
            // 
            // txtResources
            // 
            this.txtResources.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResources.Location = new System.Drawing.Point(172, 244);
            this.txtResources.Name = "txtResources";
            this.txtResources.Size = new System.Drawing.Size(146, 26);
            this.txtResources.TabIndex = 7;
            // 
            // lblResources
            // 
            this.lblResources.AutoSize = true;
            this.lblResources.BackColor = System.Drawing.Color.Transparent;
            this.lblResources.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResources.Location = new System.Drawing.Point(12, 249);
            this.lblResources.Name = "lblResources";
            this.lblResources.Size = new System.Drawing.Size(87, 21);
            this.lblResources.TabIndex = 6;
            this.lblResources.Text = "Resources";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(355, 62);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(84, 21);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(356, 122);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(75, 21);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End Date";
            // 
            // txtStallType
            // 
            this.txtStallType.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStallType.Location = new System.Drawing.Point(460, 181);
            this.txtStallType.Name = "txtStallType";
            this.txtStallType.Size = new System.Drawing.Size(211, 26);
            this.txtStallType.TabIndex = 13;
            // 
            // lblStallType
            // 
            this.lblStallType.AutoSize = true;
            this.lblStallType.BackColor = System.Drawing.Color.Transparent;
            this.lblStallType.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStallType.Location = new System.Drawing.Point(356, 190);
            this.lblStallType.Name = "lblStallType";
            this.lblStallType.Size = new System.Drawing.Size(75, 21);
            this.lblStallType.TabIndex = 12;
            this.lblStallType.Text = "StallType";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(460, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 44);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvStall
            // 
            this.dgvStall.AllowUserToAddRows = false;
            this.dgvStall.AllowUserToDeleteRows = false;
            this.dgvStall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StallId,
            this.StallName,
            this.StallLocationCode,
            this.StallCapacity,
            this.StallResources,
            this.StallStartDate,
            this.StallEndDate,
            this.StallType,
            this.Exhibitors,
            this.Edit,
            this.Delete});
            this.dgvStall.Location = new System.Drawing.Point(13, 333);
            this.dgvStall.Name = "dgvStall";
            this.dgvStall.ReadOnly = true;
            this.dgvStall.Size = new System.Drawing.Size(685, 235);
            this.dgvStall.TabIndex = 15;
            this.dgvStall.Click += new System.EventHandler(this.dgvStall_Click);
            // 
            // StallId
            // 
            this.StallId.DataPropertyName = "StallId";
            this.StallId.HeaderText = "Id";
            this.StallId.Name = "StallId";
            this.StallId.ReadOnly = true;
            // 
            // StallName
            // 
            this.StallName.DataPropertyName = "StallName";
            this.StallName.HeaderText = "Name";
            this.StallName.Name = "StallName";
            this.StallName.ReadOnly = true;
            // 
            // StallLocationCode
            // 
            this.StallLocationCode.DataPropertyName = "StallLocationCode";
            this.StallLocationCode.HeaderText = "Location Code";
            this.StallLocationCode.Name = "StallLocationCode";
            this.StallLocationCode.ReadOnly = true;
            // 
            // StallCapacity
            // 
            this.StallCapacity.DataPropertyName = "StallCapacity";
            this.StallCapacity.HeaderText = "Capacity";
            this.StallCapacity.Name = "StallCapacity";
            this.StallCapacity.ReadOnly = true;
            // 
            // StallResources
            // 
            this.StallResources.DataPropertyName = "StallResources";
            this.StallResources.HeaderText = "Resources";
            this.StallResources.Name = "StallResources";
            this.StallResources.ReadOnly = true;
            // 
            // StallStartDate
            // 
            this.StallStartDate.DataPropertyName = "StallStartDate";
            this.StallStartDate.HeaderText = "Start Date";
            this.StallStartDate.Name = "StallStartDate";
            this.StallStartDate.ReadOnly = true;
            // 
            // StallEndDate
            // 
            this.StallEndDate.DataPropertyName = "StallEndDate";
            this.StallEndDate.HeaderText = "End Date";
            this.StallEndDate.Name = "StallEndDate";
            this.StallEndDate.ReadOnly = true;
            // 
            // StallType
            // 
            this.StallType.DataPropertyName = "StallType";
            this.StallType.HeaderText = "Stall Type";
            this.StallType.Name = "StallType";
            this.StallType.ReadOnly = true;
            // 
            // Exhibitors
            // 
            this.Exhibitors.DataPropertyName = "Exhibitors";
            this.Exhibitors.HeaderText = "Exhibitors";
            this.Exhibitors.Name = "Exhibitors";
            this.Exhibitors.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dtpStartDate.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(460, 52);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(211, 26);
            this.dtpStartDate.TabIndex = 16;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dtpEndDate.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(460, 115);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(211, 26);
            this.dtpEndDate.TabIndex = 17;
            // 
            // StallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConventionManager.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 606);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dgvStall);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtStallType);
            this.Controls.Add(this.lblStallType);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtResources);
            this.Controls.Add(this.lblResources);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtLocationCode);
            this.Controls.Add(this.lblLocationCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Stall";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StallForm_FormClosed);
            this.Load += new System.EventHandler(this.StallForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocationCode;
        private System.Windows.Forms.Label lblLocationCode;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtResources;
        private System.Windows.Forms.Label lblResources;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtStallType;
        private System.Windows.Forms.Label lblStallType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvStall;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StallName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StallLocationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StallCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StallResources;
        private System.Windows.Forms.DataGridViewTextBoxColumn StallStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StallEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StallType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exhibitors;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}