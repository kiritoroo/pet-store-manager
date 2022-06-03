namespace PetStoreManager
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.mainPageDashboard = new System.Windows.Forms.TabPage();
            this.mainControlPage = new Bunifu.UI.WinForms.BunifuPages();
            this.mainEffectPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.mainTopPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.maincButtonOrders = new PetStoreManager.Components.CardTable();
            this.maincButtonPets = new PetStoreManager.Components.CardTable();
            this.maincButtonPeoples = new PetStoreManager.Components.CardTable();
            this.maincButtonDashboard = new PetStoreManager.Components.CardTable();
            this.maincButtonSales = new PetStoreManager.Components.CardTable();
            this.mainPagePeople = new System.Windows.Forms.TabPage();
            this.pDbcStatisIncome = new PetStoreManager.Components.CardStatisticsType1();
            this.pDbcStatisCustomers = new PetStoreManager.Components.CardStatisticsType1();
            this.pDbcStatisMerchandiseSales = new PetStoreManager.Components.CardStatisticsType1();
            this.pDbcStatisPetsSales = new PetStoreManager.Components.CardStatisticsType1();
            this.mainPageDashboard.SuspendLayout();
            this.mainControlPage.SuspendLayout();
            this.mainTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPageDashboard
            // 
            this.mainPageDashboard.BackColor = System.Drawing.Color.White;
            this.mainPageDashboard.Controls.Add(this.pDbcStatisIncome);
            this.mainPageDashboard.Controls.Add(this.pDbcStatisCustomers);
            this.mainPageDashboard.Controls.Add(this.pDbcStatisMerchandiseSales);
            this.mainPageDashboard.Controls.Add(this.pDbcStatisPetsSales);
            this.mainPageDashboard.Location = new System.Drawing.Point(4, 4);
            this.mainPageDashboard.Name = "mainPageDashboard";
            this.mainPageDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.mainPageDashboard.Size = new System.Drawing.Size(1272, 597);
            this.mainPageDashboard.TabIndex = 0;
            this.mainPageDashboard.Text = "Page Dashboard";
            // 
            // mainControlPage
            // 
            this.mainControlPage.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.mainControlPage.AllowTransitions = false;
            this.mainControlPage.Controls.Add(this.mainPageDashboard);
            this.mainControlPage.Controls.Add(this.mainPagePeople);
            this.mainControlPage.Location = new System.Drawing.Point(0, 110);
            this.mainControlPage.Multiline = true;
            this.mainControlPage.Name = "mainControlPage";
            this.mainControlPage.Page = this.mainPageDashboard;
            this.mainControlPage.PageIndex = 0;
            this.mainControlPage.PageName = "mainPageDashboard";
            this.mainControlPage.PageTitle = "Page Dashboard";
            this.mainControlPage.SelectedIndex = 0;
            this.mainControlPage.Size = new System.Drawing.Size(1280, 623);
            this.mainControlPage.TabIndex = 3;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.mainControlPage.Transition = animation1;
            this.mainControlPage.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.HorizSlide;
            // 
            // mainEffectPanel
            // 
            this.mainEffectPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.mainEffectPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainEffectPanel.BackgroundImage")));
            this.mainEffectPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainEffectPanel.BorderColor = System.Drawing.Color.Transparent;
            this.mainEffectPanel.BorderRadius = 0;
            this.mainEffectPanel.BorderThickness = 0;
            this.mainEffectPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainEffectPanel.Location = new System.Drawing.Point(0, 739);
            this.mainEffectPanel.Name = "mainEffectPanel";
            this.mainEffectPanel.ShowBorders = true;
            this.mainEffectPanel.Size = new System.Drawing.Size(1280, 61);
            this.mainEffectPanel.TabIndex = 1;
            // 
            // mainTopPanel
            // 
            this.mainTopPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.mainTopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainTopPanel.BackgroundImage")));
            this.mainTopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainTopPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.mainTopPanel.BorderRadius = 0;
            this.mainTopPanel.BorderThickness = 0;
            this.mainTopPanel.Controls.Add(this.maincButtonOrders);
            this.mainTopPanel.Controls.Add(this.maincButtonPets);
            this.mainTopPanel.Controls.Add(this.maincButtonPeoples);
            this.mainTopPanel.Controls.Add(this.maincButtonDashboard);
            this.mainTopPanel.Controls.Add(this.maincButtonSales);
            this.mainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTopPanel.Name = "mainTopPanel";
            this.mainTopPanel.ShowBorders = true;
            this.mainTopPanel.Size = new System.Drawing.Size(1280, 104);
            this.mainTopPanel.TabIndex = 0;
            // 
            // maincButtonOrders
            // 
            this.maincButtonOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(17)))));
            this.maincButtonOrders.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(17)))));
            this.maincButtonOrders.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(145)))));
            this.maincButtonOrders.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.maincButtonOrders.CtIcon = global::PetStoreManager.Properties.Resources.icon_orders;
            this.maincButtonOrders.CtLabel = "Orders";
            this.maincButtonOrders.FormParent = null;
            this.maincButtonOrders.Location = new System.Drawing.Point(922, 30);
            this.maincButtonOrders.Name = "maincButtonOrders";
            this.maincButtonOrders.Size = new System.Drawing.Size(150, 50);
            this.maincButtonOrders.TabIndex = 0;
            // 
            // maincButtonPets
            // 
            this.maincButtonPets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(95)))));
            this.maincButtonPets.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(95)))));
            this.maincButtonPets.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(181)))), ((int)(((byte)(193)))));
            this.maincButtonPets.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(139)))), ((int)(((byte)(158)))));
            this.maincButtonPets.CtIcon = global::PetStoreManager.Properties.Resources.icon_pets;
            this.maincButtonPets.CtLabel = "Pets";
            this.maincButtonPets.FormParent = null;
            this.maincButtonPets.Location = new System.Drawing.Point(405, 30);
            this.maincButtonPets.Name = "maincButtonPets";
            this.maincButtonPets.Size = new System.Drawing.Size(150, 50);
            this.maincButtonPets.TabIndex = 0;
            // 
            // maincButtonPeoples
            // 
            this.maincButtonPeoples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.maincButtonPeoples.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.maincButtonPeoples.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.maincButtonPeoples.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.maincButtonPeoples.CtIcon = global::PetStoreManager.Properties.Resources.icon_peoples;
            this.maincButtonPeoples.CtLabel = "Peoples";
            this.maincButtonPeoples.FormParent = null;
            this.maincButtonPeoples.Location = new System.Drawing.Point(239, 30);
            this.maincButtonPeoples.Name = "maincButtonPeoples";
            this.maincButtonPeoples.Size = new System.Drawing.Size(150, 50);
            this.maincButtonPeoples.TabIndex = 0;
            // 
            // maincButtonDashboard
            // 
            this.maincButtonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.maincButtonDashboard.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.maincButtonDashboard.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.maincButtonDashboard.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.maincButtonDashboard.CtIcon = global::PetStoreManager.Properties.Resources.icon_dashboard;
            this.maincButtonDashboard.CtLabel = "Dashboard";
            this.maincButtonDashboard.FormParent = null;
            this.maincButtonDashboard.Location = new System.Drawing.Point(72, 30);
            this.maincButtonDashboard.Name = "maincButtonDashboard";
            this.maincButtonDashboard.Size = new System.Drawing.Size(150, 50);
            this.maincButtonDashboard.TabIndex = 0;
            // 
            // maincButtonSales
            // 
            this.maincButtonSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.maincButtonSales.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.maincButtonSales.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(228)))), ((int)(((byte)(199)))));
            this.maincButtonSales.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.maincButtonSales.CtIcon = global::PetStoreManager.Properties.Resources.icon_sales;
            this.maincButtonSales.CtLabel = "Sales";
            this.maincButtonSales.FormParent = null;
            this.maincButtonSales.Location = new System.Drawing.Point(741, 30);
            this.maincButtonSales.Name = "maincButtonSales";
            this.maincButtonSales.Size = new System.Drawing.Size(150, 50);
            this.maincButtonSales.TabIndex = 0;
            // 
            // mainPagePeople
            // 
            this.mainPagePeople.Location = new System.Drawing.Point(4, 4);
            this.mainPagePeople.Name = "mainPagePeople";
            this.mainPagePeople.Padding = new System.Windows.Forms.Padding(3);
            this.mainPagePeople.Size = new System.Drawing.Size(1272, 597);
            this.mainPagePeople.TabIndex = 1;
            this.mainPagePeople.Text = "Page People";
            this.mainPagePeople.UseVisualStyleBackColor = true;
            // 
            // pDbcStatisIncome
            // 
            this.pDbcStatisIncome.BackColor = System.Drawing.Color.Transparent;
            this.pDbcStatisIncome.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.pDbcStatisIncome.ColorEffect = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(173)))), ((int)(((byte)(6)))));
            this.pDbcStatisIncome.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(200)))), ((int)(((byte)(89)))));
            this.pDbcStatisIncome.Cst1BigLabel = "Tổng số doanh thu";
            this.pDbcStatisIncome.Cst1BigNumber = "1";
            this.pDbcStatisIncome.Cst1Icon = global::PetStoreManager.Properties.Resources.icon_totalIncome;
            this.pDbcStatisIncome.Cst1SmallLabel = "Tháng này";
            this.pDbcStatisIncome.Cst1SmallNumber = "1";
            this.pDbcStatisIncome.FormParent = null;
            this.pDbcStatisIncome.Location = new System.Drawing.Point(952, 38);
            this.pDbcStatisIncome.Name = "pDbcStatisIncome";
            this.pDbcStatisIncome.Size = new System.Drawing.Size(280, 150);
            this.pDbcStatisIncome.TabIndex = 3;
            // 
            // pDbcStatisCustomers
            // 
            this.pDbcStatisCustomers.BackColor = System.Drawing.Color.Transparent;
            this.pDbcStatisCustomers.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pDbcStatisCustomers.ColorEffect = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(62)))));
            this.pDbcStatisCustomers.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(185)))), ((int)(((byte)(126)))));
            this.pDbcStatisCustomers.Cst1BigLabel = "Tổng số khách hàng";
            this.pDbcStatisCustomers.Cst1BigNumber = "1";
            this.pDbcStatisCustomers.Cst1Icon = global::PetStoreManager.Properties.Resources.icon_totalCustomer;
            this.pDbcStatisCustomers.Cst1SmallLabel = "Tổng số hóa đơn";
            this.pDbcStatisCustomers.Cst1SmallNumber = "1";
            this.pDbcStatisCustomers.FormParent = null;
            this.pDbcStatisCustomers.Location = new System.Drawing.Point(646, 38);
            this.pDbcStatisCustomers.Name = "pDbcStatisCustomers";
            this.pDbcStatisCustomers.Size = new System.Drawing.Size(280, 150);
            this.pDbcStatisCustomers.TabIndex = 4;
            // 
            // pDbcStatisMerchandiseSales
            // 
            this.pDbcStatisMerchandiseSales.BackColor = System.Drawing.Color.Transparent;
            this.pDbcStatisMerchandiseSales.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.pDbcStatisMerchandiseSales.ColorEffect = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(229)))));
            this.pDbcStatisMerchandiseSales.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(158)))), ((int)(((byte)(237)))));
            this.pDbcStatisMerchandiseSales.Cst1BigLabel = "Tổng số hàng hóa bán ";
            this.pDbcStatisMerchandiseSales.Cst1BigNumber = "1";
            this.pDbcStatisMerchandiseSales.Cst1Icon = global::PetStoreManager.Properties.Resources.icon_totalMerchandiseSale;
            this.pDbcStatisMerchandiseSales.Cst1SmallLabel = "Tháng này";
            this.pDbcStatisMerchandiseSales.Cst1SmallNumber = "1";
            this.pDbcStatisMerchandiseSales.FormParent = null;
            this.pDbcStatisMerchandiseSales.Location = new System.Drawing.Point(341, 38);
            this.pDbcStatisMerchandiseSales.Name = "pDbcStatisMerchandiseSales";
            this.pDbcStatisMerchandiseSales.Size = new System.Drawing.Size(280, 150);
            this.pDbcStatisMerchandiseSales.TabIndex = 5;
            // 
            // pDbcStatisPetsSales
            // 
            this.pDbcStatisPetsSales.BackColor = System.Drawing.Color.Transparent;
            this.pDbcStatisPetsSales.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.pDbcStatisPetsSales.ColorEffect = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(145)))), ((int)(((byte)(165)))));
            this.pDbcStatisPetsSales.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(181)))), ((int)(((byte)(195)))));
            this.pDbcStatisPetsSales.Cst1BigLabel = "Tổng số thú cưng bán";
            this.pDbcStatisPetsSales.Cst1BigNumber = "1";
            this.pDbcStatisPetsSales.Cst1Icon = global::PetStoreManager.Properties.Resources.icon_totalPetSale;
            this.pDbcStatisPetsSales.Cst1SmallLabel = "Tháng này";
            this.pDbcStatisPetsSales.Cst1SmallNumber = "1";
            this.pDbcStatisPetsSales.FormParent = null;
            this.pDbcStatisPetsSales.Location = new System.Drawing.Point(35, 38);
            this.pDbcStatisPetsSales.Name = "pDbcStatisPetsSales";
            this.pDbcStatisPetsSales.Size = new System.Drawing.Size(280, 150);
            this.pDbcStatisPetsSales.TabIndex = 6;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.mainEffectPanel);
            this.Controls.Add(this.mainTopPanel);
            this.Controls.Add(this.mainControlPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.mainPageDashboard.ResumeLayout(false);
            this.mainControlPage.ResumeLayout(false);
            this.mainTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuPanel mainTopPanel;
        public Components.CardTable maincButtonSales;
        public Components.CardTable maincButtonOrders;
        public Components.CardTable maincButtonPets;
        public Components.CardTable maincButtonPeoples;
        public Components.CardTable maincButtonDashboard;
        public Bunifu.UI.WinForms.BunifuPanel mainEffectPanel;
        private System.Windows.Forms.TabPage mainPageDashboard;
        private Bunifu.UI.WinForms.BunifuPages mainControlPage;
        private System.Windows.Forms.TabPage mainPagePeople;
        private Components.CardStatisticsType1 pDbcStatisIncome;
        private Components.CardStatisticsType1 pDbcStatisCustomers;
        private Components.CardStatisticsType1 pDbcStatisMerchandiseSales;
        private Components.CardStatisticsType1 pDbcStatisPetsSales;
    }
}