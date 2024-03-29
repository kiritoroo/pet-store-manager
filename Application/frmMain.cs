﻿using DevExpress.XtraBars.Docking2010;
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
using DevExpress.XtraSplashScreen;

namespace Application
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            badge1.Visible = false;
        }
        void Form1_Load(object sender, EventArgs e)
        {
            badge1.Visible = false;
            badge1.Properties.Text = "0";
            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
            SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");

            this.documentManager1.MdiParent = this;
            this.documentManager1.View = new TabbedView();
            frmDashboard frm = new frmDashboard();
            frm.MdiParent = this;
            frm.Show();
            SplashScreenManager.CloseForm();
        }

        private void btnEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.MdiChildren != null)
            {
                foreach (var form in this.MdiChildren)
                {
                    if (form is frmEmployee)
                    {
                        form.Select();
                        return;
                    }
                }
            }

            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
            SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");

            frmEmployee frm = new frmEmployee();
            frm.MdiParent = this;
            frm.Show();
            SplashScreenManager.CloseForm();
        }

        private void btnPet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.MdiChildren != null)
            {
                foreach (var form in this.MdiChildren)
                {
                    if (form is frmPet)
                    {
                        form.Select();
                        return;
                    }
                }
            }

            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
            SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");

            frmPet frm = new frmPet();
            frm.MdiParent = this;
            frm.Show();

            SplashScreenManager.CloseForm();
        }

        private void btnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.MdiChildren != null)
            {
                foreach (var form in this.MdiChildren)
                {
                    if (form is frmProduct)
                    {
                        form.Select();
                        return;
                    }
                }
            }

            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
            SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");

            frmProduct frm = new frmProduct();
            frm.MdiParent = this;
            frm.Show();

            SplashScreenManager.CloseForm();
        }

        private void btnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.MdiChildren != null)
            {
                foreach (var form in this.MdiChildren)
                {
                    if (form is frmCustomer)
                    {
                        form.Select();
                        return;
                    }
                }
            }

            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
            SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");

            frmCustomer frm = new frmCustomer();
            frm.MdiParent = this;
            frm.Show();
            SplashScreenManager.CloseForm();
        }

        private void btnSupplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.MdiChildren != null)
            {
                foreach (var form in this.MdiChildren)
                {
                    if (form is frmSupplier)
                    {
                        form.Select();
                        return;
                    }
                }
            }

            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
            SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");

            frmSupplier frm = new frmSupplier();
            frm.MdiParent = this;
            frm.Show();
            SplashScreenManager.CloseForm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btnDashboard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.MdiChildren != null)
            {
                foreach (var form in this.MdiChildren)
                {
                    if (form is frmDashboard)
                    {
                        form.Select();
                        return;
                    }
                }
            }

            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
            SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");

            frmDashboard frm = new frmDashboard();
            frm.MdiParent = this;
            frm.Show();
            SplashScreenManager.CloseForm();
        }

        private void btnCart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.MdiChildren != null)
            {
                try
                {
                    foreach (frmShoppingCart form in this.MdiChildren)
                    {
                        if (form is frmShoppingCart)
                        {
                            form.Select();
                            form.tabPane1.SelectedPageIndex = 1;
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
            SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");

            frmShoppingCart frm = new frmShoppingCart();
            frm.MdiParent = this;
            frm.tabPane1.SelectedPageIndex = 1;
            frm.Show();
            SplashScreenManager.CloseForm();
        }

        private void btnShopping_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.MdiChildren != null)
            {
                try
                {
                    foreach (frmShoppingCart form in this.MdiChildren)
                    {
                        if (form is frmShoppingCart)
                        {
                            form.Select();
                            form.tabPane1.SelectedPageIndex = 0;
                            return;
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
            SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");

            frmShoppingCart frm = new frmShoppingCart();
            frm.MdiParent = this;
            frm.tabPane1.SelectedPageIndex = 0;
            frm.Show();
            SplashScreenManager.CloseForm();
        }

        private void btnSale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.MdiChildren != null)
            {
                foreach (var form in this.MdiChildren)
                {
                    if (form is frmSale)
                    {
                        form.Select();
                        return;
                    }
                }
            }

            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
            SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");

            frmSale frm = new frmSale();
            frm.MdiParent = this;
            frm.Show();
            SplashScreenManager.CloseForm();
        }
    }
}