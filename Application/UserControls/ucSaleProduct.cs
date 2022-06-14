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
using Entities.Models;
using Application.Services;
using System.Globalization;
using Business.Manager;
using Application.Properties;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace Application.UserControls
{
    public partial class ucSaleProduct : DevExpress.XtraEditors.XtraUserControl
    {

        CultureInfo cul = CultureInfo.CurrentCulture;
        string groupSep;
        string sFormat;
        Product product;

        public ucSaleProduct()
        {
            InitializeComponent();
            groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
            sFormat = string.Format("#{0}###", groupSep);
            this.textEdit1.Text = "1";
            this.DelegateEvent();
        }

        #region Properties
        [Category("Custom Properties")]
        private frmSale _formParent;

        public frmSale FormParent
        {
            get { return _formParent; }
            set { _formParent = value; }
        }

        [Category("Custom Properties")]
        private frmMain _formMain;

        public frmMain FormMain
        {
            get { return _formMain; }
            set { _formMain = value; }
        }

        [Category("Custom Properties")]
        private frmShoppingCart _formMom;

        public frmShoppingCart FormMom
        {
            get { return _formMom; }
            set { _formMom = value; }
        }

        [Category("Custom Properties")]
        private SalesProduct _salesProduct;

        public SalesProduct SalesProduct
        {
            get { return _salesProduct; }
            set
            {
                _salesProduct = value;
                bllProduct bll = new bllProduct();
                this.product = bll.Find(this._salesProduct.ProductID);

                this.pictureBox1.Image = ImageService.BinaryToImage(this.product.Photo);
                this.label1.Text = this.product.Label;
                this.label2.Text = this.product.UnitPrice.ToString(sFormat) + " ₫";
                this.textEdit1.Text = this._salesProduct.Quantity.ToString();
                this.textEdit1.Enabled = false;
                this.label3.Text = (this._salesProduct.UnitPrice * this._salesProduct.Quantity).ToString(sFormat) + " ₫";
            }
        }
        #endregion

        #region Events
        private void DelegateEvent()
        {

        }
        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Cập nhật giỏ hàng");
            SplashScreenManager.Default.SetWaitFormDescription("Xóa thành công");

            this._formMom.txListSaleProduct.Remove(this._salesProduct);
            this._formMom.UpdateCart();
            int cartTotal = (this._formMom.txListSaleProduct.Count + this._formMom.txListSaleProduct.Count);
            if (cartTotal > 0)
            {
                this._formMain.badge1.Properties.Text = cartTotal.ToString();
                this._formMain.badge1.Visible = true;
            }
            else
            {
                this._formMain.badge1.Properties.Text = "0";
                this._formMain.badge1.Visible = false;
            }

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(10);
            }
            SplashScreenManager.CloseForm();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

            /*            int temp;
                        bool successfullyParsed = int.TryParse(textEdit1.Text, out temp);
                        if (successfullyParsed)
                        {
                            this._salesProduct.Quantity = int.Parse(this.textEdit1.Text);
                            var querry = from saleProduct in this._formMom.txListSaleProduct
                                         where saleProduct.ProductID == this._salesProduct.ProductID
                                         select saleProduct;
                            querry.FirstOrDefault().Quantity = int.Parse(this.textEdit1.Text);
                        }
                        else
                        {
                            this._salesProduct.Quantity = 1;
                            var querry = from saleProduct in this._formMom.txListSaleProduct
                                         where saleProduct.ProductID == this._salesProduct.ProductID
                                         select saleProduct;
                            querry.FirstOrDefault().Quantity = 1;
                        }
                        this._formMom.UpdateCart();*/

        }
        #endregion

        private void textEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }
    }
}
