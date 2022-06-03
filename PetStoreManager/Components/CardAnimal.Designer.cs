﻿namespace PetStoreManager.Components
{
    partial class CardAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardAnimal));
            this.caTitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.caPrice = new Bunifu.UI.WinForms.BunifuLabel();
            this.caIconGender = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.caPhoto = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.caAddToCard = new Bunifu.UI.WinForms.BunifuPanel();
            this.caAddToCardLabel = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.caIconGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caPhoto)).BeginInit();
            this.caAddToCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // caTitleLabel
            // 
            this.caTitleLabel.AllowParentOverrides = false;
            this.caTitleLabel.AutoEllipsis = false;
            this.caTitleLabel.AutoSize = false;
            this.caTitleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.caTitleLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.caTitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(183)))));
            this.caTitleLabel.Location = new System.Drawing.Point(0, 176);
            this.caTitleLabel.Name = "caTitleLabel";
            this.caTitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.caTitleLabel.Size = new System.Drawing.Size(250, 72);
            this.caTitleLabel.TabIndex = 2;
            this.caTitleLabel.Text = "PET LABEL";
            this.caTitleLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.caTitleLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // caPrice
            // 
            this.caPrice.AllowParentOverrides = false;
            this.caPrice.AutoEllipsis = false;
            this.caPrice.AutoSize = false;
            this.caPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.caPrice.CursorType = System.Windows.Forms.Cursors.Default;
            this.caPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.caPrice.Location = new System.Drawing.Point(0, 254);
            this.caPrice.Name = "caPrice";
            this.caPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.caPrice.Size = new System.Drawing.Size(250, 46);
            this.caPrice.TabIndex = 2;
            this.caPrice.Text = "1.150,50$";
            this.caPrice.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.caPrice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // caIconGender
            // 
            this.caIconGender.AllowFocused = false;
            this.caIconGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caIconGender.AutoSizeHeight = true;
            this.caIconGender.BorderRadius = 0;
            this.caIconGender.Image = global::PetStoreManager.Properties.Resources.icon_male;
            this.caIconGender.IsCircle = true;
            this.caIconGender.Location = new System.Drawing.Point(10, 20);
            this.caIconGender.Name = "caIconGender";
            this.caIconGender.Size = new System.Drawing.Size(35, 35);
            this.caIconGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.caIconGender.TabIndex = 1;
            this.caIconGender.TabStop = false;
            this.caIconGender.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // caPhoto
            // 
            this.caPhoto.AllowFocused = false;
            this.caPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caPhoto.AutoSizeHeight = true;
            this.caPhoto.BorderRadius = 0;
            this.caPhoto.Image = global::PetStoreManager.Properties.Resources.icon_pets_2;
            this.caPhoto.IsCircle = true;
            this.caPhoto.Location = new System.Drawing.Point(55, 20);
            this.caPhoto.Name = "caPhoto";
            this.caPhoto.Size = new System.Drawing.Size(150, 150);
            this.caPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.caPhoto.TabIndex = 0;
            this.caPhoto.TabStop = false;
            this.caPhoto.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // caAddToCard
            // 
            this.caAddToCard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(226)))), ((int)(((byte)(138)))));
            this.caAddToCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("caAddToCard.BackgroundImage")));
            this.caAddToCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.caAddToCard.BorderColor = System.Drawing.Color.Transparent;
            this.caAddToCard.BorderRadius = 3;
            this.caAddToCard.BorderThickness = 1;
            this.caAddToCard.Controls.Add(this.caAddToCardLabel);
            this.caAddToCard.Location = new System.Drawing.Point(0, 245);
            this.caAddToCard.Name = "caAddToCard";
            this.caAddToCard.ShowBorders = true;
            this.caAddToCard.Size = new System.Drawing.Size(250, 0);
            this.caAddToCard.TabIndex = 3;
            // 
            // caAddToCardLabel
            // 
            this.caAddToCardLabel.AllowParentOverrides = false;
            this.caAddToCardLabel.AutoEllipsis = false;
            this.caAddToCardLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.caAddToCardLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.caAddToCardLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caAddToCardLabel.ForeColor = System.Drawing.Color.White;
            this.caAddToCardLabel.Location = new System.Drawing.Point(55, 18);
            this.caAddToCardLabel.Name = "caAddToCardLabel";
            this.caAddToCardLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.caAddToCardLabel.Size = new System.Drawing.Size(136, 23);
            this.caAddToCardLabel.TabIndex = 0;
            this.caAddToCardLabel.Text = "ADD TO CART";
            this.caAddToCardLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.caAddToCardLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CardAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.caAddToCard);
            this.Controls.Add(this.caPrice);
            this.Controls.Add(this.caTitleLabel);
            this.Controls.Add(this.caIconGender);
            this.Controls.Add(this.caPhoto);
            this.Margin = new System.Windows.Forms.Padding(30, 20, 30, 50);
            this.Name = "CardAnimal";
            this.Size = new System.Drawing.Size(250, 300);
            ((System.ComponentModel.ISupportInitialize)(this.caIconGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caPhoto)).EndInit();
            this.caAddToCard.ResumeLayout(false);
            this.caAddToCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox caPhoto;
        private Bunifu.UI.WinForms.BunifuPictureBox caIconGender;
        private Bunifu.UI.WinForms.BunifuLabel caTitleLabel;
        private Bunifu.UI.WinForms.BunifuLabel caPrice;
        private Bunifu.UI.WinForms.BunifuPanel caAddToCard;
        private Bunifu.UI.WinForms.BunifuLabel caAddToCardLabel;
    }
}