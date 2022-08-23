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
    public class bllSales
    {
        dalSales dal = new dalSales();

        public void Load()
        {
            this.dal.Load();
        }

        public ObservableCollection<Sale> GetLocal()
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

        public IQueryable<Sale> GetAll()
        {
            return this.dal.GetAll();
        }

        public Sale Find(int id)
        {
            return this.dal.Find(id);
        }

        public void Save(Sale sale)
        {
            this.dal.Save(sale);
        }

        public void Modify(Sale sale)
        {
            this.dal.Modify(sale);
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

        public decimal GetTotalIncome()
        {
            return this.dal.GetTotalIncome();
        }

        public decimal GetTotalIncomeInMonth(string _year, string _month)
        {
            return this.dal.GetTotalIncomeInMonth(_year, _month);
        }

        public int GetTotalPetSalesInMonth(string _year, string _month)
        {
            return this.dal.GetTotalPetSalesInMonth(_year, _month);
        }

        public int GetTotalProductSalesInMonth(string _year, string _month)
        {
            return this.dal.GetTotalProductSalesInMonth(_year, _month);
        }

        public List<SalesPet> GetSalePetEachSale(Sale sale)
        {
            return this.dal.GetSalePetEachSale(sale);
        }

        public List<SalesProduct> GetSaleProductEachSale(Sale sale)
        {
            return this.dal.GetSaleProductEachSale(sale);
        }

        public (string ContactName, string Phone, string Address) GetInfoCustomerEachSale(Sale sale)
        {
            return this.dal.GetInfoCustomerEachSale(sale);
        }

        public (string FullName, string Phone) GetInfoEmployeeEachSale(Sale sale)
        {
            return this.dal.GetInfoEmployeeEachSale(sale);
        }

        public int GetTotalPetEachSale(Sale sale)
        {
            return this.dal.GetTotalPetEachSale(sale);
        }

        public decimal GetTotalMoneyPetEachSale(Sale sale)
        {
            return this.dal.GetTotalMoneyPetEachSale(sale);
        }

        public int GetTotalProductEachSale(Sale sale)
        {
            return this.dal.GetTotalProductEachSale(sale);
        }

        public decimal GetTotalMoneyProductEachSale(Sale sale)
        {
            return this.dal.GetTotalMoneyProductEachSale(sale);
        }

        public Voucher GetInfoVoucherEachSale(Sale sale)
        {
            return this.dal.GetInfoVoucherEachSale(sale);
        }

        public (bool result, String message) CreateBill(Sale sale)
        {
            return this.dal.CreateBill(sale);
        }
    }
}
