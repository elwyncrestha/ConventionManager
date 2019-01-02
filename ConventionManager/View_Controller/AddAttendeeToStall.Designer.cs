namespace ConventionManager.View_Controller
{
    partial class AddAttendeeToStall
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
            this.lblAttendee = new System.Windows.Forms.Label();
            this.lblStall = new System.Windows.Forms.Label();
            this.cbxAttendee = new System.Windows.Forms.ComboBox();
            this.cbxStall = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxAttendee = new System.Windows.Forms.GroupBox();
            this.lblContactValue = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblLastNameValue = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstNameValue = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbxStall = new System.Windows.Forms.GroupBox();
            this.lblFilledValue = new System.Windows.Forms.Label();
            this.lblFilled = new System.Windows.Forms.Label();
            this.lblStallTypeValue = new System.Windows.Forms.Label();
            this.lblStallType = new System.Windows.Forms.Label();
            this.lblCapacityValue = new System.Windows.Forms.Label();
            this.lblLocationCode = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblLocationCodeValue = new System.Windows.Forms.Label();
            this.gbxAttendee.SuspendLayout();
            this.gbxStall.SuspendLayout();
            this.SuspendLayout();
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
            // lblStall
            // 
            this.lblStall.AutoSize = true;
            this.lblStall.Location = new System.Drawing.Point(6, 29);
            this.lblStall.Name = "lblStall";
            this.lblStall.Size = new System.Drawing.Size(27, 13);
            this.lblStall.TabIndex = 1;
            this.lblStall.Text = "Stall";
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
            // cbxStall
            // 
            this.cbxStall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStall.FormattingEnabled = true;
            this.cbxStall.Location = new System.Drawing.Point(79, 20);
            this.cbxStall.Name = "cbxStall";
            this.cbxStall.Size = new System.Drawing.Size(121, 21);
            this.cbxStall.TabIndex = 3;
            this.cbxStall.SelectedIndexChanged += new System.EventHandler(this.cbxStall_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(184, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 52);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxAttendee
            // 
            this.gbxAttendee.Controls.Add(this.lblContactValue);
            this.gbxAttendee.Controls.Add(this.lblContact);
            this.gbxAttendee.Controls.Add(this.lblLastNameValue);
            this.gbxAttendee.Controls.Add(this.lblLastName);
            this.gbxAttendee.Controls.Add(this.lblFirstNameValue);
            this.gbxAttendee.Controls.Add(this.lblFirstName);
            this.gbxAttendee.Controls.Add(this.lblAttendee);
            this.gbxAttendee.Controls.Add(this.cbxAttendee);
            this.gbxAttendee.Location = new System.Drawing.Point(15, 12);
            this.gbxAttendee.Name = "gbxAttendee";
            this.gbxAttendee.Size = new System.Drawing.Size(216, 199);
            this.gbxAttendee.TabIndex = 5;
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
            // gbxStall
            // 
            this.gbxStall.Controls.Add(this.lblFilledValue);
            this.gbxStall.Controls.Add(this.lblFilled);
            this.gbxStall.Controls.Add(this.lblStallTypeValue);
            this.gbxStall.Controls.Add(this.lblStall);
            this.gbxStall.Controls.Add(this.lblStallType);
            this.gbxStall.Controls.Add(this.cbxStall);
            this.gbxStall.Controls.Add(this.lblCapacityValue);
            this.gbxStall.Controls.Add(this.lblLocationCode);
            this.gbxStall.Controls.Add(this.lblCapacity);
            this.gbxStall.Controls.Add(this.lblLocationCodeValue);
            this.gbxStall.Location = new System.Drawing.Point(237, 12);
            this.gbxStall.Name = "gbxStall";
            this.gbxStall.Size = new System.Drawing.Size(210, 199);
            this.gbxStall.TabIndex = 6;
            this.gbxStall.TabStop = false;
            this.gbxStall.Text = "Stall";
            // 
            // lblFilledValue
            // 
            this.lblFilledValue.AutoSize = true;
            this.lblFilledValue.Location = new System.Drawing.Point(106, 171);
            this.lblFilledValue.Name = "lblFilledValue";
            this.lblFilledValue.Size = new System.Drawing.Size(23, 13);
            this.lblFilledValue.TabIndex = 16;
            this.lblFilledValue.Text = "null";
            // 
            // lblFilled
            // 
            this.lblFilled.AutoSize = true;
            this.lblFilled.Location = new System.Drawing.Point(6, 171);
            this.lblFilled.Name = "lblFilled";
            this.lblFilled.Size = new System.Drawing.Size(31, 13);
            this.lblFilled.TabIndex = 15;
            this.lblFilled.Text = "Filled";
            // 
            // lblStallTypeValue
            // 
            this.lblStallTypeValue.AutoSize = true;
            this.lblStallTypeValue.Location = new System.Drawing.Point(106, 138);
            this.lblStallTypeValue.Name = "lblStallTypeValue";
            this.lblStallTypeValue.Size = new System.Drawing.Size(23, 13);
            this.lblStallTypeValue.TabIndex = 14;
            this.lblStallTypeValue.Text = "null";
            // 
            // lblStallType
            // 
            this.lblStallType.AutoSize = true;
            this.lblStallType.Location = new System.Drawing.Point(6, 138);
            this.lblStallType.Name = "lblStallType";
            this.lblStallType.Size = new System.Drawing.Size(54, 13);
            this.lblStallType.TabIndex = 13;
            this.lblStallType.Text = "Stall Type";
            // 
            // lblCapacityValue
            // 
            this.lblCapacityValue.AutoSize = true;
            this.lblCapacityValue.Location = new System.Drawing.Point(106, 103);
            this.lblCapacityValue.Name = "lblCapacityValue";
            this.lblCapacityValue.Size = new System.Drawing.Size(23, 13);
            this.lblCapacityValue.TabIndex = 12;
            this.lblCapacityValue.Text = "null";
            // 
            // lblLocationCode
            // 
            this.lblLocationCode.AutoSize = true;
            this.lblLocationCode.Location = new System.Drawing.Point(6, 71);
            this.lblLocationCode.Name = "lblLocationCode";
            this.lblLocationCode.Size = new System.Drawing.Size(76, 13);
            this.lblLocationCode.TabIndex = 9;
            this.lblLocationCode.Text = "Location Code";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(6, 103);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(48, 13);
            this.lblCapacity.TabIndex = 11;
            this.lblCapacity.Text = "Capacity";
            // 
            // lblLocationCodeValue
            // 
            this.lblLocationCodeValue.AutoSize = true;
            this.lblLocationCodeValue.Location = new System.Drawing.Point(106, 71);
            this.lblLocationCodeValue.Name = "lblLocationCodeValue";
            this.lblLocationCodeValue.Size = new System.Drawing.Size(23, 13);
            this.lblLocationCodeValue.TabIndex = 10;
            this.lblLocationCodeValue.Text = "null";
            // 
            // AddAttendeeToStall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 379);
            this.Controls.Add(this.gbxStall);
            this.Controls.Add(this.gbxAttendee);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddAttendeeToStall";
            this.Text = "AddAttendeeToStall";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddAttendeeToStall_FormClosed);
            this.Load += new System.EventHandler(this.AddAttendeeToStall_Load);
            this.gbxAttendee.ResumeLayout(false);
            this.gbxAttendee.PerformLayout();
            this.gbxStall.ResumeLayout(false);
            this.gbxStall.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAttendee;
        private System.Windows.Forms.Label lblStall;
        private System.Windows.Forms.ComboBox cbxAttendee;
        private System.Windows.Forms.ComboBox cbxStall;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxAttendee;
        private System.Windows.Forms.GroupBox gbxStall;
        private System.Windows.Forms.Label lblFirstNameValue;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastNameValue;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblContactValue;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblStallTypeValue;
        private System.Windows.Forms.Label lblStallType;
        private System.Windows.Forms.Label lblCapacityValue;
        private System.Windows.Forms.Label lblLocationCode;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblLocationCodeValue;
        private System.Windows.Forms.Label lblFilledValue;
        private System.Windows.Forms.Label lblFilled;
    }
}