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
    class bllOrderPet
    {
        dalOrderPet dal = new dalOrderPet();

        public void Load()
        {
            this.dal.Load();
        }

        public ObservableCollection<OrderPet> GetLocal()
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

        public IQueryable<OrderPet> GetAll()
        {
            return this.dal.GetAll();
        }

        public OrderPet Find(int orderID, string petID)
        {
            return this.dal.Find(orderID, petID);
        }

        public void Save(OrderPet orderPet)
        {
            this.dal.Save(orderPet);
        }

        public void Modify(OrderPet orderPet)
        {
            this.dal.Modify(orderPet);
        }

        public void Delete(int orderID, string petID)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.dal.Delete(orderID, petID);
        }

        public void CancelChanged()
        {
            this.dal.CancelChanged();
        }
    }
}
