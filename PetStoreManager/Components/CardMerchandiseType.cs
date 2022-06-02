using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetStoreManager.Properties;
using Entities.Models;

namespace PetStoreManager.Components
{
    public partial class CardMerchandiseType : UserControl
    {
        public Color color_default;
        public Color color_hover;

        public CardMerchandiseType()
        {
            InitializeComponent();
            this.DelegateEvent();
        }

        #region Properties
        [Category("Custom Properties")]
        private Form _formParent;

        public Form FormParent
        {
            get { return _formParent; }
            set { _formParent = value; }
        }

        [Category("Custom Properties")]
        private merchandiseType _merchandiseType;

        public merchandiseType AnimalType
        {
            get { return _merchandiseType; }
            set { _merchandiseType = value; }
        }

        [Category("Custom Properties")]
        private Image _cmtIcon;

        public Image CmtIcon
        {
            get { return _cmtIcon; }
            set { _cmtIcon = value;
                if (value != null)
                {
                    this.cmtIcon.Image = value;
                }
                else
                {
                    this.cmtIcon.Image = Resources.icon_merchandise;
                }
            }
        }

        [Category("Custom Properties")]
        private string _cmtLabel;

        public string CmtLabel
        {
            get { return _cmtLabel; }
            set { _cmtLabel = value; this.cmtLabel.Text = value; }
        }

        [Category("Custom Properties")]
        private string _cmtId;

        public string CmtID
        {
            get { return _cmtId; }
            set { _cmtId = value; this.cmtId.Text = value; }
        }
        #endregion

        #region Events
        private void DelegateEvent()
        {
            this.Load += new EventHandler(this.Event_Load);

            this.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.cmtIcon.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.cmtId.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.cmtLabel.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);

            this.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.cmtIcon.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.cmtId.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.cmtLabel.MouseLeave += new EventHandler(this.Event_Mouse_Leave);

            this.MouseClick += new MouseEventHandler(this.Event_Mouse_Click);
            this.cmtIcon.MouseClick += new MouseEventHandler(this.Event_Mouse_Click);
            this.cmtId.MouseClick += new MouseEventHandler(this.Event_Mouse_Click);
            this.cmtLabel.MouseClick += new MouseEventHandler(this.Event_Mouse_Click);
        }
        private void Event_Load(object sender, EventArgs e)
        {
            this.color_default = Color.FromArgb(64, 152, 254);
            this.color_hover = Color.FromArgb(189, 219, 254);
        }

        private void Event_Mouse_Move(object sender, MouseEventArgs e)
        {
            this.BackColor = this.color_hover;
        }

        private void Event_Mouse_Leave(object sender, EventArgs e)
        {
            this.BackColor = this.color_default;
        }

        private void Event_Mouse_Click(object sender, MouseEventArgs e)
        {

        }
        #endregion
    }
}
