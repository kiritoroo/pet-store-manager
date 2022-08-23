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
using Application.UserControls;
using Business.Manager;
using Entities.Models;
using DevExpress.XtraSplashScreen;
using System.Threading;
using QRCoder;
using System.Globalization;

namespace Application.Forms
{
    public partial class frmShoppingCart : DevExpress.XtraEditors.XtraForm
    {
        CultureInfo cul = CultureInfo.CurrentCulture;
        string groupSep;
        string sFormat;

        bllPetCategory bllPetCate;
        bllPet bllPet;
        bllProductCategory bllProductCate;
        bllProduct bllProduct;

        QRCodeGenerator qr = new QRCodeGenerator();

        // Entity Transaction
        public Employee txEmployee = new Employee();
        public Customer txCustomer = new Customer();
        public Voucher txVoucher = new Voucher();
        public Sale txSale = new Sale();
        
        public List<SalesPet> txListSalePet = new List<SalesPet>();
        public List<SalesProduct> txListSaleProduct = new List<SalesProduct>();
        // End
        decimal totalMoneyPet = 0;
        decimal totalMoneyProduct = 0;
        decimal discount = 0;
        decimal tax = 0;
        decimal totalGrand = 0;

        private static frmShoppingCart _instance;
        public static frmShoppingCart Instance
        {
            get
            {   
                if (_instance == null)
                    _instance = new frmShoppingCart();
                return _instance;
            }
        }

        public frmShoppingCart()
        {
            InitializeComponent();
            groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
            sFormat = string.Format("#{0}###" + " ₫", groupSep);

            this.bllPetCate = new bllPetCategory();
            this.bllPet = new bllPet();
            this.bllProductCate = new bllProductCategory();
            this.bllProduct = new bllProduct();
        }

        // TRANSACTION CHECKOUT
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (this.txEmployee == null || this.txCustomer == null || this.cbcCustomer.Text == "" || this.cbcEmployee.Text == "" || this.cbcEmployee.SelectedIndex == -1 || this.cbcCustomer.SelectedIndex == -1)
            {
                XtraMessageBox.Show("Vui lòng cung cấp đầy đủ thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Task Uncomplete LAST LAST LAST LAST LAST
            bllSales bll = new bllSales();
            // đưa danh sách thú cưng đã chọn vào Sale

            this.txSale = new Sale()
            {
                CustomerID = this.txCustomer.ID,
                EmployeeID = this.txEmployee.ID,
                SaleDate = DateTime.Now,
                SalesPets = this.txListSalePet,
                SalesProducts = this.txListSaleProduct,
                SaleTax = (float)this.tax,
                VoucherCode = this.txVoucher.Code
            };

            (bool result, String message) rs = bll.CreateBill(txSale);
            if (rs.result == false)
            {
                string messageOut = "Không thể tạo đơn hàng - " + rs.message;
                XtraMessageBox.Show(messageOut, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                QRCodeData data = qr.CreateQrCode(this.cusContactName.Text + "\n" + this.empFullName.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                picQrCode.Image = code.GetGraphic(5);
                if (XtraMessageBox.Show("Tạo đơn hàng thành công!", "Complete Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    this.ResetCart();
            }

        }

        public void UpdateCart()
        {
            this.flowCart.Controls.Clear();
            foreach (SalesPet item in this.txListSalePet)
            {
                ucSalePet uc = new ucSalePet()
                {
                    FormMain = (frmMain)this.MdiParent,
                    FormMom = this,
                    SalesPet = item
                };
                uc.hyperlinkLabelControl1.Visible = true;
                uc.textEdit1.Enabled = false;
                this.flowCart.Controls.Add(uc);
            }

            foreach (SalesProduct item in this.txListSaleProduct)
            {
                ucSaleProduct uc = new ucSaleProduct()
                {
                    FormMain = (frmMain)this.MdiParent,
                    FormMom = this,
                    SalesProduct = item
                };
                uc.hyperlinkLabelControl1.Visible = true;
                uc.textEdit1.Enabled = true;
                this.flowCart.Controls.Add(uc);
            }

            this.UpdateBill();
        }

        public void UpdateBill()
        {
            int totalPet = txListSalePet.Count;
            int totalProdut = 0;
            foreach (SalesProduct item in txListSaleProduct)
            {
                totalProdut += item.Quantity;
            }
            this.billSubItem.Text = totalPet.ToString() + " Pet" + ", " + totalProdut.ToString() + " Product";

            this.totalMoneyPet = 0;
            this.totalMoneyProduct = 0;
            foreach (SalesPet item in txListSalePet)
            {
                totalMoneyPet += (decimal)item.Price;
            }
            foreach (SalesProduct item in txListSaleProduct)
            {
                totalMoneyProduct += item.Quantity * (decimal)item.UnitPrice;
            }
            this.billSubTotal.Text = (totalMoneyPet + totalMoneyProduct).ToString(sFormat);

            this.discount = 0;
            if (this.txVoucher != null)
            {
                discount = ((totalMoneyPet + totalMoneyProduct) * this.txVoucher.Percent) / 100;
                this.billDiscount.Text = discount.ToString(sFormat) + " (" + this.txVoucher.Percent.ToString() + "%" + ")";
            }
            else
            {
                discount = 0;
                this.billDiscount.Text = "No Discount";
            }

            this.tax = ((totalMoneyPet + totalMoneyProduct) * 2) / 100;
            this.billTax.Text = tax.ToString(sFormat);

            this.totalGrand = (totalMoneyPet + totalMoneyProduct) - discount + tax;
            this.billGrandTotal.Text = totalGrand.ToString(sFormat);
        }

        public void ResetCart()
        {
            this.txCustomer = new Customer();
            this.txEmployee = new Employee();
            this.txListSalePet = new List<SalesPet>();
            this.txListSaleProduct = new List<SalesProduct>();
            this.txSale = new Sale();
            this.txVoucher = new Voucher();
            this.flowCart.Controls.Clear();
            this.cbcCustomer.SelectedIndex = -1;
            this.cbcEmployee.SelectedIndex = -1;
            this.cbcVoucher.SelectedIndex = -1;

            frmMain frmParent = (frmMain)this.MdiParent;
            frmParent.badge1.Properties.Text = "0";
            frmParent.badge1.Visible = false;
            this.voucherTitle.Text = "*Không áp dụng khuyến mãi";
            this.billDiscount.Text = "No Discount";
            this.empFullName.Text = "Full Name: None";
            this.empPhone.Text = "Phone: None";
            this.cusContactName.Text = "Contact Name: None";
            this.cusPhone.Text = "Phone: None";
            this.cusAddress.Text = "Address: None";
            this.picQrCode.Image = null;
            this.UpdateBill();
        }
        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (this.tabPane1.SelectedPageIndex == 0)
            {

            }
            if (this.tabPane1.SelectedPageIndex == 1)
            {
                this.UpdateCart();
            }
        }

        private void frmShoppingCart_Load(object sender, EventArgs e)
        {
            frmMain frmParent = (frmMain)this.MdiParent;
            frmParent.badge1.Properties.Text = "0";
            frmParent.badge1.Visible = false;

            this.comboBox1.SelectedIndex = 0;

            bllEmployee bllEmp = new bllEmployee();
            List<Employee> empList = bllEmp.GetAll().ToList();
            foreach (Employee item in empList)
            {
                this.cbcEmployee.Properties.Items.Add(item.LastName + " " + item.FirstName);
            }

            bllCustomer bllCus = new bllCustomer();
            List<Customer> cusList = bllCus.GetAll().ToList();
            foreach (Customer item in cusList)
            {
                this.cbcCustomer.Properties.Items.Add(item.ContactName + ", " + item.Phone);
            }

            bllVoucher bllVoucher = new bllVoucher();
            List<Voucher> voucherList = bllVoucher.GetAll().Where(v => DateTime.Compare(v.EndDate, DateTime.Now) > 0).ToList();
            foreach (Voucher item in voucherList)
            {
                this.cbcVoucher.Properties.Items.Add(item.Code);
            }

            this.cbcCustomer.SelectedIndex = -1;
            this.cbcEmployee.SelectedIndex = -1;
            this.cbcVoucher.SelectedIndex = -1;
        }

        private void LoadPet()
        {
            if (this.IsActive)
            {
                SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
                SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");
            }

            this.flowItem.Controls.Clear();
            this.flowCategory.Controls.Clear();
            bindingSource1.DataSource = bllPetCate.GetTopSalePetCategory();

            // All
            ucPetCategory ucAll = new ucPetCategory()
            {
                FormParent = this,
                PetType = null,
                PetCount = bllPet.GetAll().Count()
            };
            this.flowCategory.Controls.Add(ucAll);
            // Category
            List<PetCategory> listPetCate = bllPetCate.GetAll().ToList();
            foreach (PetCategory item in listPetCate)
            {
                ucPetCategory uc = new ucPetCategory()
                {
                    FormParent = this,
                    PetType = item,
                    PetCount = bllPetCate.GetTotalPetEachType(item.Label)
                };
                this.flowCategory.Controls.Add(uc);
            }

            // Item
            List<Pet> listPet = bllPet.GetAll().ToList();
            foreach (Pet item in listPet)
            {
                ucPet uc = new ucPet()
                {
                    FormParent = this,
                    FormMain = (frmMain)this.MdiParent,
                    Pet = item
                };
                this.flowItem.Controls.Add(uc);
            }

            if (this.IsActive)
            {
                SplashScreenManager.CloseForm();
            }
        }
        private void LoadProduct()
        {
            if (this.IsActive)
            {
                SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
                SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");
            }

            this.flowItem.Controls.Clear();
            this.flowCategory.Controls.Clear();
            bindingSource1.DataSource = bllProductCate.GetTopSaleProduct();

            // All
            ucProductCategory ucAll = new ucProductCategory()
            {
                FormParent = this,
                ProductType = null,
                ProductCount = bllProduct.GetAll().Count()
            };
            this.flowCategory.Controls.Add(ucAll);
            // Category
            List<ProductCategory> listProductCate = bllProductCate.GetAll().ToList();
            foreach (ProductCategory item in listProductCate)
            {
                ucProductCategory uc = new ucProductCategory()
                {
                    FormParent = this,
                    ProductType = item,
                    ProductCount = bllProductCate.GetAllProductEachType(item.Label).Count()
                };
                this.flowCategory.Controls.Add(uc);
            }

            // Item
            List<Product> listProduct = bllProduct.GetAll().ToList();
            foreach (Product item in listProduct)
            {
                ucProduct uc = new ucProduct()
                {
                    FormMain = (frmMain)this.MdiParent,
                    FormParent = this,
                    Product = item
                };
                this.flowItem.Controls.Add(uc);
            }

            if (this.IsActive)
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                this.LoadPet();
            }
            if (this.comboBox1.SelectedIndex == 1)
            {
                this.LoadProduct();
            }
        }

        // CART
        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
            this.tabPane1.SelectedPage = tabNavigationPage1;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.tabPane1.SelectedPage = tabNavigationPage2;
        }

        // Voucher
        private void btnApplyVoucher_Click(object sender, EventArgs e)
        {
            bllVoucher bll = new bllVoucher();
            if (this.cbcVoucher.SelectedText.Length > 0)
            {
                Voucher voucher = bll.Find(cbcVoucher.SelectedText);
                int percent = voucher.Percent;
                SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Add Voucher");
                SplashScreenManager.Default.SetWaitFormDescription("Giá trị khuyến mãi: " + percent.ToString() + " %");
                this.voucherTitle.Text = "* Áp dụng khuyến mãi, giá trị: " + percent.ToString() + " %";
                // Logic Voucher here
                this.txVoucher = voucher;
                this.discount = ((totalMoneyPet + totalMoneyProduct) * this.txVoucher.Percent) / 100;
                this.billDiscount.Text = this.discount.ToString(sFormat) + " (" + this.txVoucher.Percent.ToString() + "%" + ")";
                this.totalGrand = (totalMoneyPet + totalMoneyProduct) - discount + tax;
                this.billGrandTotal.Text = totalGrand.ToString(sFormat);

                for (int i = 0; i < 50; i++)
                {
                    Thread.Sleep(10);
                }
                SplashScreenManager.CloseForm();
            }
            else
            {
                this.discount = 0;
                this.txVoucher = null;
                this.voucherTitle.Text = "*Không áp dụng khuyến mãi";
                this.billDiscount.Text = "No Discount";
            }
        }

        private void linkCancelVoucher_Click(object sender, EventArgs e)
        {
            this.txVoucher = null;
            this.voucherTitle.Text = "*Không áp dụng khuyến mãi";
            this.cbcVoucher.ResetText();
            this.cbcVoucher.SelectedIndex = -1;
        }

        // Employee
        private void btnApplyEmployee_Click(object sender, EventArgs e)
        {
            bllEmployee bll = new bllEmployee();
            if (this.cbcEmployee.SelectedText.Length > 0)
            {
                Employee empChoose = bll.FindEmployeeByFullName(cbcEmployee.SelectedText);
                this.empFullName.Text = "Full Name: " + empChoose.LastName + " " + empChoose.FirstName;
                this.empPhone.Text = "Phone: " + empChoose.Phone;
                SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Apply Employee");
                SplashScreenManager.Default.SetWaitFormDescription("Nhân viên: " + empChoose.LastName + " " + empChoose.FirstName);
                // Logic Employee here
                this.txEmployee = empChoose;

                for (int i = 0; i < 50; i++)
                {
                    Thread.Sleep(10);
                }
                SplashScreenManager.CloseForm();
            }
            else
            {
                this.txEmployee = null;
                XtraMessageBox.Show("Vui lòng chọn nhân viên!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.empFullName.Text = "Full Name: None";
                this.empPhone.Text = "Phone: None";
            }
        }

        private void linkCancelEmployee_Click(object sender, EventArgs e)
        {
            this.txEmployee = null;
            this.empFullName.Text = "Full Name: None";
            this.empPhone.Text = "Phone: None";
            this.cbcEmployee.ResetText();
            this.cbcEmployee.SelectedIndex = -1;
        }

        // Customer
        private void btnApplyCustomer_Click(object sender, EventArgs e)
        {
            bllCustomer bll = new bllCustomer();
            if (this.cbcCustomer.SelectedText.Length > 0)
            {
                Customer cusChoose = bll.FindCustomerByInfo(cbcCustomer.SelectedText);
                this.cusContactName.Text = "Contact Name: " + cusChoose.ContactName;
                this.cusPhone.Text = "Phone: " + cusChoose.Phone;
                this.cusAddress.Text = "Address: " + cusChoose.Address;
                SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Apply Customer");
                SplashScreenManager.Default.SetWaitFormDescription("Khách hàng: " + cusChoose.ContactName);
                // Logic Customer here
                this.txCustomer = cusChoose;

                for (int i = 0; i < 50; i++)
                {
                    Thread.Sleep(10);
                }
                SplashScreenManager.CloseForm();
            }
            else
            {
                this.txCustomer = null;
                XtraMessageBox.Show("Vui lòng chọn hoặc thêm mới khách hàng!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cusContactName.Text = "Contact Name: None";
                this.cusPhone.Text = "Phone: None";
                this.cusAddress.Text = "Address: None";
            }
        }

        private void linkCancelCustomer_Click(object sender, EventArgs e)
        {
            this.txCustomer = null;
            this.cusContactName.Text = "Contact Name: None";
            this.cusPhone.Text = "Phone: None";
            this.cusAddress.Text = "Address: None";
            this.cbcCustomer.ResetText();
            this.cbcCustomer.SelectedIndex = -1;
        }

        private void linkNewCustomer_Click(object sender, EventArgs e)
        {
            frmNewCustomer frm = new frmNewCustomer();
            frm.frmParent = this;
            frm.Show();
        }

        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            this.ResetCart();
        }
    }
}