namespace SmartParking
{
    partial class fInputCardID
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
            this.txb_SelectcardID = new MetroFramework.Controls.MetroTextBox();
            this.btn_Ok = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // txb_SelectcardID
            // 
            // 
            // 
            // 
            this.txb_SelectcardID.CustomButton.Image = null;
            this.txb_SelectcardID.CustomButton.Location = new System.Drawing.Point(84, 2);
            this.txb_SelectcardID.CustomButton.Name = "";
            this.txb_SelectcardID.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txb_SelectcardID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txb_SelectcardID.CustomButton.TabIndex = 1;
            this.txb_SelectcardID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txb_SelectcardID.CustomButton.UseSelectable = true;
            this.txb_SelectcardID.CustomButton.UseStyleColors = true;
            this.txb_SelectcardID.CustomButton.Visible = false;
            this.txb_SelectcardID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txb_SelectcardID.Lines = new string[0];
            this.txb_SelectcardID.Location = new System.Drawing.Point(23, 72);
            this.txb_SelectcardID.MaxLength = 32767;
            this.txb_SelectcardID.Name = "txb_SelectcardID";
            this.txb_SelectcardID.PasswordChar = '\0';
            this.txb_SelectcardID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txb_SelectcardID.SelectedText = "";
            this.txb_SelectcardID.SelectionLength = 0;
            this.txb_SelectcardID.SelectionStart = 0;
            this.txb_SelectcardID.ShortcutsEnabled = true;
            this.txb_SelectcardID.Size = new System.Drawing.Size(114, 32);
            this.txb_SelectcardID.TabIndex = 0;
            this.txb_SelectcardID.UseSelectable = true;
            this.txb_SelectcardID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txb_SelectcardID.WaterMarkFont = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Ok
            // 
            this.btn_Ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Ok.CornerRoundingRadius = 6F;
            this.btn_Ok.Location = new System.Drawing.Point(143, 72);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(32, 32);
            this.btn_Ok.StateCommon.Back.Color1 = System.Drawing.Color.LawnGreen;
            this.btn_Ok.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_Ok.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.btn_Ok.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btn_Ok.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btn_Ok.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Ok.StateCommon.Border.Rounding = 6F;
            this.btn_Ok.StateCommon.Border.Width = 1;
            this.btn_Ok.TabIndex = 1;
            this.btn_Ok.Values.Text = "OK";
            // 
            // fInputCardID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 141);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txb_SelectcardID);
            this.Name = "fInputCardID";
            this.Text = "Nhập số thẻ";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txb_SelectcardID;
        private Krypton.Toolkit.KryptonButton btn_Ok;
    }
}