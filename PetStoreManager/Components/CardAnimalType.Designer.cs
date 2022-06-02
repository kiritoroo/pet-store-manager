namespace PetStoreManager.Components
{
    partial class CardAnimalType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardAnimalType));
            this.catLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.catId = new Bunifu.UI.WinForms.BunifuLabel();
            this.catIcon = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.catIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // catLabel
            // 
            this.catLabel.AllowParentOverrides = false;
            this.catLabel.AutoEllipsis = false;
            this.catLabel.AutoSize = false;
            this.catLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.catLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.catLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catLabel.ForeColor = System.Drawing.Color.White;
            this.catLabel.Location = new System.Drawing.Point(10, 48);
            this.catLabel.Name = "catLabel";
            this.catLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.catLabel.Size = new System.Drawing.Size(152, 15);
            this.catLabel.TabIndex = 0;
            this.catLabel.Text = "Text";
            this.catLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.catLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // catId
            // 
            this.catId.AllowParentOverrides = false;
            this.catId.AutoEllipsis = false;
            this.catId.AutoSize = false;
            this.catId.CursorType = null;
            this.catId.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catId.ForeColor = System.Drawing.Color.White;
            this.catId.Location = new System.Drawing.Point(105, 0);
            this.catId.Name = "catId";
            this.catId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.catId.Size = new System.Drawing.Size(73, 47);
            this.catId.TabIndex = 0;
            this.catId.Text = "ID";
            this.catId.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.catId.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // catIcon
            // 
            this.catIcon.AllowFocused = false;
            this.catIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.catIcon.AutoSizeHeight = true;
            this.catIcon.BorderRadius = 0;
            this.catIcon.Image = global::PetStoreManager.Properties.Resources.icon_pets;
            this.catIcon.IsCircle = false;
            this.catIcon.Location = new System.Drawing.Point(10, 5);
            this.catIcon.Name = "catIcon";
            this.catIcon.Size = new System.Drawing.Size(35, 35);
            this.catIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catIcon.TabIndex = 1;
            this.catIcon.TabStop = false;
            this.catIcon.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // CardAnimalType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.Controls.Add(this.catIcon);
            this.Controls.Add(this.catId);
            this.Controls.Add(this.catLabel);
            this.Name = "CardAnimalType";
            this.Size = new System.Drawing.Size(180, 70);
            ((System.ComponentModel.ISupportInitialize)(this.catIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel catLabel;
        private Bunifu.UI.WinForms.BunifuPictureBox catIcon;
        private Bunifu.UI.WinForms.BunifuLabel catId;
    }
}
