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

namespace PetStoreManager
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.DelegateEvent();
            this.DoubleBuffered = true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void DelegateEvent()
        {
            this.Load += new EventHandler(this.Event_Load);
        }

        private void Event_Load(object sender, EventArgs e)
        {
            this.Load -= Event_Load;

            saleAnimalManager saBll = new saleAnimalManager();
            string totalPetsSale = saBll.GetTotalAnimalSales().ToString();
            string totalPetsSale_thisMonth = saBll.GetTotalAnimalSalesInMonth(DateTime.Now.ToString("MM")).ToString();
            this.cardStatisPetsSales.Cst1BigNumber = totalPetsSale;
            this.cardStatisPetsSales.Cst1SmallNumber = totalPetsSale_thisMonth;

            saleMerchandiseManager smBll = new saleMerchandiseManager();
            string totalMerchandiseSale = smBll.GetTotalMerchandiseSales().ToString();
            string totalMerchandiseSale_thisMonth = smBll.GetTotalMerchandiseSalesInMonth(DateTime.Now.ToString("MM")).ToString();
            this.cardStatisMerchandiseSales.Cst1BigNumber = totalMerchandiseSale;
            this.cardStatisMerchandiseSales.Cst1SmallNumber = totalMerchandiseSale_thisMonth;

            customerManager cBll = new customerManager();
            string totalCustomer = cBll.GetTotalCustomer().ToString();
            saleManager sBll = new saleManager();
            string totalBill = sBll.GetTotalBill().ToString();
            this.cardStatisCustomers.Cst1BigNumber = totalCustomer;
            this.cardStatisCustomers.Cst1SmallNumber = totalBill;

            string totalIncome = sBll.GetTotalIncome().ToString();
            string totalIncome_thisMonthh = sBll.GetTotalIncomeInMonth(DateTime.Now.ToString("MM")).ToString();
            this.cardStatisIncome.Cst1BigNumber = totalIncome;
            this.cardStatisIncome.Cst1SmallNumber = totalIncome_thisMonthh;
        }
    }
}
