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
            context.Database.Connection.Open();

            var animalTypeList = new List<animalType> {
                new animalType { ID = "HAMS", Label = "Hamsters", Description = "Những chú Hamster ngộ nghĩnh, đáng yêu." },
                new animalType { ID = "GB", Label = "Guinea Pigs", Description = "Những chú Bọ ú cute siêu cấp vũ trụ." },
                new animalType { ID = "CAT", Label = "Cats", Description = "Những chú Mèo nghịch ngợm." }
            };
            animalTypeList.ForEach(at => context.animalTypes.Add(at));
            context.SaveChanges();
        }
    }
}
