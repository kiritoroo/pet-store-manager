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
using Application.UserControls;
using Business.Manager;
using Entities.Models;
using DevExpress.XtraSplashScreen;

namespace Application.Forms
{
    public partial class frmShoppingCart : DevExpress.XtraEditors.XtraForm
    {
        bllPetCategory bllPetCate;
        bllPet bllPet;
        bllProductCategory bllProductCate;
        bllProduct bllProduct;

        public frmShoppingCart()
        {
            InitializeComponent();

            this.bllPetCate = new bllPetCategory();
            this.bllPet = new bllPet();
            this.bllProductCate = new bllProductCategory();
            this.bllProduct = new bllProduct();
        }

        private void frmShoppingCart_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
        }

        private void LoadPet()
        {
            if (this.IsActive)
            {
                SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
                SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");
            }

            this.flowItem.Controls.Clear();
            this.flowCategory.Controls.Clear();
            bindingSource1.DataSource = bllPetCate.GetTopSalePetCategory();

            // All
            ucPetCategory ucAll = new ucPetCategory()
            {
                FormParent = this,
                PetType = null,
                PetCount = bllPet.GetAll().Count()
            };
            this.flowCategory.Controls.Add(ucAll);
            // Category
            List<PetCategory> listPetCate = bllPetCate.GetAll().ToList();
            foreach (PetCategory item in listPetCate)
            {
                ucPetCategory uc = new ucPetCategory()
                {
                    FormParent = this,
                    PetType = item,
                    PetCount = bllPetCate.GetTotalPetEachType(item.Label)
                };
                this.flowCategory.Controls.Add(uc);
            }

            // Item
            List<Pet> listPet = bllPet.GetAll().ToList();
            foreach (Pet item in listPet)
            {
                ucPet uc = new ucPet()
                {
                    Pet = item
                };
                this.flowItem.Controls.Add(uc);
            }

            if (this.IsActive)
            {
                SplashScreenManager.CloseForm();
            }
        }
        private void LoadProduct()
        {
            if (this.IsActive)
            {
                SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Đang tải dữ liệu...");
                SplashScreenManager.Default.SetWaitFormDescription("Chờ xíu");
            }

            this.flowItem.Controls.Clear();
            this.flowCategory.Controls.Clear();
            bindingSource1.DataSource = bllProductCate.GetTopSaleProduct();

            // All
            ucProductCategory ucAll = new ucProductCategory()
            {
                FormParent = this,
                ProductType = null,
                ProductCount = bllProduct.GetAll().Count()
            };
            this.flowCategory.Controls.Add(ucAll);
            // Category
            List<ProductCategory> listProductCate = bllProductCate.GetAll().ToList();
            foreach (ProductCategory item in listProductCate)
            {
                ucProductCategory uc = new ucProductCategory()
                {
                    FormParent = this,
                    ProductType = item,
                    ProductCount = bllProductCate.GetAllProductEachType(item.Label).Count()
                };
                this.flowCategory.Controls.Add(uc);
            }

            // Item
            List<Product> listProduct = bllProduct.GetAll().ToList();
            foreach (Product item in listProduct)
            {
                ucProduct uc = new ucProduct()
                {
                    Product = item
                };
                this.flowItem.Controls.Add(uc);
            }

            if (this.IsActive)
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                this.LoadPet();
            }
            if (this.comboBox1.SelectedIndex == 1)
            {
                this.LoadProduct();
            }
        }
    }
}