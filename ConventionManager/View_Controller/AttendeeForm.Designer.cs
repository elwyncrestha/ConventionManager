namespace ConventionManager.View_Controller
{
    partial class AttendeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendeeForm));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtTicketType = new System.Windows.Forms.TextBox();
            this.lblTicketType = new System.Windows.Forms.Label();
            this.txtAttendingDays = new System.Windows.Forms.TextBox();
            this.lblAttendingDays = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAttendees = new System.Windows.Forms.DataGridView();
            this.AttendeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendeeFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendeeLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendeeContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendeeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblFirstName.Location = new System.Drawing.Point(12, 28);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 21);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(168, 23);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(169, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.txtLastName.Location = new System.Drawing.Point(168, 82);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(169, 26);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblLastName.Location = new System.Drawing.Point(12, 91);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 21);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.txtEmail.Location = new System.Drawing.Point(168, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblEmail.Location = new System.Drawing.Point(12, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 21);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.txtContact.Location = new System.Drawing.Point(168, 200);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(169, 26);
            this.txtContact.TabIndex = 7;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.Transparent;
            this.lblContact.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblContact.Location = new System.Drawing.Point(12, 205);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(67, 21);
            this.lblContact.TabIndex = 6;
            this.lblContact.Text = "Contact";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.txtAddress.Location = new System.Drawing.Point(564, 23);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(166, 26);
            this.txtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblAddress.Location = new System.Drawing.Point(392, 28);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(69, 21);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // txtTicketType
            // 
            this.txtTicketType.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.txtTicketType.Location = new System.Drawing.Point(564, 79);
            this.txtTicketType.Name = "txtTicketType";
            this.txtTicketType.Size = new System.Drawing.Size(166, 26);
            this.txtTicketType.TabIndex = 11;
            // 
            // lblTicketType
            // 
            this.lblTicketType.AutoSize = true;
            this.lblTicketType.BackColor = System.Drawing.Color.Transparent;
            this.lblTicketType.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblTicketType.Location = new System.Drawing.Point(392, 82);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(91, 21);
            this.lblTicketType.TabIndex = 10;
            this.lblTicketType.Text = "Ticket Type";
            // 
            // txtAttendingDays
            // 
            this.txtAttendingDays.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.txtAttendingDays.Location = new System.Drawing.Point(564, 138);
            this.txtAttendingDays.Name = "txtAttendingDays";
            this.txtAttendingDays.Size = new System.Drawing.Size(166, 26);
            this.txtAttendingDays.TabIndex = 13;
            // 
            // lblAttendingDays
            // 
            this.lblAttendingDays.AutoSize = true;
            this.lblAttendingDays.BackColor = System.Drawing.Color.Transparent;
            this.lblAttendingDays.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblAttendingDays.Location = new System.Drawing.Point(392, 143);
            this.lblAttendingDays.Name = "lblAttendingDays";
            this.lblAttendingDays.Size = new System.Drawing.Size(155, 21);
            this.lblAttendingDays.TabIndex = 12;
            this.lblAttendingDays.Text = "Attending days (No.)";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.btnAdd.Location = new System.Drawing.Point(516, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAttendees
            // 
            this.dgvAttendees.AllowUserToAddRows = false;
            this.dgvAttendees.AllowUserToDeleteRows = false;
            this.dgvAttendees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendeeId,
            this.AttendeeFName,
            this.AttendeeLName,
            this.AttendeeEmail,
            this.AttendeeContact,
            this.AttendeeAddress,
            this.TicketType,
            this.AttendingDays,
            this.IsAvailable,
            this.Edit,
            this.Delete});
            this.dgvAttendees.Location = new System.Drawing.Point(16, 275);
            this.dgvAttendees.Name = "dgvAttendees";
            this.dgvAttendees.ReadOnly = true;
            this.dgvAttendees.Size = new System.Drawing.Size(734, 236);
            this.dgvAttendees.TabIndex = 17;
            this.dgvAttendees.Click += new System.EventHandler(this.dgvAttendees_Click);
            // 
            // AttendeeId
            // 
            this.AttendeeId.DataPropertyName = "AttendeeId";
            this.AttendeeId.HeaderText = "Id";
            this.AttendeeId.Name = "AttendeeId";
            this.AttendeeId.ReadOnly = true;
            // 
            // AttendeeFName
            // 
            this.AttendeeFName.DataPropertyName = "AttendeeFName";
            this.AttendeeFName.HeaderText = "First name";
            this.AttendeeFName.Name = "AttendeeFName";
            this.AttendeeFName.ReadOnly = true;
            // 
            // AttendeeLName
            // 
            this.AttendeeLName.DataPropertyName = "AttendeeLName";
            this.AttendeeLName.HeaderText = "Last name";
            this.AttendeeLName.Name = "AttendeeLName";
            this.AttendeeLName.ReadOnly = true;
            // 
            // AttendeeEmail
            // 
            this.AttendeeEmail.DataPropertyName = "AttendeeEmail";
            this.AttendeeEmail.HeaderText = "Email";
            this.AttendeeEmail.Name = "AttendeeEmail";
            this.AttendeeEmail.ReadOnly = true;
            // 
            // AttendeeContact
            // 
            this.AttendeeContact.DataPropertyName = "AttendeeContact";
            this.AttendeeContact.HeaderText = "Contact";
            this.AttendeeContact.Name = "AttendeeContact";
            this.AttendeeContact.ReadOnly = true;
            // 
            // AttendeeAddress
            // 
            this.AttendeeAddress.DataPropertyName = "AttendeeAddress";
            this.AttendeeAddress.HeaderText = "Address";
            this.AttendeeAddress.Name = "AttendeeAddress";
            this.AttendeeAddress.ReadOnly = true;
            // 
            // TicketType
            // 
            this.TicketType.DataPropertyName = "TicketType";
            this.TicketType.HeaderText = "Ticket Type";
            this.TicketType.Name = "TicketType";
            this.TicketType.ReadOnly = true;
            // 
            // AttendingDays
            // 
            this.AttendingDays.DataPropertyName = "AttendingDays";
            this.AttendingDays.HeaderText = "Attending Days";
            this.AttendingDays.Name = "AttendingDays";
            this.AttendingDays.ReadOnly = true;
            // 
            // IsAvailable
            // 
            this.IsAvailable.DataPropertyName = "IsAvailable";
            this.IsAvailable.HeaderText = "Is Available";
            this.IsAvailable.Name = "IsAvailable";
            this.IsAvailable.ReadOnly = true;
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
            // AttendeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConventionManager.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 549);
            this.Controls.Add(this.dgvAttendees);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAttendingDays);
            this.Controls.Add(this.lblAttendingDays);
            this.Controls.Add(this.txtTicketType);
            this.Controls.Add(this.lblTicketType);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttendeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Attendee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AttendeeForm_FormClosed);
            this.Load += new System.EventHandler(this.AddAttendee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtTicketType;
        private System.Windows.Forms.Label lblTicketType;
        private System.Windows.Forms.TextBox txtAttendingDays;
        private System.Windows.Forms.Label lblAttendingDays;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAttendees;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendeeFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendeeLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendeeContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendeeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendingDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAvailable;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}