
namespace Application.Forms
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cardStatisIncome = new Application.UserControls.ucStatisType1();
            this.cardStatisProductSales = new Application.UserControls.ucStatisType1();
            this.cardStatisCustomers = new Application.UserControls.ucStatisType1();
            this.cardStatisPetsSales = new Application.UserControls.ucStatisType1();
            this.cardIDNewCustomer = new Application.UserControls.ucStatisType2();
            this.cardIDMerchandiseSale = new Application.UserControls.ucStatisType2();
            this.cardIDPetSale = new Application.UserControls.ucStatisType2();
            this.cardIDIncome = new Application.UserControls.ucStatisType2();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutView2 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).BeginInit();
            this.SuspendLayout();
            // 
            // cardStatisIncome
            // 
            this.cardStatisIncome.Appearance.BackColor = System.Drawing.Color.White;
            this.cardStatisIncome.Appearance.Options.UseBackColor = true;
            this.cardStatisIncome.ColorBackground = System.Drawing.Color.White;
            this.cardStatisIncome.ColorLight = System.Drawing.SystemColors.Control;
            this.cardStatisIncome.Cst1BigLabel = "Tổng doanh thu";
            this.cardStatisIncome.Cst1BigNumber = "250";
            this.cardStatisIncome.Cst1BigNumberSize = 15F;
            this.cardStatisIncome.Cst1Icon = global::Application.Properties.Resources.icon_totalIncome;
            this.cardStatisIncome.Cst1SmallLabel = "Tháng này";
            this.cardStatisIncome.Cst1SmallNumber = "250";
            this.cardStatisIncome.FormParent = null;
            this.cardStatisIncome.Location = new System.Drawing.Point(662, 207);
            this.cardStatisIncome.Name = "cardStatisIncome";
            this.cardStatisIncome.Size = new System.Drawing.Size(280, 150);
            this.cardStatisIncome.TabIndex = 3;
            // 
            // cardStatisProductSales
            // 
            this.cardStatisProductSales.Appearance.BackColor = System.Drawing.Color.White;
            this.cardStatisProductSales.Appearance.Options.UseBackColor = true;
            this.cardStatisProductSales.ColorBackground = System.Drawing.Color.White;
            this.cardStatisProductSales.ColorLight = System.Drawing.SystemColors.Control;
            this.cardStatisProductSales.Cst1BigLabel = "Tổng số bán sản phẩm";
            this.cardStatisProductSales.Cst1BigNumber = "250";
            this.cardStatisProductSales.Cst1BigNumberSize = 20F;
            this.cardStatisProductSales.Cst1Icon = global::Application.Properties.Resources.icon_totalMerchandiseSale;
            this.cardStatisProductSales.Cst1SmallLabel = "Tháng này";
            this.cardStatisProductSales.Cst1SmallNumber = "250";
            this.cardStatisProductSales.FormParent = null;
            this.cardStatisProductSales.Location = new System.Drawing.Point(662, 32);
            this.cardStatisProductSales.Name = "cardStatisProductSales";
            this.cardStatisProductSales.Size = new System.Drawing.Size(280, 150);
            this.cardStatisProductSales.TabIndex = 3;
            // 
            // cardStatisCustomers
            // 
            this.cardStatisCustomers.Appearance.BackColor = System.Drawing.Color.White;
            this.cardStatisCustomers.Appearance.Options.UseBackColor = true;
            this.cardStatisCustomers.ColorBackground = System.Drawing.Color.White;
            this.cardStatisCustomers.ColorLight = System.Drawing.SystemColors.Control;
            this.cardStatisCustomers.Cst1BigLabel = "Tổng số khách hàng";
            this.cardStatisCustomers.Cst1BigNumber = "250";
            this.cardStatisCustomers.Cst1BigNumberSize = 20F;
            this.cardStatisCustomers.Cst1Icon = global::Application.Properties.Resources.icon_totalCustomer;
            this.cardStatisCustomers.Cst1SmallLabel = "Tháng này";
            this.cardStatisCustomers.Cst1SmallNumber = "250";
            this.cardStatisCustomers.FormParent = null;
            this.cardStatisCustomers.Location = new System.Drawing.Point(351, 207);
            this.cardStatisCustomers.Name = "cardStatisCustomers";
            this.cardStatisCustomers.Size = new System.Drawing.Size(280, 150);
            this.cardStatisCustomers.TabIndex = 3;
            // 
            // cardStatisPetsSales
            // 
            this.cardStatisPetsSales.Appearance.BackColor = System.Drawing.Color.White;
            this.cardStatisPetsSales.Appearance.Options.UseBackColor = true;
            this.cardStatisPetsSales.ColorBackground = System.Drawing.Color.White;
            this.cardStatisPetsSales.ColorLight = System.Drawing.SystemColors.Control;
            this.cardStatisPetsSales.Cst1BigLabel = "Tổng số bán thú cưng";
            this.cardStatisPetsSales.Cst1BigNumber = "250";
            this.cardStatisPetsSales.Cst1BigNumberSize = 20F;
            this.cardStatisPetsSales.Cst1Icon = global::Application.Properties.Resources.icon_totalPetSale;
            this.cardStatisPetsSales.Cst1SmallLabel = "Tháng này";
            this.cardStatisPetsSales.Cst1SmallNumber = "250";
            this.cardStatisPetsSales.FormParent = null;
            this.cardStatisPetsSales.Location = new System.Drawing.Point(351, 32);
            this.cardStatisPetsSales.Name = "cardStatisPetsSales";
            this.cardStatisPetsSales.Size = new System.Drawing.Size(280, 150);
            this.cardStatisPetsSales.TabIndex = 3;
            // 
            // cardIDNewCustomer
            // 
            this.cardIDNewCustomer.Appearance.BackColor = System.Drawing.Color.White;
            this.cardIDNewCustomer.Appearance.Options.UseBackColor = true;
            this.cardIDNewCustomer.Cst2LMNumber = "0";
            this.cardIDNewCustomer.Cst2Tittle = "Khách hàng mới";
            this.cardIDNewCustomer.Cst2TMNumber = "0";
            this.cardIDNewCustomer.FormParent = null;
            this.cardIDNewCustomer.Location = new System.Drawing.Point(36, 496);
            this.cardIDNewCustomer.MoneyFormat = false;
            this.cardIDNewCustomer.Name = "cardIDNewCustomer";
            this.cardIDNewCustomer.Size = new System.Drawing.Size(280, 125);
            this.cardIDNewCustomer.TabIndex = 0;
            // 
            // cardIDMerchandiseSale
            // 
            this.cardIDMerchandiseSale.Appearance.BackColor = System.Drawing.Color.White;
            this.cardIDMerchandiseSale.Appearance.Options.UseBackColor = true;
            this.cardIDMerchandiseSale.Cst2LMNumber = "0";
            this.cardIDMerchandiseSale.Cst2Tittle = "Doanh số (Sản phẩm)";
            this.cardIDMerchandiseSale.Cst2TMNumber = "0";
            this.cardIDMerchandiseSale.FormParent = null;
            this.cardIDMerchandiseSale.Location = new System.Drawing.Point(36, 343);
            this.cardIDMerchandiseSale.MoneyFormat = false;
            this.cardIDMerchandiseSale.Name = "cardIDMerchandiseSale";
            this.cardIDMerchandiseSale.Size = new System.Drawing.Size(280, 125);
            this.cardIDMerchandiseSale.TabIndex = 0;
            // 
            // cardIDPetSale
            // 
            this.cardIDPetSale.Appearance.BackColor = System.Drawing.Color.White;
            this.cardIDPetSale.Appearance.Options.UseBackColor = true;
            this.cardIDPetSale.Cst2LMNumber = "0";
            this.cardIDPetSale.Cst2Tittle = "Doanh số (Thú cưng)";
            this.cardIDPetSale.Cst2TMNumber = "0";
            this.cardIDPetSale.FormParent = null;
            this.cardIDPetSale.Location = new System.Drawing.Point(36, 186);
            this.cardIDPetSale.MoneyFormat = false;
            this.cardIDPetSale.Name = "cardIDPetSale";
            this.cardIDPetSale.Size = new System.Drawing.Size(280, 125);
            this.cardIDPetSale.TabIndex = 0;
            // 
            // cardIDIncome
            // 
            this.cardIDIncome.Appearance.BackColor = System.Drawing.Color.White;
            this.cardIDIncome.Appearance.Options.UseBackColor = true;
            this.cardIDIncome.Cst2LMNumber = "0";
            this.cardIDIncome.Cst2Tittle = "Doanh thu";
            this.cardIDIncome.Cst2TMNumber = "0";
            this.cardIDIncome.FormParent = null;
            this.cardIDIncome.Location = new System.Drawing.Point(36, 32);
            this.cardIDIncome.MoneyFormat = true;
            this.cardIDIncome.Name = "cardIDIncome";
            this.cardIDIncome.Size = new System.Drawing.Size(280, 125);
            this.cardIDIncome.TabIndex = 0;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.bindingSource2;
            this.gridControl2.Location = new System.Drawing.Point(976, 342);
            this.gridControl2.MainView = this.layoutView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(498, 314);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView2});
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(976, 12);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(498, 314);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // layoutView2
            // 
            this.layoutView2.GridControl = this.gridControl2;
            this.layoutView2.Name = "layoutView2";
            this.layoutView2.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.layoutView2.TemplateCard = this.layoutViewCard2;
            // 
            // layoutViewCard2
            // 
            this.layoutViewCard2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard2.Name = "layoutViewCard2";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 668);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.cardStatisIncome);
            this.Controls.Add(this.cardStatisProductSales);
            this.Controls.Add(this.cardStatisCustomers);
            this.Controls.Add(this.cardStatisPetsSales);
            this.Controls.Add(this.cardIDNewCustomer);
            this.Controls.Add(this.cardIDMerchandiseSale);
            this.Controls.Add(this.cardIDPetSale);
            this.Controls.Add(this.cardIDIncome);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucStatisType2 cardIDIncome;
        private UserControls.ucStatisType2 cardIDPetSale;
        private UserControls.ucStatisType2 cardIDMerchandiseSale;
        private UserControls.ucStatisType2 cardIDNewCustomer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControls.ucStatisType1 cardStatisPetsSales;
        private UserControls.ucStatisType1 cardStatisCustomers;
        private UserControls.ucStatisType1 cardStatisProductSales;
        private UserControls.ucStatisType1 cardStatisIncome;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard2;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}