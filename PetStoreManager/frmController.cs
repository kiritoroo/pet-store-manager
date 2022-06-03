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
using PetStoreManager.Components;
using PetStoreManager.Services;

namespace PetStoreManager
{
    public partial class frmController : Form
    {
        private Form activeForm = null;
        public frmController()
        {
            InitializeComponent();
            this.DelegateEvent();
            this.DoubleBuffered = true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.Show();
            childForm.BringToFront();
        }

        private void CloseFormChild(object sender, EventArgs e)
        {
            Form[] childArray = this.MdiChildren;
            foreach (Form childForm in childArray)
            {
                childForm.Close();
            }
        }

        #region Event
        private void DelegateEvent()
        {
            this.Load += new EventHandler(this.Event_Load);
            this.Load += new EventHandler(this.Event_maincButtonDashboard_Click);

            maincButtonDashboard.Click += Event_maincButtonDashboard_Click;
            maincButtonDashboard.ctArrowEffect.Click += Event_maincButtonDashboard_Click;
            maincButtonDashboard.ctIcon.Click += Event_maincButtonDashboard_Click;
            maincButtonDashboard.ctLabel.Click += Event_maincButtonDashboard_Click;
            maincButtonDashboard.ctLineEffect.Click += Event_maincButtonDashboard_Click;
            maincButtonDashboard.ctPanelEffect.Click += Event_maincButtonDashboard_Click;

            maincButtonPeoples.Click += Event_maincButtonPeoples_Click;
            maincButtonPeoples.ctArrowEffect.Click += Event_maincButtonPeoples_Click;
            maincButtonPeoples.ctIcon.Click += Event_maincButtonPeoples_Click;
            maincButtonPeoples.ctLabel.Click += Event_maincButtonPeoples_Click;
            maincButtonPeoples.ctLineEffect.Click += Event_maincButtonPeoples_Click;
            maincButtonPeoples.ctPanelEffect.Click += Event_maincButtonPeoples_Click;
        }
        private void Event_Load(object sender, EventArgs e)
        {
            this.Load -= Event_Load;

            Console.WriteLine("Data Initializing...");
            Console.WriteLine("Check Variable Here!");

            List< animal> l = new List<animal>();
            animalManager t = new animalManager();
            l = t.GetAll().ToList();

            this.maincButtonDashboard.FormParent = this;
            this.maincButtonPeoples.FormParent = this;
            this.maincButtonPets.FormParent = this;
            this.maincButtonSales.FormParent = this;
            this.maincButtonOrders.FormParent = this;
        }

        private void Event_maincButtonDashboard_Click(object sender, EventArgs e)
        {
            // Load Page Dashboard
            Console.WriteLine("Current Page: Dashboard");
            frmDashboard frmDashboard = new frmDashboard();
            openChildForm(frmDashboard);
        }
        private void Event_maincButtonPeoples_Click(object sender, EventArgs e)
        {
            // Load Page People
            Console.WriteLine("Current Page: People Manager");
            frmPeoples frmPeoples = new frmPeoples();
            openChildForm(frmPeoples);
        }
        #endregion
    }
}
