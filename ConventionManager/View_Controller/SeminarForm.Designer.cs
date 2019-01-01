﻿namespace ConventionManager.View_Controller
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
            this.dgvSeminar = new System.Windows.Forms.DataGridView();
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
            this.SeminarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeminarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeminarStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeminarEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
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
            this.dgvSeminar.Location = new System.Drawing.Point(15, 336);
            this.dgvSeminar.Name = "dgvSeminar";
            this.dgvSeminar.ReadOnly = true;
            this.dgvSeminar.Size = new System.Drawing.Size(697, 162);
            this.dgvSeminar.TabIndex = 27;
            this.dgvSeminar.Click += new System.EventHandler(this.dgvSeminar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCapacityValue
            // 
            this.lblCapacityValue.AutoSize = true;
            this.lblCapacityValue.Location = new System.Drawing.Point(106, 213);
            this.lblCapacityValue.Name = "lblCapacityValue";
            this.lblCapacityValue.Size = new System.Drawing.Size(13, 13);
            this.lblCapacityValue.TabIndex = 25;
            this.lblCapacityValue.Text = "0";
            // 
            // cbxRoom
            // 
            this.cbxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(109, 159);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(158, 21);
            this.cbxRoom.TabIndex = 24;
            this.cbxRoom.SelectedIndexChanged += new System.EventHandler(this.cbxRoom_SelectedIndexChanged);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(12, 213);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(79, 13);
            this.lblCapacity.TabIndex = 23;
            this.lblCapacity.Text = "Room Capacity";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(12, 167);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(35, 13);
            this.lblRoom.TabIndex = 22;
            this.lblRoom.Text = "Room";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(12, 121);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 21;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 70);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 20;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(109, 114);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(158, 20);
            this.dtpEndDate.TabIndex = 19;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(109, 64);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(158, 20);
            this.dtpStartDate.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 20);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
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
            // SeminarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 522);
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
            this.Name = "SeminarForm";
            this.Text = "SeminarForm";
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