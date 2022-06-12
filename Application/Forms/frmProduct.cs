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
using DevExpress.XtraNavBar;
using System.Globalization;

namespace Application.Forms
{
    public partial class frmProduct : DevExpress.XtraEditors.XtraForm
    {
        bllProductCategory bllProductCategory;
        bllProduct bllProduct;
        public frmProduct()
        {
            InitializeComponent();
            this.bllProductCategory = new bllProductCategory();
            this.bllProduct = new bllProduct();
            this.toggle2.Checked = true;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            bllProductCategory.Load();
            bllProduct.Load();
            productCategoryBindingSource.DataSource = bllProductCategory.GetLocal();
            productBindingSource.DataSource = bllProduct.GetLocal();
            CultureInfo cul = CultureInfo.CurrentCulture;
            string groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
            string sFormat = string.Format("#{0}###" + " ₫", groupSep);
            this.colUnitPrice.DisplayFormat.FormatString = sFormat;

            List<ProductCategory> pcList = bllProductCategory.GetAll().ToList();
            try
            {
                navBarControl1.BeginUpdate();
                navBarGroup1.Expanded = true;
                foreach (var pc in pcList)
                {
                    NavBarItem item = new NavBarItem(pc.Label.ToString());
                    item.SmallImage = ImageService.BinaryToImage(pc.Icon);
                    item.ImageOptions.SmallImageSize = new Size(16, 16);
                    navBarControl1.Items.Add(item);
                    navBarGroup1.ItemLinks.Add(item);
                }

                if (navBarGroup1.ItemLinks.Count > 0)
                {
                    navBarControl1.Groups.Add(navBarGroup1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                navBarControl1.EndUpdate();
            }
        }

        private void navBarControl1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (e.Link.Caption == "Tất cả sản phẩm")
            {
                productBindingSource.DataSource = bllProduct.GetLocal();
                return;
            }
            productBindingSource.DataSource = bllProductCategory.GetAllProductEachType(e.Link.Caption).ToList();
            productBindingSource.ResetBindings(true);
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.toggle1.Checked)
            {
                productCategoryBindingSource.AddNew();
            }
            if (this.toggle2.Checked)
            {
                productBindingSource.AddNew();
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.toggle1.Checked)
            {
                this.bllProductCategory.SaveLocal();
                productCategoryBindingSource.ResetBindings(true);
            }
            if (this.toggle2.Checked)
            {
                this.bllProduct.SaveLocal();
                productBindingSource.ResetBindings(true);
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.toggle1.Checked)
                {
                    productCategoryBindingSource.RemoveCurrent();
                    productCategoryBindingSource.ResetBindings(true);
                }
                if (this.toggle2.Checked)
                {
                    productBindingSource.RemoveCurrent();
                    productBindingSource.ResetBindings(true);
                }
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.toggle1.Checked)
            {
                this.bllProductCategory.CancelChanged();
                productCategoryBindingSource.ResetBindings(false);
            }
            if (this.toggle2.Checked)
            {
                this.bllProduct.CancelChanged();
                productBindingSource.ResetBindings(false);
            }
        }

        private void btnAddImageProductCate_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Open Image";
                open.Filter = "Image (*.png;*.jpg)|*.png;*.jpg";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filepath = open.FileName;
                    byte[] bImg = ImageService.ImageToBinary(Image.FromFile(filepath));
                    Console.WriteLine(bImg);
                    if (this.IDTextEdit.Text != "")
                    {
                        ProductCategory current = (ProductCategory)productCategoryBindingSource.Current;
                        current.Icon = bImg;
                        productCategoryBindingSource.ResetBindings(true);
                    }
                }
            }
        }

        private void btnAddImageProduct_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Open Image";
                open.Filter = "Image (*.png;*.jpg)|*.png;*.jpg";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filepath = open.FileName;
                    byte[] bImg = ImageService.ImageToBinary(Image.FromFile(filepath));
                    Console.WriteLine(bImg);
                    if (this.textEdit1.Text != "")
                    {
                        Product current = (Product)productBindingSource.Current;
                        current.Photo = bImg;   
                        productBindingSource.ResetBindings(true);
                    }
                }
            }
        }

        private void toggle1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.toggle1.Checked == true)
            {
                this.toggle2.Checked = false;
            }
            else
            {
                this.toggle2.Checked = true;
            }
        }

        private void toggle2_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.toggle2.Checked == true)
            {
                this.toggle1.Checked = false;
            }
            else
            {
                this.toggle1.Checked = true;
            }
        }
    }
}