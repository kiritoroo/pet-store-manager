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
using Business.Manager;
using Entities.Models;
using Application.Services;
using Application.Properties;
using DevExpress.XtraSplashScreen;

namespace Application.UserControls
{
    public partial class ucProductCategory : DevExpress.XtraEditors.XtraUserControl
    {
        public ucProductCategory()
        {
            InitializeComponent();
        }

        #region Properties
        [Category("Custom Properties")]
        private frmShoppingCart _formParent;

        public frmShoppingCart FormParent
        {
            get { return _formParent; }
            set { _formParent = value; }
        }

        [Category("Custom Properties")]
        private ProductCategory _productCategory;

        public ProductCategory ProductType
        {
            get { return _productCategory; }
            set
            {
                _productCategory = value;
                if (_productCategory != null)
                {
                    this.hyperlinkLabelControl1.Text = _productCategory.Label;
                    this.pictureBox1.Image = ImageService.BinaryToImage(this._productCategory.Icon);
                }
                else
                {
                    this.hyperlinkLabelControl1.Text = "Tất cả sản phẩm";
                    this.pictureBox1.Image = Resources.icon_product_all;
                }
            }
        }

        [Category("Custom Properties")]
        private int _productCount;

        public int ProductCount
        {
            get { return _productCount; }
            set { _productCount = value; this.label2.Text = value.ToString(); }
        }
        #endregion

        #region Events
        private void DelegateEvent()
        {

        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
            SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");

            bllProductCategory bllProductCate = new bllProductCategory();
            bllProduct bllProduct = new bllProduct();
            List<Product> productList;
            if (this._productCategory != null)
            {
                productList = bllProductCate.GetAllProductEachType(this._productCategory.Label).ToList();
            }
            else
            {
                productList = bllProduct.GetAll().ToList();
            }

            this._formParent.flowItem.Controls.Clear();
            foreach (Product item in productList)
            {
                ucProduct uc = new ucProduct()
                {
                    Product = item
                };
                this._formParent.flowItem.Controls.Add(uc);
            }

            SplashScreenManager.CloseForm();
        }
        #endregion
    }
}
