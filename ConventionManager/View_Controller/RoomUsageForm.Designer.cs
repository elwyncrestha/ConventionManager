namespace ConventionManager.View_Controller
{
    partial class RoomUsageForm
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
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.dgvRoomUsage = new System.Windows.Forms.DataGridView();
            this.lblSelectRoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxRoom
            // 
            this.cbxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(135, 69);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(178, 21);
            this.cbxRoom.TabIndex = 0;
            this.cbxRoom.SelectedIndexChanged += new System.EventHandler(this.cbxRoom_SelectedIndexChanged);
            // 
            // dgvRoomUsage
            // 
            this.dgvRoomUsage.AllowUserToAddRows = false;
            this.dgvRoomUsage.AllowUserToDeleteRows = false;
            this.dgvRoomUsage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomUsage.Location = new System.Drawing.Point(12, 183);
            this.dgvRoomUsage.Name = "dgvRoomUsage";
            this.dgvRoomUsage.ReadOnly = true;
            this.dgvRoomUsage.Size = new System.Drawing.Size(421, 177);
            this.dgvRoomUsage.TabIndex = 1;
            // 
            // lblSelectRoom
            // 
            this.lblSelectRoom.AutoSize = true;
            this.lblSelectRoom.Location = new System.Drawing.Point(190, 34);
            this.lblSelectRoom.Name = "lblSelectRoom";
            this.lblSelectRoom.Size = new System.Drawing.Size(68, 13);
            this.lblSelectRoom.TabIndex = 2;
            this.lblSelectRoom.Text = "Select Room";
            // 
            // RoomUsageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 413);
            this.Controls.Add(this.lblSelectRoom);
            this.Controls.Add(this.dgvRoomUsage);
            this.Controls.Add(this.cbxRoom);
            this.Name = "RoomUsageForm";
            this.Text = "RoomUsage";
            this.Load += new System.EventHandler(this.RoomUsageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomUsage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxRoom;
        private System.Windows.Forms.DataGridView dgvRoomUsage;
        private System.Windows.Forms.Label lblSelectRoom;
    }
}