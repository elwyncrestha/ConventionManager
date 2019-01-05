namespace ConventionManager
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.attendeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrManageAttendee = new System.Windows.Forms.ToolStripMenuItem();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrManageEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrAddAttendeeToEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.seminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrManageSeminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrAddAttendeeToSeminar = new System.Windows.Forms.ToolStripMenuItem();
            this.stallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrManageStall = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrAddAttendeeToStall = new System.Windows.Forms.ToolStripMenuItem();
            this.stripHome = new System.Windows.Forms.MenuStrip();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrManageRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrRoomUsage = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrTEST = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxConventionManager = new System.Windows.Forms.GroupBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblDetail1 = new System.Windows.Forms.Label();
            this.lblDetail2 = new System.Windows.Forms.Label();
            this.lblDetail3 = new System.Windows.Forms.Label();
            this.lblDetail4 = new System.Windows.Forms.Label();
            this.lblDetail5 = new System.Windows.Forms.Label();
            this.lblDetail6 = new System.Windows.Forms.Label();
            this.stripHome.SuspendLayout();
            this.gbxConventionManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // attendeeToolStripMenuItem
            // 
            this.attendeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrManageAttendee});
            this.attendeeToolStripMenuItem.Name = "attendeeToolStripMenuItem";
            this.attendeeToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.attendeeToolStripMenuItem.Text = "Attendee";
            // 
            // mstrManageAttendee
            // 
            this.mstrManageAttendee.Name = "mstrManageAttendee";
            this.mstrManageAttendee.Size = new System.Drawing.Size(210, 26);
            this.mstrManageAttendee.Text = "Manage Attendee";
            this.mstrManageAttendee.Click += new System.EventHandler(this.mstrManageAttendee_Click);
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrManageEvent,
            this.mstrAddAttendeeToEvent});
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.eventToolStripMenuItem.Text = "Event";
            // 
            // mstrManageEvent
            // 
            this.mstrManageEvent.Name = "mstrManageEvent";
            this.mstrManageEvent.Size = new System.Drawing.Size(242, 26);
            this.mstrManageEvent.Text = "Manage Event";
            this.mstrManageEvent.Click += new System.EventHandler(this.mstrManageEvent_Click);
            // 
            // mstrAddAttendeeToEvent
            // 
            this.mstrAddAttendeeToEvent.Name = "mstrAddAttendeeToEvent";
            this.mstrAddAttendeeToEvent.Size = new System.Drawing.Size(242, 26);
            this.mstrAddAttendeeToEvent.Text = "Add Attendee to Event";
            this.mstrAddAttendeeToEvent.Click += new System.EventHandler(this.mstrAddAttendeeToEvent_Click);
            // 
            // seminarToolStripMenuItem
            // 
            this.seminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrManageSeminar,
            this.mstrAddAttendeeToSeminar});
            this.seminarToolStripMenuItem.Name = "seminarToolStripMenuItem";
            this.seminarToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.seminarToolStripMenuItem.Text = "Seminar";
            // 
            // mstrManageSeminar
            // 
            this.mstrManageSeminar.Name = "mstrManageSeminar";
            this.mstrManageSeminar.Size = new System.Drawing.Size(261, 26);
            this.mstrManageSeminar.Text = "Manage Seminar";
            this.mstrManageSeminar.Click += new System.EventHandler(this.mstrManageSeminar_Click);
            // 
            // mstrAddAttendeeToSeminar
            // 
            this.mstrAddAttendeeToSeminar.Name = "mstrAddAttendeeToSeminar";
            this.mstrAddAttendeeToSeminar.Size = new System.Drawing.Size(261, 26);
            this.mstrAddAttendeeToSeminar.Text = "Add Attendee to Seminar";
            this.mstrAddAttendeeToSeminar.Click += new System.EventHandler(this.mstrAddAttendeeToSeminar_Click);
            // 
            // stallToolStripMenuItem
            // 
            this.stallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrManageStall,
            this.mstrAddAttendeeToStall});
            this.stallToolStripMenuItem.Name = "stallToolStripMenuItem";
            this.stallToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.stallToolStripMenuItem.Text = "Stall";
            // 
            // mstrManageStall
            // 
            this.mstrManageStall.Name = "mstrManageStall";
            this.mstrManageStall.Size = new System.Drawing.Size(234, 26);
            this.mstrManageStall.Text = "Manage Stall";
            this.mstrManageStall.Click += new System.EventHandler(this.mstrManageStall_Click);
            // 
            // mstrAddAttendeeToStall
            // 
            this.mstrAddAttendeeToStall.Name = "mstrAddAttendeeToStall";
            this.mstrAddAttendeeToStall.Size = new System.Drawing.Size(234, 26);
            this.mstrAddAttendeeToStall.Text = "Add Attendee to Stall";
            this.mstrAddAttendeeToStall.Click += new System.EventHandler(this.mstrAddAttendeeToStall_Click);
            // 
            // stripHome
            // 
            this.stripHome.BackColor = System.Drawing.Color.Transparent;
            this.stripHome.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendeeToolStripMenuItem,
            this.eventToolStripMenuItem,
            this.seminarToolStripMenuItem,
            this.stallToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.mstrTEST});
            this.stripHome.Location = new System.Drawing.Point(0, 0);
            this.stripHome.Name = "stripHome";
            this.stripHome.Size = new System.Drawing.Size(438, 29);
            this.stripHome.TabIndex = 0;
            this.stripHome.Text = "menuStrip1";
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrManageRoom,
            this.mstrRoomUsage});
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.roomToolStripMenuItem.Text = "Room";
            // 
            // mstrManageRoom
            // 
            this.mstrManageRoom.Name = "mstrManageRoom";
            this.mstrManageRoom.Size = new System.Drawing.Size(185, 26);
            this.mstrManageRoom.Text = "Manage Room";
            this.mstrManageRoom.Click += new System.EventHandler(this.mstrManageRoom_Click);
            // 
            // mstrRoomUsage
            // 
            this.mstrRoomUsage.Name = "mstrRoomUsage";
            this.mstrRoomUsage.Size = new System.Drawing.Size(185, 26);
            this.mstrRoomUsage.Text = "Room Usage";
            this.mstrRoomUsage.Click += new System.EventHandler(this.mstrRoomUsage_Click);
            // 
            // mstrTEST
            // 
            this.mstrTEST.Name = "mstrTEST";
            this.mstrTEST.Size = new System.Drawing.Size(56, 25);
            this.mstrTEST.Text = "TEST";
            this.mstrTEST.Click += new System.EventHandler(this.mstrTEST_Click);
            // 
            // gbxConventionManager
            // 
            this.gbxConventionManager.BackColor = System.Drawing.Color.Transparent;
            this.gbxConventionManager.Controls.Add(this.lblDetail6);
            this.gbxConventionManager.Controls.Add(this.lblDetail5);
            this.gbxConventionManager.Controls.Add(this.lblDetail4);
            this.gbxConventionManager.Controls.Add(this.lblDetail3);
            this.gbxConventionManager.Controls.Add(this.lblDetail2);
            this.gbxConventionManager.Controls.Add(this.lblDetail1);
            this.gbxConventionManager.Controls.Add(this.lblIntro);
            this.gbxConventionManager.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.gbxConventionManager.Location = new System.Drawing.Point(13, 59);
            this.gbxConventionManager.Name = "gbxConventionManager";
            this.gbxConventionManager.Size = new System.Drawing.Size(413, 241);
            this.gbxConventionManager.TabIndex = 1;
            this.gbxConventionManager.TabStop = false;
            this.gbxConventionManager.Text = "Convention Manager System";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(6, 44);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(381, 21);
            this.lblIntro.TabIndex = 2;
            this.lblIntro.Text = "A multi-feature system to well manage conventions.";
            // 
            // lblDetail1
            // 
            this.lblDetail1.AutoSize = true;
            this.lblDetail1.Location = new System.Drawing.Point(6, 76);
            this.lblDetail1.Name = "lblDetail1";
            this.lblDetail1.Size = new System.Drawing.Size(381, 21);
            this.lblDetail1.TabIndex = 3;
            this.lblDetail1.Text = "This system tracks and manage following elements:";
            // 
            // lblDetail2
            // 
            this.lblDetail2.AutoSize = true;
            this.lblDetail2.Location = new System.Drawing.Point(6, 122);
            this.lblDetail2.Name = "lblDetail2";
            this.lblDetail2.Size = new System.Drawing.Size(209, 21);
            this.lblDetail2.TabIndex = 4;
            this.lblDetail2.Text = "- Rooms and Stall Locations";
            // 
            // lblDetail3
            // 
            this.lblDetail3.AutoSize = true;
            this.lblDetail3.Location = new System.Drawing.Point(6, 143);
            this.lblDetail3.Name = "lblDetail3";
            this.lblDetail3.Size = new System.Drawing.Size(93, 21);
            this.lblDetail3.TabIndex = 5;
            this.lblDetail3.Text = "- Attendees";
            // 
            // lblDetail4
            // 
            this.lblDetail4.AutoSize = true;
            this.lblDetail4.Location = new System.Drawing.Point(6, 164);
            this.lblDetail4.Name = "lblDetail4";
            this.lblDetail4.Size = new System.Drawing.Size(58, 21);
            this.lblDetail4.TabIndex = 6;
            this.lblDetail4.Text = "- Stalls";
            // 
            // lblDetail5
            // 
            this.lblDetail5.AutoSize = true;
            this.lblDetail5.Location = new System.Drawing.Point(6, 185);
            this.lblDetail5.Name = "lblDetail5";
            this.lblDetail5.Size = new System.Drawing.Size(85, 21);
            this.lblDetail5.TabIndex = 7;
            this.lblDetail5.Text = "- Seminars";
            // 
            // lblDetail6
            // 
            this.lblDetail6.AutoSize = true;
            this.lblDetail6.Location = new System.Drawing.Point(6, 206);
            this.lblDetail6.Name = "lblDetail6";
            this.lblDetail6.Size = new System.Drawing.Size(66, 21);
            this.lblDetail6.TabIndex = 8;
            this.lblDetail6.Text = "- Events";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConventionManager.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(438, 312);
            this.Controls.Add(this.gbxConventionManager);
            this.Controls.Add(this.stripHome);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.stripHome;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convention Manager Home";
            this.stripHome.ResumeLayout(false);
            this.stripHome.PerformLayout();
            this.gbxConventionManager.ResumeLayout(false);
            this.gbxConventionManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem attendeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstrManageAttendee;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstrManageEvent;
        private System.Windows.Forms.ToolStripMenuItem seminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstrManageSeminar;
        private System.Windows.Forms.ToolStripMenuItem stallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstrManageStall;
        private System.Windows.Forms.MenuStrip stripHome;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstrManageRoom;
        private System.Windows.Forms.ToolStripMenuItem mstrAddAttendeeToStall;
        private System.Windows.Forms.ToolStripMenuItem mstrAddAttendeeToEvent;
        private System.Windows.Forms.ToolStripMenuItem mstrAddAttendeeToSeminar;
        private System.Windows.Forms.ToolStripMenuItem mstrTEST;
        private System.Windows.Forms.ToolStripMenuItem mstrRoomUsage;
        private System.Windows.Forms.GroupBox gbxConventionManager;
        private System.Windows.Forms.Label lblDetail1;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblDetail6;
        private System.Windows.Forms.Label lblDetail5;
        private System.Windows.Forms.Label lblDetail4;
        private System.Windows.Forms.Label lblDetail3;
        private System.Windows.Forms.Label lblDetail2;
    }
}