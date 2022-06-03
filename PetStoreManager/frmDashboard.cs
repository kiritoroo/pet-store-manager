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
using System.Data.Entity;
using PetStoreManager.Components;
using PetStoreManager.Services;

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

        #region Event
        private void DelegateEvent()
        {
            this.Load += new EventHandler(this.Event_Load);
            this.Load += new EventHandler(this.Event_maincButtonDashboard_Click);

            maincButtonDashboard.Click += Event_maincButtonDashboard_Click;
            maincButtonDashboard.ctArrowEffect.Click += Event_maincButtonDashboard_Click;
            maincButtonDashboard.ctIcon.Click += Event_maincButtonDashboard_Click;
            maincButtonDashboard.ctLabel.Click += Event_maincButtonDashboard_Click;
            maincButtonDashboard.ctLineEffect.Click += Event_maincButtonDashboard_Click;
            maincButtonDashboard.ctPanelEffect.Click += Event_maincButtonDashboard_Click;

            maincButtonPeoples.Click += Event_maincButtonPeoples_Click;
            maincButtonPeoples.ctArrowEffect.Click += Event_maincButtonPeoples_Click;
            maincButtonPeoples.ctIcon.Click += Event_maincButtonPeoples_Click;
            maincButtonPeoples.ctLabel.Click += Event_maincButtonPeoples_Click;
            maincButtonPeoples.ctLineEffect.Click += Event_maincButtonPeoples_Click;
            maincButtonPeoples.ctPanelEffect.Click += Event_maincButtonPeoples_Click;
        }
        private void Event_Load(object sender, EventArgs e)
        {
            this.Load -= Event_Load;

            Console.WriteLine("Data Initializing...");
            Console.WriteLine("Check Variable Here!");

            List< animal> l = new List<animal>();
            animalManager t = new animalManager();
            l = t.GetAll().ToList();

            this.maincButtonDashboard.FormParent = this;
            this.maincButtonPeoples.FormParent = this;
            this.maincButtonPets.FormParent = this;
            this.maincButtonSales.FormParent = this;
            this.maincButtonOrders.FormParent = this;
        }

        private void Event_maincButtonDashboard_Click(object sender, EventArgs e)
        {
            // Load Page Dashboard
            Console.WriteLine("Current Page: Dashboard");
            this.mainControlPage.SetPage(mainPageDashboard);
            
            saleAnimalManager saBll = new saleAnimalManager();
            string totalPetsSale = saBll.GetTotalAnimalSales().ToString();
            string totalPetsSale_thisMonth = saBll.GetTotalAnimalSalesInMonth(DateTime.Now.ToString("MM")).ToString();
            this.pDbcStatisPetsSales.Cst1BigNumber = totalPetsSale;
            this.pDbcStatisPetsSales.Cst1SmallNumber = totalPetsSale_thisMonth;

            saleMerchandiseManager smBll = new saleMerchandiseManager();
            string totalMerchandiseSale = smBll.GetTotalMerchandiseSales().ToString();
            string totalMerchandiseSale_thisMonth = smBll.GetTotalMerchandiseSalesInMonth(DateTime.Now.ToString("MM")).ToString();
            this.pDbcStatisMerchandiseSales.Cst1BigNumber = totalMerchandiseSale;
            this.pDbcStatisMerchandiseSales.Cst1SmallNumber = totalMerchandiseSale_thisMonth;

            customerManager cBll = new customerManager();
            string totalCustomer = cBll.GetTotalCustomer().ToString();
            saleManager sBll = new saleManager();
            string totalBill = sBll.GetTotalBill().ToString();
            this.pDbcStatisCustomers.Cst1BigNumber = totalCustomer;
            this.pDbcStatisCustomers.Cst1SmallNumber = totalBill;

            string totalIncome = sBll.GetTotalIncome().ToString();
            string totalIncome_thisMonthh = sBll.GetTotalIncomeInMonth(DateTime.Now.ToString("MM")).ToString();
            this.pDbcStatisIncome.Cst1BigNumber = totalIncome;
            this.pDbcStatisIncome.Cst1SmallNumber = totalIncome_thisMonthh;
        }
        private void Event_maincButtonPeoples_Click(object sender, EventArgs e)
        {
            // Load Page People
            Console.WriteLine("Current Page: People Manager");
            this.mainControlPage.SetPage(mainPagePeople);
        }
        #endregion
    }
}
