using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;
using DataAccess.Services;
using DataAccess.Properties;
namespace DataAccess
{
    public class PetStoreDBInitializer : DropCreateDatabaseIfModelChanges<PetStoreDBContext>
    {
        protected override void Seed(PetStoreDBContext context)
        {
            var loginList = new List<Login> {
                new Login { Username = "admin", Password = "Admin@123" }
            };
            loginList.ForEach(log => context.Logins.Add(log));
            context.SaveChanges();

            var employeeList = new List<Employee> {
                new Employee { LastName = "Le", FirstName = "Trung", Title = "Nhân viên bán hàng",  BirthDate = DateTime.ParseExact("05/10/2000", "dd/MM/yyyy", null), HireDate = DateTime.ParseExact("15/05/2022", "dd/MM/yyyy", null), Address = "507 - 20th Ave. E.Apt. 2A", City = "Thành phố Hồ Chí Minh", Country = "Việt Nam", Phone = "(206) 555-9857", Photo = ImageService.ImageToBinary(Resources.emp_1) },
                new Employee { LastName = "Le", FirstName = "Huy", Title = "Nhân viên nhập liệu",  BirthDate = DateTime.ParseExact("02/02/2001", "dd/MM/yyyy", null), HireDate = DateTime.ParseExact("15/05/2022", "dd/MM/yyyy", null), Address = "908 W. Capital Way", City = "Thành phố Hồ Chí Minh", Country = "Việt Nam", Phone = "(206) 555-8122", Photo = ImageService.ImageToBinary(Resources.emp_0) },
                new Employee { LastName = "Xuan", FirstName = "Hieu", Title = "Nhân viên chăm sóc khách hàng",  BirthDate = DateTime.ParseExact("15/05/2002", "dd/MM/yyyy", null), HireDate = DateTime.ParseExact("15/05/2022", "dd/MM/yyyy", null), Address = "722 Moss Bay Blvd.", City = "Thành phố Hồ Chí Minh", Country = "Việt Nam", Phone = "(71) 555-7773", Photo = ImageService.ImageToBinary(Resources.emp_2) }
            };
            employeeList.ForEach(emp => context.Employees.Add(emp));
            context.SaveChanges();

            var customerList = new List<Customer> {
                new Customer { ContactName = "Lưu Gia Bảo", Address = "10/80C XL Hà Nội, Phường Tân Phú, Thủ Đức", City = "Thành phố Hồ Chí Minh", Country = "Việt Nam", Phone = "0965 432 988", AddDate = DateTime.ParseExact("29/05/2022", "dd/MM/yyyy", null) },
                new Customer { ContactName = "Ninh Japanese", Address = "13 Đường số 13, Long Thạnh Mỹ, Quận 9", City = "Thành phố Hồ Chí Minh", Country = "Việt Nam", Phone = "0382 995 862", AddDate = DateTime.ParseExact("30/05/2022", "dd/MM/yyyy", null) },
                new Customer { ContactName = "Nguyễn Công Huy", Address = "135 Đ. Nam Kỳ Khởi Nghĩa, Phường Bến Thành, Quận 1", City = "Thành phố Hồ Chí Minh", Country = "Việt Nam", Phone = "0169 882 555", AddDate = DateTime.ParseExact("07/06/2022", "dd/MM/yyyy", null) },
                new Customer { ContactName = "Minh Anh", Address = "Phạm Ngũ Lão, Phường Phạm Ngũ Lão, Quận 1", City = "Thành phố Hồ Chí Minh", Country = "Việt Nam", Phone = "0903 710 699", AddDate = DateTime.ParseExact("08/06/2022", "dd/MM/yyyy", null) },
                new Customer { ContactName = "Germanyy An", Address = "10/80C XL Hà Nội, Phường Tân Phú, Thủ Đức", City = "Thành phố Hồ Chí Minh", Country = "Việt Nam", Phone = "0909 595 151", AddDate = DateTime.ParseExact("09/06/2022", "dd/MM/yyyy", null) }
            };
            customerList.ForEach(cus => context.Customers.Add(cus));
            context.SaveChanges();

            var supplierList = new List<Supplier>
            {
                new Supplier { CompanyName = "Happy Pet Co.", ContactName = "Peter Wilson", Address = "1 Chome Kaminakazato, Kita City", City = "Tokyo", Country = "Japan", Phone = "(03) 3555-5011", Website = "www.happypet.co.jp"},
                new Supplier { CompanyName = "Alice & Flo's Pet Ltd.", ContactName = "Yoshi Nagase", Address = "2 Chome-201-1 Onaricho, Omiya Ward", City = "Saitama", Country = "Japan", Phone = "(03) 444-2343", Website = "www.alice-kojima.com"},
                new Supplier { CompanyName = "Jonsanty Pet Product Co.", ContactName = "Nagase Tomoya", Address = "495 Tashiro, Otaki, Isumi District", City = "Chiba", Country = "Japan", Phone = "(06) 431-7877", Website = "www.jonsantypet.co.jp"}
            };
            supplierList.ForEach(sup => context.Suppliers.Add(sup));
            context.SaveChanges();

            var petCategoryList = new List<PetCategory> {
                new PetCategory { ID = "GNB", Label = "Bọ Ú", Icon = ImageService.ImageToBinary(Resources.pt_guineapig) },
                new PetCategory { ID = "HAM", Label = "Chuột Hamsters", Icon = ImageService.ImageToBinary(Resources.pt_hamster) },
                new PetCategory { ID = "SQU", Label = "Sóc", Icon = ImageService.ImageToBinary(Resources.pt_squirrel) },
                new PetCategory { ID = "RAB", Label = "Thỏ", Icon = ImageService.ImageToBinary(Resources.pt_bunny) },
                new PetCategory { ID = "CAT", Label = "Mèo", Icon = ImageService.ImageToBinary(Resources.pt_cat) }
            };
            petCategoryList.ForEach(pt => context.PetCategorys.Add(pt));
            context.SaveChanges();

            var petList = new List<Pet> {
                new Pet { PetCategory = petCategoryList[0], Label = "American Short Hair Guinea Pig", Age = "Junior", Breed = "American Short Hair", Gender = "Male", Color = "Brown", Price = 1500000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.gp_1) },
                new Pet { PetCategory = petCategoryList[0], Label = "American Short Hair Guinea Pig Soloca Lilac", Age = "Newborn", Breed = "American Short Hair", Gender = "Female", Color = "Socola", Price = 2100000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.gp_2) },
                new Pet { PetCategory = petCategoryList[0], Label = "Guinea Pig Teddy Bear", Age = "Junior", Breed = "Teddy Bear", Gender = "Female", Color = "Orange", Price = 1500000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.gp_3) },
                
                new Pet { PetCategory = petCategoryList[1], Label = "Bear Gấu lông sát", Age = "Junior", Breed = "Bear", Gender = "Male", Color = "Orange", Price = 120000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.hams_2)},
                new Pet { PetCategory = petCategoryList[1], Label = "Campell Safia Sóc", Age = "Newborn", Breed = "Campell", Gender = "Male", Color = "Sliver", Price = 50000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.hams_3) },
                new Pet { PetCategory = petCategoryList[1], Label = "Hamster Bò Sữa Xám", Age = "Junior", Breed = "Bò Sữa", Gender = "Female", Color = "Gray", Price = 120000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.hams_4) },
                new Pet { PetCategory = petCategoryList[1], Label = "Hamster Campell Albino", Age = "Teen", Breed = "Campell", Gender = "Male", Color = "White", Price = 80000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.hams_5) },
                
                new Pet { PetCategory = petCategoryList[2], Label = "Sóc Bay Úc", Age = "Newborn", Breed = "Úc", Gender = "Male", Color = "White", Price = 1000000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.squ_1) },
                new Pet { PetCategory = petCategoryList[2], Label = "Sóc Bắc Mỹ", Age = "Teen", Breed = "American", Gender = "Male", Color = "White", Price = 4500000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.squ_2) },
                new Pet { PetCategory = petCategoryList[2], Label = "Red Squirrel - Cực hiếm", Age = "Teen", Breed = "Red American", Gender = "Male", Color = "Red", Price = 8500000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.squ_3) },
                
                new Pet { PetCategory = petCategoryList[3], Label = "Rabbit Lion baby new", Age = "Junior", Breed = "Lion", Gender = "Female", Color = "White", Price = 1100000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.rab_1) },
                new Pet { PetCategory = petCategoryList[3], Label = "Thỏ lùn Netherland", Age = "Teen", Breed = "Netherland", Gender = "Female", Color = "White", Price = 1200000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.rab_2) },
                new Pet { PetCategory = petCategoryList[3], Label = "Thỏ Minilop", Age = "Newborn", Breed = "Rabbit Lion", Gender = "Male", Color = "White", Price = 2100000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.rab_3) },
                new Pet { PetCategory = petCategoryList[3], Label = "Thỏ sư tử lion head", Age = "Newborn", Breed = "Lion", Gender = "Male", Color = "White", Price = 1100000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.rab_4)},
                new Pet { PetCategory = petCategoryList[3], Label = "Thỏ Woody-Toy", Age = "Teen", Breed = "Woody-Toy", Gender = "Male", Color = "White", Price = 1600000, Status = "Stocking", Photo = ImageService.ImageToBinary(Resources.rab_5)}
            };
            petList.ForEach(pet => context.Pets.Add(pet));
            context.SaveChanges();

            var producCategoryList = new List<ProductCategory> {
                new ProductCategory { ID = "FOD", Label = "Thức ăn", Description = "Thức ăn cho thú cưng", Icon = ImageService.ImageToBinary(Resources.prdc_1) },
                new ProductCategory { ID = "ITM", Label = "Vật dụng", Description = "Vật dụng cho thú cưng", Icon = ImageService.ImageToBinary(Resources.prdc_2) },
                new ProductCategory { ID = "TOY", Label = "Đồ chơi", Description = "Đồ chơi cho thú cưng", Icon = ImageService.ImageToBinary(Resources.prdc_3) },
                new ProductCategory { ID = "CAG", Label = "Lồng nuôi", Description = "Lót chuồng thú cưng", Icon = ImageService.ImageToBinary(Resources.prdc_4) },
                new ProductCategory { ID = "LIT", Label = "Lót chuồng", Description = "Lót chuồng thú cưng", Icon = ImageService.ImageToBinary(Resources.prdc_5) },
                new ProductCategory { ID = "MED", Label = "Dược phẩm", Description = "Vitamin, thuốc bổ cho thú cưng", Icon = ImageService.ImageToBinary(Resources.prdc_6) }
            };
            producCategoryList.ForEach(prc => context.ProductCategories.Add(prc));
            context.SaveChanges();

            var productList = new List<Product> {
                new Product { ProductCategory = producCategoryList[0], Label = "Đậu nành sấy lạnh cho Pet nhỏ", QuantityPerUnit = "500ml", UnitPrice = 60000, UnitsInStock = 100, Photo = ImageService.ImageToBinary(Resources.prd_6) },
                new Product { ProductCategory = producCategoryList[0], Label = "Cỏ Alfafa Chopy Mrhay cho thỏ bọ", QuantityPerUnit = "500g", UnitPrice = 80000, UnitsInStock = 20, Photo = ImageService.ImageToBinary(Resources.prd_7) },
                new Product { ProductCategory = producCategoryList[0], Label = "Carot cỏ Tymothy", QuantityPerUnit = "1 cái", UnitPrice = 85000, UnitsInStock = 10, Photo = ImageService.ImageToBinary(Resources.prd_8) },
                new Product { ProductCategory = producCategoryList[0], Label = "Lá cỏ Alfafa Jonsanty", QuantityPerUnit = "500g", UnitPrice = 150000, UnitsInStock = 25, Photo = ImageService.ImageToBinary(Resources.prd_9) },
                new Product { ProductCategory = producCategoryList[0], Label = "Cỏ nén chống rụng lông Pronutri", QuantityPerUnit = "900g", UnitPrice = 160000, UnitsInStock = 30, Photo = ImageService.ImageToBinary(Resources.prd_10) },
                new Product { ProductCategory = producCategoryList[0], Label = "Treat Kiwi sấy lạnh Alice cho Pet cưng", QuantityPerUnit = "15g", UnitPrice = 98000, UnitsInStock = 50, Photo = ImageService.ImageToBinary(Resources.prd_11) },
                new Product { ProductCategory = producCategoryList[0], Label = "Thạch sữa dê cho Pet nhỏ", QuantityPerUnit = "10 cube", UnitPrice = 85000, UnitsInStock = 55, Photo = ImageService.ImageToBinary(Resources.prd_12) },
                new Product { ProductCategory = producCategoryList[0], Label = "Pate cho mèo con Royal Cannin Kitten", QuantityPerUnit = "85g - 12 packet", UnitPrice = 380000, UnitsInStock = 15, Photo = ImageService.ImageToBinary(Resources.prd_13) },
                new Product { ProductCategory = producCategoryList[0], Label = "Kit Cat Kitten Tuna Flakes With Aspic", QuantityPerUnit = "400g", UnitPrice = 250000, UnitsInStock = 50, Photo = ImageService.ImageToBinary(Resources.prd_14) },
                new Product { ProductCategory = producCategoryList[0], Label = "Kit Cat Super Premium Wild Caught Tuna & Anchovy", QuantityPerUnit = "90g", UnitPrice = 55000, UnitsInStock = 50, Photo = ImageService.ImageToBinary(Resources.prd_15) },

                new Product { ProductCategory = producCategoryList[1], Label = "Bồn tắm cát con nhộng Buscastage size 18cm", QuantityPerUnit = "1 cái", UnitPrice = 120000, UnitsInStock = 15, Photo = ImageService.ImageToBinary(Resources.prd_16) },
                new Product { ProductCategory = producCategoryList[1], Label = "Bình nước cao cấp cho Pet", QuantityPerUnit = "1 bộ", UnitPrice = 180000, UnitsInStock = 15, Photo = ImageService.ImageToBinary(Resources.prd_17) },
                new Product { ProductCategory = producCategoryList[1], Label = "Chén ăn Bucastage", QuantityPerUnit = "1 cái", UnitPrice = 75000, UnitsInStock = 15, Photo = ImageService.ImageToBinary(Resources.prd_18) },
                new Product { ProductCategory = producCategoryList[1], Label = "Đế bình nước sứ Hươu cao cổ", QuantityPerUnit = "1 cái", UnitPrice = 110000, UnitsInStock = 10, Photo = ImageService.ImageToBinary(Resources.prd_19) },
                new Product { ProductCategory = producCategoryList[1], Label = "Nhà ngủ bằng vải", QuantityPerUnit = "1 cái", UnitPrice = 400000, UnitsInStock = 5, Photo = ImageService.ImageToBinary(Resources.prd_20) },

                new Product { ProductCategory = producCategoryList[2], Label = "Whell Bucastage gắn lồng 21cm", QuantityPerUnit = "1 cái", UnitPrice = 290000, UnitsInStock = 10, Photo = ImageService.ImageToBinary(Resources.prd_21) },
                new Product { ProductCategory = producCategoryList[2], Label = "Nhà ngủ đường hầm rừng xanh cho hamster", QuantityPerUnit = "1 cái", UnitPrice = 390000, UnitsInStock = 5, Photo = ImageService.ImageToBinary(Resources.prd_22) },
                new Product { ProductCategory = producCategoryList[2], Label = "Thang gỗ lượn sóng", QuantityPerUnit = "1 cái", UnitPrice = 85000, UnitsInStock = 5, Photo = ImageService.ImageToBinary(Resources.prd_23) },
                new Product { ProductCategory = producCategoryList[2], Label = "Dây cỏ mài răng cho bỏ bọ", QuantityPerUnit = "1 bộ", UnitPrice = 95000, UnitsInStock = 10, Photo = ImageService.ImageToBinary(Resources.prd_24) },
                new Product { ProductCategory = producCategoryList[2], Label = "Bộ áo dây dắt thỏ", QuantityPerUnit = "1 cái", UnitPrice = 240000, UnitsInStock = 5, Photo = ImageService.ImageToBinary(Resources.prd_25) },

                new Product { ProductCategory = producCategoryList[3], Label = "Lồng thỏ bọ Alice cao cấp SIZE M", QuantityPerUnit = "1 bộ", UnitPrice = 1150000, UnitsInStock = 5, Photo = ImageService.ImageToBinary(Resources.prd_26) },
                new Product { ProductCategory = producCategoryList[3], Label = "Lồng khay kéo", QuantityPerUnit = "1 bộ", UnitPrice = 3000000, UnitsInStock = 10, Photo = ImageService.ImageToBinary(Resources.prd_27) },
                new Product { ProductCategory = producCategoryList[3], Label = "Lồng ngăn đôi trong suốt", QuantityPerUnit = "1 bộ", UnitPrice = 480000, UnitsInStock = 10, Photo = ImageService.ImageToBinary(Resources.prd_28) },

                new Product { ProductCategory = producCategoryList[4], Label = "Giấy lót chuồng siêu mềm mịn", QuantityPerUnit = "1kg", UnitPrice = 170000, UnitsInStock = 10, Photo = ImageService.ImageToBinary(Resources.prd_29) },
                new Product { ProductCategory = producCategoryList[4], Label = "Bắp lót chuồng không bụi Jonsanty", QuantityPerUnit = "2,5kg", UnitPrice = 95000, UnitsInStock = 15, Photo = ImageService.ImageToBinary(Resources.prd_30) },

                new Product { ProductCategory = producCategoryList[5], Label = "Bánh cỏ thảo dược cho thỏ bọ hamster", QuantityPerUnit = "80g", UnitPrice = 85000, UnitsInStock = 50, Photo = ImageService.ImageToBinary(Resources.prd_1) },
                new Product { ProductCategory = producCategoryList[5], Label = "Bột tắm khô Jolly mới (Lavender)", QuantityPerUnit = "200ml", UnitPrice = 95000, UnitsInStock = 25, Photo = ImageService.ImageToBinary(Resources.prd_2) },
                new Product { ProductCategory = producCategoryList[5], Label = "Phấn tắm khô Alice chanh (mới)", QuantityPerUnit = "250ml", UnitPrice = 95000, UnitsInStock = 30, Photo = ImageService.ImageToBinary(Resources.prd_3) },
                new Product { ProductCategory = producCategoryList[5], Label = "Gel Canxi Bucastage - hỗ trợ ướt đuôi", QuantityPerUnit = "5g", UnitPrice = 45000, UnitsInStock = 35, Photo = ImageService.ImageToBinary(Resources.prd_4) },
                new Product { ProductCategory = producCategoryList[5], Label = "Sữa vi sinh cho thỏ bọ hamster sóc nhím", QuantityPerUnit = "5gx2", UnitPrice = 150000, UnitsInStock = 50, Photo = ImageService.ImageToBinary(Resources.prd_5) }
            };
            productList.ForEach(pro => context.Products.Add(pro));
            context.SaveChanges();

            var voucherList = new List<Voucher> {
                new Voucher { Code = VoucherService.GenerateCode(10), Percent = 5, BeginDate = DateTime.ParseExact("20/05/2022", "dd/MM/yyyy", null), EndDate = DateTime.ParseExact("01/06/2022", "dd/MM/yyyy", null) },
                new Voucher { Code = VoucherService.GenerateCode(10), Percent = 15, BeginDate = DateTime.ParseExact("02/06/2022", "dd/MM/yyyy", null), EndDate = DateTime.ParseExact("19/06/2022", "dd/MM/yyyy", null) },
                new Voucher { Code = VoucherService.GenerateCode(10), Percent = 20, BeginDate = DateTime.ParseExact("02/06/2022", "dd/MM/yyyy", null), EndDate = DateTime.ParseExact("15/06/2022", "dd/MM/yyyy", null) },
                new Voucher { Code = VoucherService.GenerateCode(10), Percent = 50, BeginDate = DateTime.ParseExact("05/06/2022", "dd/MM/yyyy", null), EndDate = DateTime.ParseExact("18/06/2022", "dd/MM/yyyy", null) },
                new Voucher { Code = VoucherService.GenerateCode(10), Percent = 10, BeginDate = DateTime.ParseExact("10/06/2022", "dd/MM/yyyy", null), EndDate = DateTime.ParseExact("19/06/2022", "dd/MM/yyyy", null) }
            };
            voucherList.ForEach(vou => context.Vouchers.Add(vou));
            context.SaveChanges();

            var salesList = new List<Sale> {
                new Sale { Customer = customerList[0], Employee = employeeList[0], SaleDate = DateTime.ParseExact("29/05/2022", "dd/MM/yyyy", null), SaleTax = 12000, Voucher = voucherList[0], Status = "Đã thanh toán" },
                new Sale { Customer = customerList[1], Employee = employeeList[0], SaleDate = DateTime.ParseExact("30/05/2022", "dd/MM/yyyy", null), SaleTax = 15000, Status = "Đã thanh toán" },
                new Sale { Customer = customerList[2], Employee = employeeList[0], SaleDate = DateTime.ParseExact("07/06/2022", "dd/MM/yyyy", null), SaleTax = 25000, Status = "Đã thanh toán" },
                new Sale { Customer = customerList[3], Employee = employeeList[0], SaleDate = DateTime.ParseExact("08/06/2022", "dd/MM/yyyy", null), SaleTax = 10000, Status = "Đã thanh toán" },
                new Sale { Customer = customerList[4], Employee = employeeList[0], SaleDate = DateTime.ParseExact("09/06/2022", "dd/MM/yyyy", null), SaleTax = 5000, Status = "Đã thanh toán" },
                new Sale { Customer = customerList[0], Employee = employeeList[0], SaleDate = DateTime.ParseExact("15/06/2022", "dd/MM/yyyy", null), SaleTax = 10000, Voucher = voucherList[4], Status = "Chưa thanh toán" }
            };
            salesList.ForEach(sal => context.Sales.Add(sal));
            context.SaveChanges();

            var salesPetList = new List<SalesPet> {
                new SalesPet { Sale = salesList[0], Pet = petList[0], Price = 1500000},
                new SalesPet { Sale = salesList[0], Pet = petList[1], Price = 2100000},

                new SalesPet { Sale = salesList[1], Pet = petList[8], Price = 4500000},

                new SalesPet { Sale = salesList[2], Pet = petList[3], Price = 120000},
                new SalesPet { Sale = salesList[2], Pet = petList[4], Price = 50000},
                new SalesPet { Sale = salesList[2], Pet = petList[5], Price = 120000},

                new SalesPet { Sale = salesList[3], Pet = petList[10], Price = 1100000},

                new SalesPet { Sale = salesList[4], Pet = petList[11], Price = 1200000},
                new SalesPet { Sale = salesList[4], Pet = petList[12], Price = 2100000},
            };
            salesPetList.ForEach(sp => context.SalesPets.Add(sp));
            context.SaveChanges();

            var salesProductList = new List<SalesProduct> {
                new SalesProduct { Sale = salesList[0], Product = productList[12], Quantity = 5, UnitPrice = 75000 },
                new SalesProduct { Sale = salesList[0], Product = productList[1], Quantity = 1, UnitPrice = 80000 },
                new SalesProduct { Sale = salesList[0], Product = productList[20], Quantity = 1, UnitPrice = 1150000 },

                new SalesProduct { Sale = salesList[1], Product = productList[25], Quantity = 2, UnitPrice = 85000 },
                new SalesProduct { Sale = salesList[1], Product = productList[14], Quantity = 1, UnitPrice = 400000 },

                new SalesProduct { Sale = salesList[2], Product = productList[0], Quantity = 2, UnitPrice = 60000 },

                new SalesProduct { Sale = salesList[3], Product = productList[0], Quantity = 5, UnitPrice = 60000 },
                new SalesProduct { Sale = salesList[3], Product = productList[27], Quantity = 1, UnitPrice = 95000 },
                new SalesProduct { Sale = salesList[3], Product = productList[22], Quantity = 1, UnitPrice = 480000 },
                new SalesProduct { Sale = salesList[3], Product = productList[6], Quantity = 1, UnitPrice = 85000 },
                new SalesProduct { Sale = salesList[3], Product = productList[16], Quantity = 1, UnitPrice = 390000 },

                new SalesProduct { Sale = salesList[4], Product = productList[18], Quantity = 2, UnitPrice = 95000 },
                new SalesProduct { Sale = salesList[4], Product = productList[1], Quantity = 1, UnitPrice = 80000 },

                new SalesProduct { Sale = salesList[5], Product = productList[1], Quantity = 2, UnitPrice = 80000 },
                new SalesProduct { Sale = salesList[5], Product = productList[24], Quantity = 2, UnitPrice = 95000 },
            };
            salesProductList.ForEach(spr => context.SalesProducts.Add(spr));
            context.SaveChanges();

            var orderList = new List<Order> {

            };
            orderList.ForEach(o => context.Orders.Add(o));
            context.SaveChanges();

            var orderPetList = new List<OrderPet> {

            };
            orderPetList.ForEach(op => context.OrderPets.Add(op));
            context.SaveChanges();

            var orderProductList = new List<OrderProduct> {

            };
            orderProductList.ForEach(opr => context.OrderProducts.Add(opr));
            context.SaveChanges();

            var deliveryList = new List<Delivery>
            {
                new Delivery { Sale = salesList[5], SentDate = DateTime.ParseExact("15/06/2022", "dd/MM/yyyy", null), ReceiveDate = null, ShippingCode = VoucherService.GenerateCode(15), ShippingUnit = "Viettel Post", Status = "Đang giao hàng" }
            };
            deliveryList.ForEach(del => context.Deliveries.Add(del));
            context.SaveChanges();
        }
    }
}
