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
using Business.Manager;
using Entities.Models;
using Application.Services;
using DevExpress.XtraNavBar;
using System.Globalization;

namespace Application.Forms
{
    public partial class frmPet : DevExpress.XtraEditors.XtraForm
    {
        bllPetCategory bllPetType;
        bllPet bllPet;
        public frmPet()
        {
            InitializeComponent();
            this.bllPetType = new bllPetCategory();
            this.bllPet = new bllPet();
            this.toggle2.Checked = true;
        }

        private void frmPet_Load(object sender, EventArgs e)
        {
            bllPetType.Load();
            bllPet.Load();
            petTypeBindingSource.DataSource = bllPetType.GetLocal();
            petBindingSource.DataSource = bllPet.GetLocal();
            CultureInfo cul = CultureInfo.CurrentCulture;
            string groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
            string sFormat = string.Format("#{0}###" + " ₫", groupSep);
            this.colPrice.DisplayFormat.FormatString = sFormat;

            List<PetCategory> pcList = bllPetType.GetAll().ToList();
            try
            {
                navBarControl1.BeginUpdate();
                navBarGroup1.Expanded = true;
                foreach (var pc in pcList)
                {
                    NavBarItem item = new NavBarItem(pc.Label.ToString());
                    item.SmallImage = ImageService.BinaryToImage(pc.Icon);
                    item.ImageOptions.SmallImageSize = new Size(16, 16);
                    navBarControl1.Items.Add(item);
                    navBarGroup1.ItemLinks.Add(item);
                }

                if (navBarGroup1.ItemLinks.Count > 0)
                {
                    navBarControl1.Groups.Add(navBarGroup1);
                }
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                navBarControl1.EndUpdate();
            }
        }

        private void navBarControl1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (e.Link.Caption == "Tất cả thú cưng")
            {
                petBindingSource.DataSource = bllPet.GetLocal();
                return;
            }
            petBindingSource.DataSource = bllPetType.GetAllPetEachType(e.Link.Caption).ToList();
            petBindingSource.ResetBindings(true);
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.toggle1.Checked)
            {
                petTypeBindingSource.AddNew();
            }
            if (this.toggle2.Checked)
            {
                petBindingSource.AddNew();
            }
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.toggle1.Checked)
            {
                this.bllPetType.SaveLocal();
                petTypeBindingSource.ResetBindings(true);
            }
            if (this.toggle2.Checked)
            {
                this.bllPet.SaveLocal();
                petBindingSource.ResetBindings(true);
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.toggle1.Checked)
                {
                    petTypeBindingSource.RemoveCurrent();
                    petTypeBindingSource.ResetBindings(true);
                }
                if (this.toggle2.Checked)
                {
                    petBindingSource.RemoveCurrent();
                    petBindingSource.ResetBindings(true);
                }
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.toggle1.Checked)
            {
                this.bllPetType.CancelChanged();
                petTypeBindingSource.ResetBindings(false);
            }
            if (this.toggle2.Checked)
            {
                this.bllPetType.CancelChanged();
                petBindingSource.ResetBindings(false);
            }
        }

        private void btnAddImagePetType_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Open Image";
                open.Filter = "Image (*.png;*.jpg)|*.png;*.jpg";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filepath = open.FileName;
                    byte[] bImg = ImageService.ImageToBinary(Image.FromFile(filepath));
                    Console.WriteLine(bImg);
                    if (this.IDTextEdit.Text != "")
                    {
                        PetCategory current = (PetCategory)petTypeBindingSource.Current;
                        current.Icon = bImg;
                        petTypeBindingSource.ResetBindings(true);
                    }
                }
            }
        }

        private void btnAddImagePet_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Open Image";
                open.Filter = "Image (*.png;*.jpg)|*.png;*.jpg";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filepath = open.FileName;
                    byte[] bImg = ImageService.ImageToBinary(Image.FromFile(filepath));
                    Console.WriteLine(bImg);
                    if (this.textEdit1.Text != "")
                    {
                        Pet current = (Pet)petBindingSource.Current;
                        current.Photo = bImg;
                        petBindingSource.ResetBindings(true);
                    }
                }
            }
        }

        private void toggle1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.toggle1.Checked == true)
            {
                this.toggle2.Checked = false;
            }
            else
            {
                this.toggle2.Checked = true;
            }
        }

        private void toggle2_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.toggle2.Checked == true)
            {
                this.toggle1.Checked = false;
            }
            else
            {
                this.toggle1.Checked = true;
            }
        }
    }
}