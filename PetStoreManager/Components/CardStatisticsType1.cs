using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Models;
using Business.Manager;

namespace PetStoreManager.Components
{
    public partial class CardStatisticsType1 : UserControl
    {
        public CardStatisticsType1()
        {
            InitializeComponent();
            this.DelegateEvent();
        }

        #region Properties
        [Category("Custom Properties")]
        private frmDashboard _formParent;

        public frmDashboard FormParent
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
            set { _colorBackground = value; this.cst1MainPanel.BackgroundColor = value; }
        }

        [Category("Custom Properties")]
        private Color _colorEffect;

        public Color ColorEffect
        {
            get { return _colorEffect; }
            set { _colorEffect = value; this.cst1LowPanel.BackgroundColor = value; }
        }

        [Category("Custom Properties")]
        private Color _colorLight;

        public Color ColorLight
        {
            get { return _colorLight; }
            set { _colorLight = value; }
        }

        #endregion

        #region Events
        private void DelegateEvent()
        {
            this.Load += new EventHandler(this.Event_Load);

            this.cst1BigLabel.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.cst1BigNumber.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.cst1Icon.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.cst1LowPanel.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.cst1MainPanel.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.cst1SmallLabel.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.cst1SmallNumber.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);

            this.cst1BigLabel.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.cst1BigNumber.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.cst1Icon.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.cst1LowPanel.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.cst1MainPanel.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.cst1SmallLabel.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.cst1SmallNumber.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
        }

        private void Event_Load(object sender, EventArgs e)
        {
            
        }

        private void Event_Mouse_Move(object sender, MouseEventArgs e)
        {
            this.cst1MainPanel.BackgroundColor = this.ColorLight;
            this.cst1LowPanel.BackgroundColor = this.ColorLight;
        }

        private void Event_Mouse_Leave(object sender, EventArgs e)
        {
            this.cst1MainPanel.BackgroundColor = this.ColorBackground;
            this.cst1LowPanel.BackgroundColor = this.ColorEffect;
        }
        #endregion
    }
}
