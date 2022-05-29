using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Entities.Models;
using Business.Manager;
using PetStoreManager.Utilities;

namespace PetStoreManager
{
    public partial class Form1 : Form
    {
        private Image img;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            animalManager bll = new animalManager();
            this.dataGridView1.DataSource = bll.GetAllList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            animalManager bll = new animalManager();
            animal a = new animal()
            {
                ID = txtID.Text,
                AnimalTypeID = "PT1",
                Label = "GuineaPig Bear Cute",
                Age = 2,
                Breed = "American",
                Gender = "Male",
                Color = "Orange",
                ListPrice = 1500000,
                Photo = ImageService.ImageToBinary(this.img)
            };

            try
            {
                bll.Add(a);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.dataGridView1.DataSource = bll.GetAllList();
        }

        private void btnPickPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Open Image";
                open.Filter = "Image (*.png;*.jpg)|*.png;*.jpg";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filepath = open.FileName;
                    this.img = Image.FromFile(filepath);

                    MessageBox.Show("Success");
                }
            }
        }
    }
}
