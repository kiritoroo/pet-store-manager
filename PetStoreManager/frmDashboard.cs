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
using System.Data.Entity;
using PetStoreManager.Components;
using PetStoreManager.Properties;

namespace PetStoreManager
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnPets_Click(object sender, EventArgs e)
        {
            this.pageControl.Visible = true;
            this.petsPage.Refresh();
            this.flowPanel.Controls.Clear();
            this.pageControl.SetPage(2);
            animalTypeManager bll = new animalTypeManager();
            var animalTypes = bll.GetAll();
            foreach (var at in animalTypes)
            {
                PetTypeButtonComponent newComp = new PetTypeButtonComponent()
                {
                    Image = Resources.icon_pets,
                    Title = at.Label,
                    IdText = at.ID
                };
                this.flowPanel.Controls.Add(newComp);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.pageControl.Visible = true;
            this.pageControl.SetPage(0);
        }
    }
}
