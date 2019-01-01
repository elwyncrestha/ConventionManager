﻿namespace ConventionManager.View_Controller
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
            this.gbxAttendee = new System.Windows.Forms.GroupBox();
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
            this.lblRoomNameValue = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblSeminarEndDateValue = new System.Windows.Forms.Label();
            this.lblSeminarStartDate = new System.Windows.Forms.Label();
            this.lblSeminarEndDate = new System.Windows.Forms.Label();
            this.lblSeminarStartDateValue = new System.Windows.Forms.Label();
            this.lblIsPresenter = new System.Windows.Forms.Label();
            this.chkIsPresenter = new System.Windows.Forms.CheckBox();
            this.gbxAttendee.SuspendLayout();
            this.gbxSeminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAttendee
            // 
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
            this.gbxAttendee.Location = new System.Drawing.Point(15, 30);
            this.gbxAttendee.Name = "gbxAttendee";
            this.gbxAttendee.Size = new System.Drawing.Size(216, 199);
            this.gbxAttendee.TabIndex = 11;
            this.gbxAttendee.TabStop = false;
            this.gbxAttendee.Text = "Attendee";
            // 
            // lblContactValue
            // 
            this.lblContactValue.AutoSize = true;
            this.lblContactValue.Location = new System.Drawing.Point(82, 138);
            this.lblContactValue.Name = "lblContactValue";
            this.lblContactValue.Size = new System.Drawing.Size(23, 13);
            this.lblContactValue.TabIndex = 8;
            this.lblContactValue.Text = "null";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(9, 138);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "Contact";
            // 
            // lblLastNameValue
            // 
            this.lblLastNameValue.AutoSize = true;
            this.lblLastNameValue.Location = new System.Drawing.Point(82, 103);
            this.lblLastNameValue.Name = "lblLastNameValue";
            this.lblLastNameValue.Size = new System.Drawing.Size(23, 13);
            this.lblLastNameValue.TabIndex = 6;
            this.lblLastNameValue.Text = "null";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(9, 103);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstNameValue
            // 
            this.lblFirstNameValue.AutoSize = true;
            this.lblFirstNameValue.Location = new System.Drawing.Point(82, 71);
            this.lblFirstNameValue.Name = "lblFirstNameValue";
            this.lblFirstNameValue.Size = new System.Drawing.Size(23, 13);
            this.lblFirstNameValue.TabIndex = 4;
            this.lblFirstNameValue.Text = "null";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 71);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // lblAttendee
            // 
            this.lblAttendee.AutoSize = true;
            this.lblAttendee.Location = new System.Drawing.Point(6, 29);
            this.lblAttendee.Name = "lblAttendee";
            this.lblAttendee.Size = new System.Drawing.Size(50, 13);
            this.lblAttendee.TabIndex = 0;
            this.lblAttendee.Text = "Attendee";
            // 
            // cbxAttendee
            // 
            this.cbxAttendee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAttendee.FormattingEnabled = true;
            this.cbxAttendee.Location = new System.Drawing.Point(85, 20);
            this.cbxAttendee.Name = "cbxAttendee";
            this.cbxAttendee.Size = new System.Drawing.Size(121, 21);
            this.cbxAttendee.TabIndex = 2;
            this.cbxAttendee.SelectedIndexChanged += new System.EventHandler(this.cbxAttendee_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(184, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 52);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSeminar
            // 
            this.lblSeminar.AutoSize = true;
            this.lblSeminar.Location = new System.Drawing.Point(6, 29);
            this.lblSeminar.Name = "lblSeminar";
            this.lblSeminar.Size = new System.Drawing.Size(45, 13);
            this.lblSeminar.TabIndex = 1;
            this.lblSeminar.Text = "Seminar";
            // 
            // cbxSeminar
            // 
            this.cbxSeminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeminar.FormattingEnabled = true;
            this.cbxSeminar.Location = new System.Drawing.Point(79, 20);
            this.cbxSeminar.Name = "cbxSeminar";
            this.cbxSeminar.Size = new System.Drawing.Size(121, 21);
            this.cbxSeminar.TabIndex = 3;
            this.cbxSeminar.SelectedIndexChanged += new System.EventHandler(this.cbxSeminar_SelectedIndexChanged);
            // 
            // gbxSeminar
            // 
            this.gbxSeminar.Controls.Add(this.lblRoomNameValue);
            this.gbxSeminar.Controls.Add(this.lblSeminar);
            this.gbxSeminar.Controls.Add(this.lblRoomName);
            this.gbxSeminar.Controls.Add(this.cbxSeminar);
            this.gbxSeminar.Controls.Add(this.lblSeminarEndDateValue);
            this.gbxSeminar.Controls.Add(this.lblSeminarStartDate);
            this.gbxSeminar.Controls.Add(this.lblSeminarEndDate);
            this.gbxSeminar.Controls.Add(this.lblSeminarStartDateValue);
            this.gbxSeminar.Location = new System.Drawing.Point(237, 30);
            this.gbxSeminar.Name = "gbxSeminar";
            this.gbxSeminar.Size = new System.Drawing.Size(210, 199);
            this.gbxSeminar.TabIndex = 12;
            this.gbxSeminar.TabStop = false;
            this.gbxSeminar.Text = "Seminar";
            // 
            // lblRoomNameValue
            // 
            this.lblRoomNameValue.AutoSize = true;
            this.lblRoomNameValue.Location = new System.Drawing.Point(106, 138);
            this.lblRoomNameValue.Name = "lblRoomNameValue";
            this.lblRoomNameValue.Size = new System.Drawing.Size(23, 13);
            this.lblRoomNameValue.TabIndex = 14;
            this.lblRoomNameValue.Text = "null";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(6, 138);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(66, 13);
            this.lblRoomName.TabIndex = 13;
            this.lblRoomName.Text = "Room Name";
            // 
            // lblSeminarEndDateValue
            // 
            this.lblSeminarEndDateValue.AutoSize = true;
            this.lblSeminarEndDateValue.Location = new System.Drawing.Point(106, 103);
            this.lblSeminarEndDateValue.Name = "lblSeminarEndDateValue";
            this.lblSeminarEndDateValue.Size = new System.Drawing.Size(23, 13);
            this.lblSeminarEndDateValue.TabIndex = 12;
            this.lblSeminarEndDateValue.Text = "null";
            // 
            // lblSeminarStartDate
            // 
            this.lblSeminarStartDate.AutoSize = true;
            this.lblSeminarStartDate.Location = new System.Drawing.Point(6, 71);
            this.lblSeminarStartDate.Name = "lblSeminarStartDate";
            this.lblSeminarStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblSeminarStartDate.TabIndex = 9;
            this.lblSeminarStartDate.Text = "Start Date";
            // 
            // lblSeminarEndDate
            // 
            this.lblSeminarEndDate.AutoSize = true;
            this.lblSeminarEndDate.Location = new System.Drawing.Point(6, 103);
            this.lblSeminarEndDate.Name = "lblSeminarEndDate";
            this.lblSeminarEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblSeminarEndDate.TabIndex = 11;
            this.lblSeminarEndDate.Text = "End Date";
            // 
            // lblSeminarStartDateValue
            // 
            this.lblSeminarStartDateValue.AutoSize = true;
            this.lblSeminarStartDateValue.Location = new System.Drawing.Point(106, 71);
            this.lblSeminarStartDateValue.Name = "lblSeminarStartDateValue";
            this.lblSeminarStartDateValue.Size = new System.Drawing.Size(23, 13);
            this.lblSeminarStartDateValue.TabIndex = 10;
            this.lblSeminarStartDateValue.Text = "null";
            // 
            // lblIsPresenter
            // 
            this.lblIsPresenter.AutoSize = true;
            this.lblIsPresenter.Location = new System.Drawing.Point(9, 170);
            this.lblIsPresenter.Name = "lblIsPresenter";
            this.lblIsPresenter.Size = new System.Drawing.Size(69, 13);
            this.lblIsPresenter.TabIndex = 9;
            this.lblIsPresenter.Text = "Is Presenter?";
            // 
            // chkIsPresenter
            // 
            this.chkIsPresenter.AutoSize = true;
            this.chkIsPresenter.Location = new System.Drawing.Point(84, 169);
            this.chkIsPresenter.Name = "chkIsPresenter";
            this.chkIsPresenter.Size = new System.Drawing.Size(44, 17);
            this.chkIsPresenter.TabIndex = 10;
            this.chkIsPresenter.Text = "Yes";
            this.chkIsPresenter.UseVisualStyleBackColor = true;
            // 
            // AddAttendeeToSeminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 379);
            this.Controls.Add(this.gbxAttendee);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxSeminar);
            this.Name = "AddAttendeeToSeminar";
            this.Text = "AddAttendeeToSeminar";
            this.Load += new System.EventHandler(this.AddAttendeeToSeminar_Load);
            this.gbxAttendee.ResumeLayout(false);
            this.gbxAttendee.PerformLayout();
            this.gbxSeminar.ResumeLayout(false);
            this.gbxSeminar.PerformLayout();
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
    }
}