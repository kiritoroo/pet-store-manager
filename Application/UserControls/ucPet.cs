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
using Application.Properties;

namespace Application.UserControls
{
    public partial class ucPet : DevExpress.XtraEditors.XtraUserControl
    {
        CultureInfo cul = CultureInfo.CurrentCulture;
        string groupSep;
        string sFormat;

        public ucPet()
        {
            InitializeComponent();
            groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
            sFormat = string.Format("#{0}###", groupSep);

            panel1.Size = new Size(panel1.Width, 0);
            this.DelegateEvent();
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
        private Pet _pet;

        public Pet Pet
        {
            get { return _pet; }
            set { _pet = value;
                if (_pet != null)
                {
                    if (this._pet.Photo != null)
                        this.pictureBox1.Image = ImageService.BinaryToImage(this._pet.Photo);
                    else
                        this.pictureBox1.Image = Resources.icon_pet_all;
                    this.label1.Text = this._pet.Label; 
                    this.label2.Text = this._pet.Price.ToString(sFormat) + " ₫";
                }
              }
        }
        #endregion

        #region Events
        private void DelegateEvent()
        {
            this.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.pictureBox1.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.label1.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.label2.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.label3.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.panel1.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);

            this.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.pictureBox1.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.label1.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.label2.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.label3.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.panel1.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
        }

        private void Event_Mouse_Move(object sender, MouseEventArgs e)
        {
            panel1.Size = new Size(panel1.Width, 50);
        }

        private void Event_Mouse_Leave(object sender, EventArgs e)
        {
            panel1.Size = new Size(panel1.Width, 0);
        }
        #endregion
    }
}
