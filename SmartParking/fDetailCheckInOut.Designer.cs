namespace SmartParking.Model
{
    partial class fDetailCheckInOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid_CheckInOut = new MetroFramework.Controls.MetroGrid();
            this.CardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOUTTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_CheckInOut)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_CheckInOut
            // 
            this.Grid_CheckInOut.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_CheckInOut.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_CheckInOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid_CheckInOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_CheckInOut.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_CheckInOut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_CheckInOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_CheckInOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_CheckInOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CardID,
            this.LicensePlate,
            this.SpaceName,
            this.CheckInTime,
            this.CheckOUTTime,
            this.TotalCost,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_CheckInOut.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_CheckInOut.EnableHeadersVisualStyles = false;
            this.Grid_CheckInOut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid_CheckInOut.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid_CheckInOut.Location = new System.Drawing.Point(49, 81);
            this.Grid_CheckInOut.Name = "Grid_CheckInOut";
            this.Grid_CheckInOut.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_CheckInOut.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid_CheckInOut.RowHeadersVisible = false;
            this.Grid_CheckInOut.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_CheckInOut.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Grid_CheckInOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_CheckInOut.Size = new System.Drawing.Size(991, 493);
            this.Grid_CheckInOut.TabIndex = 0;
            this.Grid_CheckInOut.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // CardID
            // 
            this.CardID.HeaderText = "Số thẻ";
            this.CardID.Name = "CardID";
            // 
            // LicensePlate
            // 
            this.LicensePlate.FillWeight = 130F;
            this.LicensePlate.HeaderText = "Biến số xe";
            this.LicensePlate.Name = "LicensePlate";
            this.LicensePlate.Width = 130;
            // 
            // SpaceName
            // 
            this.SpaceName.FillWeight = 120F;
            this.SpaceName.HeaderText = "Khu để xe";
            this.SpaceName.Name = "SpaceName";
            this.SpaceName.Width = 120;
            // 
            // CheckInTime
            // 
            this.CheckInTime.FillWeight = 170F;
            this.CheckInTime.HeaderText = "Thời gian vào";
            this.CheckInTime.Name = "CheckInTime";
            this.CheckInTime.Width = 170;
            // 
            // CheckOUTTime
            // 
            this.CheckOUTTime.FillWeight = 170F;
            this.CheckOUTTime.HeaderText = "Thời gian ra";
            this.CheckOUTTime.Name = "CheckOUTTime";
            this.CheckOUTTime.Width = 170;
            // 
            // TotalCost
            // 
            this.TotalCost.FillWeight = 120F;
            this.TotalCost.HeaderText = "Giá cước";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Width = 120;
            // 
            // Status
            // 
            this.Status.FillWeight = 120F;
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            this.Status.Width = 120;
            // 
            // fDetailCheckInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 631);
            this.Controls.Add(this.Grid_CheckInOut);
            this.Name = "fDetailCheckInOut";
            this.Text = "Chi tiết khu giữ xe";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_CheckInOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid Grid_CheckInOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOUTTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}