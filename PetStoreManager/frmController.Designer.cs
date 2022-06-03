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
            this.mainEffectPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.mainTopPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.childFormPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.maincButtonOrders = new PetStoreManager.Components.CardTable();
            this.maincButtonPets = new PetStoreManager.Components.CardTable();
            this.maincButtonPeoples = new PetStoreManager.Components.CardTable();
            this.maincButtonDashboard = new PetStoreManager.Components.CardTable();
            this.maincButtonSales = new PetStoreManager.Components.CardTable();
            this.mainTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainEffectPanel
            // 
            this.mainEffectPanel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.mainEffectPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainEffectPanel.BackgroundImage")));
            this.mainEffectPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainEffectPanel.BorderColor = System.Drawing.Color.Transparent;
            this.mainEffectPanel.BorderRadius = 0;
            this.mainEffectPanel.BorderThickness = 0;
            this.mainEffectPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainEffectPanel.Location = new System.Drawing.Point(0, 739);
            this.mainEffectPanel.Name = "mainEffectPanel";
            this.mainEffectPanel.ShowBorders = true;
            this.mainEffectPanel.Size = new System.Drawing.Size(1280, 61);
            this.mainEffectPanel.TabIndex = 1;
            // 
            // mainTopPanel
            // 
            this.mainTopPanel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.mainTopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainTopPanel.BackgroundImage")));
            this.mainTopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainTopPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.mainTopPanel.BorderRadius = 0;
            this.mainTopPanel.BorderThickness = 0;
            this.mainTopPanel.Controls.Add(this.maincButtonOrders);
            this.mainTopPanel.Controls.Add(this.maincButtonPets);
            this.mainTopPanel.Controls.Add(this.maincButtonPeoples);
            this.mainTopPanel.Controls.Add(this.maincButtonDashboard);
            this.mainTopPanel.Controls.Add(this.maincButtonSales);
            this.mainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTopPanel.Name = "mainTopPanel";
            this.mainTopPanel.ShowBorders = true;
            this.mainTopPanel.Size = new System.Drawing.Size(1280, 104);
            this.mainTopPanel.TabIndex = 0;
            // 
            // childFormPanel
            // 
            this.childFormPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.childFormPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("childFormPanel.BackgroundImage")));
            this.childFormPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.childFormPanel.BorderColor = System.Drawing.Color.Transparent;
            this.childFormPanel.BorderRadius = 3;
            this.childFormPanel.BorderThickness = 1;
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(0, 104);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.ShowBorders = true;
            this.childFormPanel.Size = new System.Drawing.Size(1280, 635);
            this.childFormPanel.TabIndex = 2;
            // 
            // maincButtonOrders
            // 
            this.maincButtonOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(17)))));
            this.maincButtonOrders.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(17)))));
            this.maincButtonOrders.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(145)))));
            this.maincButtonOrders.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
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
            this.maincButtonPets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(95)))));
            this.maincButtonPets.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(95)))));
            this.maincButtonPets.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(181)))), ((int)(((byte)(193)))));
            this.maincButtonPets.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(139)))), ((int)(((byte)(158)))));
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
            this.maincButtonPeoples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.maincButtonPeoples.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.maincButtonPeoples.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.maincButtonPeoples.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
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
            this.maincButtonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.maincButtonDashboard.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.maincButtonDashboard.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.maincButtonDashboard.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
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
            this.maincButtonSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.maincButtonSales.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.maincButtonSales.ColorLineSmall = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(228)))), ((int)(((byte)(199)))));
            this.maincButtonSales.ColorPanel = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
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
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.mainEffectPanel);
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
        public Bunifu.UI.WinForms.BunifuPanel mainEffectPanel;
        private Bunifu.UI.WinForms.BunifuPanel childFormPanel;
    }
}