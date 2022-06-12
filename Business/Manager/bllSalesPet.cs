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
    public class bllSalesPet
    {
        dalSalesPet dal = new dalSalesPet();

        public void Load()
        {
            this.dal.Load();
        }

        public ObservableCollection<SalesPet> GetLocal()
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

        public IQueryable<SalesPet> GetAll()
        {
            return this.dal.GetAll();
        }

        public SalesPet Find(int saleID, int petID)
        {
            return this.dal.Find(saleID, petID);
        }

        public void Save(SalesPet salesPet)
        {
            this.dal.Save(salesPet);
        }

        public void Modify(SalesPet salesPet)
        {
            this.dal.Modify(salesPet);
        }

        public void Delete(int saleID, int petID)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.dal.Delete(saleID, petID);
        }

        public void CancelChanged()
        {
            this.dal.CancelChanged();
        }

        public int GetTotalPetSales()
        {
            return this.dal.GetTotalPetSales();
        }
    }
}
