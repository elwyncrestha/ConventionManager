namespace ConventionManager.View_Controller
{
    partial class SeminarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeminarForm));
            this.dgvSeminar = new System.Windows.Forms.DataGridView();
            this.SeminarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeminarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeminarStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeminarEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCapacityValue = new System.Windows.Forms.Label();
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeminar
            // 
            this.dgvSeminar.AllowUserToAddRows = false;
            this.dgvSeminar.AllowUserToDeleteRows = false;
            this.dgvSeminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeminar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeminarId,
            this.SeminarName,
            this.SeminarStartDate,
            this.SeminarEndDate,
            this.RoomName,
            this.Edit,
            this.Delete});
            this.dgvSeminar.Location = new System.Drawing.Point(15, 364);
            this.dgvSeminar.Name = "dgvSeminar";
            this.dgvSeminar.ReadOnly = true;
            this.dgvSeminar.Size = new System.Drawing.Size(697, 211);
            this.dgvSeminar.TabIndex = 27;
            this.dgvSeminar.Click += new System.EventHandler(this.dgvSeminar_Click);
            // 
            // SeminarId
            // 
            this.SeminarId.DataPropertyName = "SeminarId";
            this.SeminarId.HeaderText = "Id";
            this.SeminarId.Name = "SeminarId";
            this.SeminarId.ReadOnly = true;
            // 
            // SeminarName
            // 
            this.SeminarName.DataPropertyName = "SeminarName";
            this.SeminarName.HeaderText = "Name";
            this.SeminarName.Name = "SeminarName";
            this.SeminarName.ReadOnly = true;
            // 
            // SeminarStartDate
            // 
            this.SeminarStartDate.DataPropertyName = "SeminarStartDate";
            this.SeminarStartDate.HeaderText = "Start Date";
            this.SeminarStartDate.Name = "SeminarStartDate";
            this.SeminarStartDate.ReadOnly = true;
            // 
            // SeminarEndDate
            // 
            this.SeminarEndDate.DataPropertyName = "SeminarEndDate";
            this.SeminarEndDate.HeaderText = "End Date";
            this.SeminarEndDate.Name = "SeminarEndDate";
            this.SeminarEndDate.ReadOnly = true;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "Room Name";
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
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
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.btnAdd.Location = new System.Drawing.Point(175, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 46);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCapacityValue
            // 
            this.lblCapacityValue.AutoSize = true;
            this.lblCapacityValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCapacityValue.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblCapacityValue.Location = new System.Drawing.Point(171, 221);
            this.lblCapacityValue.Name = "lblCapacityValue";
            this.lblCapacityValue.Size = new System.Drawing.Size(19, 21);
            this.lblCapacityValue.TabIndex = 25;
            this.lblCapacityValue.Text = "0";
            // 
            // cbxRoom
            // 
            this.cbxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoom.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(175, 166);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(223, 29);
            this.cbxRoom.TabIndex = 24;
            this.cbxRoom.SelectedIndexChanged += new System.EventHandler(this.cbxRoom_SelectedIndexChanged);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.BackColor = System.Drawing.Color.Transparent;
            this.lblCapacity.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblCapacity.Location = new System.Drawing.Point(11, 221);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(118, 21);
            this.lblCapacity.TabIndex = 23;
            this.lblCapacity.Text = "Room Capacity";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblRoom.Location = new System.Drawing.Point(11, 173);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(52, 21);
            this.lblRoom.TabIndex = 22;
            this.lblRoom.Text = "Room";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblEndDate.Location = new System.Drawing.Point(11, 128);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(75, 21);
            this.lblEndDate.TabIndex = 21;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblStartDate.Location = new System.Drawing.Point(12, 81);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(84, 21);
            this.lblStartDate.TabIndex = 20;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dtpEndDate.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(175, 123);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(223, 26);
            this.dtpEndDate.TabIndex = 19;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dtpStartDate.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(176, 77);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(223, 26);
            this.dtpStartDate.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.txtName.Location = new System.Drawing.Point(176, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 26);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblName.Location = new System.Drawing.Point(12, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 21);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // SeminarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConventionManager.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 602);
            this.Controls.Add(this.dgvSeminar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCapacityValue);
            this.Controls.Add(this.cbxRoom);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeminarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Seminar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeminarForm_FormClosed);
            this.Load += new System.EventHandler(this.SeminarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSeminar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCapacityValue;
        private System.Windows.Forms.ComboBox cbxRoom;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeminarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeminarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeminarStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeminarEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}