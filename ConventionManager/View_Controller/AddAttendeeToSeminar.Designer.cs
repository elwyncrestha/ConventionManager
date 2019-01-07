namespace ConventionManager.View_Controller
{
    partial class AddAttendeeToSeminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAttendeeToSeminar));
            this.gbxAttendee = new System.Windows.Forms.GroupBox();
            this.chkIsPresenter = new System.Windows.Forms.CheckBox();
            this.lblIsPresenter = new System.Windows.Forms.Label();
            this.lblContactValue = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblLastNameValue = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstNameValue = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAttendee = new System.Windows.Forms.Label();
            this.cbxAttendee = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSeminar = new System.Windows.Forms.Label();
            this.cbxSeminar = new System.Windows.Forms.ComboBox();
            this.gbxSeminar = new System.Windows.Forms.GroupBox();
            this.lblRoomCapacityValue = new System.Windows.Forms.Label();
            this.lblRoomCapacity = new System.Windows.Forms.Label();
            this.lblFilledValue = new System.Windows.Forms.Label();
            this.lblFilled = new System.Windows.Forms.Label();
            this.lblRoomNameValue = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblSeminarEndDateValue = new System.Windows.Forms.Label();
            this.lblSeminarStartDate = new System.Windows.Forms.Label();
            this.lblSeminarEndDate = new System.Windows.Forms.Label();
            this.lblSeminarStartDateValue = new System.Windows.Forms.Label();
            this.dgvAttendeeSeminar = new System.Windows.Forms.DataGridView();
            this.SeminarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeminarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPresenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gbxAttendee.SuspendLayout();
            this.gbxSeminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendeeSeminar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAttendee
            // 
            this.gbxAttendee.BackColor = System.Drawing.Color.Transparent;
            this.gbxAttendee.Controls.Add(this.chkIsPresenter);
            this.gbxAttendee.Controls.Add(this.lblIsPresenter);
            this.gbxAttendee.Controls.Add(this.lblContactValue);
            this.gbxAttendee.Controls.Add(this.lblContact);
            this.gbxAttendee.Controls.Add(this.lblLastNameValue);
            this.gbxAttendee.Controls.Add(this.lblLastName);
            this.gbxAttendee.Controls.Add(this.lblFirstNameValue);
            this.gbxAttendee.Controls.Add(this.lblFirstName);
            this.gbxAttendee.Controls.Add(this.lblAttendee);
            this.gbxAttendee.Controls.Add(this.cbxAttendee);
            this.gbxAttendee.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.gbxAttendee.Location = new System.Drawing.Point(15, 14);
            this.gbxAttendee.Name = "gbxAttendee";
            this.gbxAttendee.Size = new System.Drawing.Size(276, 273);
            this.gbxAttendee.TabIndex = 11;
            this.gbxAttendee.TabStop = false;
            this.gbxAttendee.Text = "Attendee";
            // 
            // chkIsPresenter
            // 
            this.chkIsPresenter.AutoSize = true;
            this.chkIsPresenter.Location = new System.Drawing.Point(141, 195);
            this.chkIsPresenter.Name = "chkIsPresenter";
            this.chkIsPresenter.Size = new System.Drawing.Size(54, 25);
            this.chkIsPresenter.TabIndex = 10;
            this.chkIsPresenter.Text = "Yes";
            this.chkIsPresenter.UseVisualStyleBackColor = true;
            // 
            // lblIsPresenter
            // 
            this.lblIsPresenter.AutoSize = true;
            this.lblIsPresenter.Location = new System.Drawing.Point(9, 196);
            this.lblIsPresenter.Name = "lblIsPresenter";
            this.lblIsPresenter.Size = new System.Drawing.Size(107, 21);
            this.lblIsPresenter.TabIndex = 9;
            this.lblIsPresenter.Text = "Is Presenter?";
            // 
            // lblContactValue
            // 
            this.lblContactValue.AutoSize = true;
            this.lblContactValue.Location = new System.Drawing.Point(139, 159);
            this.lblContactValue.Name = "lblContactValue";
            this.lblContactValue.Size = new System.Drawing.Size(36, 21);
            this.lblContactValue.TabIndex = 8;
            this.lblContactValue.Text = "null";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(9, 159);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(67, 21);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "Contact";
            // 
            // lblLastNameValue
            // 
            this.lblLastNameValue.AutoSize = true;
            this.lblLastNameValue.Location = new System.Drawing.Point(139, 119);
            this.lblLastNameValue.Name = "lblLastNameValue";
            this.lblLastNameValue.Size = new System.Drawing.Size(36, 21);
            this.lblLastNameValue.TabIndex = 6;
            this.lblLastNameValue.Text = "null";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(9, 119);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 21);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstNameValue
            // 
            this.lblFirstNameValue.AutoSize = true;
            this.lblFirstNameValue.Location = new System.Drawing.Point(139, 82);
            this.lblFirstNameValue.Name = "lblFirstNameValue";
            this.lblFirstNameValue.Size = new System.Drawing.Size(36, 21);
            this.lblFirstNameValue.TabIndex = 4;
            this.lblFirstNameValue.Text = "null";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 82);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 21);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // lblAttendee
            // 
            this.lblAttendee.AutoSize = true;
            this.lblAttendee.Location = new System.Drawing.Point(6, 33);
            this.lblAttendee.Name = "lblAttendee";
            this.lblAttendee.Size = new System.Drawing.Size(77, 21);
            this.lblAttendee.TabIndex = 0;
            this.lblAttendee.Text = "Attendee";
            // 
            // cbxAttendee
            // 
            this.cbxAttendee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAttendee.FormattingEnabled = true;
            this.cbxAttendee.Location = new System.Drawing.Point(85, 23);
            this.cbxAttendee.Name = "cbxAttendee";
            this.cbxAttendee.Size = new System.Drawing.Size(185, 29);
            this.cbxAttendee.TabIndex = 2;
            this.cbxAttendee.SelectedIndexChanged += new System.EventHandler(this.cbxAttendee_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(264, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 46);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSeminar
            // 
            this.lblSeminar.AutoSize = true;
            this.lblSeminar.Location = new System.Drawing.Point(6, 33);
            this.lblSeminar.Name = "lblSeminar";
            this.lblSeminar.Size = new System.Drawing.Size(69, 21);
            this.lblSeminar.TabIndex = 1;
            this.lblSeminar.Text = "Seminar";
            // 
            // cbxSeminar
            // 
            this.cbxSeminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeminar.FormattingEnabled = true;
            this.cbxSeminar.Location = new System.Drawing.Point(143, 23);
            this.cbxSeminar.Name = "cbxSeminar";
            this.cbxSeminar.Size = new System.Drawing.Size(216, 29);
            this.cbxSeminar.TabIndex = 3;
            this.cbxSeminar.SelectedIndexChanged += new System.EventHandler(this.cbxSeminar_SelectedIndexChanged);
            // 
            // gbxSeminar
            // 
            this.gbxSeminar.BackColor = System.Drawing.Color.Transparent;
            this.gbxSeminar.Controls.Add(this.lblRoomCapacityValue);
            this.gbxSeminar.Controls.Add(this.lblRoomCapacity);
            this.gbxSeminar.Controls.Add(this.lblFilledValue);
            this.gbxSeminar.Controls.Add(this.lblFilled);
            this.gbxSeminar.Controls.Add(this.lblRoomNameValue);
            this.gbxSeminar.Controls.Add(this.lblSeminar);
            this.gbxSeminar.Controls.Add(this.lblRoomName);
            this.gbxSeminar.Controls.Add(this.cbxSeminar);
            this.gbxSeminar.Controls.Add(this.lblSeminarEndDateValue);
            this.gbxSeminar.Controls.Add(this.lblSeminarStartDate);
            this.gbxSeminar.Controls.Add(this.lblSeminarEndDate);
            this.gbxSeminar.Controls.Add(this.lblSeminarStartDateValue);
            this.gbxSeminar.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.gbxSeminar.Location = new System.Drawing.Point(297, 14);
            this.gbxSeminar.Name = "gbxSeminar";
            this.gbxSeminar.Size = new System.Drawing.Size(365, 273);
            this.gbxSeminar.TabIndex = 12;
            this.gbxSeminar.TabStop = false;
            this.gbxSeminar.Text = "Seminar";
            // 
            // lblRoomCapacityValue
            // 
            this.lblRoomCapacityValue.AutoSize = true;
            this.lblRoomCapacityValue.Location = new System.Drawing.Point(139, 231);
            this.lblRoomCapacityValue.Name = "lblRoomCapacityValue";
            this.lblRoomCapacityValue.Size = new System.Drawing.Size(36, 21);
            this.lblRoomCapacityValue.TabIndex = 22;
            this.lblRoomCapacityValue.Text = "null";
            // 
            // lblRoomCapacity
            // 
            this.lblRoomCapacity.AutoSize = true;
            this.lblRoomCapacity.Location = new System.Drawing.Point(6, 231);
            this.lblRoomCapacity.Name = "lblRoomCapacity";
            this.lblRoomCapacity.Size = new System.Drawing.Size(118, 21);
            this.lblRoomCapacity.TabIndex = 21;
            this.lblRoomCapacity.Text = "Room Capacity";
            // 
            // lblFilledValue
            // 
            this.lblFilledValue.AutoSize = true;
            this.lblFilledValue.Location = new System.Drawing.Point(139, 196);
            this.lblFilledValue.Name = "lblFilledValue";
            this.lblFilledValue.Size = new System.Drawing.Size(36, 21);
            this.lblFilledValue.TabIndex = 16;
            this.lblFilledValue.Text = "null";
            // 
            // lblFilled
            // 
            this.lblFilled.AutoSize = true;
            this.lblFilled.Location = new System.Drawing.Point(6, 196);
            this.lblFilled.Name = "lblFilled";
            this.lblFilled.Size = new System.Drawing.Size(95, 21);
            this.lblFilled.TabIndex = 15;
            this.lblFilled.Text = "Room Filled";
            // 
            // lblRoomNameValue
            // 
            this.lblRoomNameValue.AutoSize = true;
            this.lblRoomNameValue.Location = new System.Drawing.Point(139, 159);
            this.lblRoomNameValue.Name = "lblRoomNameValue";
            this.lblRoomNameValue.Size = new System.Drawing.Size(36, 21);
            this.lblRoomNameValue.TabIndex = 14;
            this.lblRoomNameValue.Text = "null";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(6, 159);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(97, 21);
            this.lblRoomName.TabIndex = 13;
            this.lblRoomName.Text = "Room Name";
            // 
            // lblSeminarEndDateValue
            // 
            this.lblSeminarEndDateValue.AutoSize = true;
            this.lblSeminarEndDateValue.Location = new System.Drawing.Point(139, 119);
            this.lblSeminarEndDateValue.Name = "lblSeminarEndDateValue";
            this.lblSeminarEndDateValue.Size = new System.Drawing.Size(36, 21);
            this.lblSeminarEndDateValue.TabIndex = 12;
            this.lblSeminarEndDateValue.Text = "null";
            // 
            // lblSeminarStartDate
            // 
            this.lblSeminarStartDate.AutoSize = true;
            this.lblSeminarStartDate.Location = new System.Drawing.Point(6, 82);
            this.lblSeminarStartDate.Name = "lblSeminarStartDate";
            this.lblSeminarStartDate.Size = new System.Drawing.Size(84, 21);
            this.lblSeminarStartDate.TabIndex = 9;
            this.lblSeminarStartDate.Text = "Start Date";
            // 
            // lblSeminarEndDate
            // 
            this.lblSeminarEndDate.AutoSize = true;
            this.lblSeminarEndDate.Location = new System.Drawing.Point(6, 119);
            this.lblSeminarEndDate.Name = "lblSeminarEndDate";
            this.lblSeminarEndDate.Size = new System.Drawing.Size(75, 21);
            this.lblSeminarEndDate.TabIndex = 11;
            this.lblSeminarEndDate.Text = "End Date";
            // 
            // lblSeminarStartDateValue
            // 
            this.lblSeminarStartDateValue.AutoSize = true;
            this.lblSeminarStartDateValue.Location = new System.Drawing.Point(139, 82);
            this.lblSeminarStartDateValue.Name = "lblSeminarStartDateValue";
            this.lblSeminarStartDateValue.Size = new System.Drawing.Size(36, 21);
            this.lblSeminarStartDateValue.TabIndex = 10;
            this.lblSeminarStartDateValue.Text = "null";
            // 
            // dgvAttendeeSeminar
            // 
            this.dgvAttendeeSeminar.AllowUserToAddRows = false;
            this.dgvAttendeeSeminar.AllowUserToDeleteRows = false;
            this.dgvAttendeeSeminar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendeeSeminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendeeSeminar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeminarId,
            this.AttendeeId,
            this.SeminarName,
            this.AttendeeEmail,
            this.IsPresenter,
            this.Delete});
            this.dgvAttendeeSeminar.Location = new System.Drawing.Point(15, 376);
            this.dgvAttendeeSeminar.Name = "dgvAttendeeSeminar";
            this.dgvAttendeeSeminar.ReadOnly = true;
            this.dgvAttendeeSeminar.Size = new System.Drawing.Size(647, 203);
            this.dgvAttendeeSeminar.TabIndex = 13;
            // 
            // SeminarId
            // 
            this.SeminarId.DataPropertyName = "SeminarId";
            this.SeminarId.HeaderText = "SeminarId";
            this.SeminarId.Name = "SeminarId";
            this.SeminarId.ReadOnly = true;
            // 
            // AttendeeId
            // 
            this.AttendeeId.DataPropertyName = "AttendeeId";
            this.AttendeeId.HeaderText = "AttendeeId";
            this.AttendeeId.Name = "AttendeeId";
            this.AttendeeId.ReadOnly = true;
            // 
            // SeminarName
            // 
            this.SeminarName.DataPropertyName = "SeminarName";
            this.SeminarName.HeaderText = "Seminar Name";
            this.SeminarName.Name = "SeminarName";
            this.SeminarName.ReadOnly = true;
            // 
            // AttendeeEmail
            // 
            this.AttendeeEmail.DataPropertyName = "AttendeeEmail";
            this.AttendeeEmail.HeaderText = "Attendee Email";
            this.AttendeeEmail.Name = "AttendeeEmail";
            this.AttendeeEmail.ReadOnly = true;
            // 
            // IsPresenter
            // 
            this.IsPresenter.DataPropertyName = "IsPresenter";
            this.IsPresenter.HeaderText = "Is Presenter";
            this.IsPresenter.Name = "IsPresenter";
            this.IsPresenter.ReadOnly = true;
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
            // AddAttendeeToSeminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConventionManager.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 591);
            this.Controls.Add(this.dgvAttendeeSeminar);
            this.Controls.Add(this.gbxAttendee);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxSeminar);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAttendeeToSeminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Attendee To Seminar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddAttendeeToSeminar_FormClosed);
            this.Load += new System.EventHandler(this.AddAttendeeToSeminar_Load);
            this.gbxAttendee.ResumeLayout(false);
            this.gbxAttendee.PerformLayout();
            this.gbxSeminar.ResumeLayout(false);
            this.gbxSeminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendeeSeminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAttendee;
        private System.Windows.Forms.Label lblContactValue;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblLastNameValue;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstNameValue;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAttendee;
        private System.Windows.Forms.ComboBox cbxAttendee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSeminar;
        private System.Windows.Forms.ComboBox cbxSeminar;
        private System.Windows.Forms.GroupBox gbxSeminar;
        private System.Windows.Forms.Label lblRoomNameValue;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblSeminarEndDateValue;
        private System.Windows.Forms.Label lblSeminarStartDate;
        private System.Windows.Forms.Label lblSeminarEndDate;
        private System.Windows.Forms.Label lblSeminarStartDateValue;
        private System.Windows.Forms.CheckBox chkIsPresenter;
        private System.Windows.Forms.Label lblIsPresenter;
        private System.Windows.Forms.Label lblFilledValue;
        private System.Windows.Forms.Label lblFilled;
        private System.Windows.Forms.Label lblRoomCapacityValue;
        private System.Windows.Forms.Label lblRoomCapacity;
        private System.Windows.Forms.DataGridView dgvAttendeeSeminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeminarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeminarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPresenter;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}