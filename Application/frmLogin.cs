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
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace Application
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login lg = new Login()
            {
                Username = this.txtUsername.Text,
                Password = this.txtPassword.Text
            };

            SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, false);
            SplashScreenManager.Default.SetWaitFormCaption("Kết nối cơ sở dữ liệu...");
            SplashScreenManager.Default.SetWaitFormDescription("Đang tải");

            bllLogin bll = new bllLogin();
            if (bll.GetLogin(lg))
            {
                SplashScreenManager.CloseForm();
                frmMain frm = new frmMain();
                frm.Show();
                this.Visible = false;
            }
            else
            {
                SplashScreenManager.CloseForm();
                DevExpress.XtraEditors.XtraMessageBox.Show("Đăng nhập thất bại!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtUsername.Text = "admin";
            this.txtPassword.Text = "admin@123";
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnLogin_Click(sender, e);
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnLogin_Click(sender, e);
        }
    }
}