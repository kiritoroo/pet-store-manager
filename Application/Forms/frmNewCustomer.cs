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

namespace Application.Forms
{
    public partial class frmNewCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmShoppingCart frmParent;
        public frmNewCustomer()
        {
            InitializeComponent();
            this.AddDateDateEdit.DateTime = DateTime.Now;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.ContactNameTextEdit.Text.Length < 1)
            {
                XtraMessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Customer newCus = new Customer()
            {
                ContactName = this.ContactNameTextEdit.Text,
                AddDate = DateTime.Now,
                Address = this.AddressTextEdit.Text,
                City = this.CityTextEdit.Text,
                Country = this.CountryTextEdit.Text,
                Phone = this.PhoneTextEdit.Text,
            };
            bllCustomer bll = new bllCustomer();
            bll.Save(newCus);
            frmParent.txCustomer = newCus;

            this.frmParent.cbcCustomer.Properties.Items.Clear();
            List<Customer> cusList = bll.GetAll().ToList();
            foreach (Customer item in cusList)
            {
                this.frmParent.cbcCustomer.Properties.Items.Add(item.ContactName + ", " + item.Phone);
            }
            this.frmParent.cbcCustomer.SelectedText = newCus.ContactName + ", " + newCus.Phone;
            this.frmParent.cbcCustomer.SelectedIndex = cusList.Count - 1;
            if (XtraMessageBox.Show("Thêm thành công!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}