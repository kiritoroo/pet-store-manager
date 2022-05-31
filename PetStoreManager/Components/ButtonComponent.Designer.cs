namespace PetStoreManager.Components
{
    partial class ButtonComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonComponent));
            this.titleComp = new Bunifu.UI.WinForms.BunifuLabel();
            this.imgComp = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.effectPanelComp = new Bunifu.UI.WinForms.BunifuPanel();
            this.effectLineComp = new Bunifu.UI.WinForms.BunifuShapes();
            this.arrowIconComp = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgComp)).BeginInit();
            this.effectPanelComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowIconComp)).BeginInit();
            this.SuspendLayout();
            // 
            // titleComp
            // 
            this.titleComp.AllowParentOverrides = false;
            this.titleComp.AutoEllipsis = false;
            this.titleComp.AutoSize = false;
            this.titleComp.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleComp.CursorType = System.Windows.Forms.Cursors.Default;
            this.titleComp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleComp.ForeColor = System.Drawing.Color.White;
            this.titleComp.Location = new System.Drawing.Point(6, 30);
            this.titleComp.Name = "titleComp";
            this.titleComp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleComp.Size = new System.Drawing.Size(115, 18);
            this.titleComp.TabIndex = 1;
            this.titleComp.Text = "Text";
            this.titleComp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleComp.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.titleComp.Click += new System.EventHandler(this.ButtonComponent_Click);
            this.titleComp.MouseLeave += new System.EventHandler(this.ButtonComponent_MouseLeave);
            this.titleComp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonComponent_MouseMove);
            // 
            // imgComp
            // 
            this.imgComp.AllowFocused = false;
            this.imgComp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgComp.AutoSizeHeight = true;
            this.imgComp.BorderRadius = 0;
            this.imgComp.Image = ((System.Drawing.Image)(resources.GetObject("imgComp.Image")));
            this.imgComp.IsCircle = true;
            this.imgComp.Location = new System.Drawing.Point(5, 5);
            this.imgComp.Name = "imgComp";
            this.imgComp.Size = new System.Drawing.Size(20, 20);
            this.imgComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgComp.TabIndex = 5;
            this.imgComp.TabStop = false;
            this.imgComp.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.imgComp.Click += new System.EventHandler(this.ButtonComponent_Click);
            this.imgComp.MouseLeave += new System.EventHandler(this.ButtonComponent_MouseLeave);
            this.imgComp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonComponent_MouseMove);
            // 
            // effectPanelComp
            // 
            this.effectPanelComp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(132)))), ((int)(((byte)(203)))));
            this.effectPanelComp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("effectPanelComp.BackgroundImage")));
            this.effectPanelComp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.effectPanelComp.BorderColor = System.Drawing.Color.Transparent;
            this.effectPanelComp.BorderRadius = 3;
            this.effectPanelComp.BorderThickness = 1;
            this.effectPanelComp.Controls.Add(this.effectLineComp);
            this.effectPanelComp.Controls.Add(this.arrowIconComp);
            this.effectPanelComp.Location = new System.Drawing.Point(120, -3);
            this.effectPanelComp.Name = "effectPanelComp";
            this.effectPanelComp.ShowBorders = true;
            this.effectPanelComp.Size = new System.Drawing.Size(30, 55);
            this.effectPanelComp.TabIndex = 2;
            this.effectPanelComp.Click += new System.EventHandler(this.ButtonComponent_Click);
            this.effectPanelComp.MouseLeave += new System.EventHandler(this.ButtonComponent_MouseLeave);
            this.effectPanelComp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonComponent_MouseMove);
            // 
            // effectLineComp
            // 
            this.effectLineComp.Angle = 90F;
            this.effectLineComp.BackColor = System.Drawing.Color.Transparent;
            this.effectLineComp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(143)))), ((int)(((byte)(206)))));
            this.effectLineComp.BorderThickness = 2;
            this.effectLineComp.FillColor = System.Drawing.Color.Transparent;
            this.effectLineComp.FillShape = true;
            this.effectLineComp.Location = new System.Drawing.Point(-9, -1);
            this.effectLineComp.Name = "effectLineComp";
            this.effectLineComp.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            this.effectLineComp.Sides = 5;
            this.effectLineComp.Size = new System.Drawing.Size(20, 55);
            this.effectLineComp.TabIndex = 3;
            this.effectLineComp.Text = "bunifuShapes1";
            // 
            // arrowIconComp
            // 
            this.arrowIconComp.AllowFocused = false;
            this.arrowIconComp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrowIconComp.AutoSizeHeight = true;
            this.arrowIconComp.BackColor = System.Drawing.Color.Transparent;
            this.arrowIconComp.BorderRadius = 0;
            this.arrowIconComp.Image = global::PetStoreManager.Properties.Resources.icon_triangle;
            this.arrowIconComp.IsCircle = true;
            this.arrowIconComp.Location = new System.Drawing.Point(10, 24);
            this.arrowIconComp.Name = "arrowIconComp";
            this.arrowIconComp.Size = new System.Drawing.Size(8, 8);
            this.arrowIconComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrowIconComp.TabIndex = 5;
            this.arrowIconComp.TabStop = false;
            this.arrowIconComp.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.arrowIconComp.Click += new System.EventHandler(this.ButtonComponent_Click);
            this.arrowIconComp.MouseLeave += new System.EventHandler(this.ButtonComponent_MouseLeave);
            this.arrowIconComp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonComponent_MouseMove);
            // 
            // ButtonComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.Controls.Add(this.effectPanelComp);
            this.Controls.Add(this.titleComp);
            this.Controls.Add(this.imgComp);
            this.Name = "ButtonComponent";
            this.Size = new System.Drawing.Size(150, 50);
            this.Load += new System.EventHandler(this.ButtonComponent_Load);
            this.Click += new System.EventHandler(this.ButtonComponent_Click);
            this.MouseLeave += new System.EventHandler(this.ButtonComponent_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonComponent_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.imgComp)).EndInit();
            this.effectPanelComp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.arrowIconComp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel titleComp;
        private Bunifu.UI.WinForms.BunifuPanel effectPanelComp;
        private Bunifu.UI.WinForms.BunifuShapes effectLineComp;
        private Bunifu.UI.WinForms.BunifuPictureBox arrowIconComp;
        private Bunifu.UI.WinForms.BunifuPictureBox imgComp;
    }
}
