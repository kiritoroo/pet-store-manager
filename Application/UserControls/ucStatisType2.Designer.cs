
namespace Application.UserControls
{
    partial class ucStatisType2
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cst2Icon = new System.Windows.Forms.PictureBox();
            this.cst2Ratio = new System.Windows.Forms.Label();
            this.cst2TMLabel = new System.Windows.Forms.Label();
            this.cst2TMNumber = new System.Windows.Forms.Label();
            this.cst2LMNumber = new System.Windows.Forms.Label();
            this.cst2LMLabel = new System.Windows.Forms.Label();
            this.cst2TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cst2Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.cst2Icon);
            this.panelControl1.Controls.Add(this.cst2Ratio);
            this.panelControl1.Controls.Add(this.cst2TMLabel);
            this.panelControl1.Controls.Add(this.cst2TMNumber);
            this.panelControl1.Controls.Add(this.cst2LMNumber);
            this.panelControl1.Controls.Add(this.cst2LMLabel);
            this.panelControl1.Controls.Add(this.cst2TitleLabel);
            this.panelControl1.Location = new System.Drawing.Point(11, 8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(257, 109);
            this.panelControl1.TabIndex = 0;
            // 
            // cst2Icon
            // 
            this.cst2Icon.Image = global::Application.Properties.Resources.icon_increase;
            this.cst2Icon.Location = new System.Drawing.Point(16, 73);
            this.cst2Icon.Name = "cst2Icon";
            this.cst2Icon.Size = new System.Drawing.Size(30, 30);
            this.cst2Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cst2Icon.TabIndex = 1;
            this.cst2Icon.TabStop = false;
            // 
            // cst2Ratio
            // 
            this.cst2Ratio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst2Ratio.Location = new System.Drawing.Point(88, 73);
            this.cst2Ratio.Name = "cst2Ratio";
            this.cst2Ratio.Size = new System.Drawing.Size(153, 31);
            this.cst2Ratio.TabIndex = 0;
            this.cst2Ratio.Text = "20 %";
            this.cst2Ratio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cst2TMLabel
            // 
            this.cst2TMLabel.AutoSize = true;
            this.cst2TMLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst2TMLabel.Location = new System.Drawing.Point(113, 53);
            this.cst2TMLabel.Name = "cst2TMLabel";
            this.cst2TMLabel.Size = new System.Drawing.Size(36, 17);
            this.cst2TMLabel.TabIndex = 0;
            this.cst2TMLabel.Text = "TM -";
            // 
            // cst2TMNumber
            // 
            this.cst2TMNumber.AutoSize = true;
            this.cst2TMNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst2TMNumber.Location = new System.Drawing.Point(162, 53);
            this.cst2TMNumber.Name = "cst2TMNumber";
            this.cst2TMNumber.Size = new System.Drawing.Size(75, 17);
            this.cst2TMNumber.TabIndex = 0;
            this.cst2TMNumber.Text = "100,000,000";
            // 
            // cst2LMNumber
            // 
            this.cst2LMNumber.AutoSize = true;
            this.cst2LMNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst2LMNumber.Location = new System.Drawing.Point(162, 32);
            this.cst2LMNumber.Name = "cst2LMNumber";
            this.cst2LMNumber.Size = new System.Drawing.Size(75, 17);
            this.cst2LMNumber.TabIndex = 0;
            this.cst2LMNumber.Text = "100,000,000";
            // 
            // cst2LMLabel
            // 
            this.cst2LMLabel.AutoSize = true;
            this.cst2LMLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst2LMLabel.Location = new System.Drawing.Point(114, 32);
            this.cst2LMLabel.Name = "cst2LMLabel";
            this.cst2LMLabel.Size = new System.Drawing.Size(35, 17);
            this.cst2LMLabel.TabIndex = 0;
            this.cst2LMLabel.Text = "LM -";
            // 
            // cst2TitleLabel
            // 
            this.cst2TitleLabel.AutoSize = true;
            this.cst2TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst2TitleLabel.Location = new System.Drawing.Point(12, 8);
            this.cst2TitleLabel.Name = "cst2TitleLabel";
            this.cst2TitleLabel.Size = new System.Drawing.Size(83, 21);
            this.cst2TitleLabel.TabIndex = 0;
            this.cst2TitleLabel.Text = "Doanh thu";
            // 
            // ucStatisType2
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucStatisType2";
            this.Size = new System.Drawing.Size(280, 125);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cst2Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label cst2TitleLabel;
        private System.Windows.Forms.Label cst2LMLabel;
        private System.Windows.Forms.Label cst2TMLabel;
        private System.Windows.Forms.Label cst2LMNumber;
        private System.Windows.Forms.Label cst2TMNumber;
        private System.Windows.Forms.Label cst2Ratio;
        private System.Windows.Forms.PictureBox cst2Icon;
    }
}
