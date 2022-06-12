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
using Application.Services;

namespace Application.Forms
{
    public partial class frmEmployee : DevExpress.XtraEditors.XtraForm
    {
        bllEmployee bllEmp;
        public frmEmployee()
        {
            InitializeComponent();
            this.bllEmp = new bllEmployee();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            bllEmp.Load();
            employeeBindingSource.DataSource = bllEmp.GetLocal();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employeeBindingSource.AddNew();

            HireDateDateEdit.DateTime = DateTime.Now;
            BirthDateDateEdit.DateTime = DateTime.Now;
            Employee current = (Employee)employeeBindingSource.Current;
            current.HireDate = HireDateDateEdit.DateTime;
            current.BirthDate = BirthDateDateEdit.DateTime;
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bllEmp.SaveLocal();
            employeeBindingSource.ResetBindings(true);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                employeeBindingSource.RemoveCurrent();
                employeeBindingSource.ResetBindings(true);
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bllEmp.CancelChanged();
            employeeBindingSource.ResetBindings(false);
        }

        private void btnImageLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Open Image";
                open.Filter = "Image (*.png;*.jpg)|*.png;*.jpg";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filepath = open.FileName;
                    byte[] bImg = ImageService.ImageToBinary(Image.FromFile(filepath));
                    if (this.IDTextEdit.Text != "")
                    {
                        Employee current = (Employee)employeeBindingSource.Current;
                        current.Photo = bImg;
                        employeeBindingSource.ResetBindings(true);
                    }
                }
            }
        }

        private void employeeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Employee currentEmp = (Employee)employeeBindingSource.Current;

            bindingSource1.DataSource = bllEmp.GetSaleDetailEachEmployee(currentEmp).Select(q => new
            { 
                ID = q.ID,
                CustomerID = q.CustomerID,
                EmployeeID = q.EmployeeID,
                SaleDate = q.SaleDate,
                SaleTax = q.SaleTax,
                Voucher = q.VoucherCode,
                Status = q.Status
            });
            bindingSource2.DataSource = bllEmp.GetOrderDetailEachEmployee(currentEmp).Select(q => new
            { 
                ID = q.ID,
                SupplierID = q.SupplierID,
                EmployeeID = q.EmployeeID,
                OrderDate = q.OrderDate,
                ReceiveDate = q.ReceiveDate,
                ShippingCost = q.ShippingCost,
                Status = q.Status
            });

            this.totalSale.Text = bllEmp.GetTotalSaleEachEmployee(currentEmp).ToString();
            this.totalOrder.Text = bllEmp.GetTotalOrderEachEmployee(currentEmp).ToString();
        }
    }
}