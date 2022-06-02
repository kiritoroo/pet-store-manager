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
    public partial class CardAnimalType : UserControl
    {
        public Color color_default;
        public Color color_hover;

        public CardAnimalType()
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
        private animalType _animalType;

        public animalType AnimalType
        {
            get { return _animalType; }
            set { _animalType = value; }
        }

        [Category("Custom Properties")]
        private Image _catIcon;   

        public Image CatIcon
        {
            get { return _catIcon; }
            set { _catIcon = value; 
                if (value != null) {
                    this.catIcon.Image = value; 
                }
                else {
                    this.catIcon.Image = Resources.icon_pets;
                }
            }
        }

        [Category("Custom Properties")]
        private string _catLabel;

        public string CatLabel
        {
            get { return _catLabel; }
            set { _catLabel = value; this.catLabel.Text = value; }
        }

        [Category("Custom Properties")]
        private string _catId;

        public string CatID
        {
            get { return _catId; }
            set { _catId = value; this.catId.Text = value;  }
        }
        #endregion

        #region Events
        private void DelegateEvent()
        {
            this.Load += new EventHandler(this.Event_Load);

            this.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.catId.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.catIcon.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.catLabel.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            
            this.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.catId.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.catIcon.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.catLabel.MouseLeave += new EventHandler(this.Event_Mouse_Leave);

            this.MouseClick += new MouseEventHandler(this.Event_Mouse_Click);
            this.catId.MouseClick += new MouseEventHandler(this.Event_Mouse_Click);
            this.catIcon.MouseClick += new MouseEventHandler(this.Event_Mouse_Click);
            this.catLabel.MouseClick += new MouseEventHandler(this.Event_Mouse_Click);
        }
        private void Event_Load(object sender, EventArgs e)
        {
            this.color_default = Color.FromArgb(255, 90, 130);
            this.color_hover = Color.FromArgb(255, 133, 163);
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
