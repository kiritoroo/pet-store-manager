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

namespace Application.UserControls
{
    public partial class ucStatisType1 : DevExpress.XtraEditors.XtraUserControl
    {
        public ucStatisType1()
        {
            InitializeComponent();
        }

        #region Properties
        [Category("Custom Properties")]
        private frmMain _formParent;

        public frmMain FormParent
        {
            get { return _formParent; }
            set { _formParent = value; }
        }

        [Category("Custom Properties")]
        private Image _cst1Icon;

        public Image Cst1Icon
        {
            get { return _cst1Icon; }
            set { _cst1Icon = value; this.cst1Icon.Image = value; }
        }

        [Category("Custom Properties")]
        private string _cst1BigNumber;

        public string Cst1BigNumber
        {
            get { return _cst1BigNumber; }
            set { _cst1BigNumber = value; this.cst1BigNumber.Text = value; }
        }

        [Category("Custom Properties")]
        private string _cst1SmallNumber;

        public string Cst1SmallNumber
        {
            get { return _cst1SmallNumber; }
            set { _cst1SmallNumber = value; this.cst1SmallNumber.Text = value; }
        }

        [Category("Custom Properties")]
        private string _cst1BigLabel;

        public string Cst1BigLabel
        {
            get { return _cst1BigLabel; }
            set { _cst1BigLabel = value; this.cst1BigLabel.Text = value; }
        }

        [Category("Custom Properties")]
        private string _cst1SmallLabel;

        public string Cst1SmallLabel
        {
            get { return _cst1SmallLabel; }
            set { _cst1SmallLabel = value; this.cst1SmallLabel.Text = value; }
        }

        [Category("Custom Properties")]
        private Color _colorBackground;

        public Color ColorBackground
        {
            get { return _colorBackground; }
            set { _colorBackground = value; this.BackColor = value; }
        }

        [Category("Custom Properties")]
        private Color _colorLight;

        public Color ColorLight
        {
            get { return _colorLight; }
            set { _colorLight = value; }
        }

        [Category("Custom Properties")]
        private float _cst1BigNumberSize;

        public float Cst1BigNumberSize
        {

            get { return _cst1BigNumberSize; }
            set { _cst1BigNumberSize = value; this.cst1BigNumber.Font = new System.Drawing.Font(cst1BigNumber.Font.Name, value, FontStyle.Bold); }
        }
        #endregion
    }
}
