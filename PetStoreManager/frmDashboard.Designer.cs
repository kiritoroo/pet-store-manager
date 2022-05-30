namespace PetStoreManager
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnPickPhoto = new System.Windows.Forms.Button();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.lblListPrice = new System.Windows.Forms.Label();
            this.txtListPrice = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableTitle = new System.Windows.Forms.Label();
            this.lblAnimalTypeID = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.txtAnimalTypeID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPickPhoto
            // 
            this.btnPickPhoto.Location = new System.Drawing.Point(138, 330);
            this.btnPickPhoto.Name = "btnPickPhoto";
            this.btnPickPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnPickPhoto.TabIndex = 42;
            this.btnPickPhoto.Text = "Pick";
            this.btnPickPhoto.UseVisualStyleBackColor = true;
            this.btnPickPhoto.Click += new System.EventHandler(this.btnPickPhoto_Click);
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(31, 333);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(35, 13);
            this.lblPhoto.TabIndex = 41;
            this.lblPhoto.Text = "Photo";
            // 
            // lblListPrice
            // 
            this.lblListPrice.AutoSize = true;
            this.lblListPrice.Location = new System.Drawing.Point(31, 305);
            this.lblListPrice.Name = "lblListPrice";
            this.lblListPrice.Size = new System.Drawing.Size(50, 13);
            this.lblListPrice.TabIndex = 40;
            this.lblListPrice.Text = "List Price";
            // 
            // txtListPrice
            // 
            this.txtListPrice.Location = new System.Drawing.Point(138, 302);
            this.txtListPrice.Name = "txtListPrice";
            this.txtListPrice.Size = new System.Drawing.Size(182, 20);
            this.txtListPrice.TabIndex = 39;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(31, 277);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 38;
            this.lblColor.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(138, 274);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(182, 20);
            this.txtColor.TabIndex = 37;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(31, 249);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 36;
            this.lblGender.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(138, 246);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(182, 20);
            this.txtGender.TabIndex = 35;
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(31, 221);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(35, 13);
            this.lblBreed.TabIndex = 34;
            this.lblBreed.Text = "Breed";
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(138, 218);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(182, 20);
            this.txtBreed.TabIndex = 33;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(31, 193);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 32;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(138, 190);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(182, 20);
            this.txtAge.TabIndex = 31;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(31, 165);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(33, 13);
            this.lblLabel.TabIndex = 30;
            this.lblLabel.Text = "Label";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(138, 162);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(182, 20);
            this.txtLabel.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(366, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(403, 369);
            this.dataGridView1.TabIndex = 28;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(208, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tableTitle
            // 
            this.tableTitle.AutoSize = true;
            this.tableTitle.Location = new System.Drawing.Point(31, 61);
            this.tableTitle.Name = "tableTitle";
            this.tableTitle.Size = new System.Drawing.Size(65, 13);
            this.tableTitle.TabIndex = 26;
            this.tableTitle.Text = "Animal Type";
            // 
            // lblAnimalTypeID
            // 
            this.lblAnimalTypeID.AutoSize = true;
            this.lblAnimalTypeID.Location = new System.Drawing.Point(31, 137);
            this.lblAnimalTypeID.Name = "lblAnimalTypeID";
            this.lblAnimalTypeID.Size = new System.Drawing.Size(65, 13);
            this.lblAnimalTypeID.TabIndex = 25;
            this.lblAnimalTypeID.Text = "Animal Type";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(31, 109);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(18, 13);
            this.lblD.TabIndex = 24;
            this.lblD.Text = "ID";
            // 
            // txtAnimalTypeID
            // 
            this.txtAnimalTypeID.Location = new System.Drawing.Point(138, 134);
            this.txtAnimalTypeID.Name = "txtAnimalTypeID";
            this.txtAnimalTypeID.Size = new System.Drawing.Size(100, 20);
            this.txtAnimalTypeID.TabIndex = 23;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(138, 106);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 22;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPickPhoto);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.lblListPrice);
            this.Controls.Add(this.txtListPrice);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableTitle);
            this.Controls.Add(this.lblAnimalTypeID);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.txtAnimalTypeID);
            this.Controls.Add(this.txtID);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPickPhoto;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Label lblListPrice;
        private System.Windows.Forms.TextBox txtListPrice;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label tableTitle;
        private System.Windows.Forms.Label lblAnimalTypeID;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.TextBox txtAnimalTypeID;
        private System.Windows.Forms.TextBox txtID;
    }
}