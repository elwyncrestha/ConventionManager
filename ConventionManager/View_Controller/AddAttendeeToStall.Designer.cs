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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAttendeeToStall));
            this.lblAttendee = new System.Windows.Forms.Label();
            this.lblStall = new System.Windows.Forms.Label();
            this.cbxAttendee = new System.Windows.Forms.ComboBox();
            this.cbxStall = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxAttendee = new System.Windows.Forms.GroupBox();
            this.chkIsExhibitor = new System.Windows.Forms.CheckBox();
            this.lblIsExhibitor = new System.Windows.Forms.Label();
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
            this.dgvAttendeeStall = new System.Windows.Forms.DataGridView();
            this.StallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPresenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gbxAttendee.SuspendLayout();
            this.gbxStall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendeeStall)).BeginInit();
            this.SuspendLayout();
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
            // lblStall
            // 
            this.lblStall.AutoSize = true;
            this.lblStall.Location = new System.Drawing.Point(6, 33);
            this.lblStall.Name = "lblStall";
            this.lblStall.Size = new System.Drawing.Size(42, 21);
            this.lblStall.TabIndex = 1;
            this.lblStall.Text = "Stall";
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
            // cbxStall
            // 
            this.cbxStall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStall.FormattingEnabled = true;
            this.cbxStall.Location = new System.Drawing.Point(79, 23);
            this.cbxStall.Name = "cbxStall";
            this.cbxStall.Size = new System.Drawing.Size(205, 29);
            this.cbxStall.TabIndex = 3;
            this.cbxStall.SelectedIndexChanged += new System.EventHandler(this.cbxStall_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.btnAdd.Location = new System.Drawing.Point(264, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 46);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxAttendee
            // 
            this.gbxAttendee.BackColor = System.Drawing.Color.Transparent;
            this.gbxAttendee.Controls.Add(this.chkIsExhibitor);
            this.gbxAttendee.Controls.Add(this.lblIsExhibitor);
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
            this.gbxAttendee.TabIndex = 5;
            this.gbxAttendee.TabStop = false;
            this.gbxAttendee.Text = "Attendee";
            // 
            // chkIsExhibitor
            // 
            this.chkIsExhibitor.AutoSize = true;
            this.chkIsExhibitor.Location = new System.Drawing.Point(142, 193);
            this.chkIsExhibitor.Name = "chkIsExhibitor";
            this.chkIsExhibitor.Size = new System.Drawing.Size(54, 25);
            this.chkIsExhibitor.TabIndex = 10;
            this.chkIsExhibitor.Text = "Yes";
            this.chkIsExhibitor.UseVisualStyleBackColor = true;
            // 
            // lblIsExhibitor
            // 
            this.lblIsExhibitor.AutoSize = true;
            this.lblIsExhibitor.Location = new System.Drawing.Point(9, 197);
            this.lblIsExhibitor.Name = "lblIsExhibitor";
            this.lblIsExhibitor.Size = new System.Drawing.Size(99, 21);
            this.lblIsExhibitor.TabIndex = 9;
            this.lblIsExhibitor.Text = "Is Exhibitor?";
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
            // gbxStall
            // 
            this.gbxStall.BackColor = System.Drawing.Color.Transparent;
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
            this.gbxStall.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.gbxStall.Location = new System.Drawing.Point(297, 14);
            this.gbxStall.Name = "gbxStall";
            this.gbxStall.Size = new System.Drawing.Size(365, 273);
            this.gbxStall.TabIndex = 6;
            this.gbxStall.TabStop = false;
            this.gbxStall.Text = "Stall";
            // 
            // lblFilledValue
            // 
            this.lblFilledValue.AutoSize = true;
            this.lblFilledValue.Location = new System.Drawing.Point(154, 197);
            this.lblFilledValue.Name = "lblFilledValue";
            this.lblFilledValue.Size = new System.Drawing.Size(36, 21);
            this.lblFilledValue.TabIndex = 16;
            this.lblFilledValue.Text = "null";
            // 
            // lblFilled
            // 
            this.lblFilled.AutoSize = true;
            this.lblFilled.Location = new System.Drawing.Point(6, 197);
            this.lblFilled.Name = "lblFilled";
            this.lblFilled.Size = new System.Drawing.Size(49, 21);
            this.lblFilled.TabIndex = 15;
            this.lblFilled.Text = "Filled";
            // 
            // lblStallTypeValue
            // 
            this.lblStallTypeValue.AutoSize = true;
            this.lblStallTypeValue.Location = new System.Drawing.Point(154, 159);
            this.lblStallTypeValue.Name = "lblStallTypeValue";
            this.lblStallTypeValue.Size = new System.Drawing.Size(36, 21);
            this.lblStallTypeValue.TabIndex = 14;
            this.lblStallTypeValue.Text = "null";
            // 
            // lblStallType
            // 
            this.lblStallType.AutoSize = true;
            this.lblStallType.Location = new System.Drawing.Point(6, 159);
            this.lblStallType.Name = "lblStallType";
            this.lblStallType.Size = new System.Drawing.Size(79, 21);
            this.lblStallType.TabIndex = 13;
            this.lblStallType.Text = "Stall Type";
            // 
            // lblCapacityValue
            // 
            this.lblCapacityValue.AutoSize = true;
            this.lblCapacityValue.Location = new System.Drawing.Point(154, 119);
            this.lblCapacityValue.Name = "lblCapacityValue";
            this.lblCapacityValue.Size = new System.Drawing.Size(36, 21);
            this.lblCapacityValue.TabIndex = 12;
            this.lblCapacityValue.Text = "null";
            // 
            // lblLocationCode
            // 
            this.lblLocationCode.AutoSize = true;
            this.lblLocationCode.Location = new System.Drawing.Point(6, 82);
            this.lblLocationCode.Name = "lblLocationCode";
            this.lblLocationCode.Size = new System.Drawing.Size(113, 21);
            this.lblLocationCode.TabIndex = 9;
            this.lblLocationCode.Text = "Location Code";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(6, 119);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(72, 21);
            this.lblCapacity.TabIndex = 11;
            this.lblCapacity.Text = "Capacity";
            // 
            // lblLocationCodeValue
            // 
            this.lblLocationCodeValue.AutoSize = true;
            this.lblLocationCodeValue.Location = new System.Drawing.Point(154, 82);
            this.lblLocationCodeValue.Name = "lblLocationCodeValue";
            this.lblLocationCodeValue.Size = new System.Drawing.Size(36, 21);
            this.lblLocationCodeValue.TabIndex = 10;
            this.lblLocationCodeValue.Text = "null";
            // 
            // dgvAttendeeStall
            // 
            this.dgvAttendeeStall.AllowUserToAddRows = false;
            this.dgvAttendeeStall.AllowUserToDeleteRows = false;
            this.dgvAttendeeStall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendeeStall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendeeStall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StallId,
            this.AttendeeId,
            this.StallName,
            this.AttendeeEmail,
            this.IsPresenter,
            this.Delete});
            this.dgvAttendeeStall.Location = new System.Drawing.Point(15, 376);
            this.dgvAttendeeStall.Name = "dgvAttendeeStall";
            this.dgvAttendeeStall.ReadOnly = true;
            this.dgvAttendeeStall.Size = new System.Drawing.Size(647, 203);
            this.dgvAttendeeStall.TabIndex = 14;
            this.dgvAttendeeStall.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendeeStall_CellContentClick);
            // 
            // StallId
            // 
            this.StallId.DataPropertyName = "StallId";
            this.StallId.HeaderText = "StallId";
            this.StallId.Name = "StallId";
            this.StallId.ReadOnly = true;
            // 
            // AttendeeId
            // 
            this.AttendeeId.DataPropertyName = "AttendeeId";
            this.AttendeeId.HeaderText = "AttendeeId";
            this.AttendeeId.Name = "AttendeeId";
            this.AttendeeId.ReadOnly = true;
            // 
            // StallName
            // 
            this.StallName.DataPropertyName = "StallName";
            this.StallName.HeaderText = "Stall Name";
            this.StallName.Name = "StallName";
            this.StallName.ReadOnly = true;
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
            this.IsPresenter.DataPropertyName = "IsExhibitor";
            this.IsPresenter.HeaderText = "Is Exhibitor";
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
            // AddAttendeeToStall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConventionManager.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 591);
            this.Controls.Add(this.dgvAttendeeStall);
            this.Controls.Add(this.gbxStall);
            this.Controls.Add(this.gbxAttendee);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAttendeeToStall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Attendee To Stall";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddAttendeeToStall_FormClosed);
            this.Load += new System.EventHandler(this.AddAttendeeToStall_Load);
            this.gbxAttendee.ResumeLayout(false);
            this.gbxAttendee.PerformLayout();
            this.gbxStall.ResumeLayout(false);
            this.gbxStall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendeeStall)).EndInit();
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
        private System.Windows.Forms.CheckBox chkIsExhibitor;
        private System.Windows.Forms.Label lblIsExhibitor;
        private System.Windows.Forms.DataGridView dgvAttendeeStall;
        private System.Windows.Forms.DataGridViewTextBoxColumn StallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StallName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPresenter;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}