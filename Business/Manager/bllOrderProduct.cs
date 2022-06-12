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
    public class bllOrderProduct
    {
        dalOrderProduct dal = new dalOrderProduct();

        public void Load()
        {
            this.dal.Load();
        }

        public ObservableCollection<OrderProduct> GetLocal()
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

        public IQueryable<OrderProduct> GetAll()
        {
            return this.dal.GetAll();
        }

        public OrderProduct Find(int orderID, int productID)
        {
            return this.dal.Find(orderID, productID);
        }

        public void Save(OrderProduct orderProduct)
        {
            this.dal.Save(orderProduct);
        }

        public void Modify(OrderProduct orderProduct)
        {
            this.dal.Modify(orderProduct);
        }

        public void Delete(int orderID, int productID)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.dal.Delete(orderID, productID);
        }

        public void CancelChanged()
        {
            this.dal.CancelChanged();
        }
    }
}
