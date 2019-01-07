namespace ConventionManager.View_Controller
{
    partial class ConventionManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConventionManager));
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lnkAdmin = new System.Windows.Forms.LinkLabel();
            this.gbxConventionManager = new System.Windows.Forms.GroupBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.txtAttendeeEmail = new System.Windows.Forms.TextBox();
            this.gbxConventionManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.btnCheckIn.Location = new System.Drawing.Point(42, 124);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(155, 35);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Attendee Check-in";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // lnkAdmin
            // 
            this.lnkAdmin.AutoSize = true;
            this.lnkAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lnkAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkAdmin.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lnkAdmin.LinkColor = System.Drawing.Color.Black;
            this.lnkAdmin.Location = new System.Drawing.Point(67, 241);
            this.lnkAdmin.Name = "lnkAdmin";
            this.lnkAdmin.Size = new System.Drawing.Size(106, 21);
            this.lnkAdmin.TabIndex = 4;
            this.lnkAdmin.TabStop = true;
            this.lnkAdmin.Text = "- Admin Login";
            this.lnkAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdmin_LinkClicked);
            // 
            // gbxConventionManager
            // 
            this.gbxConventionManager.BackColor = System.Drawing.Color.Transparent;
            this.gbxConventionManager.Controls.Add(this.txtAttendeeEmail);
            this.gbxConventionManager.Controls.Add(this.lblIntro);
            this.gbxConventionManager.Controls.Add(this.lnkAdmin);
            this.gbxConventionManager.Controls.Add(this.btnCheckIn);
            this.gbxConventionManager.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.gbxConventionManager.Location = new System.Drawing.Point(12, 12);
            this.gbxConventionManager.Name = "gbxConventionManager";
            this.gbxConventionManager.Size = new System.Drawing.Size(260, 277);
            this.gbxConventionManager.TabIndex = 3;
            this.gbxConventionManager.TabStop = false;
            this.gbxConventionManager.Text = "Convention Manager System";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(6, 44);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(250, 21);
            this.lblIntro.TabIndex = 2;
            this.lblIntro.Text = "Enter email for attendee check-in";
            // 
            // txtAttendeeEmail
            // 
            this.txtAttendeeEmail.Location = new System.Drawing.Point(10, 78);
            this.txtAttendeeEmail.Name = "txtAttendeeEmail";
            this.txtAttendeeEmail.Size = new System.Drawing.Size(244, 26);
            this.txtAttendeeEmail.TabIndex = 1;
            // 
            // ConventionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConventionManager.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.gbxConventionManager);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConventionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convention Manager";
            this.gbxConventionManager.ResumeLayout(false);
            this.gbxConventionManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.LinkLabel lnkAdmin;
        private System.Windows.Forms.GroupBox gbxConventionManager;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.TextBox txtAttendeeEmail;
    }
}