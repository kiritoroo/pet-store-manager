using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Manager;
using Entities.Models;
using Application.UserControls;
using Application.Services;
using DevExpress.XtraNavBar;
using System.Globalization;
using DevExpress.XtraSplashScreen;

namespace Application.Forms
{
    public partial class frmSale : DevExpress.XtraEditors.XtraForm
    {
        CultureInfo cul = CultureInfo.CurrentCulture;
        string groupSep;
        string sFormat;

        bllSales bllSale = new bllSales();
        bllSalesPet bllSalePet = new bllSalesPet();
        bllSalesProduct bllSalesProduct = new bllSalesProduct();

        public frmSale()
        {
            InitializeComponent();
            groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
            sFormat = string.Format("#{0}###" + " ₫", groupSep);

        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            bllSale.Load();
            saleBindingSource.DataSource = bllSale.GetLocal();
            this.colSaleTax.DisplayFormat.FormatString = sFormat;
        }

        private void saleBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (this.IsActive)
            {
                SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
                SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");
            }

            this.flowLayoutPanel1.Controls.Clear();

            Sale currentSale = (Sale)saleBindingSource.Current;
            List<SalesPet> listSalePet = bllSale.GetSalePeteEachSale(currentSale);
            foreach (SalesPet item in listSalePet)
            {
                ucSalePet uc = new ucSalePet()
                {
                    SalesPet = item
                };
                uc.hyperlinkLabelControl1.Visible = false;
                this.flowLayoutPanel1.Controls.Add(uc);
            }

            List<SalesProduct> listSaleProduct = bllSale.GetSaleProductEachSale(currentSale);
            foreach (SalesProduct item in listSaleProduct)
            {
                ucSaleProduct uc = new ucSaleProduct()
                {
                    SalesProduct = item
                };
                uc.hyperlinkLabelControl1.Visible = false;
                this.flowLayoutPanel1.Controls.Add(uc);            
            }

            if (this.IsActive)
            {
                SplashScreenManager.CloseForm();
            }
        }
    }
}