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
using Business.Manager;
using Entities.Models;
using Application.Services;
using Application.Properties;
using DevExpress.XtraSplashScreen;

namespace Application.UserControls
{
    public partial class ucPetCategory : DevExpress.XtraEditors.XtraUserControl
    {
        public ucPetCategory()
        {
            InitializeComponent();

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
        private PetCategory _petType;

        public PetCategory PetType
        {
            get { return _petType; }
            set { _petType = value;
                if (_petType != null)
                {
                    this.hyperlinkLabelControl1.Text = _petType.Label; 
                    this.pictureBox1.Image = ImageService.BinaryToImage(this._petType.Icon);
                }
                else
                {
                    this.hyperlinkLabelControl1.Text = "Tất cả thú cưng";
                    this.pictureBox1.Image = Resources.icon_pet_all;
                }
            }
        }

        [Category("Custom Properties")]
        private int _PetCount;

        public int PetCount
        {
            get { return _PetCount; }
            set { _PetCount = value; this.label2.Text = value.ToString(); }
        }
        #endregion

        #region Events
        private void DelegateEvent()
        {

        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
            SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");

            bllPetCategory bllPetCate = new bllPetCategory();
            bllPet bllPet = new bllPet();
            List<Pet> petList;
            if (this._petType != null)
            {
                petList = bllPetCate.GetAllPetEachType(this._petType.Label).ToList();
            }
            else
            {
                petList = bllPet.GetAll().ToList();
            }

            this._formParent.flowItem.Controls.Clear();
            foreach (Pet item in petList)
            {
                ucPet uc = new ucPet()
                {
                    Pet = item
                };
                this._formParent.flowItem.Controls.Add(uc);
            }

            SplashScreenManager.CloseForm();
        }
        #endregion
    }
}
