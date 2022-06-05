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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cardStatisIncome = new PetStoreManager.Components.CardStatisticsType1();
            this.cardStatisCustomers = new PetStoreManager.Components.CardStatisticsType1();
            this.cardStatisMerchandiseSales = new PetStoreManager.Components.CardStatisticsType1();
            this.cardStatisPetsSales = new PetStoreManager.Components.CardStatisticsType1();
            this.cardIDIncome = new PetStoreManager.Components.CardStatisticsType2();
            this.cardIDPetSale = new PetStoreManager.Components.CardStatisticsType2();
            this.cardIDNewCustomer = new PetStoreManager.Components.CardStatisticsType2();
            this.cardIDMerchandiseSale = new PetStoreManager.Components.CardStatisticsType2();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.statisMerchandiseDGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.cusTopPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.cusLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.statisPetDGV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisMerchandiseDGV)).BeginInit();
            this.cusTopPanel.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisPetDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cardStatisIncome
            // 
            this.cardStatisIncome.BackColor = System.Drawing.Color.Transparent;
            this.cardStatisIncome.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.cardStatisIncome.ColorEffect = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(154)))), ((int)(((byte)(222)))));
            this.cardStatisIncome.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.cardStatisIncome.Cst1BigLabel = "Tổng số doanh thu";
            this.cardStatisIncome.Cst1BigNumber = "1";
            this.cardStatisIncome.Cst1BigNumberSize = 15F;
            this.cardStatisIncome.Cst1Icon = global::PetStoreManager.Properties.Resources.icon_totalIncome;
            this.cardStatisIncome.Cst1SmallLabel = "Tháng này";
            this.cardStatisIncome.Cst1SmallNumber = "1";
            this.cardStatisIncome.FormParent = null;
            this.cardStatisIncome.Location = new System.Drawing.Point(967, 27);
            this.cardStatisIncome.Name = "cardStatisIncome";
            this.cardStatisIncome.Size = new System.Drawing.Size(301, 162);
            this.cardStatisIncome.TabIndex = 7;
            // 
            // cardStatisCustomers
            // 
            this.cardStatisCustomers.BackColor = System.Drawing.Color.Transparent;
            this.cardStatisCustomers.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.cardStatisCustomers.ColorEffect = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(154)))), ((int)(((byte)(222)))));
            this.cardStatisCustomers.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.cardStatisCustomers.Cst1BigLabel = "Tổng số khách hàng";
            this.cardStatisCustomers.Cst1BigNumber = "1";
            this.cardStatisCustomers.Cst1BigNumberSize = 25F;
            this.cardStatisCustomers.Cst1Icon = global::PetStoreManager.Properties.Resources.icon_totalCustomer;
            this.cardStatisCustomers.Cst1SmallLabel = "Tháng này";
            this.cardStatisCustomers.Cst1SmallNumber = "1";
            this.cardStatisCustomers.FormParent = null;
            this.cardStatisCustomers.Location = new System.Drawing.Point(661, 30);
            this.cardStatisCustomers.Name = "cardStatisCustomers";
            this.cardStatisCustomers.Size = new System.Drawing.Size(300, 162);
            this.cardStatisCustomers.TabIndex = 8;
            // 
            // cardStatisMerchandiseSales
            // 
            this.cardStatisMerchandiseSales.BackColor = System.Drawing.Color.Transparent;
            this.cardStatisMerchandiseSales.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.cardStatisMerchandiseSales.ColorEffect = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(154)))), ((int)(((byte)(222)))));
            this.cardStatisMerchandiseSales.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.cardStatisMerchandiseSales.Cst1BigLabel = "Tổng số hàng hóa bán ";
            this.cardStatisMerchandiseSales.Cst1BigNumber = "1";
            this.cardStatisMerchandiseSales.Cst1BigNumberSize = 25F;
            this.cardStatisMerchandiseSales.Cst1Icon = global::PetStoreManager.Properties.Resources.icon_totalMerchandiseSale;
            this.cardStatisMerchandiseSales.Cst1SmallLabel = "Tháng này";
            this.cardStatisMerchandiseSales.Cst1SmallNumber = "1";
            this.cardStatisMerchandiseSales.FormParent = null;
            this.cardStatisMerchandiseSales.Location = new System.Drawing.Point(356, 27);
            this.cardStatisMerchandiseSales.Name = "cardStatisMerchandiseSales";
            this.cardStatisMerchandiseSales.Size = new System.Drawing.Size(299, 165);
            this.cardStatisMerchandiseSales.TabIndex = 9;
            // 
            // cardStatisPetsSales
            // 
            this.cardStatisPetsSales.BackColor = System.Drawing.Color.Transparent;
            this.cardStatisPetsSales.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.cardStatisPetsSales.ColorEffect = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(154)))), ((int)(((byte)(222)))));
            this.cardStatisPetsSales.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.cardStatisPetsSales.Cst1BigLabel = "Tổng số thú cưng bán";
            this.cardStatisPetsSales.Cst1BigNumber = "1";
            this.cardStatisPetsSales.Cst1BigNumberSize = 25F;
            this.cardStatisPetsSales.Cst1Icon = global::PetStoreManager.Properties.Resources.icon_totalPetSale;
            this.cardStatisPetsSales.Cst1SmallLabel = "Tháng này";
            this.cardStatisPetsSales.Cst1SmallNumber = "1";
            this.cardStatisPetsSales.FormParent = null;
            this.cardStatisPetsSales.Location = new System.Drawing.Point(50, 27);
            this.cardStatisPetsSales.Name = "cardStatisPetsSales";
            this.cardStatisPetsSales.Size = new System.Drawing.Size(287, 162);
            this.cardStatisPetsSales.TabIndex = 10;
            // 
            // cardIDIncome
            // 
            this.cardIDIncome.BackColor = System.Drawing.Color.Transparent;
            this.cardIDIncome.Cst2LMNumber = "1";
            this.cardIDIncome.Cst2Tittle = "Doanh Thu";
            this.cardIDIncome.Cst2TMNumber = "2";
            this.cardIDIncome.FormParent = null;
            this.cardIDIncome.Location = new System.Drawing.Point(50, 316);
            this.cardIDIncome.MoneyFormat = true;
            this.cardIDIncome.Name = "cardIDIncome";
            this.cardIDIncome.Size = new System.Drawing.Size(263, 115);
            this.cardIDIncome.TabIndex = 11;
            // 
            // cardIDPetSale
            // 
            this.cardIDPetSale.BackColor = System.Drawing.Color.Transparent;
            this.cardIDPetSale.Cst2LMNumber = "1";
            this.cardIDPetSale.Cst2Tittle = "Doanh Số (Thú cưng)";
            this.cardIDPetSale.Cst2TMNumber = "2";
            this.cardIDPetSale.FormParent = null;
            this.cardIDPetSale.Location = new System.Drawing.Point(50, 437);
            this.cardIDPetSale.MoneyFormat = false;
            this.cardIDPetSale.Name = "cardIDPetSale";
            this.cardIDPetSale.Size = new System.Drawing.Size(263, 115);
            this.cardIDPetSale.TabIndex = 11;
            // 
            // cardIDNewCustomer
            // 
            this.cardIDNewCustomer.BackColor = System.Drawing.Color.Transparent;
            this.cardIDNewCustomer.Cst2LMNumber = "2";
            this.cardIDNewCustomer.Cst2Tittle = "Khách Hàng Mới";
            this.cardIDNewCustomer.Cst2TMNumber = "1";
            this.cardIDNewCustomer.FormParent = null;
            this.cardIDNewCustomer.Location = new System.Drawing.Point(50, 195);
            this.cardIDNewCustomer.MoneyFormat = false;
            this.cardIDNewCustomer.Name = "cardIDNewCustomer";
            this.cardIDNewCustomer.Size = new System.Drawing.Size(263, 115);
            this.cardIDNewCustomer.TabIndex = 11;
            // 
            // cardIDMerchandiseSale
            // 
            this.cardIDMerchandiseSale.BackColor = System.Drawing.Color.Transparent;
            this.cardIDMerchandiseSale.Cst2LMNumber = "2";
            this.cardIDMerchandiseSale.Cst2Tittle = "Doanh Số (Hàng hóa)";
            this.cardIDMerchandiseSale.Cst2TMNumber = "1";
            this.cardIDMerchandiseSale.FormParent = null;
            this.cardIDMerchandiseSale.Location = new System.Drawing.Point(50, 558);
            this.cardIDMerchandiseSale.MoneyFormat = false;
            this.cardIDMerchandiseSale.Name = "cardIDMerchandiseSale";
            this.cardIDMerchandiseSale.Size = new System.Drawing.Size(263, 115);
            this.cardIDMerchandiseSale.TabIndex = 11;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.DimGray;
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.statisMerchandiseDGV);
            this.bunifuPanel1.Controls.Add(this.cusTopPanel);
            this.bunifuPanel1.Location = new System.Drawing.Point(356, 195);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(891, 210);
            this.bunifuPanel1.TabIndex = 13;
            // 
            // statisMerchandiseDGV
            // 
            this.statisMerchandiseDGV.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.statisMerchandiseDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.statisMerchandiseDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.statisMerchandiseDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.statisMerchandiseDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statisMerchandiseDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.statisMerchandiseDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statisMerchandiseDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.statisMerchandiseDGV.ColumnHeadersHeight = 40;
            this.statisMerchandiseDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.statisMerchandiseDGV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.statisMerchandiseDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.statisMerchandiseDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.statisMerchandiseDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.statisMerchandiseDGV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.statisMerchandiseDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.statisMerchandiseDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.statisMerchandiseDGV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.statisMerchandiseDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.statisMerchandiseDGV.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.statisMerchandiseDGV.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.statisMerchandiseDGV.CurrentTheme.Name = null;
            this.statisMerchandiseDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.statisMerchandiseDGV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.statisMerchandiseDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.statisMerchandiseDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.statisMerchandiseDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statisMerchandiseDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.statisMerchandiseDGV.EnableHeadersVisualStyles = false;
            this.statisMerchandiseDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.statisMerchandiseDGV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.statisMerchandiseDGV.HeaderBgColor = System.Drawing.Color.Empty;
            this.statisMerchandiseDGV.HeaderForeColor = System.Drawing.Color.White;
            this.statisMerchandiseDGV.Location = new System.Drawing.Point(3, 37);
            this.statisMerchandiseDGV.Name = "statisMerchandiseDGV";
            this.statisMerchandiseDGV.RowHeadersVisible = false;
            this.statisMerchandiseDGV.RowTemplate.Height = 40;
            this.statisMerchandiseDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statisMerchandiseDGV.Size = new System.Drawing.Size(884, 171);
            this.statisMerchandiseDGV.TabIndex = 15;
            this.statisMerchandiseDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // cusTopPanel
            // 
            this.cusTopPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(154)))), ((int)(((byte)(222)))));
            this.cusTopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cusTopPanel.BackgroundImage")));
            this.cusTopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cusTopPanel.BorderColor = System.Drawing.Color.Transparent;
            this.cusTopPanel.BorderRadius = 3;
            this.cusTopPanel.BorderThickness = 1;
            this.cusTopPanel.Controls.Add(this.cusLabel);
            this.cusTopPanel.Location = new System.Drawing.Point(3, 3);
            this.cusTopPanel.Name = "cusTopPanel";
            this.cusTopPanel.ShowBorders = true;
            this.cusTopPanel.Size = new System.Drawing.Size(885, 32);
            this.cusTopPanel.TabIndex = 14;
            // 
            // cusLabel
            // 
            this.cusLabel.AllowParentOverrides = false;
            this.cusLabel.AutoEllipsis = false;
            this.cusLabel.AutoSize = false;
            this.cusLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.cusLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.cusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusLabel.ForeColor = System.Drawing.Color.White;
            this.cusLabel.Location = new System.Drawing.Point(25, 9);
            this.cusLabel.Name = "cusLabel";
            this.cusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cusLabel.Size = new System.Drawing.Size(191, 17);
            this.cusLabel.TabIndex = 0;
            this.cusLabel.Text = "TOP MẶT HÀNG BÁN";
            this.cusLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.cusLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.DimGray;
            this.bunifuPanel2.BorderRadius = 0;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.statisPetDGV);
            this.bunifuPanel2.Controls.Add(this.bunifuPanel3);
            this.bunifuPanel2.Location = new System.Drawing.Point(356, 463);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(891, 210);
            this.bunifuPanel2.TabIndex = 15;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(154)))), ((int)(((byte)(222)))));
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel3.Location = new System.Drawing.Point(3, 3);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(885, 32);
            this.bunifuPanel3.TabIndex = 14;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(25, 9);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(191, 17);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "TOP THÚ CƯNG BÁN";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // statisPetDGV
            // 
            this.statisPetDGV.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.statisPetDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.statisPetDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.statisPetDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.statisPetDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statisPetDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.statisPetDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statisPetDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.statisPetDGV.ColumnHeadersHeight = 40;
            this.statisPetDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.statisPetDGV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.statisPetDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.statisPetDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.statisPetDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.statisPetDGV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.statisPetDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.statisPetDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.statisPetDGV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.statisPetDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.statisPetDGV.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.statisPetDGV.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.statisPetDGV.CurrentTheme.Name = null;
            this.statisPetDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.statisPetDGV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.statisPetDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.statisPetDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.statisPetDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statisPetDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.statisPetDGV.EnableHeadersVisualStyles = false;
            this.statisPetDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.statisPetDGV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.statisPetDGV.HeaderBgColor = System.Drawing.Color.Empty;
            this.statisPetDGV.HeaderForeColor = System.Drawing.Color.White;
            this.statisPetDGV.Location = new System.Drawing.Point(3, 35);
            this.statisPetDGV.Name = "statisPetDGV";
            this.statisPetDGV.RowHeadersVisible = false;
            this.statisPetDGV.RowTemplate.Height = 40;
            this.statisPetDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statisPetDGV.Size = new System.Drawing.Size(884, 172);
            this.statisPetDGV.TabIndex = 16;
            this.statisPetDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1280, 685);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.cardIDNewCustomer);
            this.Controls.Add(this.cardIDMerchandiseSale);
            this.Controls.Add(this.cardIDPetSale);
            this.Controls.Add(this.cardIDIncome);
            this.Controls.Add(this.cardStatisIncome);
            this.Controls.Add(this.cardStatisCustomers);
            this.Controls.Add(this.cardStatisMerchandiseSales);
            this.Controls.Add(this.cardStatisPetsSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisMerchandiseDGV)).EndInit();
            this.cusTopPanel.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisPetDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.CardStatisticsType1 cardStatisIncome;
        private Components.CardStatisticsType1 cardStatisCustomers;
        private Components.CardStatisticsType1 cardStatisMerchandiseSales;
        private Components.CardStatisticsType1 cardStatisPetsSales;
        private Components.CardStatisticsType2 cardIDIncome;
        private Components.CardStatisticsType2 cardIDPetSale;
        private Components.CardStatisticsType2 cardIDNewCustomer;
        private Components.CardStatisticsType2 cardIDMerchandiseSale;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel cusTopPanel;
        private Bunifu.UI.WinForms.BunifuLabel cusLabel;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDataGridView statisMerchandiseDGV;
        private Bunifu.UI.WinForms.BunifuDataGridView statisPetDGV;
    }
}