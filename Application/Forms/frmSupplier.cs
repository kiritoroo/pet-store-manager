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
    public partial class frmSupplier : DevExpress.XtraEditors.XtraForm
    {
        bllSupplier bllSup;
        CultureInfo cul = CultureInfo.CurrentCulture;
        string groupSep;
        string sFormat;

        public frmSupplier()
        {
            InitializeComponent();
            groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
            sFormat = string.Format("#{0}###", groupSep);

            bllSup = new bllSupplier();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            bllSup.Load();
            supplierBindingSource.DataSource = bllSup.GetLocal();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            supplierBindingSource.AddNew();
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bllSup.SaveLocal();
            supplierBindingSource.ResetBindings(true);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                supplierBindingSource.RemoveCurrent();
                supplierBindingSource.ResetBindings(true);
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bllSup.CancelChanged();
            supplierBindingSource.ResetBindings(false);
        }

        private void supplierBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Supplier currentSup = (Supplier)supplierBindingSource.Current;

            bindingSource1.DataSource = bllSup.GetOrderPetDetailEachSupplier(currentSup);
            bindingSource1.DataSource = bllSup.GetOrderProductDetailEachSupplier(currentSup);

            TotalPet.Text = bllSup.GetTotalOrderPetEachSupplier(currentSup).ToString();
            totalProduct.Text = bllSup.GetTotalOrderProductEachSupplier(currentSup).ToString();
            TotalPetCost.Text = bllSup.GetTotalPetCostEachSupplier(currentSup).ToString(sFormat) + " ₫";
            totalProductCost.Text = bllSup.GetTotalProductCostEachSupplier(currentSup).ToString(sFormat) + " ₫";
        }
    }
}