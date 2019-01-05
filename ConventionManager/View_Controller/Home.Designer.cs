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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrManageRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrRoomUsage = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrTEST = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // attendeeToolStripMenuItem
            // 
            this.attendeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrManageAttendee});
            this.attendeeToolStripMenuItem.Name = "attendeeToolStripMenuItem";
            this.attendeeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.attendeeToolStripMenuItem.Text = "Attendee";
            // 
            // mstrManageAttendee
            // 
            this.mstrManageAttendee.Name = "mstrManageAttendee";
            this.mstrManageAttendee.Size = new System.Drawing.Size(168, 22);
            this.mstrManageAttendee.Text = "Manage Attendee";
            this.mstrManageAttendee.Click += new System.EventHandler(this.mstrManageAttendee_Click);
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrManageEvent,
            this.mstrAddAttendeeToEvent});
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.eventToolStripMenuItem.Text = "Event";
            // 
            // mstrManageEvent
            // 
            this.mstrManageEvent.Name = "mstrManageEvent";
            this.mstrManageEvent.Size = new System.Drawing.Size(193, 22);
            this.mstrManageEvent.Text = "Manage Event";
            this.mstrManageEvent.Click += new System.EventHandler(this.mstrManageEvent_Click);
            // 
            // mstrAddAttendeeToEvent
            // 
            this.mstrAddAttendeeToEvent.Name = "mstrAddAttendeeToEvent";
            this.mstrAddAttendeeToEvent.Size = new System.Drawing.Size(193, 22);
            this.mstrAddAttendeeToEvent.Text = "Add Attendee to Event";
            this.mstrAddAttendeeToEvent.Click += new System.EventHandler(this.mstrAddAttendeeToEvent_Click);
            // 
            // seminarToolStripMenuItem
            // 
            this.seminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrManageSeminar,
            this.mstrAddAttendeeToSeminar});
            this.seminarToolStripMenuItem.Name = "seminarToolStripMenuItem";
            this.seminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.seminarToolStripMenuItem.Text = "Seminar";
            // 
            // mstrManageSeminar
            // 
            this.mstrManageSeminar.Name = "mstrManageSeminar";
            this.mstrManageSeminar.Size = new System.Drawing.Size(207, 22);
            this.mstrManageSeminar.Text = "Manage Seminar";
            this.mstrManageSeminar.Click += new System.EventHandler(this.mstrManageSeminar_Click);
            // 
            // mstrAddAttendeeToSeminar
            // 
            this.mstrAddAttendeeToSeminar.Name = "mstrAddAttendeeToSeminar";
            this.mstrAddAttendeeToSeminar.Size = new System.Drawing.Size(207, 22);
            this.mstrAddAttendeeToSeminar.Text = "Add Attendee to Seminar";
            this.mstrAddAttendeeToSeminar.Click += new System.EventHandler(this.mstrAddAttendeeToSeminar_Click);
            // 
            // stallToolStripMenuItem
            // 
            this.stallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrManageStall,
            this.mstrAddAttendeeToStall});
            this.stallToolStripMenuItem.Name = "stallToolStripMenuItem";
            this.stallToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.stallToolStripMenuItem.Text = "Stall";
            // 
            // mstrManageStall
            // 
            this.mstrManageStall.Name = "mstrManageStall";
            this.mstrManageStall.Size = new System.Drawing.Size(186, 22);
            this.mstrManageStall.Text = "Manage Stall";
            this.mstrManageStall.Click += new System.EventHandler(this.mstrManageStall_Click);
            // 
            // mstrAddAttendeeToStall
            // 
            this.mstrAddAttendeeToStall.Name = "mstrAddAttendeeToStall";
            this.mstrAddAttendeeToStall.Size = new System.Drawing.Size(186, 22);
            this.mstrAddAttendeeToStall.Text = "Add Attendee to Stall";
            this.mstrAddAttendeeToStall.Click += new System.EventHandler(this.mstrAddAttendeeToStall_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendeeToolStripMenuItem,
            this.eventToolStripMenuItem,
            this.seminarToolStripMenuItem,
            this.stallToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.mstrTEST});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrManageRoom,
            this.mstrRoomUsage});
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.roomToolStripMenuItem.Text = "Room";
            // 
            // mstrManageRoom
            // 
            this.mstrManageRoom.Name = "mstrManageRoom";
            this.mstrManageRoom.Size = new System.Drawing.Size(215, 22);
            this.mstrManageRoom.Text = "Manage Room";
            this.mstrManageRoom.Click += new System.EventHandler(this.mstrManageRoom_Click);
            // 
            // mstrRoomUsage
            // 
            this.mstrRoomUsage.Name = "mstrRoomUsage";
            this.mstrRoomUsage.Size = new System.Drawing.Size(215, 22);
            this.mstrRoomUsage.Text = "Room Usage";
            this.mstrRoomUsage.Click += new System.EventHandler(this.mstrRoomUsage_Click);
            // 
            // mstrTEST
            // 
            this.mstrTEST.Name = "mstrTEST";
            this.mstrTEST.Size = new System.Drawing.Size(45, 20);
            this.mstrTEST.Text = "TEST";
            this.mstrTEST.Click += new System.EventHandler(this.mstrTEST_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 341);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstrManageRoom;
        private System.Windows.Forms.ToolStripMenuItem mstrAddAttendeeToStall;
        private System.Windows.Forms.ToolStripMenuItem mstrAddAttendeeToEvent;
        private System.Windows.Forms.ToolStripMenuItem mstrAddAttendeeToSeminar;
        private System.Windows.Forms.ToolStripMenuItem mstrTEST;
        private System.Windows.Forms.ToolStripMenuItem mstrRoomUsage;
    }
}