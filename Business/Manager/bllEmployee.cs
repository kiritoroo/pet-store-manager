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
    public class bllEmployee
    {
        dalEmployee dal = new dalEmployee();

        public void Load()
        {
            this.dal.Load();
        }

        public ObservableCollection<Employee> GetLocal()
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

        public IQueryable<Employee> GetAll()
        {
            return this.dal.GetAll();
        }

        public Employee Find(int id)
        {
            return this.dal.Find(id);
        }

        public void Save(Employee employee)
        {
            this.dal.Save(employee);
        }

        public void Modify(Employee employee)
        {
            this.dal.Modify(employee);
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

        public int GetTotalEmployee()
        {
            return this.dal.GetTotalEmployee();
        }

        public List<Sale> GetSaleDetailEachEmployee(Employee employee)
        {
            return this.dal.GetSaleDetailEachEmployee(employee);
        }

        public List<Order> GetOrderDetailEachEmployee(Employee employee)
        {
            return this.dal.GetOrderDetailEachEmployee(employee);
        }

        public int GetTotalSaleEachEmployee(Employee employee)
        {
            return this.dal.GetTotalSaleEachEmployee(employee);
        }

        public int GetTotalOrderEachEmployee(Employee employee)
        {
            return this.dal.GetTotalOrderEachEmployee(employee);
        }

        public Employee FindEmployeeByFullName(string fullName)
        {
            return this.dal.FindEmployeeByFullName(fullName);
        }
    }
}
