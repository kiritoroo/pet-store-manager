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
        #endregion
    }
}
