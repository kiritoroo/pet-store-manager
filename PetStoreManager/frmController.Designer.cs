namespace PetStoreManager
{
    partial class frmController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmController));
            this.childFormPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.mainTopPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.maincButtonOrders = new PetStoreManager.Components.CardTable();
            this.maincButtonPets = new PetStoreManager.Components.CardTable();
            this.maincButtonPeoples = new PetStoreManager.Components.CardTable();
            this.maincButtonDashboard = new PetStoreManager.Components.CardTable();
            this.maincButtonSales = new PetStoreManager.Components.CardTable();
            this.mainTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.childFormPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("childFormPanel.BackgroundImage")));
            this.childFormPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.childFormPanel.BorderColor = System.Drawing.Color.Transparent;
            this.childFormPanel.BorderRadius = 3;
            this.childFormPanel.BorderThickness = 1;
            this.childFormPanel.Location = new System.Drawing.Point(0, 87);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.ShowBorders = true;
            this.childFormPanel.Size = new System.Drawing.Size(1800, 815);
            this.childFormPanel.TabIndex = 2;
            // 
            // mainTopPanel
            // 
            this.mainTopPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mainTopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainTopPanel.BackgroundImage")));
            this.mainTopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainTopPanel.BorderColor = System.Drawing.Color.DimGray;
            this.mainTopPanel.BorderRadius = 0;
            this.mainTopPanel.BorderThickness = 1;
            this.mainTopPanel.Controls.Add(this.maincButtonOrders);
            this.mainTopPanel.Controls.Add(this.maincButtonPets);
            this.mainTopPanel.Controls.Add(this.maincButtonPeoples);
            this.mainTopPanel.Controls.Add(this.maincButtonDashboard);
            this.mainTopPanel.Controls.Add(this.maincButtonSales);
            this.mainTopPanel.Location = new System.Drawing.Point(-6, -8);
            this.mainTopPanel.Name = "mainTopPanel";
            this.mainTopPanel.ShowBorders = true;
            this.mainTopPanel.Size = new System.Drawing.Size(1303, 89);
            this.mainTopPanel.TabIndex = 0;
            // 
            // maincButtonOrders
            // 
            this.maincButtonOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.maincButtonOrders.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.maincButtonOrders.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.maincButtonOrders.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.maincButtonOrders.CtIcon = global::PetStoreManager.Properties.Resources.icon_orders;
            this.maincButtonOrders.CtLabel = "Orders";
            this.maincButtonOrders.FormParent = null;
            this.maincButtonOrders.Location = new System.Drawing.Point(922, 30);
            this.maincButtonOrders.Name = "maincButtonOrders";
            this.maincButtonOrders.Size = new System.Drawing.Size(150, 50);
            this.maincButtonOrders.TabIndex = 0;
            // 
            // maincButtonPets
            // 
            this.maincButtonPets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.maincButtonPets.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.maincButtonPets.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.maincButtonPets.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.maincButtonPets.CtIcon = global::PetStoreManager.Properties.Resources.icon_pets;
            this.maincButtonPets.CtLabel = "Pets";
            this.maincButtonPets.FormParent = null;
            this.maincButtonPets.Location = new System.Drawing.Point(405, 30);
            this.maincButtonPets.Name = "maincButtonPets";
            this.maincButtonPets.Size = new System.Drawing.Size(150, 50);
            this.maincButtonPets.TabIndex = 0;
            // 
            // maincButtonPeoples
            // 
            this.maincButtonPeoples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.maincButtonPeoples.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.maincButtonPeoples.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.maincButtonPeoples.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.maincButtonPeoples.CtIcon = global::PetStoreManager.Properties.Resources.icon_peoples;
            this.maincButtonPeoples.CtLabel = "Peoples";
            this.maincButtonPeoples.FormParent = null;
            this.maincButtonPeoples.Location = new System.Drawing.Point(239, 30);
            this.maincButtonPeoples.Name = "maincButtonPeoples";
            this.maincButtonPeoples.Size = new System.Drawing.Size(150, 50);
            this.maincButtonPeoples.TabIndex = 0;
            // 
            // maincButtonDashboard
            // 
            this.maincButtonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.maincButtonDashboard.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.maincButtonDashboard.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.maincButtonDashboard.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.maincButtonDashboard.CtIcon = global::PetStoreManager.Properties.Resources.icon_dashboard;
            this.maincButtonDashboard.CtLabel = "Dashboard";
            this.maincButtonDashboard.FormParent = null;
            this.maincButtonDashboard.Location = new System.Drawing.Point(72, 30);
            this.maincButtonDashboard.Name = "maincButtonDashboard";
            this.maincButtonDashboard.Size = new System.Drawing.Size(150, 50);
            this.maincButtonDashboard.TabIndex = 0;
            // 
            // maincButtonSales
            // 
            this.maincButtonSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.maincButtonSales.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.maincButtonSales.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.maincButtonSales.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.maincButtonSales.CtIcon = global::PetStoreManager.Properties.Resources.icon_sales;
            this.maincButtonSales.CtLabel = "Sales";
            this.maincButtonSales.FormParent = null;
            this.maincButtonSales.Location = new System.Drawing.Point(741, 30);
            this.maincButtonSales.Name = "maincButtonSales";
            this.maincButtonSales.Size = new System.Drawing.Size(150, 50);
            this.maincButtonSales.TabIndex = 0;
            // 
            // frmController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 900);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.mainTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.mainTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuPanel mainTopPanel;
        public Components.CardTable maincButtonSales;
        public Components.CardTable maincButtonOrders;
        public Components.CardTable maincButtonPets;
        public Components.CardTable maincButtonPeoples;
        public Components.CardTable maincButtonDashboard;
        private Bunifu.UI.WinForms.BunifuPanel childFormPanel;
    }
}