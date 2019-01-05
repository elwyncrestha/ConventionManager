namespace ConventionManager.View_Controller
{
    partial class RoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocationCode = new System.Windows.Forms.TextBox();
            this.lblLocationCode = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtResources = new System.Windows.Forms.TextBox();
            this.lblResources = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomLocationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomResources = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblName.Location = new System.Drawing.Point(12, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.txtName.Location = new System.Drawing.Point(170, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtLocationCode
            // 
            this.txtLocationCode.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.txtLocationCode.Location = new System.Drawing.Point(170, 74);
            this.txtLocationCode.Name = "txtLocationCode";
            this.txtLocationCode.Size = new System.Drawing.Size(174, 26);
            this.txtLocationCode.TabIndex = 3;
            // 
            // lblLocationCode
            // 
            this.lblLocationCode.AutoSize = true;
            this.lblLocationCode.BackColor = System.Drawing.Color.Transparent;
            this.lblLocationCode.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblLocationCode.Location = new System.Drawing.Point(12, 79);
            this.lblLocationCode.Name = "lblLocationCode";
            this.lblLocationCode.Size = new System.Drawing.Size(113, 21);
            this.lblLocationCode.TabIndex = 2;
            this.lblLocationCode.Text = "Location Code";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.txtCapacity.Location = new System.Drawing.Point(170, 126);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(174, 26);
            this.txtCapacity.TabIndex = 5;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.BackColor = System.Drawing.Color.Transparent;
            this.lblCapacity.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblCapacity.Location = new System.Drawing.Point(12, 131);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(72, 21);
            this.lblCapacity.TabIndex = 4;
            this.lblCapacity.Text = "Capacity";
            // 
            // txtResources
            // 
            this.txtResources.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.txtResources.Location = new System.Drawing.Point(170, 178);
            this.txtResources.Name = "txtResources";
            this.txtResources.Size = new System.Drawing.Size(174, 26);
            this.txtResources.TabIndex = 7;
            // 
            // lblResources
            // 
            this.lblResources.AutoSize = true;
            this.lblResources.BackColor = System.Drawing.Color.Transparent;
            this.lblResources.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.lblResources.Location = new System.Drawing.Point(9, 183);
            this.lblResources.Name = "lblResources";
            this.lblResources.Size = new System.Drawing.Size(87, 21);
            this.lblResources.TabIndex = 6;
            this.lblResources.Text = "Resources";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.btnAdd.Location = new System.Drawing.Point(170, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 48);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToDeleteRows = false;
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomId,
            this.RoomName,
            this.RoomLocationCode,
            this.RoomCapacity,
            this.RoomResources,
            this.Edit,
            this.Delete});
            this.dgvRoom.Location = new System.Drawing.Point(13, 317);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.ReadOnly = true;
            this.dgvRoom.Size = new System.Drawing.Size(509, 212);
            this.dgvRoom.TabIndex = 9;
            this.dgvRoom.Click += new System.EventHandler(this.dgvRoom_Click);
            // 
            // RoomId
            // 
            this.RoomId.DataPropertyName = "RoomId";
            this.RoomId.HeaderText = "Id";
            this.RoomId.Name = "RoomId";
            this.RoomId.ReadOnly = true;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "Name";
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            // 
            // RoomLocationCode
            // 
            this.RoomLocationCode.DataPropertyName = "RoomLocationCode";
            this.RoomLocationCode.HeaderText = "Location Code";
            this.RoomLocationCode.Name = "RoomLocationCode";
            this.RoomLocationCode.ReadOnly = true;
            // 
            // RoomCapacity
            // 
            this.RoomCapacity.DataPropertyName = "RoomCapacity";
            this.RoomCapacity.HeaderText = "Capacity";
            this.RoomCapacity.Name = "RoomCapacity";
            this.RoomCapacity.ReadOnly = true;
            // 
            // RoomResources
            // 
            this.RoomResources.DataPropertyName = "RoomResources";
            this.RoomResources.HeaderText = "Resources";
            this.RoomResources.Name = "RoomResources";
            this.RoomResources.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConventionManager.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 580);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtResources);
            this.Controls.Add(this.lblResources);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtLocationCode);
            this.Controls.Add(this.lblLocationCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Room";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoomForm_FormClosed);
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocationCode;
        private System.Windows.Forms.Label lblLocationCode;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtResources;
        private System.Windows.Forms.Label lblResources;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomLocationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomResources;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}