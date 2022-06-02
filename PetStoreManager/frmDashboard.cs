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
using PetStoreManager.Services;

namespace PetStoreManager
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
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

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        #region Event
        private void Event_CardTable_Click(object sender, MouseEventArgs e)
        {
            
        }
        #endregion
    }
}
