using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
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
using Application.Forms;

namespace Application
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        void Form1_Load(object sender, EventArgs e)
        {
            this.documentManager1.MdiParent = this;
            this.documentManager1.View = new TabbedView();
            frmDashboard frm = new frmDashboard();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPet frm = new frmPet();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnSupplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSupplier frm = new frmSupplier();
            frm.MdiParent = this;
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btnDashboard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDashboard frm = new frmDashboard();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmShoppingCart frm = new frmShoppingCart();
            frm.MdiParent = this;
            frm.tabPane1.SelectedPageIndex = 1;
            frm.Show();
        }

        private void btnShopping_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmShoppingCart frm = new frmShoppingCart();
            frm.MdiParent = this;
            frm.tabPane1.SelectedPageIndex = 0;
            frm.Show();
        }

        private void btnSale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSale frm = new frmSale();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}