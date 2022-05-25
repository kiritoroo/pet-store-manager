using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetStoreManager.Models;

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
            // Demo Context
            using (var ctx = new PetStoreDBEntities())
            {
                var order = new Order()
                {
                    CustomerID = 1,
                    EmployeeID = 10,
                    OrderDate = DateTime.Now,
                    OrderDetails = null,
                    OrderID = 1
                };

                ctx.Orders.Add(order);
                ctx.SaveChanges();
            }
        }
    }
}
