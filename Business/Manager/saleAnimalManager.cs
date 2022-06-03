using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Access;
using Entities.Models;

namespace Business.Manager
{
    public class saleAnimalManager
    {
        private saleAnimalAccess dal = new saleAnimalAccess();

        public IQueryable<saleAnimal> GetAll()
        {
            return this.dal.GetAll();
        }

        public saleAnimal Find(int saleId, string animalId)
        {
            return this.dal.Find(saleId, animalId);
        }

        public void Add(saleAnimal _saleAnimal)
        {
            this.dal.Add(_saleAnimal);
        }

        public void Modify(saleAnimal _saleAnimal)
        {
            this.dal.Modify(_saleAnimal);
        }

        public void Delete(int saleId, string animalId)
        {
            this.dal.Delete(saleId, animalId);
        }

        public int GetTotalAnimalSales()
        {
            int total = this.dal.GetTotalAnimalSale();
            return total;
        }

        public int GetTotalAnimalSalesInMonth(string _month)
        {
            int total = this.dal.GetTotalAnimalSalesInMonth(_month);
            return total;
        }
    }
}
