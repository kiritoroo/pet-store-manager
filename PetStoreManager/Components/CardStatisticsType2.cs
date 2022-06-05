using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetStoreManager.Properties;

namespace PetStoreManager.Components
{
    public partial class CardStatisticsType2 : UserControl
    {
        Color color_increase = Color.FromArgb(63, 136, 50);
        Color color_decrease = Color.FromArgb(215, 1, 1);
        Image icon_increase = Resources.icon_increase;
        Image icon_decrease = Resources.icon_descrease;

        public CardStatisticsType2()
        {
            InitializeComponent();
            this._cst2LMNumber = "0";
            this._cst2TMNumber = "0";
            this.cst2LMNumber.Text = "0";
            this.cst2TMNumber.Text = "0";
            this.cst2Ratio.Text = "0";
        }

        #region Properties
        [Category("Custom Properties")]
        private frmController _formParent;

        public frmController FormParent
        {
            get { return _formParent; }
            set { _formParent = value; }
        }

        [Category("Custom Properties")]
        private bool _moneyFormat;

        public bool MoneyFormat
        {
            get { return _moneyFormat; }
            set
            {
                _moneyFormat = value;
                if (value == false)
                    return;

                CultureInfo cul = CultureInfo.CurrentCulture;
                string groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
                string gFormat = string.Format("#{0}###", groupSep);
                this.cst2LMNumber.Text = decimal.Parse(_cst2LMNumber).ToString(gFormat) + " ₫";
                this.cst2TMNumber.Text = decimal.Parse(_cst2TMNumber).ToString(gFormat) + " ₫";
            }
        }

        [Category("Custom Properties")]
        private string _cst2Tittle;

        public string Cst2Tittle
        {
            get { return _cst2Tittle; }
            set { _cst2Tittle = value; this.cst2TitleLabel.Text = value; }
        }

        [Category("Custom Properties")]
        private string _cst2LMNumber;

        public string Cst2LMNumber
        {
            get { return _cst2LMNumber; }
            set
            {
                _cst2LMNumber = value;
                CultureInfo cul = CultureInfo.CurrentCulture;
                string groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
                string decimalSep = cul.NumberFormat.CurrencyDecimalSeparator;//decimalSep ='.'
                string sFormat = string.Format("#{0}##", decimalSep);
                string gFormat = string.Format("#{0}###", groupSep);
                if (_moneyFormat)
                {
                    this.cst2LMNumber.Text = decimal.Parse(this._cst2LMNumber).ToString(gFormat) + " ₫";
                }
                else
                {
                    this.cst2LMNumber.Text = value;
                }
                if (int.Parse(_cst2LMNumber) > int.Parse(_cst2LMNumber))
                {
                    this.cst2LMNumber.ForeColor = this.color_increase;
                    this.cst2TMNumber.ForeColor = this.color_decrease;
                    this.cst2Icon.Image = this.icon_decrease;
                }
                else
                {
                    this.cst2LMNumber.ForeColor = this.color_decrease;
                    this.cst2TMNumber.ForeColor = this.color_increase;
                    this.cst2Icon.Image = this.icon_increase;
                }
                float ratio = ((int.Parse(_cst2TMNumber) - int.Parse(_cst2LMNumber)) / float.Parse(_cst2LMNumber)) * 100;
                this.cst2Ratio.Text = ratio.ToString(sFormat) + " %";
                if (ratio > 0)
                {
                    this.cst2Ratio.ForeColor = this.color_increase;
                }
                else
                {
                    this.cst2Ratio.ForeColor = this.color_decrease;
                }
            }
        }

        [Category("Custom Properties")]
        private string _cst2TMNumber;

        public string Cst2TMNumber
        {
            get { return _cst2TMNumber; }
            set { _cst2TMNumber = value;
                CultureInfo cul = CultureInfo.CurrentCulture;
                string groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
                string decimalSep = cul.NumberFormat.CurrencyDecimalSeparator;//decimalSep ='.'
                string sFormat = string.Format("#{0}##", decimalSep);
                string gFormat = string.Format("#{0}###", groupSep);
                if (_moneyFormat)
                {
                    this.cst2TMNumber.Text = decimal.Parse(this._cst2TMNumber).ToString(gFormat) + " ₫";
                }
                else
                {
                    this.cst2TMNumber.Text = value;
                }
                if (int.Parse(_cst2LMNumber) > int.Parse(_cst2TMNumber))
                {
                    this.cst2LMNumber.ForeColor = this.color_increase;
                    this.cst2TMNumber.ForeColor = this.color_decrease;
                    this.cst2Icon.Image = this.icon_decrease;
                }
                else
                {
                    this.cst2LMNumber.ForeColor = this.color_decrease;
                    this.cst2TMNumber.ForeColor = this.color_increase;
                    this.cst2Icon.Image = this.icon_increase;
                }
                float ratio = ((int.Parse(_cst2TMNumber) - int.Parse(_cst2LMNumber)) / float.Parse(_cst2LMNumber)) * 100;
                this.cst2Ratio.Text = ratio.ToString(sFormat) + " %";
                if (ratio > 0)
                {
                    this.cst2Ratio.ForeColor = this.color_increase;
                }
                else
                {
                    this.cst2Ratio.ForeColor = this.color_decrease;
                }
            }
        }
        #endregion
    }
}