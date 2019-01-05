namespace ConventionManager.View_Controller
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.lblCapacityValue = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.EventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblName.Location = new System.Drawing.Point(12, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.txtName.Location = new System.Drawing.Point(124, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.txtDescription.Location = new System.Drawing.Point(124, 102);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(256, 147);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblDescription.Location = new System.Drawing.Point(12, 110);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(92, 21);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dtpStartDate.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(532, 44);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(158, 26);
            this.dtpStartDate.TabIndex = 4;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dtpEndDate.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(532, 102);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(158, 26);
            this.dtpEndDate.TabIndex = 5;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblStartDate.Location = new System.Drawing.Point(435, 51);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(84, 21);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblEndDate.Location = new System.Drawing.Point(435, 110);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(75, 21);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "End Date";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblRoom.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblRoom.Location = new System.Drawing.Point(435, 163);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(52, 21);
            this.lblRoom.TabIndex = 8;
            this.lblRoom.Text = "Room";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.BackColor = System.Drawing.Color.Transparent;
            this.lblCapacity.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblCapacity.Location = new System.Drawing.Point(435, 216);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(118, 21);
            this.lblCapacity.TabIndex = 9;
            this.lblCapacity.Text = "Room Capacity";
            // 
            // cbxRoom
            // 
            this.cbxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoom.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(532, 153);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(158, 29);
            this.cbxRoom.TabIndex = 10;
            this.cbxRoom.SelectedIndexChanged += new System.EventHandler(this.cbxRoom_SelectedIndexChanged);
            // 
            // lblCapacityValue
            // 
            this.lblCapacityValue.AutoSize = true;
            this.lblCapacityValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCapacityValue.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblCapacityValue.Location = new System.Drawing.Point(573, 216);
            this.lblCapacityValue.Name = "lblCapacityValue";
            this.lblCapacityValue.Size = new System.Drawing.Size(19, 21);
            this.lblCapacityValue.TabIndex = 11;
            this.lblCapacityValue.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.btnAdd.Location = new System.Drawing.Point(124, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 46);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvEvent
            // 
            this.dgvEvent.AllowUserToAddRows = false;
            this.dgvEvent.AllowUserToDeleteRows = false;
            this.dgvEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventId,
            this.EventName,
            this.EventStartDate,
            this.EventEndDate,
            this.RoomName,
            this.RoomCapacity,
            this.EventDescription,
            this.Edit,
            this.Delete});
            this.dgvEvent.Location = new System.Drawing.Point(15, 359);
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.ReadOnly = true;
            this.dgvEvent.Size = new System.Drawing.Size(697, 232);
            this.dgvEvent.TabIndex = 13;
            this.dgvEvent.Click += new System.EventHandler(this.dgvEvent_Click);
            // 
            // EventId
            // 
            this.EventId.DataPropertyName = "EventId";
            this.EventId.HeaderText = "Id";
            this.EventId.Name = "EventId";
            this.EventId.ReadOnly = true;
            // 
            // EventName
            // 
            this.EventName.DataPropertyName = "EventName";
            this.EventName.HeaderText = "Name";
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            // 
            // EventStartDate
            // 
            this.EventStartDate.DataPropertyName = "EventStartDate";
            this.EventStartDate.HeaderText = "Start Date";
            this.EventStartDate.Name = "EventStartDate";
            this.EventStartDate.ReadOnly = true;
            // 
            // EventEndDate
            // 
            this.EventEndDate.DataPropertyName = "EventEndDate";
            this.EventEndDate.HeaderText = "End Date";
            this.EventEndDate.Name = "EventEndDate";
            this.EventEndDate.ReadOnly = true;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "Room Name";
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            // 
            // RoomCapacity
            // 
            this.RoomCapacity.DataPropertyName = "RoomCapacity";
            this.RoomCapacity.HeaderText = "Room Capacity";
            this.RoomCapacity.Name = "RoomCapacity";
            this.RoomCapacity.ReadOnly = true;
            // 
            // EventDescription
            // 
            this.EventDescription.DataPropertyName = "EventDescription";
            this.EventDescription.HeaderText = "Description";
            this.EventDescription.Name = "EventDescription";
            this.EventDescription.ReadOnly = true;
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
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConventionManager.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 602);
            this.Controls.Add(this.dgvEvent);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCapacityValue);
            this.Controls.Add(this.cbxRoom);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Event";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventForm_FormClosed);
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.ComboBox cbxRoom;
        private System.Windows.Forms.Label lblCapacityValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDescription;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}