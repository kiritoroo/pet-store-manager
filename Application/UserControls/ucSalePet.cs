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
    public partial class ucSalePet : DevExpress.XtraEditors.XtraUserControl
    {
        CultureInfo cul = CultureInfo.CurrentCulture;
        string groupSep;
        string sFormat;
        Pet pet;

        public ucSalePet()
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
        private SalesPet _salePet;

        public SalesPet SalesPet
        {
            get { return _salePet; }
            set { _salePet = value;
                bllPet bll = new bllPet();
                this.pet = bll.Find(this._salePet.PetID);

                this.pictureBox1.Image = ImageService.BinaryToImage(this.pet.Photo);
                this.label1.Text = this.pet.Label;
                this.label2.Text = this.pet.Price.ToString(sFormat) + " ₫";
                this.textEdit1.Text = "1";
                this.textEdit1.Enabled = false;
                this.label3.Text = this._salePet.Price.ToString(sFormat) + " ₫";
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

            this._formMom.txListSalePet.Remove(this._salePet);
            this._formMom.UpdateCart();
            int cartTotal = (this._formMom.txListSalePet.Count + this._formMom.txListSaleProduct.Count);
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
        #endregion
    }
}
