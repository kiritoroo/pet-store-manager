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
          
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            animailOderItemManager  bll = new animailOderItemManager  ();
            var test = new   animalOrderItem()
            {
               OrderID=7,
               AnimalID="1",
               Cost =20
               

            };
            bll.Save(test);
            MessageBox.Show("Thanh cong");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            animailOderItemManager  bll = new animailOderItemManager  ();
            var test = new   animalOrderItem()
            {
                OrderID = 7,
                AnimalID = "1",
                Cost = 30
            };
            bll.Modify(test);
            MessageBox.Show("Thanh cong");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           animailOderItemManager  bll = new animailOderItemManager  ();
            var test = new   animalOrderItem()
            {
                OrderID = 7,
                AnimalID = "1",
                Cost = 20
            };
            bll.Delete(test.OrderID,test.AnimalID);
            MessageBox.Show("Thanh cong");
        }
    }
}
