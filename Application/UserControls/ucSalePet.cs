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
        #endregion
    }
}
