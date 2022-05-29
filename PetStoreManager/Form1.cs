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
using Data;


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
            using (var context=new DataContext())
            {
                var pettype1 = new animalType()
                {
                    ID = "1",
                    Description = "CAT",
                    // Animals = []
                };

                var cat1 = new animal()
                {
                    ID = "C1",
                    Age = 2,
                    Breed = "Meo muop",
                    Color = "Do",
                    Gender = "Nu",
                    Label = "MEO MAP CUTE",
                    ListPrice = 15000,
                    Photo = null
                };

                pettype1.Animals = new List<animal>();
                pettype1.Animals.Add(cat1); // Animals = [cat1]
                context.animalTypes.Add(pettype1);

                var customer1 = new customer()
                {
                    ID = "1",
                    Phone = "12345678910",
                    FristName = "David",
                    LastName = "Teo",
                    Address = "USA",
                    //Sales = new List<sale>()
                };
                context.customers.Add(customer1);
                var employee1 = new employee()
                {
                    ID = "1",
                    Phone = "5486378541",
                    LastName = "Lee",
                    FristName = "Sun",
                    Address = "JP",
                    DataHired = DateTime.Today,
                    //Sales = new List<sale>()
                };
                context.employees.Add(employee1);

                var sale1 = new sale
                {
                    ID = 1,
                    saledate = DateTime.Now,
                    SaleTax = 5000
                };
                
                employee1.Sales = new List<sale>();
                customer1.Sales = new List<sale>();
                employee1.Sales.Add(sale1);
                customer1.Sales.Add(sale1);

                context.sales.Add(sale1);


                context.SaveChanges();

            }        
        }
    }
}
