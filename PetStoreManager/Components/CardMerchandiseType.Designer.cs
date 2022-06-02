namespace PetStoreManager.Components
{
    partial class CardMerchandiseType
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardMerchandiseType));
            this.cmtIcon = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.cmtLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.cmtId = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cmtIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // cmtIcon
            // 
            this.cmtIcon.AllowFocused = false;
            this.cmtIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmtIcon.AutoSizeHeight = true;
            this.cmtIcon.BorderRadius = 0;
            this.cmtIcon.Image = global::PetStoreManager.Properties.Resources.icon_merchandise;
            this.cmtIcon.IsCircle = false;
            this.cmtIcon.Location = new System.Drawing.Point(10, 5);
            this.cmtIcon.Name = "cmtIcon";
            this.cmtIcon.Size = new System.Drawing.Size(35, 35);
            this.cmtIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmtIcon.TabIndex = 2;
            this.cmtIcon.TabStop = false;
            this.cmtIcon.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // cmtLabel
            // 
            this.cmtLabel.AllowParentOverrides = false;
            this.cmtLabel.AutoEllipsis = false;
            this.cmtLabel.AutoSize = false;
            this.cmtLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmtLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.cmtLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmtLabel.ForeColor = System.Drawing.Color.White;
            this.cmtLabel.Location = new System.Drawing.Point(10, 48);
            this.cmtLabel.Name = "cmtLabel";
            this.cmtLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmtLabel.Size = new System.Drawing.Size(152, 15);
            this.cmtLabel.TabIndex = 3;
            this.cmtLabel.Text = "Text";
            this.cmtLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.cmtLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cmtId
            // 
            this.cmtId.AllowParentOverrides = false;
            this.cmtId.AutoEllipsis = false;
            this.cmtId.AutoSize = false;
            this.cmtId.CursorType = null;
            this.cmtId.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmtId.ForeColor = System.Drawing.Color.White;
            this.cmtId.Location = new System.Drawing.Point(105, 0);
            this.cmtId.Name = "cmtId";
            this.cmtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmtId.Size = new System.Drawing.Size(73, 47);
            this.cmtId.TabIndex = 4;
            this.cmtId.Text = "ID";
            this.cmtId.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.cmtId.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CardMerchandiseType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(152)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.cmtId);
            this.Controls.Add(this.cmtLabel);
            this.Controls.Add(this.cmtIcon);
            this.Name = "CardMerchandiseType";
            this.Size = new System.Drawing.Size(180, 70);
            ((System.ComponentModel.ISupportInitialize)(this.cmtIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox cmtIcon;
        private Bunifu.UI.WinForms.BunifuLabel cmtLabel;
        private Bunifu.UI.WinForms.BunifuLabel cmtId;
    }
}
