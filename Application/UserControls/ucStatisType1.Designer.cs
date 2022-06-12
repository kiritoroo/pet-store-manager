
namespace Application.UserControls
{
    partial class ucStatisType1
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
            this.cst1LowPanel = new DevExpress.XtraEditors.PanelControl();
            this.cst1SmallLabel = new System.Windows.Forms.Label();
            this.cst1SmallNumber = new System.Windows.Forms.Label();
            this.cst1BigNumber = new System.Windows.Forms.Label();
            this.cst1BigLabel = new System.Windows.Forms.Label();
            this.cst1Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cst1LowPanel)).BeginInit();
            this.cst1LowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cst1Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // cst1LowPanel
            // 
            this.cst1LowPanel.Controls.Add(this.cst1SmallLabel);
            this.cst1LowPanel.Controls.Add(this.cst1SmallNumber);
            this.cst1LowPanel.Location = new System.Drawing.Point(0, 114);
            this.cst1LowPanel.Name = "cst1LowPanel";
            this.cst1LowPanel.Size = new System.Drawing.Size(280, 36);
            this.cst1LowPanel.TabIndex = 0;
            // 
            // cst1SmallLabel
            // 
            this.cst1SmallLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst1SmallLabel.Location = new System.Drawing.Point(19, 8);
            this.cst1SmallLabel.Name = "cst1SmallLabel";
            this.cst1SmallLabel.Size = new System.Drawing.Size(98, 19);
            this.cst1SmallLabel.TabIndex = 1;
            this.cst1SmallLabel.Text = "This Month";
            // 
            // cst1SmallNumber
            // 
            this.cst1SmallNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst1SmallNumber.Location = new System.Drawing.Point(142, 8);
            this.cst1SmallNumber.Name = "cst1SmallNumber";
            this.cst1SmallNumber.Size = new System.Drawing.Size(120, 19);
            this.cst1SmallNumber.TabIndex = 1;
            this.cst1SmallNumber.Text = "250";
            this.cst1SmallNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cst1BigNumber
            // 
            this.cst1BigNumber.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst1BigNumber.Location = new System.Drawing.Point(16, 11);
            this.cst1BigNumber.Name = "cst1BigNumber";
            this.cst1BigNumber.Size = new System.Drawing.Size(158, 37);
            this.cst1BigNumber.TabIndex = 1;
            this.cst1BigNumber.Text = "250";
            // 
            // cst1BigLabel
            // 
            this.cst1BigLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst1BigLabel.Location = new System.Drawing.Point(16, 58);
            this.cst1BigLabel.Name = "cst1BigLabel";
            this.cst1BigLabel.Size = new System.Drawing.Size(158, 50);
            this.cst1BigLabel.TabIndex = 1;
            this.cst1BigLabel.Text = "Total Pet";
            // 
            // cst1Icon
            // 
            this.cst1Icon.Location = new System.Drawing.Point(180, 19);
            this.cst1Icon.Name = "cst1Icon";
            this.cst1Icon.Size = new System.Drawing.Size(87, 89);
            this.cst1Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cst1Icon.TabIndex = 2;
            this.cst1Icon.TabStop = false;
            // 
            // ucStatisType1
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cst1Icon);
            this.Controls.Add(this.cst1BigLabel);
            this.Controls.Add(this.cst1BigNumber);
            this.Controls.Add(this.cst1LowPanel);
            this.Name = "ucStatisType1";
            this.Size = new System.Drawing.Size(280, 150);
            ((System.ComponentModel.ISupportInitialize)(this.cst1LowPanel)).EndInit();
            this.cst1LowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cst1Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl cst1LowPanel;
        private System.Windows.Forms.Label cst1BigNumber;
        private System.Windows.Forms.Label cst1BigLabel;
        private System.Windows.Forms.PictureBox cst1Icon;
        private System.Windows.Forms.Label cst1SmallLabel;
        private System.Windows.Forms.Label cst1SmallNumber;
    }
}
