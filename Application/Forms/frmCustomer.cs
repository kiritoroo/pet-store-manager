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
using System.Globalization;

namespace Application.Forms
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        CultureInfo cul = CultureInfo.CurrentCulture;
        string groupSep;
        string sFormat;
        
        bllCustomer bllCus;

        public frmCustomer()
        {
            InitializeComponent();
            groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
            sFormat = string.Format("#{0}###", groupSep);

            this.bllCus = new bllCustomer();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            bllCus.Load();
            customerBindingSource.DataSource = bllCus.GetLocal();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customerBindingSource.AddNew();

            AddDateDateEdit.DateTime = DateTime.Now;
            Customer current = (Customer)customerBindingSource.Current;
            current.AddDate = AddDateDateEdit.DateTime;
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bllCus.SaveLocal();
            customerBindingSource.ResetBindings(true);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                customerBindingSource.RemoveCurrent();
                customerBindingSource.ResetBindings(true);
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bllCus.CancelChanged();
            customerBindingSource.ResetBindings(false);
        }

        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Customer currentCus = (Customer)customerBindingSource.Current;

            bindingSource1.DataSource = bllCus.GetSalePetDetailEachCustomer(currentCus);
            bindingSource2.DataSource = bllCus.GetSaleProductDetailEachCustomer(currentCus);

            totalSalePet.Text = bllCus.GetTotalSalePetEachCustomer(currentCus).ToString();
            totalMoneyPet.Text = bllCus.GetTotalMoneyPetEachCustomer(currentCus).ToString(sFormat) + " ₫";
            totalSaleProduct.Text = bllCus.GetTotalSaleProductEachCustomer(currentCus).ToString();
            totalMoneyProduct.Text = bllCus.GetTotalMoneyProductEachCustomer(currentCus).ToString(sFormat) + " ₫";
        }
    }
}