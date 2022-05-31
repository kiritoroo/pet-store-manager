namespace PetStoreManager.Components
{
    partial class PetTypeButtonComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetTypeButtonComponent));
            this.titleComp = new Bunifu.UI.WinForms.BunifuLabel();
            this.iconComp = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.idComp = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.iconComp)).BeginInit();
            this.SuspendLayout();
            // 
            // titleComp
            // 
            this.titleComp.AllowParentOverrides = false;
            this.titleComp.AutoEllipsis = false;
            this.titleComp.AutoSize = false;
            this.titleComp.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleComp.CursorType = System.Windows.Forms.Cursors.Default;
            this.titleComp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleComp.ForeColor = System.Drawing.Color.White;
            this.titleComp.Location = new System.Drawing.Point(10, 47);
            this.titleComp.Name = "titleComp";
            this.titleComp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleComp.Size = new System.Drawing.Size(152, 15);
            this.titleComp.TabIndex = 0;
            this.titleComp.Text = "Text";
            this.titleComp.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.titleComp.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.titleComp.Click += new System.EventHandler(this.PetTypeButtonComponent_Click);
            this.titleComp.MouseLeave += new System.EventHandler(this.PetTypeButtonComponent_MouseLeave);
            this.titleComp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PetTypeButtonComponent_MouseMove);
            // 
            // iconComp
            // 
            this.iconComp.AllowFocused = false;
            this.iconComp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconComp.AutoSizeHeight = true;
            this.iconComp.BorderRadius = 0;
            this.iconComp.Image = global::PetStoreManager.Properties.Resources.icon_pets;
            this.iconComp.IsCircle = false;
            this.iconComp.Location = new System.Drawing.Point(10, 5);
            this.iconComp.Name = "iconComp";
            this.iconComp.Size = new System.Drawing.Size(35, 35);
            this.iconComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconComp.TabIndex = 1;
            this.iconComp.TabStop = false;
            this.iconComp.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.iconComp.Click += new System.EventHandler(this.PetTypeButtonComponent_Click);
            this.iconComp.MouseLeave += new System.EventHandler(this.PetTypeButtonComponent_MouseLeave);
            this.iconComp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PetTypeButtonComponent_MouseMove);
            // 
            // idComp
            // 
            this.idComp.AllowParentOverrides = false;
            this.idComp.AutoEllipsis = false;
            this.idComp.AutoSize = false;
            this.idComp.CursorType = null;
            this.idComp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idComp.ForeColor = System.Drawing.Color.White;
            this.idComp.Location = new System.Drawing.Point(105, 0);
            this.idComp.Name = "idComp";
            this.idComp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idComp.Size = new System.Drawing.Size(73, 47);
            this.idComp.TabIndex = 0;
            this.idComp.Text = "1";
            this.idComp.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.idComp.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.idComp.Click += new System.EventHandler(this.PetTypeButtonComponent_Click);
            this.idComp.MouseLeave += new System.EventHandler(this.PetTypeButtonComponent_MouseLeave);
            this.idComp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PetTypeButtonComponent_MouseMove);
            // 
            // PetTypeButtonComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.iconComp);
            this.Controls.Add(this.idComp);
            this.Controls.Add(this.titleComp);
            this.Name = "PetTypeButtonComponent";
            this.Size = new System.Drawing.Size(180, 70);
            this.Load += new System.EventHandler(this.PetTypeButtonComponent_Load);
            this.Click += new System.EventHandler(this.PetTypeButtonComponent_Click);
            this.MouseLeave += new System.EventHandler(this.PetTypeButtonComponent_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PetTypeButtonComponent_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.iconComp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel titleComp;
        private Bunifu.UI.WinForms.BunifuPictureBox iconComp;
        private Bunifu.UI.WinForms.BunifuLabel idComp;
    }
}
