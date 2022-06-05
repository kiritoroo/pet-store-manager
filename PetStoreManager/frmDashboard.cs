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

namespace PetStoreManager
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.DelegateEvent();
        }

        private void DelegateEvent()
        {
            this.Load += new EventHandler(this.Event_Load);

            CultureInfo cul = CultureInfo.CurrentCulture;
            string groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
            string sFormat = string.Format("#{0}###", groupSep);
            statisPetDGV.CellFormatting += (obj, args) =>
            {
                if (args.RowIndex >= 0 &&
                    args.ColumnIndex == 4 &&
                    args.Value != null)
                {
                    args.Value = int.Parse(args.Value.ToString()).ToString(sFormat) + " ₫";
                }
            };
            statisMerchandiseDGV.CellFormatting += (obj, args) =>
            {
                if (args.RowIndex >= 0 &&
                    args.ColumnIndex == 2 &&
                    args.Value != null)
                {
                    args.Value = int.Parse(args.Value.ToString()).ToString(sFormat) + " ₫";
                }
            };
        }

        private void Event_Load(object sender, EventArgs e)
        {
            this.Load -= Event_Load;

            // Card Statistic
            saleManager sBll = new saleManager();
            saleAnimalManager saBll = new saleAnimalManager();
            string totalPetsSale = saBll.GetTotalAnimalSales().ToString();
            string totalPetsSale_thisMonth = sBll.GetTotalAnimalSalesInMonth(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString()).ToString();
            this.cardStatisPetsSales.Cst1BigNumber = totalPetsSale;
            this.cardStatisPetsSales.Cst1SmallNumber = totalPetsSale_thisMonth;

            saleMerchandiseManager smBll = new saleMerchandiseManager();
            string totalMerchandiseSale = smBll.GetTotalMerchandiseSales().ToString();
            string totalMerchandiseSale_thisMonth = sBll.GetTotalMerchandiseSalesInMonth(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString()).ToString();
            this.cardStatisMerchandiseSales.Cst1BigNumber = totalMerchandiseSale;
            this.cardStatisMerchandiseSales.Cst1SmallNumber = totalMerchandiseSale_thisMonth;

            customerManager cusBll = new customerManager();
            string totalCustomer = cusBll.GetTotalCustomer().ToString();
            string totalCustomer_thisMonth = cusBll.GetTotalCustomerInMonth(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString()).ToString();
            this.cardStatisCustomers.Cst1BigNumber = totalCustomer;
            this.cardStatisCustomers.Cst1SmallNumber = totalCustomer_thisMonth;

            CultureInfo cul = CultureInfo.CurrentCulture;
            string groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
            string sFormat = string.Format("#{0}###", groupSep);
            string totalIncome = sBll.GetTotalIncome().ToString(sFormat) + " ₫";
            string totalIncome_thisMonth = sBll.GetTotalIncomeInMonth(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString()).ToString(sFormat) + " ₫";
            this.cardStatisIncome.Cst1BigNumber = totalIncome;
            this.cardStatisIncome.Cst1SmallNumber = totalIncome_thisMonth;

            // Card ID
            string totalIncome_latsMonth = sBll.GetTotalIncomeInMonth(DateTime.Now.Year.ToString(), DateTime.Now.AddMonths(-1).Month.ToString()).ToString();
            string totalIncome_thisMonth2 = sBll.GetTotalIncomeInMonth(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString()).ToString();
            this.cardIDIncome.Cst2LMNumber = totalIncome_latsMonth;
            this.cardIDIncome.Cst2TMNumber = totalIncome_thisMonth2;

            string totalPetsSale_lastMonth = sBll.GetTotalAnimalSalesInMonth(DateTime.Now.Year.ToString(), DateTime.Now.AddMonths(-1).Month.ToString()).ToString();
            this.cardIDPetSale.Cst2LMNumber = totalPetsSale_lastMonth;
            this.cardIDPetSale.Cst2TMNumber = totalPetsSale_thisMonth;

            string totalMerchandiseSale_lastMonth = sBll.GetTotalMerchandiseSalesInMonth(DateTime.Now.Year.ToString(), DateTime.Now.AddMonths(-1).Month.ToString()).ToString();
            this.cardIDMerchandiseSale.Cst2LMNumber = totalMerchandiseSale_lastMonth;
            this.cardIDMerchandiseSale.Cst2TMNumber = totalMerchandiseSale_thisMonth;

            string totalNewCustomer_lastMonth = cusBll.GetTotalCustomerInMonth(DateTime.Now.Year.ToString(), DateTime.Now.AddMonths(-1).Month.ToString()).ToString();
            string totalNewCustomer_thisMonth = cusBll.GetTotalCustomerInMonth(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString()).ToString();
            this.cardIDNewCustomer.Cst2LMNumber = totalNewCustomer_lastMonth;
            this.cardIDNewCustomer.Cst2TMNumber = totalNewCustomer_thisMonth;

            // DGV
            merchandiseManager mBll = new merchandiseManager();
            var rsList1 = mBll.GetStatisticAllMerchandise();
            statisMerchandiseDGV.DataSource = rsList1;

            animalTypeManager atBll = new animalTypeManager();
            var rsList2 = atBll.GetStatisticAllAnimal();
            statisPetDGV.DataSource = rsList2;

            this.SettingDataGridView();
        }

        private void SettingDataGridView()
        {
            Font fontStype1 = new Font("Segoe UI", 12, FontStyle.Bold);
            Font fontStype2 = new Font("Segoe UI", 10);
            for (int i = 0; i < this.statisMerchandiseDGV.Columns.Count; i++)
            {
                this.statisMerchandiseDGV.Columns[i].HeaderCell.Style.Font = fontStype1;
            }
            this.statisMerchandiseDGV.DefaultCellStyle.Font = fontStype2;

            for (int i = 0; i < this.statisPetDGV.Columns.Count; i++)
            {
                this.statisPetDGV.Columns[i].HeaderCell.Style.Font = fontStype1;
            }
            this.statisPetDGV.DefaultCellStyle.Font = fontStype2;
        }
    }
}
