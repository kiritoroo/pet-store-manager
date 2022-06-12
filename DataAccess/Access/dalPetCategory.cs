using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections.ObjectModel;

namespace DataAccess.Access
{
    public class dalPetCategory
    {
        PetStoreDBContext db = new PetStoreDBContext();

        public void Load()
        {
            this.db.PetCategorys.Load();
        }

        public ObservableCollection<PetCategory> GetLocal()
        {
            return this.db.PetCategorys.Local;
        }

        public void SaveLocal()
        {
            this.db.SaveChanges();
        }

        public List<DbEntityEntry> GetChangeTracker()
        {
            var changed = db.ChangeTracker.Entries().Where(x => x.State != System.Data.Entity.EntityState.Unchanged).ToList();
            return changed;
        }

        public IQueryable<PetCategory> GetAll()
        {
            return this.db.PetCategorys;
        }

        public PetCategory Find(string id)
        {
            return this.db.PetCategorys.Find(id);
        }

        public void Save(PetCategory petCategory)
        {
            this.db.PetCategorys.Add(petCategory);
            this.db.SaveChanges();
        }

        public void Modify(PetCategory petCategory)
        {
            this.db.Entry(petCategory).State = EntityState.Modified;
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            PetCategory petCategory = this.Find(id);
            this.db.PetCategorys.Remove(petCategory);
            this.db.SaveChanges();
        }

        public void CancelChanged()
        {
            var changed = this.GetChangeTracker();
            foreach (var obj in changed)
            {
                switch (obj.State)
                {
                    case EntityState.Modified:
                        obj.CurrentValues.SetValues(obj.OriginalValues);
                        obj.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        obj.State = EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        obj.State = EntityState.Unchanged;
                        break;
                }
            }
        }

        public IQueryable<Pet> GetAllPetEachType(string label)
        {
            var querry = from petType in db.PetCategorys
                         join pet in db.Pets on petType.ID equals pet.PetCategoryID
                         where petType.Label == label
                         select pet;
            return querry;
        }

        public int GetTotalPetEachType(string label)
        {
            return this.GetAllPetEachType(label).ToList().Count;
        }

        public List<dynamic> GetTopSalePetCategory()
        {
            // Task Complete advance- Trung
            //Querry

            List<dynamic> list = new List<dynamic>();
            var querry = (from at in db.PetCategorys
                          join animal in db.Pets on at.ID equals animal.PetCategoryID into result1
                          from rs1 in result1.DefaultIfEmpty()
                          join saleAnimal in db.SalesPets on rs1.ID equals saleAnimal.PetID into result2
                          from rs2 in result2.DefaultIfEmpty()
                          group rs2 by at into gr
                          select new
                          {
                              ID = gr.Key.ID,
                              Label = gr.Key.Label,
                              Icon = gr.Key.Icon,
                              TotalSale = (int?)gr.Where(g => g != null).Select(g => g.SalesID).Count() ?? 0,
                              TotalRevenue = (int?)gr.Where(g => g != null).Select(g => g.Price).Sum() ?? 0
                          }).OrderByDescending(rs => rs.TotalSale);

            list = querry.ToList<dynamic>();
            return list;
        }
    }
}
