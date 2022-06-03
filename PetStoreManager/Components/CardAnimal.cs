using PetStoreManager.Properties;
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

namespace PetStoreManager.Components
{
    public partial class CardAnimal : UserControl
    {
        public CardAnimal()
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
        private animal animal;

        public animal Animal
        {
            get { return animal; }
            set { animal = value; }
        }


        [Category("Custom Properties")]
        private string _caGender;

        public string CaGender
        {
            get { return _caGender; }
            set { _caGender = value; 
                if (value == "Male") {
                    this.caIconGender.Image = Resources.icon_male;
                }
                else {
                    this.caIconGender.Image = Resources.icon_female;
                }
            }
        }

        [Category("Custom Properties")]
        private Image _caPhoto;

        public Image CaPhoto
        {
            get { return _caPhoto; }
            set { _caPhoto = value;
                if (value != null) {
                    this.caPhoto.Image = value;
                }
                else {
                    this.caPhoto.Image = Resources.icon_pets_2;
                }
            }
        }

        [Category("Custom Properties")]
        private string _caTitleLabel;

        public string CaTitleLabel
        {
            get { return _caTitleLabel; }
            set { _caTitleLabel = value; this.caTitleLabel.Text = value;  }
        }

        [Category("Custom Properties")]
        private float _caPrice;

        public float CaPrice
        {
            get { return _caPrice; }
            set { _caPrice = value; this.caPrice.Text = value.ToString() + " $"; }
        }
        #endregion

        #region Events
        private void DelegateEvent()
        {
            this.Load += new EventHandler(this.Event_Load);

            this.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.caAddToCardPanel.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.caAddToCardLabel.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.caIconGender.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.caPhoto.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.caPrice.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.caTitleLabel.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);

            this.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.caAddToCardPanel.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.caAddToCardLabel.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.caIconGender.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.caPhoto.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.caPrice.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.caTitleLabel.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
        }

        private void Event_Load(object sender, EventArgs e)
        {

        }

        private void Event_Mouse_Move(object sender, MouseEventArgs e)
        {
            caAddToCardPanel.Size = new Size(caAddToCardPanel.Width, 50);
        }

        private void Event_Mouse_Leave(object sender, EventArgs e)
        {
            caAddToCardPanel.Size = new Size(caAddToCardPanel.Width, 0);
        }

        private void Event_Mouse_Click(object sender, MouseEventArgs e)
        {

        }
        #endregion
    }
}
