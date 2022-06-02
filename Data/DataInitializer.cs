using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.Database.ExecuteSqlCommand("ALTER TABLE animals ADD CONSTRAINT chk_id CHECK(animals.ID LIKE animals.AnimalTypeID + '%')");
            context.Database.Connection.Open();

            var animalTypeList = new List<animalType> {
                new animalType { ID = "GNB", Label = "Bọ Ú", Description = "Cute" },
                new animalType { ID = "HAM", Label = "Chuột Hamsters", Description = "Cute" },
                new animalType { ID = "SQU", Label = "Sóc", Description = "Cute"},
                new animalType { ID = "RAB", Label = "Thỏ", Description = "Cute"},
                new animalType { ID = "CAT", Label = "Mèo", Description = "Cute" }
            };
            animalTypeList.ForEach(at => context.animalTypes.Add(at));
            context.SaveChanges();

            var animalList = new List<animal> {
                new animal { ID = "GNB001", AnimalType = animalTypeList[0], Label = "American Short Hair Guinea Pig", Age = 1, Breed = "American Short Hair", Gender = "Male", Color = "Brown", ListPrice = 1500000 },
                new animal { ID = "GNB002", AnimalType = animalTypeList[0], Label = "American Short Hair Guinea Pig Soloca Lilac", Age = 1, Breed = "American Short Hair", Gender = "Female", Color = "Socola", ListPrice = 2100000 },
                new animal { ID = "HAM001", AnimalType = animalTypeList[1], Label = "Bear Gấu lông sát", Age = 1, Breed = "Bear", Gender = "Male", Color = "Orange", ListPrice = 120000 },
                new animal { ID = "HAM002", AnimalType = animalTypeList[1], Label = "Campell Safia Sóc", Age = 1, Breed = "Campell", Gender = "Male", Color = "Sliver", ListPrice = 50000 },
                new animal { ID = "HAM003", AnimalType = animalTypeList[1], Label = "Hamster Bò Sữa Xám", Age = 1, Breed = "Bò Sữa", Gender = "Female", Color = "Gray", ListPrice = 120000 },
                new animal { ID = "HAM004", AnimalType = animalTypeList[1], Label = "Hamster Campell Albino", Age = 1, Breed = "Campell", Gender = "Male", Color = "White", ListPrice = 80000 }
            };
            animalList.ForEach(a => context.animals.Add(a));
            context.SaveChanges();

            var merchandiseTypeList = new List<merchandiseType> {
                new merchandiseType { ID = "FOD", Label = "Thức ăn", Description = "Thức ăn cho thú cưng"},
                new merchandiseType { ID = "ITM", Label = "Vật dụng", Description = "Vật dụng cho thú cưng"},
                new merchandiseType { ID = "TOY", Label = "Đồ chơi", Description = "Đồ chơi cho thú cưng"},
                new merchandiseType { ID = "CAG", Label = "Lồng nuôi", Description = "Lót chuồng thú cưng"},
                new merchandiseType { ID = "LIT", Label = "Lót chuồng", Description = "Lót chuồng thú cưng"},
                new merchandiseType { ID = "MED", Label = "Dược phẩm", Description = "Vitamin, thuốc bổ cho thú cưng"}
            };
            merchandiseTypeList.ForEach(mt => context.merchandiseTypes.Add(mt));
            context.SaveChanges();

            var merchandiseList = new List<merchandise> {
                new merchandise { ID = "FOD001", MerchandiseType = merchandiseTypeList[0], Label = "Bánh cỏ thảo dược cho Thỏ Bọ Hamster", ListPrice = 85000, QuantityInStock = 20 },
                new merchandise { ID = "FOD002", MerchandiseType = merchandiseTypeList[0], Label = "Bánh thưởng ngũ cốc trái cây cho Thỏ Bọ Hamster", ListPrice = 29000, QuantityInStock = 50 },
                new merchandise { ID = "FOD003", MerchandiseType = merchandiseTypeList[0], Label = "Cỏ Alfafa Mrhay 500G", ListPrice = 80000, QuantityInStock = 10 },
                new merchandise { ID = "FOD004", MerchandiseType = merchandiseTypeList[0], Label = "Cỏ Alfafa Mrhay 1KG", ListPrice = 130000, QuantityInStock = 10 },
                new merchandise { ID = "FOD005", MerchandiseType = merchandiseTypeList[0], Label = "Cheese Cube cho Thỏ Bọ Hamster", ListPrice = 55000, QuantityInStock = 50 },
                new merchandise { ID = "FOD006", MerchandiseType = merchandiseTypeList[0], Label = "Thức ăn chính ngũ cốc cho Hamster 500G", ListPrice = 35000, QuantityInStock = 50 },
                new merchandise { ID = "FOD007", MerchandiseType = merchandiseTypeList[0], Label = "Carrot sấy khô cho Thỏ Bọ Hamster", ListPrice = 37000, QuantityInStock = 20 },
                new merchandise { ID = "FOD008", MerchandiseType = merchandiseTypeList[0], Label = "Cỏ nén Gex Mix Soft Carot 2,5KG", ListPrice = 280000, QuantityInStock = 10 },
                new merchandise { ID = "FOD009", MerchandiseType = merchandiseTypeList[0], Label = "Đậu nành sấy lạnh cho Pet nhỏ", ListPrice = 60000, QuantityInStock = 10 },
                new merchandise { ID = "FOD010", MerchandiseType = merchandiseTypeList[0], Label = "Thức ăn mèo con cao cấp Iskhan Korean", ListPrice = 390000, QuantityInStock = 10 },
                new merchandise { ID = "FOD011", MerchandiseType = merchandiseTypeList[0], Label = "ME-O Kitten chuyên biệt cho mèo con", ListPrice = 50000, QuantityInStock = 20 },
                new merchandise { ID = "FOD012", MerchandiseType = merchandiseTypeList[0], Label = "Whiskat mèo lớn 400G", ListPrice = 35000, QuantityInStock = 30 },
                new merchandise { ID = "ITM001", MerchandiseType = merchandiseTypeList[1], Label = "Khay cỏ nhựa", ListPrice = 120000, QuantityInStock = 5 },
                new merchandise { ID = "ITM002", MerchandiseType = merchandiseTypeList[1], Label = "Khay vệ sinh Carno chữ nhật size lớn", ListPrice = 190000, QuantityInStock = 5 },
                new merchandise { ID = "ITM003", MerchandiseType = merchandiseTypeList[1], Label = "Chén ăn Bucastage", ListPrice = 75000, QuantityInStock = 10 },
                new merchandise { ID = "ITM004", MerchandiseType = merchandiseTypeList[1], Label = "Bộ máng cỏ + bình nước Arylic", ListPrice = 180000, QuantityInStock = 10 },
                new merchandise { ID = "ITM005", MerchandiseType = merchandiseTypeList[1], Label = "Ba lô phi hành gia đeo thú cưng", ListPrice = 650000, QuantityInStock = 2 },
                new merchandise { ID = "TOY001", MerchandiseType = merchandiseTypeList[2], Label = "Whell Niteangel full color", ListPrice = 690000, QuantityInStock = 5 },
                new merchandise { ID = "TOY002", MerchandiseType = merchandiseTypeList[2], Label = "Banh cỏ", ListPrice = 35000, QuantityInStock = 20 },
                new merchandise { ID = "TOY003", MerchandiseType = merchandiseTypeList[2], Label = "Nhà ngủ xương rồng Poly cao cấp", ListPrice = 280000, QuantityInStock = 20 },
                new merchandise { ID = "TOY004", MerchandiseType = merchandiseTypeList[2], Label = "Carrot sơ mước size lớn", ListPrice = 85000, QuantityInStock = 10 },
                new merchandise { ID = "TOY005", MerchandiseType = merchandiseTypeList[2], Label = "Cần câu cho Dog Cat", ListPrice = 40000, QuantityInStock = 5 },
                new merchandise { ID = "CAG001", MerchandiseType = merchandiseTypeList[3], Label = "Lồng khay kéo size 72x60x50", ListPrice = 2500000, QuantityInStock = 5 },
                new merchandise { ID = "CAG002", MerchandiseType = merchandiseTypeList[3], Label = "Lồng Alice cho Thỏ Bọ Hamster size cực lớn", ListPrice = 15000000, QuantityInStock = 5 },
                new merchandise { ID = "LIT001", MerchandiseType = merchandiseTypeList[4], Label = "Giấy lót chuồng Chipsi Carefresh", ListPrice = 850000, QuantityInStock = 20 },
                new merchandise { ID = "LIT002", MerchandiseType = merchandiseTypeList[4], Label = "Bắp lót chuồng Jonsanty 1KG", ListPrice = 100000, QuantityInStock = 20 },
                new merchandise { ID = "MED001", MerchandiseType = merchandiseTypeList[5], Label = "Yaua táo kiwwi - bảo vệ tiêu hóa cho Thỏ Bọ", ListPrice = 10000, QuantityInStock = 50 },
                new merchandise { ID = "MED002", MerchandiseType = merchandiseTypeList[5], Label = "Vitamin bổ sung Enzym", ListPrice = 10000, QuantityInStock = 50 },
                new merchandise { ID = "MED003", MerchandiseType = merchandiseTypeList[5], Label = "Bọt tắm khô Jolly", ListPrice = 10000, QuantityInStock = 20 },
                new merchandise { ID = "MED004", MerchandiseType = merchandiseTypeList[5], Label = "Thanh cỏ thảo dược dâu rừng", ListPrice = 10000, QuantityInStock = 20 },
                new merchandise { ID = "MED005", MerchandiseType = merchandiseTypeList[5], Label = "Gel canxi bucastage hỗ trợ tiêu chảy", ListPrice = 10000, QuantityInStock = 20 },
                new merchandise { ID = "MED006", MerchandiseType = merchandiseTypeList[5], Label = "Sữa bột cho Thỏ Bọ Hamster", ListPrice = 10000, QuantityInStock = 20 },
            };
        }
    }
}
