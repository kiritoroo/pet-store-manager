namespace PetStoreManager.Components
{
    partial class CardTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardTable));
            this.ctIcon = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ctLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.ctLineEffect = new Bunifu.UI.WinForms.BunifuShapes();
            this.ctPanelEffect = new Bunifu.UI.WinForms.BunifuPanel();
            this.ctArrowEffect = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctIcon)).BeginInit();
            this.ctPanelEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctArrowEffect)).BeginInit();
            this.SuspendLayout();
            // 
            // ctIcon
            // 
            this.ctIcon.AllowFocused = false;
            this.ctIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctIcon.AutoSizeHeight = true;
            this.ctIcon.BorderRadius = 0;
            this.ctIcon.Image = ((System.Drawing.Image)(resources.GetObject("ctIcon.Image")));
            this.ctIcon.IsCircle = true;
            this.ctIcon.Location = new System.Drawing.Point(5, 5);
            this.ctIcon.Name = "ctIcon";
            this.ctIcon.Size = new System.Drawing.Size(20, 20);
            this.ctIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ctIcon.TabIndex = 5;
            this.ctIcon.TabStop = false;
            this.ctIcon.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // ctLabel
            // 
            this.ctLabel.AllowParentOverrides = false;
            this.ctLabel.AutoEllipsis = false;
            this.ctLabel.AutoSize = false;
            this.ctLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.ctLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctLabel.ForeColor = System.Drawing.Color.White;
            this.ctLabel.Location = new System.Drawing.Point(6, 30);
            this.ctLabel.Name = "ctLabel";
            this.ctLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ctLabel.Size = new System.Drawing.Size(115, 18);
            this.ctLabel.TabIndex = 1;
            this.ctLabel.Text = "Text";
            this.ctLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ctLineEffect
            // 
            this.ctLineEffect.Angle = 90F;
            this.ctLineEffect.BackColor = System.Drawing.Color.Transparent;
            this.ctLineEffect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(143)))), ((int)(((byte)(206)))));
            this.ctLineEffect.BorderThickness = 2;
            this.ctLineEffect.FillColor = System.Drawing.Color.Transparent;
            this.ctLineEffect.FillShape = true;
            this.ctLineEffect.Location = new System.Drawing.Point(-9, -1);
            this.ctLineEffect.Name = "ctLineEffect";
            this.ctLineEffect.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            this.ctLineEffect.Sides = 5;
            this.ctLineEffect.Size = new System.Drawing.Size(20, 55);
            this.ctLineEffect.TabIndex = 3;
            this.ctLineEffect.Text = "bunifuShapes1";
            // 
            // ctPanelEffect
            // 
            this.ctPanelEffect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(132)))), ((int)(((byte)(203)))));
            this.ctPanelEffect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctPanelEffect.BackgroundImage")));
            this.ctPanelEffect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctPanelEffect.BorderColor = System.Drawing.Color.Transparent;
            this.ctPanelEffect.BorderRadius = 3;
            this.ctPanelEffect.BorderThickness = 1;
            this.ctPanelEffect.Controls.Add(this.ctLineEffect);
            this.ctPanelEffect.Controls.Add(this.ctArrowEffect);
            this.ctPanelEffect.Location = new System.Drawing.Point(120, -3);
            this.ctPanelEffect.Name = "ctPanelEffect";
            this.ctPanelEffect.ShowBorders = true;
            this.ctPanelEffect.Size = new System.Drawing.Size(30, 55);
            this.ctPanelEffect.TabIndex = 2;
            // 
            // ctArrowEffect
            // 
            this.ctArrowEffect.AllowFocused = false;
            this.ctArrowEffect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctArrowEffect.AutoSizeHeight = true;
            this.ctArrowEffect.BackColor = System.Drawing.Color.Transparent;
            this.ctArrowEffect.BorderRadius = 0;
            this.ctArrowEffect.Image = global::PetStoreManager.Properties.Resources.icon_triangle;
            this.ctArrowEffect.IsCircle = true;
            this.ctArrowEffect.Location = new System.Drawing.Point(10, 24);
            this.ctArrowEffect.Name = "ctArrowEffect";
            this.ctArrowEffect.Size = new System.Drawing.Size(8, 8);
            this.ctArrowEffect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ctArrowEffect.TabIndex = 5;
            this.ctArrowEffect.TabStop = false;
            this.ctArrowEffect.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // CardTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.Controls.Add(this.ctPanelEffect);
            this.Controls.Add(this.ctLabel);
            this.Controls.Add(this.ctIcon);
            this.Name = "CardTable";
            this.Size = new System.Drawing.Size(150, 50);
            ((System.ComponentModel.ISupportInitialize)(this.ctIcon)).EndInit();
            this.ctPanelEffect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctArrowEffect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuPictureBox ctIcon;
        public Bunifu.UI.WinForms.BunifuLabel ctLabel;
        public Bunifu.UI.WinForms.BunifuShapes ctLineEffect;
        public Bunifu.UI.WinForms.BunifuPanel ctPanelEffect;
        public Bunifu.UI.WinForms.BunifuPictureBox ctArrowEffect;
    }
}
