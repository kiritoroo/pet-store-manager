using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Manager;
using Entities.Models;

namespace PetStoreManager
{
    public partial class frmPeoples : Form
    {
        CultureInfo cul;
        string groupSep;
        string sFormat;

        customerManager cusBll;
        List<customer> cusList;

        employeeManager empBll;
        List<employee> empList;

        supplierManager supBll;
        List<supplier> supList;

        public frmPeoples()
        {
            InitializeComponent();

            cul = CultureInfo.CurrentCulture;
            groupSep = cul.NumberFormat.CurrencyGroupSeparator;//groupSep=','
            sFormat = string.Format("#{0}###", groupSep);

            this.DelegateEvent();
        }

        private void SettingDataGridView()
        {
            Font fontStype1 = new Font("Segoe UI", 12, FontStyle.Bold);
            Font fontStype2 = new Font("Segoe UI", 10);
            for (int i = 0; i < this.cusDGV.Columns.Count; i++)
            {
                this.cusDGV.Columns[i].HeaderCell.Style.Font = fontStype1;
            }
            this.cusDGV.DefaultCellStyle.Font = fontStype2;

            for (int i = 0; i < this.empDGV.Columns.Count; i++)
            {
                this.empDGV.Columns[i].HeaderCell.Style.Font = fontStype1;
            }
            this.empDGV.DefaultCellStyle.Font = fontStype2;

            for (int i = 0; i < this.supDGV.Columns.Count; i++)
            {
                this.supDGV.Columns[i].HeaderCell.Style.Font = fontStype1;
            }
            this.supDGV.DefaultCellStyle.Font = fontStype2;
        }

        private void Load_Data_Customer()
        {
            this.cusBll = new customerManager();
            this.cusList = cusBll.GetAll().ToList();

            this.cusDGV.DataSource = cusList.Select(cus => new
            {
                ID = cus.ID,
                Phone = cus.Phone,
                ContactName = cus.ContactName,
                Address = cus.Address,
                Country = cus.Country,
                DateAdd = cus.DateAdd
            }).ToList();
            this.GetCustomerDetailRecord(0);

            this.cusCount.Text = cusBll.GetTotalCustomer().ToString();
            this.SettingDataGridView();
        }

        private void Load_Data_Employee()
        {
            this.empBll = new employeeManager();
            this.empList = empBll.GetAll().ToList();

            this.empDGV.DataSource = empList.Select(emp => new
            {
                ID = emp.ID,
                Phone = emp.Phone,
                FirstName = emp.FristName,
                LastName = emp.LastName,
                Address = emp.Address,
                DateHired = emp.DataHired
            }).ToList();
            this.GetEmployeeDetailRecord(0);

            this.emptCount.Text = empBll.GetTotalEmployee().ToString();
            this.SettingDataGridView();
        }

        private void Load_Data_Supplier()
        {
            this.supBll = new supplierManager();
            this.supList = supBll.GetAll().ToList();

            this.supDGV.DataSource = supList.Select(sup => new
            {
                ID = sup.ID,
                Phone = sup.Phone,
                ContactName = sup.Name,
                Address = sup.Address,
                Country = sup.Country
            }).ToList();
            this.GetSupplierDetailRecord(0);

            this.supCount.Text = supBll.GetTotalSupplier().ToString();
            this.SettingDataGridView();
        }

        private void GetCustomerDetailRecord(int _row)
        {
            // Get Detail Info
            cusDGV.CurrentRow.Selected = true;
            cusIdTextBox.Text = cusDGV.Rows[_row].Cells[0].FormattedValue.ToString();
            cusPhoneTextBox.Text = cusDGV.Rows[_row].Cells[1].FormattedValue.ToString();
            cusContactNameTextBox.Text = cusDGV.Rows[_row].Cells[2].FormattedValue.ToString();
            cusAddressTextBox.Text = cusDGV.Rows[_row].Cells[3].FormattedValue.ToString();
            cusCountryTextBox.Text = cusDGV.Rows[_row].Cells[4].FormattedValue.ToString();
            cusDateAdd.Text = cusDGV.Rows[_row].Cells[5].FormattedValue.ToString();

            // Get Detail Work
            var rsList1 = cusBll.GetSaleAnimalDetailEachCustomer(this.cusList[_row]);
            if (rsList1.Any())
            {
                cusSalePetDetailDGV.DataSource = rsList1;
            }
            this.cusSalePetCount.Text = cusBll.GetTotalSaleAnimalEachCustomer(this.cusList[_row]).ToString();
            this.cusTotalPetSaleMoney.Text = cusBll.GetTotalMoneyAnimalEachCustomer(this.cusList[_row]).ToString(sFormat) + " ₫";

            var rsList2 = cusBll.GetSaleMerchandiseDetailEachCustomer(this.cusList[_row]);
            if (rsList2.Any())
            {
                cusSaleMerchandiseDetailDGV.DataSource = rsList2;
            }
            this.cusSaleMerchandiseCount.Text = cusBll.GetTotalSaleMerchandiseEachCustomer(this.cusList[_row]).ToString();
            this.cusTotalSaleMerchandiseMoney.Text = cusBll.GetTotalMoneyMerchandiseEachCustomer(this.cusList[_row]).ToString(sFormat) + " ₫"; ;
        }

        private void GetEmployeeDetailRecord(int _row)
        {
            // Get Detail Info
            empDGV.CurrentRow.Selected = true;
            empId.Text = empDGV.Rows[_row].Cells[0].FormattedValue.ToString();
            empPhone.Text = empDGV.Rows[_row].Cells[1].FormattedValue.ToString();
            empFirstname.Text = empDGV.Rows[_row].Cells[2].FormattedValue.ToString();
            empLastName.Text = empDGV.Rows[_row].Cells[3].FormattedValue.ToString();
            empAddress.Text = empDGV.Rows[_row].Cells[4].FormattedValue.ToString();
            empDateHired.Text = empDGV.Rows[_row].Cells[5].FormattedValue.ToString();

            // Get Detail Work
            var rsList1 = empBll.GetSaleDetailEachEmployee(this.empList[_row]);
            if (rsList1.Any())
            {
                empSaleDetailDGV.DataSource = rsList1;
            }
            this.empTotalSale.Text = empBll.GetTotalSaleEachEmployee(this.empList[_row]).ToString();

            var rsList2 = empBll.GetOrderAnimalDetailEachEmployee(this.empList[_row]);
            if (rsList2.Any())
            {
                empPetOrderDGV.DataSource = rsList2;
            }
            this.empTotalPetOrder.Text = empBll.GetTotalOrderAnimalEachEmployee(this.empList[_row]).ToString();

            var rsList3 = empBll.GetOrderMerchandiseDetailEachEmployee(this.empList[_row]);
            if (rsList3.Any())
            {
                empMerchandiseOrderDGV.DataSource = rsList3;
            }
            this.empTotalMerchandiseOrder.Text = empBll.GetTotalOrderMerchandiseEachEmployee(this.empList[_row]).ToString();

        }

        private void GetSupplierDetailRecord(int _row)
        {
            // Get Detail Info
            supDGV.CurrentRow.Selected = true;
            supId.Text = supDGV.Rows[_row].Cells[0].FormattedValue.ToString();
            supPhone.Text = supDGV.Rows[_row].Cells[1].FormattedValue.ToString();
            supContactName.Text = supDGV.Rows[_row].Cells[2].FormattedValue.ToString();
            supAddress.Text = supDGV.Rows[_row].Cells[3].FormattedValue.ToString();
            supCountry.Text = supDGV.Rows[_row].Cells[4].FormattedValue.ToString();

            // Get Detail Work
            var rsList1 = supBll.GetOrderAnimalDetailEachSupplier(this.supList[_row]);
            if (rsList1!=null)
            {
                supPetOrderDGV.DataSource = rsList1;
            }
            this.supTotalPetOrder.Text = supBll.GetTotalOrderAnimalEachSupplier(this.supList[_row]).ToString();
            this.supTotalPetOrderMoney.Text = supBll.GetTotalCostAnimalEachSupplier(this.supList[_row]).ToString(sFormat) + " ₫";

            var rsList2 = supBll.GetOrderMerchandiseDetailEachSupplier(this.supList[_row]);
            if (rsList2!=null)
            {
                supMerchandiseOrderDGV.DataSource = rsList2;
            }
            this.supTotalMerchandiseOrder.Text = supBll.GetTotalOrderMerchandiseEachSupplier(this.supList[_row]).ToString();
            this.supTotalMerchandiseOrderMoney.Text = supBll.GetTotalCostMerchandiseEachSupplier(this.supList[_row]).ToString(sFormat) + " ₫";
        }

        #region Event
        private void DelegateEvent()
        {
            this.Load += new EventHandler(this.Event_Load);

            this.cusChoose.Click += new EventHandler(this.Event_ChoosePageCustomer);
            this.empChoose.Click += new EventHandler(this.Event_ChoosePageEmployee);
            this.supChoose.Click += new EventHandler(this.Event_ChoosePageSupplier);

            this.cusDGV.CellMouseClick += Event_GetCustomerDetailRecord;
            this.empDGV.CellMouseClick += Event_GetEmployeeDetailRecord;
            this.supDGV.CellMouseClick += Event_GetSupplierDetailRecord;

            // Format Money
            cusSalePetDetailDGV.CellFormatting += (obj, args) =>
            {
                if (args.RowIndex >= 0 &&
                    args.ColumnIndex == 3 &&
                    args.Value != null)
                {
                    args.Value = int.Parse(args.Value.ToString()).ToString(sFormat) + " ₫";
                }
            };
            cusSaleMerchandiseDetailDGV.CellFormatting += (obj, args) =>
            {
                if (args.RowIndex >= 0 &&
                    args.ColumnIndex == 3 &&
                    args.Value != null)
                {
                    args.Value = int.Parse(args.Value.ToString()).ToString(sFormat) + " ₫";
                }
            };
            supPetOrderDGV.CellFormatting += (obj, args) =>
            {
                if (args.RowIndex >= 0 &&
                    args.ColumnIndex == 3 &&
                    args.Value != null)
                {
                    args.Value = int.Parse(args.Value.ToString()).ToString(sFormat) + " ₫";
                }
            };
            supMerchandiseOrderDGV.CellFormatting += (obj, args) =>
            {
                if (args.RowIndex >= 0 &&
                    args.ColumnIndex == 3 &&
                    args.Value != null)
                {
                    args.Value = int.Parse(args.Value.ToString()).ToString(sFormat) + " ₫";
                }
            };
        }

        private void Event_Load(object sender, EventArgs e)
        {
            this.Load -= Event_Load;
            this.Load_Data_Customer();
        }

        private void Event_ChoosePageCustomer(object sender, EventArgs e)
        {
            this.pageController.SetPage(0);
            this.Load_Data_Customer();
        }

        private void Event_ChoosePageEmployee(object sender, EventArgs e)
        {
            this.pageController.SetPage(1);
            this.Load_Data_Employee();
        }

        private void Event_ChoosePageSupplier(object sender, EventArgs e)
        {
            this.pageController.SetPage(2);
            this.Load_Data_Supplier();
        }

        private void Event_GetCustomerDetailRecord(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (cusDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    this.GetCustomerDetailRecord(e.RowIndex);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }
        }

        private void Event_GetEmployeeDetailRecord(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (empDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    this.GetEmployeeDetailRecord(e.RowIndex);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }
        }

        private void Event_GetSupplierDetailRecord(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (supDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    this.GetSupplierDetailRecord(e.RowIndex);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }
        }
        #endregion
    }
}
