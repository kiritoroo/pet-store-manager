using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace Data.Access
{
    public class animalTypeAccess
    {
        DataContext db = new DataContext();
        // CRUD
        public IQueryable<animalType> GetAll()
        {
            return this.db.animalTypes;
        }

        public animalType Find(string id)
        {
            return this.db.animalTypes.Find(id);
        }

        public void Add(animalType _animalType)
        {
            this.db.animalTypes.Add(_animalType);
            this.db.SaveChanges();
        }

        public void Modify(animalType _animalType)
        {
            this.db.Entry(_animalType).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            animalType _animalType = this.Find(id);
            this.db.animalTypes.Remove(_animalType);
            this.db.SaveChanges();
        }

        public List<dynamic> GetStatisticAllAnimal()
        {
            // Task Complete advance- Trung
            //Querry

            List<dynamic> list = new List<dynamic>();
            var querry = (from at in db.animalTypes
                          join animal in db.animals on at.ID equals animal.AnimalTypeID into result1
                          from rs1 in result1.DefaultIfEmpty()
                          join saleAnimal in db.saleAnimals on rs1.ID equals saleAnimal.AnimalID into result2
                          from rs2 in result2.DefaultIfEmpty()
                          group rs2 by at into gr
                          select new
                          {
                              ID = gr.Key.ID,
                              Label = gr.Key.Label,
                              Description = gr.Key.Description,
                              TotalSale = (int?)gr.Where(g => g != null).Select(g => g.SaleID).Count() ?? 0,
                              TotalRevenue = (int?)gr.Where(g => g != null).Select(g => g.SalePrice).Sum() ?? 0
                          }).OrderByDescending(rs => rs.TotalSale);
            list = querry.ToList<dynamic>();
            return list;
        }
    }
}
