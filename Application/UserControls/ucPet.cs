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
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace Application.UserControls
{
    public partial class ucPet : DevExpress.XtraEditors.XtraUserControl
    {
        CultureInfo cul = CultureInfo.CurrentCulture;
        string groupSep;
        string sFormat;

        DateTime begin;
        DateTime current;

        public ucPet()
        {
            InitializeComponent();
            groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
            sFormat = string.Format("#{0}###", groupSep);

            //panel1.Size = new Size(panel1.Width, 0);
            this.panel1.Visible = false;
            this.label3.BringToFront();
            this.panel1.BringToFront();
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
        private frmMain _formMain;

        public frmMain FormMain
        {
            get { return _formMain; }
            set { _formMain = value; }
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
            this.MouseEnter += new EventHandler(this.Evemt_Mouse_Enter);
            this.pictureBox1.MouseEnter += new EventHandler(this.Evemt_Mouse_Enter);
            this.label1.MouseEnter += new EventHandler(this.Evemt_Mouse_Enter);
            this.label2.MouseEnter += new EventHandler(this.Evemt_Mouse_Enter);
            //this.label3.MouseEnter += new EventHandler(this.Evemt_Mouse_Enter);
            //this.panel1.MouseEnter += new EventHandler(this.Evemt_Mouse_Enter);

            //this.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            //this.pictureBox1.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            //this.label1.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            //this.label2.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            //this.label3.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            //this.panel1.MouseLeave += new EventHandler(this.Event_Mouse_Leave);

            //this.collisionPanel.MouseEnter += new EventHandler(this.Evemt_Mouse_Enter);
            //this.collisionPanel.MouseLeave += new EventHandler(this.Event_Mouse_Leave);

            this.label3.MouseClick += new MouseEventHandler(this.Event_AddToCart);
            this.panel1.MouseClick += new MouseEventHandler(this.Event_AddToCart);

            this.timer1.Tick += timer1_Tick;
        }

        private void Evemt_Mouse_Enter(object sender, EventArgs e)
        {
            //panel1.Size = new Size(panel1.Width, 50);
            this.panel1.Visible = true;
            this.begin = DateTime.Now;
            this.timer1.Start();
        }

        private void Event_Mouse_Leave(object sender, EventArgs e)
        {
            //panel1.Size = new Size(panel1.Width, 50);
            this.panel1.Visible = false;
        }

        private void Event_AddToCart(object sender, MouseEventArgs e)
        {
            foreach (SalesPet item in this._formParent.txListSalePet)
            {
                if (item.PetID == this._pet.ID)
                {
                    XtraMessageBox.Show("Thú cưng đã có trong giỏ hàng!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Cập nhật giỏ hàng");
            SplashScreenManager.Default.SetWaitFormDescription("Thêm thú cưng thành công");

            this._formParent.txListSalePet.Add(new SalesPet { Price = this._pet.Price, PetID = this._pet.ID });
            int cartTotal = (this._formParent.txListSalePet.Count + this._formParent.txListSaleProduct.Count);
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

            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(10);
            }
            SplashScreenManager.CloseForm();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            current = DateTime.Now;
            TimeSpan span = current.Subtract(begin);
            if (span.Milliseconds >= 500)
            {
                this.panel1.Visible = false;
            }
        }
        #endregion
    }
}
