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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomUsageForm));
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.dgvRoomUsage = new System.Windows.Forms.DataGridView();
            this.lblSelectRoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxRoom
            // 
            this.cbxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoom.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(135, 80);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(178, 29);
            this.cbxRoom.TabIndex = 0;
            this.cbxRoom.SelectedIndexChanged += new System.EventHandler(this.cbxRoom_SelectedIndexChanged);
            // 
            // dgvRoomUsage
            // 
            this.dgvRoomUsage.AllowUserToAddRows = false;
            this.dgvRoomUsage.AllowUserToDeleteRows = false;
            this.dgvRoomUsage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomUsage.Location = new System.Drawing.Point(12, 211);
            this.dgvRoomUsage.Name = "dgvRoomUsage";
            this.dgvRoomUsage.ReadOnly = true;
            this.dgvRoomUsage.Size = new System.Drawing.Size(421, 204);
            this.dgvRoomUsage.TabIndex = 1;
            // 
            // lblSelectRoom
            // 
            this.lblSelectRoom.AutoSize = true;
            this.lblSelectRoom.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectRoom.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F);
            this.lblSelectRoom.Location = new System.Drawing.Point(158, 33);
            this.lblSelectRoom.Name = "lblSelectRoom";
            this.lblSelectRoom.Size = new System.Drawing.Size(136, 28);
            this.lblSelectRoom.TabIndex = 2;
            this.lblSelectRoom.Text = "Select Room";
            // 
            // RoomUsageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConventionManager.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 477);
            this.Controls.Add(this.lblSelectRoom);
            this.Controls.Add(this.dgvRoomUsage);
            this.Controls.Add(this.cbxRoom);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomUsageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Room Usage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoomUsageForm_FormClosed);
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