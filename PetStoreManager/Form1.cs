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

namespace PetStoreManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Database.SetInitializer<DataContext>(null);
            animalTypeManager bll = new animalTypeManager();

            var petType1 = new animalType()
            {
                ID = "1",
                Description = "CAT",
            };
            bll.Save(petType1);
        }
    }
}
