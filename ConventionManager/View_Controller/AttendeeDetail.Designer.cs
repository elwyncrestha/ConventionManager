namespace ConventionManager.View_Controller
{
    partial class AttendeeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendeeDetail));
            this.lblSelectAttendee = new System.Windows.Forms.Label();
            this.dgvAttendeeDetails = new System.Windows.Forms.DataGridView();
            this.cbxAttendee = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactValue = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAttendingDaysValue = new System.Windows.Forms.Label();
            this.lblAttendingDays = new System.Windows.Forms.Label();
            this.lblTicketTypeValue = new System.Windows.Forms.Label();
            this.lblTicketType = new System.Windows.Forms.Label();
            this.lblAddressValue = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectAttendee
            // 
            this.lblSelectAttendee.AutoSize = true;
            this.lblSelectAttendee.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectAttendee.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F);
            this.lblSelectAttendee.Location = new System.Drawing.Point(12, 25);
            this.lblSelectAttendee.Name = "lblSelectAttendee";
            this.lblSelectAttendee.Size = new System.Drawing.Size(169, 28);
            this.lblSelectAttendee.TabIndex = 5;
            this.lblSelectAttendee.Text = "Select Attendee";
            // 
            // dgvAttendeeDetails
            // 
            this.dgvAttendeeDetails.AllowUserToAddRows = false;
            this.dgvAttendeeDetails.AllowUserToDeleteRows = false;
            this.dgvAttendeeDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendeeDetails.Location = new System.Drawing.Point(429, 24);
            this.dgvAttendeeDetails.Name = "dgvAttendeeDetails";
            this.dgvAttendeeDetails.ReadOnly = true;
            this.dgvAttendeeDetails.Size = new System.Drawing.Size(311, 389);
            this.dgvAttendeeDetails.TabIndex = 4;
            // 
            // cbxAttendee
            // 
            this.cbxAttendee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAttendee.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.cbxAttendee.FormattingEnabled = true;
            this.cbxAttendee.Location = new System.Drawing.Point(205, 24);
            this.cbxAttendee.Name = "cbxAttendee";
            this.cbxAttendee.Size = new System.Drawing.Size(218, 29);
            this.cbxAttendee.TabIndex = 3;
            this.cbxAttendee.SelectedIndexChanged += new System.EventHandler(this.cbxAttendee_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblName.Location = new System.Drawing.Point(13, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 21);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.BackColor = System.Drawing.Color.Transparent;
            this.lblNameValue.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblNameValue.Location = new System.Drawing.Point(201, 84);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(36, 21);
            this.lblNameValue.TabIndex = 7;
            this.lblNameValue.Text = "null";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailValue.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblEmailValue.Location = new System.Drawing.Point(201, 131);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(36, 21);
            this.lblEmailValue.TabIndex = 9;
            this.lblEmailValue.Text = "null";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblEmail.Location = new System.Drawing.Point(13, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 21);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblContactValue
            // 
            this.lblContactValue.AutoSize = true;
            this.lblContactValue.BackColor = System.Drawing.Color.Transparent;
            this.lblContactValue.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblContactValue.Location = new System.Drawing.Point(201, 178);
            this.lblContactValue.Name = "lblContactValue";
            this.lblContactValue.Size = new System.Drawing.Size(36, 21);
            this.lblContactValue.TabIndex = 11;
            this.lblContactValue.Text = "null";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.Transparent;
            this.lblContact.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblContact.Location = new System.Drawing.Point(13, 178);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(67, 21);
            this.lblContact.TabIndex = 10;
            this.lblContact.Text = "Contact";
            // 
            // lblAttendingDaysValue
            // 
            this.lblAttendingDaysValue.AutoSize = true;
            this.lblAttendingDaysValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAttendingDaysValue.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblAttendingDaysValue.Location = new System.Drawing.Point(201, 315);
            this.lblAttendingDaysValue.Name = "lblAttendingDaysValue";
            this.lblAttendingDaysValue.Size = new System.Drawing.Size(36, 21);
            this.lblAttendingDaysValue.TabIndex = 17;
            this.lblAttendingDaysValue.Text = "null";
            // 
            // lblAttendingDays
            // 
            this.lblAttendingDays.AutoSize = true;
            this.lblAttendingDays.BackColor = System.Drawing.Color.Transparent;
            this.lblAttendingDays.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblAttendingDays.Location = new System.Drawing.Point(11, 315);
            this.lblAttendingDays.Name = "lblAttendingDays";
            this.lblAttendingDays.Size = new System.Drawing.Size(115, 21);
            this.lblAttendingDays.TabIndex = 16;
            this.lblAttendingDays.Text = "AttendingDays";
            // 
            // lblTicketTypeValue
            // 
            this.lblTicketTypeValue.AutoSize = true;
            this.lblTicketTypeValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTicketTypeValue.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblTicketTypeValue.Location = new System.Drawing.Point(201, 268);
            this.lblTicketTypeValue.Name = "lblTicketTypeValue";
            this.lblTicketTypeValue.Size = new System.Drawing.Size(36, 21);
            this.lblTicketTypeValue.TabIndex = 15;
            this.lblTicketTypeValue.Text = "null";
            // 
            // lblTicketType
            // 
            this.lblTicketType.AutoSize = true;
            this.lblTicketType.BackColor = System.Drawing.Color.Transparent;
            this.lblTicketType.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblTicketType.Location = new System.Drawing.Point(11, 268);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(91, 21);
            this.lblTicketType.TabIndex = 14;
            this.lblTicketType.Text = "Ticket Type";
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.AutoSize = true;
            this.lblAddressValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressValue.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblAddressValue.Location = new System.Drawing.Point(201, 221);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(36, 21);
            this.lblAddressValue.TabIndex = 13;
            this.lblAddressValue.Text = "null";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblAddress.Location = new System.Drawing.Point(11, 221);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(69, 21);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(79, 369);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(83, 44);
            this.btnView.TabIndex = 20;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // AttendeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConventionManager.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 441);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblAttendingDaysValue);
            this.Controls.Add(this.lblAttendingDays);
            this.Controls.Add(this.lblTicketTypeValue);
            this.Controls.Add(this.lblTicketType);
            this.Controls.Add(this.lblAddressValue);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContactValue);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblEmailValue);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSelectAttendee);
            this.Controls.Add(this.dgvAttendeeDetails);
            this.Controls.Add(this.cbxAttendee);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttendeeDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendeeDetail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AttendeeDetail_FormClosed);
            this.Load += new System.EventHandler(this.AttendeeDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendeeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectAttendee;
        private System.Windows.Forms.DataGridView dgvAttendeeDetails;
        private System.Windows.Forms.ComboBox cbxAttendee;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactValue;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblAttendingDaysValue;
        private System.Windows.Forms.Label lblAttendingDays;
        private System.Windows.Forms.Label lblTicketTypeValue;
        private System.Windows.Forms.Label lblTicketType;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnView;
    }
}