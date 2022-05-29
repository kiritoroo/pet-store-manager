
namespace PetStoreManager
{
    partial class Form1
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAnimalTypeID = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.lblAnimalTypeID = new System.Windows.Forms.Label();
            this.tableTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblLabel = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblBreed = new System.Windows.Forms.Label();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblListPrice = new System.Windows.Forms.Label();
            this.txtListPrice = new System.Windows.Forms.TextBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.btnPickPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(155, 115);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtAnimalTypeID
            // 
            this.txtAnimalTypeID.Location = new System.Drawing.Point(155, 143);
            this.txtAnimalTypeID.Name = "txtAnimalTypeID";
            this.txtAnimalTypeID.Size = new System.Drawing.Size(100, 22);
            this.txtAnimalTypeID.TabIndex = 1;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(48, 118);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(20, 16);
            this.lblD.TabIndex = 2;
            this.lblD.Text = "ID";
            // 
            // lblAnimalTypeID
            // 
            this.lblAnimalTypeID.AutoSize = true;
            this.lblAnimalTypeID.Location = new System.Drawing.Point(48, 146);
            this.lblAnimalTypeID.Name = "lblAnimalTypeID";
            this.lblAnimalTypeID.Size = new System.Drawing.Size(104, 20);
            this.lblAnimalTypeID.TabIndex = 3;
            this.lblAnimalTypeID.Text = "Animal Type";
            // 
            // tableTitle
            // 
            this.tableTitle.AutoSize = true;
            this.tableTitle.Location = new System.Drawing.Point(48, 70);
            this.tableTitle.Name = "tableTitle";
            this.tableTitle.Size = new System.Drawing.Size(83, 16);
            this.tableTitle.TabIndex = 4;
            this.tableTitle.Text = "Animal Type";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(225, 381);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(383, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(403, 369);
            this.dataGridView1.TabIndex = 6;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(48, 174);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(51, 20);
            this.lblLabel.TabIndex = 8;
            this.lblLabel.Text = "Label";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(155, 171);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(182, 22);
            this.txtLabel.TabIndex = 7;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(48, 202);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(40, 20);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(155, 199);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(182, 22);
            this.txtAge.TabIndex = 9;
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(48, 230);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(55, 20);
            this.lblBreed.TabIndex = 12;
            this.lblBreed.Text = "Breed";
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(155, 227);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(182, 22);
            this.txtBreed.TabIndex = 11;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(48, 258);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(65, 20);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(155, 255);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(182, 22);
            this.txtGender.TabIndex = 13;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(48, 286);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(49, 20);
            this.lblColor.TabIndex = 16;
            this.lblColor.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(155, 283);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(182, 22);
            this.txtColor.TabIndex = 15;
            // 
            // lblListPrice
            // 
            this.lblListPrice.AutoSize = true;
            this.lblListPrice.Location = new System.Drawing.Point(48, 314);
            this.lblListPrice.Name = "lblListPrice";
            this.lblListPrice.Size = new System.Drawing.Size(76, 20);
            this.lblListPrice.TabIndex = 18;
            this.lblListPrice.Text = "List Price";
            // 
            // txtListPrice
            // 
            this.txtListPrice.Location = new System.Drawing.Point(155, 311);
            this.txtListPrice.Name = "txtListPrice";
            this.txtListPrice.Size = new System.Drawing.Size(182, 22);
            this.txtListPrice.TabIndex = 17;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(48, 342);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(53, 20);
            this.lblPhoto.TabIndex = 20;
            this.lblPhoto.Text = "Photo";
            // 
            // btnPickPhoto
            // 
            this.btnPickPhoto.Location = new System.Drawing.Point(155, 339);
            this.btnPickPhoto.Name = "btnPickPhoto";
            this.btnPickPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnPickPhoto.TabIndex = 21;
            this.btnPickPhoto.Text = "Pick";
            this.btnPickPhoto.UseVisualStyleBackColor = true;
            this.btnPickPhoto.Click += new System.EventHandler(this.btnPickPhoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAnimalTypeID;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblAnimalTypeID;
        private System.Windows.Forms.Label tableTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblListPrice;
        private System.Windows.Forms.TextBox txtListPrice;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Button btnPickPhoto;
    }
}

