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
    public class bllCustomer
    {
        dalCustomer dal = new dalCustomer();

        public void Load()
        {
            this.dal.Load();
        }

        public ObservableCollection<Customer> GetLocal()
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

        public IQueryable<Customer> GetAll()
        {
            return this.dal.GetAll();
        }

        public Customer Find(int id)
        {
            return this.dal.Find(id);
        }

        public void Save(Customer customer)
        {
            this.dal.Save(customer);
        }

        public void Modify(Customer customer)
        {
            this.dal.Modify(customer);
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

        public int GetTotalCustomer()
        {
            return this.dal.GetTotalCustomer();
        }

        public int GetTotalCustomerInMonth(string _year, string _month)
        {
            return this.dal.GetTotalCustomerInMonth(_year, _month);
        }

        public List<dynamic> GetSalePetDetailEachCustomer(Customer customer)
        {
            try
            {
                return this.dal.GetSalePetDetailEachCustomer(customer);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public List<dynamic> GetSaleProductDetailEachCustomer(Customer customer)
        {
            try
            {
                return this.dal.GetSaleProductDetailEachCustomer(customer);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public int GetTotalSalePetEachCustomer(Customer customer)
        {
            return this.dal.GetTotalSalePetEachCustomer(customer);
        }

        public decimal GetTotalMoneyPetEachCustomer(Customer customer)
        {
            return this.dal.GetTotalMoneyPetEachCustomer(customer);
        }

        public int GetTotalSaleProductEachCustomer(Customer customer)
        {
            return this.dal.GetTotalSaleProductEachCustomer(customer);
        }

        public decimal GetTotalMoneyProductEachCustomer(Customer customer)
        {
            return this.dal.GetTotalMoneyProductEachCustomer(customer);
        }
    }
}
