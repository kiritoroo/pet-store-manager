using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using DataAccess.Access;
using System.Data.Entity.Infrastructure;
using System.Collections.ObjectModel;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Business.Manager
{
    public class bllSupplier
    {
        dalSupplier dal = new dalSupplier();

        public void Load()
        {
            this.dal.Load();
        }

        public ObservableCollection<Supplier> GetLocal()
        {
            return this.dal.GetLocal();
        }
        public bool SaveLocal()
        {
            try
            {
                this.dal.SaveLocal();
                XtraMessageBox.Show("Cập nhật thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                XtraMessageBox.Show("Cập nhật thất bại!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.dal.CancelChanged();
                return false;
            }
        }

        public List<DbEntityEntry> GetChangeTracker()
        {
            return this.dal.GetChangeTracker();
        }

        public IQueryable<Supplier> GetAll()
        {
            return this.dal.GetAll();
        }

        public Supplier Find(int id)
        {
            return this.dal.Find(id);
        }

        public void Save(Supplier supplier)
        {
            this.dal.Save(supplier);
        }

        public void Modify(Supplier supplier)
        {
            this.dal.Modify(supplier);
        }

        public void Delete(int id)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.dal.Delete(id);
        }

        public void CancelChanged()
        {
            this.dal.CancelChanged();
        }

        public int GetTotalSupplier()
        {
            return this.dal.GetTotalSupplier();
        }

        public List<dynamic> GetOrderPetDetailEachSupplier(Supplier supplier)
        {
            return this.dal.GetOrderPetDetailEachSupplier(supplier);
        }

        public List<dynamic> GetOrderProductDetailEachSupplier(Supplier supplier)
        {
            return this.dal.GetOrderProductDetailEachSupplier(supplier);
        }

        public int GetTotalOrderPetEachSupplier(Supplier supplier)
        {
            return this.dal.GetTotalOrderPetEachSupplier(supplier);
        }

        public decimal GetTotalPetCostEachSupplier(Supplier supplier)
        {
            return this.dal.GetTotalPetCostEachSupplier(supplier);
        }

        public int GetTotalOrderProductEachSupplier(Supplier supplier)
        {
            return this.dal.GetTotalOrderProductEachSupplier(supplier);
        }

        public decimal GetTotalProductCostEachSupplier(Supplier supplier)
        {
            return this.dal.GetTotalProductCostEachSupplier(supplier);
        }
    }
}
