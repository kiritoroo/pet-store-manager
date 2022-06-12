using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Manager;
using Entities.Models;

namespace Application.Forms
{
    public partial class frmDashboard : DevExpress.XtraEditors.XtraForm
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            CultureInfo cul = CultureInfo.CurrentCulture;
            string groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
            string sFormat = string.Format("#{0}###", groupSep);

            bllSales sBll = new bllSales();
            bllCustomer cusBll = new bllCustomer();
            bllSalesPet saBll = new bllSalesPet();
            bllSalesProduct spBll = new bllSalesProduct();
            bllPetCategory petCateBll = new bllPetCategory();
            bllProductCategory proCateBll = new bllProductCategory();

            // Binding Source
            this.bindingSource1.DataSource = petCateBll.GetTopSalePetCategory();
            this.bindingSource2.DataSource = proCateBll.GetTopSaleProduct();

            // Card Statistic
            string totalPetsSale = saBll.GetTotalPetSales().ToString();
            string totalPetsSale_thisMonth = sBll.GetTotalPetSalesInMonth(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString()).ToString();
            this.cardStatisPetsSales.Cst1BigNumber = totalPetsSale;
            this.cardStatisPetsSales.Cst1SmallNumber = totalPetsSale_thisMonth;

            string totalProductSale = spBll.GetTotalProductSales().ToString();
            string totalProductSale_thisMonth = sBll.GetTotalProductSalesInMonth(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString()).ToString();
            this.cardStatisProductSales.Cst1BigNumber = totalProductSale;
            this.cardStatisProductSales.Cst1SmallNumber = totalProductSale_thisMonth;

            string totalCustomer = cusBll.GetTotalCustomer().ToString();
            string totalCustomer_thisMonth = cusBll.GetTotalCustomerInMonth(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString()).ToString();
            this.cardStatisCustomers.Cst1BigNumber = totalCustomer;
            this.cardStatisCustomers.Cst1SmallNumber = totalCustomer_thisMonth;

            string totalIncome = sBll.GetTotalIncome().ToString(sFormat) + " ₫";
            string totalIncome_thisMonth = sBll.GetTotalIncomeInMonth(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString()).ToString(sFormat) + " ₫";
            this.cardStatisIncome.Cst1BigNumber = totalIncome;
            this.cardStatisIncome.Cst1SmallNumber = totalIncome_thisMonth;

            // Card ID
            string totalIncome_latsMonth = sBll.GetTotalIncomeInMonth(DateTime.Now.Year.ToString(), DateTime.Now.AddMonths(-1).Month.ToString()).ToString();
            string totalIncome_thisMonth2 = sBll.GetTotalIncomeInMonth(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString()).ToString();
            this.cardIDIncome.Cst2LMNumber = totalIncome_latsMonth;
            this.cardIDIncome.Cst2TMNumber = totalIncome_thisMonth2;

            string totalPetsSale_lastMonth = sBll.GetTotalPetSalesInMonth(DateTime.Now.Year.ToString(), DateTime.Now.AddMonths(-1).Month.ToString()).ToString();
            string totalPetsSale_thisMonth2 = sBll.GetTotalPetSalesInMonth(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString()).ToString();
            this.cardIDPetSale.Cst2LMNumber = totalPetsSale_lastMonth;
            this.cardIDPetSale.Cst2TMNumber = totalPetsSale_thisMonth;

            string totalMerchandiseSale_lastMonth = sBll.GetTotalProductSalesInMonth(DateTime.Now.Year.ToString(), DateTime.Now.AddMonths(-1).Month.ToString()).ToString();
            string totalMerchandiseSale_thisMonth = sBll.GetTotalProductSalesInMonth(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString()).ToString();
            this.cardIDMerchandiseSale.Cst2LMNumber = totalMerchandiseSale_lastMonth;
            this.cardIDMerchandiseSale.Cst2TMNumber = totalMerchandiseSale_thisMonth;

            string totalNewCustomer_lastMonth = cusBll.GetTotalCustomerInMonth(DateTime.Now.Year.ToString(), DateTime.Now.AddMonths(-1).Month.ToString()).ToString();
            string totalNewCustomer_thisMonth = cusBll.GetTotalCustomerInMonth(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString()).ToString();
            this.cardIDNewCustomer.Cst2LMNumber = totalNewCustomer_lastMonth;
            this.cardIDNewCustomer.Cst2TMNumber = totalNewCustomer_thisMonth;
        }
    }
}