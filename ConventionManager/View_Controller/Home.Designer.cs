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
            this.mstrAddAttendee = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrDisplayAttendees = new System.Windows.Forms.ToolStripMenuItem();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrAddEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrDisplayEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.seminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrAddSeminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrDisplaySeminars = new System.Windows.Forms.ToolStripMenuItem();
            this.stallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrAddStall = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrDisplayStalls = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrAddAttendeeToStall = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrAddRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrDisplayEditDeleteRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrAddAttendeeToEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrAddAttendeeToSeminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // attendeeToolStripMenuItem
            // 
            this.attendeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrAddAttendee,
            this.mstrDisplayAttendees});
            this.attendeeToolStripMenuItem.Name = "attendeeToolStripMenuItem";
            this.attendeeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.attendeeToolStripMenuItem.Text = "Attendee";
            // 
            // mstrAddAttendee
            // 
            this.mstrAddAttendee.Name = "mstrAddAttendee";
            this.mstrAddAttendee.Size = new System.Drawing.Size(231, 22);
            this.mstrAddAttendee.Text = "Add Attendee";
            this.mstrAddAttendee.Click += new System.EventHandler(this.mstrAddAttendee_Click);
            // 
            // mstrDisplayAttendees
            // 
            this.mstrDisplayAttendees.Name = "mstrDisplayAttendees";
            this.mstrDisplayAttendees.Size = new System.Drawing.Size(231, 22);
            this.mstrDisplayAttendees.Text = "Display/Edit/Delete Attendees";
            this.mstrDisplayAttendees.Click += new System.EventHandler(this.mstrDisplayAttendees_Click);
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrAddEvent,
            this.mstrDisplayEvents,
            this.mstrAddAttendeeToEvent});
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.eventToolStripMenuItem.Text = "Event";
            // 
            // mstrAddEvent
            // 
            this.mstrAddEvent.Name = "mstrAddEvent";
            this.mstrAddEvent.Size = new System.Drawing.Size(212, 22);
            this.mstrAddEvent.Text = "Add Event";
            this.mstrAddEvent.Click += new System.EventHandler(this.mstrAddEvent_Click);
            // 
            // mstrDisplayEvents
            // 
            this.mstrDisplayEvents.Name = "mstrDisplayEvents";
            this.mstrDisplayEvents.Size = new System.Drawing.Size(212, 22);
            this.mstrDisplayEvents.Text = "Display/Edit/Delete Events";
            this.mstrDisplayEvents.Click += new System.EventHandler(this.mstrDisplayEvents_Click);
            // 
            // seminarToolStripMenuItem
            // 
            this.seminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrAddSeminar,
            this.mstrDisplaySeminars,
            this.mstrAddAttendeeToSeminar});
            this.seminarToolStripMenuItem.Name = "seminarToolStripMenuItem";
            this.seminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.seminarToolStripMenuItem.Text = "Seminar";
            // 
            // mstrAddSeminar
            // 
            this.mstrAddSeminar.Name = "mstrAddSeminar";
            this.mstrAddSeminar.Size = new System.Drawing.Size(226, 22);
            this.mstrAddSeminar.Text = "Add Seminar";
            this.mstrAddSeminar.Click += new System.EventHandler(this.mstrAddSeminar_Click);
            // 
            // mstrDisplaySeminars
            // 
            this.mstrDisplaySeminars.Name = "mstrDisplaySeminars";
            this.mstrDisplaySeminars.Size = new System.Drawing.Size(226, 22);
            this.mstrDisplaySeminars.Text = "Display/Edit/Delete Seminars";
            // 
            // stallToolStripMenuItem
            // 
            this.stallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrAddStall,
            this.mstrDisplayStalls,
            this.mstrAddAttendeeToStall});
            this.stallToolStripMenuItem.Name = "stallToolStripMenuItem";
            this.stallToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.stallToolStripMenuItem.Text = "Stall";
            // 
            // mstrAddStall
            // 
            this.mstrAddStall.Name = "mstrAddStall";
            this.mstrAddStall.Size = new System.Drawing.Size(205, 22);
            this.mstrAddStall.Text = "Add Stall";
            this.mstrAddStall.Click += new System.EventHandler(this.mstrAddStall_Click);
            // 
            // mstrDisplayStalls
            // 
            this.mstrDisplayStalls.Name = "mstrDisplayStalls";
            this.mstrDisplayStalls.Size = new System.Drawing.Size(205, 22);
            this.mstrDisplayStalls.Text = "Display/Edit/Delete Stalls";
            this.mstrDisplayStalls.Click += new System.EventHandler(this.mstrDisplayStalls_Click);
            // 
            // mstrAddAttendeeToStall
            // 
            this.mstrAddAttendeeToStall.Name = "mstrAddAttendeeToStall";
            this.mstrAddAttendeeToStall.Size = new System.Drawing.Size(205, 22);
            this.mstrAddAttendeeToStall.Text = "Add Attendee to Stall";
            this.mstrAddAttendeeToStall.Click += new System.EventHandler(this.mstrAddAttendeeToStall_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendeeToolStripMenuItem,
            this.eventToolStripMenuItem,
            this.seminarToolStripMenuItem,
            this.stallToolStripMenuItem,
            this.toolStripMenuItem1,
            this.roomToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstrAddRoom,
            this.mstrDisplayEditDeleteRooms});
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.roomToolStripMenuItem.Text = "Room";
            // 
            // mstrAddRoom
            // 
            this.mstrAddRoom.Name = "mstrAddRoom";
            this.mstrAddRoom.Size = new System.Drawing.Size(215, 22);
            this.mstrAddRoom.Text = "Add Room";
            this.mstrAddRoom.Click += new System.EventHandler(this.mstrAddRoom_Click);
            // 
            // mstrDisplayEditDeleteRooms
            // 
            this.mstrDisplayEditDeleteRooms.Name = "mstrDisplayEditDeleteRooms";
            this.mstrDisplayEditDeleteRooms.Size = new System.Drawing.Size(215, 22);
            this.mstrDisplayEditDeleteRooms.Text = "Display/Edit/Delete Rooms";
            // 
            // mstrAddAttendeeToEvent
            // 
            this.mstrAddAttendeeToEvent.Name = "mstrAddAttendeeToEvent";
            this.mstrAddAttendeeToEvent.Size = new System.Drawing.Size(212, 22);
            this.mstrAddAttendeeToEvent.Text = "Add Attendee to Event";
            this.mstrAddAttendeeToEvent.Click += new System.EventHandler(this.mstrAddAttendeeToEvent_Click);
            // 
            // mstrAddAttendeeToSeminar
            // 
            this.mstrAddAttendeeToSeminar.Name = "mstrAddAttendeeToSeminar";
            this.mstrAddAttendeeToSeminar.Size = new System.Drawing.Size(226, 22);
            this.mstrAddAttendeeToSeminar.Text = "Add Attendee to Seminar";
            this.mstrAddAttendeeToSeminar.Click += new System.EventHandler(this.mstrAddAttendeeToSeminar_Click);
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
        private System.Windows.Forms.ToolStripMenuItem mstrAddAttendee;
        private System.Windows.Forms.ToolStripMenuItem mstrDisplayAttendees;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstrAddEvent;
        private System.Windows.Forms.ToolStripMenuItem mstrDisplayEvents;
        private System.Windows.Forms.ToolStripMenuItem seminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstrAddSeminar;
        private System.Windows.Forms.ToolStripMenuItem mstrDisplaySeminars;
        private System.Windows.Forms.ToolStripMenuItem stallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstrAddStall;
        private System.Windows.Forms.ToolStripMenuItem mstrDisplayStalls;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstrAddRoom;
        private System.Windows.Forms.ToolStripMenuItem mstrDisplayEditDeleteRooms;
        private System.Windows.Forms.ToolStripMenuItem mstrAddAttendeeToStall;
        private System.Windows.Forms.ToolStripMenuItem mstrAddAttendeeToEvent;
        private System.Windows.Forms.ToolStripMenuItem mstrAddAttendeeToSeminar;
    }
}