using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Access;
using Entities.Models;

namespace Business.Manager
{
   public class mechandiseOrderManager
   {
        private merchandiseOrderAccess dal = new merchandiseOrderAccess();  

        public IQueryable<merchandiseOrder> GetAll()
        {
            return this.dal.GetAll();
        }

        public merchandiseOrder Find(int id)
        {
            return this.dal.Find(id);
        }

        public void Save(merchandiseOrder _merchandiseOrder)
        {
            this.dal.Save(_merchandiseOrder);
        }

        public void Modify(merchandiseOrder _merchandiseOrder)
        {
            this.dal.Modify(_merchandiseOrder);
        }

        public void Delete(int id)
        {
            this.dal.Delete(id);
        }
   }
}

