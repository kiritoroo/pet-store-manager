namespace PetStoreManager
{
    partial class frmDashboard
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
            this.cardStatisIncome = new PetStoreManager.Components.CardStatisticsType1();
            this.cardStatisCustomers = new PetStoreManager.Components.CardStatisticsType1();
            this.cardStatisMerchandiseSales = new PetStoreManager.Components.CardStatisticsType1();
            this.cardStatisPetsSales = new PetStoreManager.Components.CardStatisticsType1();
            this.SuspendLayout();
            // 
            // cardStatisIncome
            // 
            this.cardStatisIncome.BackColor = System.Drawing.Color.Transparent;
            this.cardStatisIncome.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.cardStatisIncome.ColorEffect = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(173)))), ((int)(((byte)(6)))));
            this.cardStatisIncome.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(200)))), ((int)(((byte)(89)))));
            this.cardStatisIncome.Cst1BigLabel = "Tổng số doanh thu";
            this.cardStatisIncome.Cst1BigNumber = "1";
            this.cardStatisIncome.Cst1BigNumberSize = 20F;
            this.cardStatisIncome.Cst1Icon = global::PetStoreManager.Properties.Resources.icon_totalIncome;
            this.cardStatisIncome.Cst1SmallLabel = "Tháng này";
            this.cardStatisIncome.Cst1SmallNumber = "1";
            this.cardStatisIncome.FormParent = null;
            this.cardStatisIncome.Location = new System.Drawing.Point(967, 27);
            this.cardStatisIncome.Name = "cardStatisIncome";
            this.cardStatisIncome.Size = new System.Drawing.Size(280, 150);
            this.cardStatisIncome.TabIndex = 7;
            // 
            // cardStatisCustomers
            // 
            this.cardStatisCustomers.BackColor = System.Drawing.Color.Transparent;
            this.cardStatisCustomers.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.cardStatisCustomers.ColorEffect = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(62)))));
            this.cardStatisCustomers.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(185)))), ((int)(((byte)(126)))));
            this.cardStatisCustomers.Cst1BigLabel = "Tổng số khách hàng";
            this.cardStatisCustomers.Cst1BigNumber = "1";
            this.cardStatisCustomers.Cst1BigNumberSize = 25F;
            this.cardStatisCustomers.Cst1Icon = global::PetStoreManager.Properties.Resources.icon_totalCustomer;
            this.cardStatisCustomers.Cst1SmallLabel = "Tổng số hóa đơn";
            this.cardStatisCustomers.Cst1SmallNumber = "1";
            this.cardStatisCustomers.FormParent = null;
            this.cardStatisCustomers.Location = new System.Drawing.Point(661, 27);
            this.cardStatisCustomers.Name = "cardStatisCustomers";
            this.cardStatisCustomers.Size = new System.Drawing.Size(280, 150);
            this.cardStatisCustomers.TabIndex = 8;
            // 
            // cardStatisMerchandiseSales
            // 
            this.cardStatisMerchandiseSales.BackColor = System.Drawing.Color.Transparent;
            this.cardStatisMerchandiseSales.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.cardStatisMerchandiseSales.ColorEffect = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(229)))));
            this.cardStatisMerchandiseSales.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(158)))), ((int)(((byte)(237)))));
            this.cardStatisMerchandiseSales.Cst1BigLabel = "Tổng số hàng hóa bán ";
            this.cardStatisMerchandiseSales.Cst1BigNumber = "1";
            this.cardStatisMerchandiseSales.Cst1BigNumberSize = 25F;
            this.cardStatisMerchandiseSales.Cst1Icon = global::PetStoreManager.Properties.Resources.icon_totalMerchandiseSale;
            this.cardStatisMerchandiseSales.Cst1SmallLabel = "Tháng này";
            this.cardStatisMerchandiseSales.Cst1SmallNumber = "1";
            this.cardStatisMerchandiseSales.FormParent = null;
            this.cardStatisMerchandiseSales.Location = new System.Drawing.Point(356, 27);
            this.cardStatisMerchandiseSales.Name = "cardStatisMerchandiseSales";
            this.cardStatisMerchandiseSales.Size = new System.Drawing.Size(280, 150);
            this.cardStatisMerchandiseSales.TabIndex = 9;
            // 
            // cardStatisPetsSales
            // 
            this.cardStatisPetsSales.BackColor = System.Drawing.Color.Transparent;
            this.cardStatisPetsSales.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.cardStatisPetsSales.ColorEffect = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(165)))));
            this.cardStatisPetsSales.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(181)))), ((int)(((byte)(195)))));
            this.cardStatisPetsSales.Cst1BigLabel = "Tổng số thú cưng bán";
            this.cardStatisPetsSales.Cst1BigNumber = "1";
            this.cardStatisPetsSales.Cst1BigNumberSize = 25F;
            this.cardStatisPetsSales.Cst1Icon = global::PetStoreManager.Properties.Resources.icon_totalPetSale;
            this.cardStatisPetsSales.Cst1SmallLabel = "Tháng này";
            this.cardStatisPetsSales.Cst1SmallNumber = "1";
            this.cardStatisPetsSales.FormParent = null;
            this.cardStatisPetsSales.Location = new System.Drawing.Point(50, 27);
            this.cardStatisPetsSales.Name = "cardStatisPetsSales";
            this.cardStatisPetsSales.Size = new System.Drawing.Size(280, 150);
            this.cardStatisPetsSales.TabIndex = 10;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1280, 685);
            this.Controls.Add(this.cardStatisIncome);
            this.Controls.Add(this.cardStatisCustomers);
            this.Controls.Add(this.cardStatisMerchandiseSales);
            this.Controls.Add(this.cardStatisPetsSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.CardStatisticsType1 cardStatisIncome;
        private Components.CardStatisticsType1 cardStatisCustomers;
        private Components.CardStatisticsType1 cardStatisMerchandiseSales;
        private Components.CardStatisticsType1 cardStatisPetsSales;
    }
}