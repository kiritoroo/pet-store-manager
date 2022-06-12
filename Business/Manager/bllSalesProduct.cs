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
    public class bllSalesProduct
    {
        dalSalesProduct dal = new dalSalesProduct();

        public void Load()
        {
            this.dal.Load();
        }

        public ObservableCollection<SalesProduct> GetLocal()
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

        public IQueryable<SalesProduct> GetAll()
        {
            return this.dal.GetAll();
        }

        public SalesProduct Find(int saleID, int productID)
        {
            return this.dal.Find(saleID, productID);
        }

        public void Save(SalesProduct salesProduct)
        {
            this.dal.Save(salesProduct);
        }

        public void Modify(SalesProduct salesProduct)
        {
            this.dal.Modify(salesProduct);
        }

        public void Delete(int saleID, int productID)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.dal.Delete(saleID, productID);
        }

        public void CancelChanged()
        {
            this.dal.CancelChanged();
        }

        public int GetTotalProductSales()
        {
            return this.dal.GetTotalProductSales();
        }
    }
}
