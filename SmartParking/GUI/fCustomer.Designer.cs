namespace SmartParking.GUI
{
    partial class fCustomer
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
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.lb_DisplayName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_logout = new Krypton.Toolkit.KryptonButton();
            this.btn_Bookinghistory = new Krypton.Toolkit.KryptonButton();
            this.btn_NavBooking = new Krypton.Toolkit.KryptonButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonGroupBox1.CaptionVisible = false;
            this.kryptonGroupBox1.CausesValidation = false;
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(20, 60);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.lb_DisplayName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.pictureBox1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btn_logout);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btn_Bookinghistory);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btn_NavBooking);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(196, 704);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(76)))), ((int)(((byte)(212)))));
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(76)))), ((int)(((byte)(212)))));
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 30F;
            this.kryptonGroupBox1.TabIndex = 2;
            // 
            // lb_DisplayName
            // 
            this.lb_DisplayName.AutoSize = true;
            this.lb_DisplayName.BackColor = System.Drawing.Color.Transparent;
            this.lb_DisplayName.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DisplayName.ForeColor = System.Drawing.Color.White;
            this.lb_DisplayName.Location = new System.Drawing.Point(19, 76);
            this.lb_DisplayName.Name = "lb_DisplayName";
            this.lb_DisplayName.Size = new System.Drawing.Size(50, 26);
            this.lb_DisplayName.TabIndex = 0;
            this.lb_DisplayName.Text = "User1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::SmartParking.Resource.profile;
            this.pictureBox1.Location = new System.Drawing.Point(52, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_logout
            // 
            this.btn_logout.CornerRoundingRadius = 10F;
            this.btn_logout.Location = new System.Drawing.Point(3, 568);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_logout.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_logout.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_logout.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_logout.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_logout.Size = new System.Drawing.Size(168, 54);
            this.btn_logout.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_logout.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_logout.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_logout.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btn_logout.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btn_logout.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_logout.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btn_logout.StateCommon.Border.Rounding = 10F;
            this.btn_logout.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btn_logout.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_logout.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_logout.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_logout.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_logout.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_logout.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_logout.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_logout.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Values.Text = "Đăng xuất";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_Bookinghistory
            // 
            this.btn_Bookinghistory.CornerRoundingRadius = 15F;
            this.btn_Bookinghistory.Location = new System.Drawing.Point(3, 209);
            this.btn_Bookinghistory.Name = "btn_Bookinghistory";
            this.btn_Bookinghistory.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_Bookinghistory.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_Bookinghistory.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Bookinghistory.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_Bookinghistory.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_Bookinghistory.Size = new System.Drawing.Size(168, 54);
            this.btn_Bookinghistory.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_Bookinghistory.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_Bookinghistory.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_Bookinghistory.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btn_Bookinghistory.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btn_Bookinghistory.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Bookinghistory.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btn_Bookinghistory.StateCommon.Border.Rounding = 15F;
            this.btn_Bookinghistory.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btn_Bookinghistory.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Bookinghistory.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Bookinghistory.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bookinghistory.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_Bookinghistory.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_Bookinghistory.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Bookinghistory.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Bookinghistory.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_Bookinghistory.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_Bookinghistory.TabIndex = 3;
            this.btn_Bookinghistory.Values.Text = "Lịch sử đặt chỗ";
            this.btn_Bookinghistory.Click += new System.EventHandler(this.btn_Bookinghistory_Click);
            // 
            // btn_NavBooking
            // 
            this.btn_NavBooking.CornerRoundingRadius = 15F;
            this.btn_NavBooking.Location = new System.Drawing.Point(3, 136);
            this.btn_NavBooking.Name = "btn_NavBooking";
            this.btn_NavBooking.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_NavBooking.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_NavBooking.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_NavBooking.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_NavBooking.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_NavBooking.Size = new System.Drawing.Size(168, 54);
            this.btn_NavBooking.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_NavBooking.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_NavBooking.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.btn_NavBooking.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btn_NavBooking.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btn_NavBooking.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_NavBooking.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.btn_NavBooking.StateCommon.Border.Rounding = 15F;
            this.btn_NavBooking.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btn_NavBooking.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_NavBooking.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_NavBooking.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NavBooking.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_NavBooking.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_NavBooking.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_NavBooking.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_NavBooking.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_NavBooking.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(104)))), ((int)(((byte)(220)))));
            this.btn_NavBooking.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.btn_NavBooking.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_NavBooking.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_NavBooking.TabIndex = 2;
            this.btn_NavBooking.Values.Text = "Đặt chỗ";
            this.btn_NavBooking.Click += new System.EventHandler(this.btn_NavBooking_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(216, 60);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1193, 704);
            this.panelContainer.TabIndex = 3;
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 784);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Name = "fCustomer";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.Label lb_DisplayName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton btn_logout;
        private Krypton.Toolkit.KryptonButton btn_Bookinghistory;
        private Krypton.Toolkit.KryptonButton btn_NavBooking;
        private System.Windows.Forms.Panel panelContainer;
    }
}