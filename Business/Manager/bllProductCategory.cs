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
    public class bllProductCategory
    {
        dalProductCategory dal = new dalProductCategory();

        public void Load()
        {
            this.dal.Load();
        }

        public ObservableCollection<ProductCategory> GetLocal()
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

        public IQueryable<ProductCategory> GetAll()
        {
            return this.dal.GetAll();
        }

        public ProductCategory Find(string id)
        {
            return this.dal.Find(id);
        }

        public void Save(ProductCategory productCategory)
        {
            this.dal.Save(productCategory);
        }

        public void Modify(ProductCategory productCategory)
        {
            this.dal.Modify(productCategory);
        }

        public void Delete(string id)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.dal.Delete(id);
        }

        public void CancelChanged()
        {
            this.dal.CancelChanged();
        }

        public IQueryable<Product> GetAllProductEachType(string label)
        {
            return this.dal.GetAllProductEachType(label);
        }

        public List<dynamic> GetTopSaleProduct()
        {
            return this.dal.GetTopSaleProduct();
        }
    }
}
