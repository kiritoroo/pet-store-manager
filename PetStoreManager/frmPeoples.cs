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
using PetStoreManager.Properties;

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
            this.Load_Data_Customer();
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

            this.empSaleDetailDGV.DefaultCellStyle.Font = fontStype2;
            this.empPetOrderDGV.DefaultCellStyle.Font = fontStype2;
            this.empMerchandiseOrderDGV.DefaultCellStyle.Font = fontStype2;

            this.cusSalePetDetailDGV.DefaultCellStyle.Font = fontStype2;
            this.cusSaleMerchandiseDetailDGV.DefaultCellStyle.Font = fontStype2;

            this.supPetOrderDGV.DefaultCellStyle.Font = fontStype2;
            this.supMerchandiseOrderDGV.DefaultCellStyle.Font = fontStype2;
        }

        private void Load_Data_Customer()
        {
            this.cusBll = new customerManager();
            this.cusList = cusBll.GetAll().ToList();

            cusDGV.Columns.Clear();
            cusDGV.DataSource = null;
            cusDGV.Refresh();
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

            empDGV.Columns.Clear();
            empDGV.DataSource = null;
            empDGV.Refresh();
            empDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
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
            if (rsList1!=null)
            {
                cusSalePetDetailDGV.DataSource = rsList1;
            }
            else
            {
                cusSalePetDetailDGV.Rows.Clear();
                cusSalePetDetailDGV.Refresh();
            }
            this.cusSalePetCount.Text = cusBll.GetTotalSaleAnimalEachCustomer(this.cusList[_row]).ToString();
            this.cusTotalPetSaleMoney.Text = cusBll.GetTotalMoneyAnimalEachCustomer(this.cusList[_row]).ToString(sFormat) + " ₫";

            var rsList2 = cusBll.GetSaleMerchandiseDetailEachCustomer(this.cusList[_row]);
            if (rsList2!=null)
            {
                cusSaleMerchandiseDetailDGV.DataSource = rsList2;
            }
            else
            {
                cusSaleMerchandiseDetailDGV.Rows.Clear();
                cusSaleMerchandiseDetailDGV.Refresh();
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
            if (rsList1!=null)
            {
                empSaleDetailDGV.DataSource = rsList1.Select(rs => new
                {
                    SaleID = rs.ID,
                    Date = rs.saledate,
                    CustomerID = rs.CustomerID,
                    EmployeeID = rs.EmployeeID,
                    Tax = rs.SaleTax
                }).ToList();
            }
            else
            {
                empSaleDetailDGV.Rows.Clear();
                empSaleDetailDGV.Refresh();
            }
            this.empTotalSale.Text = empBll.GetTotalSaleEachEmployee(this.empList[_row]).ToString();

            var rsList2 = empBll.GetOrderAnimalDetailEachEmployee(this.empList[_row]);
            if (rsList2!=null)
            {
                empPetOrderDGV.DataSource = rsList2.Select(rs => new
                {
                    OrderID = rs.ID,
                    OrderDate = rs.OrderDate,
                    ReceiveDate = rs.ReceiveDate,
                    SupplierID = rs.SupplierID,
                    ShippingCost = rs.ShippingCost

                }).ToList();
            }
            else
            {
                empPetOrderDGV.Rows.Clear();
                empPetOrderDGV.Refresh();
            }
            this.empTotalPetOrder.Text = empBll.GetTotalOrderAnimalEachEmployee(this.empList[_row]).ToString();

            var rsList3 = empBll.GetOrderMerchandiseDetailEachEmployee(this.empList[_row]);
            if (rsList3!=null)
            {
                empMerchandiseOrderDGV.DataSource = rsList3.Select(rs => new
                {
                    OrderID = rs.ID,
                    OrderDate = rs.OrderDate,
                    ReceiveDate = rs.ReceiveDate,
                    SupplierID = rs.SupplierID,
                    ShippingCost = rs.ShippingCost

                }).ToList();
            }
            else
            {
                empMerchandiseOrderDGV.Rows.Clear();
                empMerchandiseOrderDGV.Refresh();
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
            else
            {
                supPetOrderDGV.Rows.Clear();
                supPetOrderDGV.Refresh();
            }
            this.supTotalPetOrder.Text = supBll.GetTotalOrderAnimalEachSupplier(this.supList[_row]).ToString();
            this.supTotalPetOrderMoney.Text = supBll.GetTotalCostAnimalEachSupplier(this.supList[_row]).ToString(sFormat) + " ₫";

            var rsList2 = supBll.GetOrderMerchandiseDetailEachSupplier(this.supList[_row]);
            if (rsList2!=null)
            {
                supMerchandiseOrderDGV.DataSource = rsList2;
            }
            else
            {
                supMerchandiseOrderDGV.Rows.Clear();
                supMerchandiseOrderDGV.Refresh();
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


            // Format Tabel
            cusDGV.DataBindingComplete += (obj, args) =>
            {
                if (cusDGV.Columns.Count < 7 && cusDGV.Columns.Count > 5)
                {
                    DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                    {
                        btnEdit.Name = "Edit";
                        btnEdit.HeaderText = "Edit";
                        btnEdit.Text = "Edit";
                        btnEdit.FlatStyle = FlatStyle.Popup;
                        btnEdit.DefaultCellStyle.BackColor = Color.FromArgb(248, 251, 255);
                        btnEdit.UseColumnTextForButtonValue = true;
                        this.cusDGV.Columns.Add(btnEdit);
                    }
                    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                    {
                        btnDelete.Name = "Delete";
                        btnDelete.HeaderText = "Delete";
                        btnDelete.Text = "Delete";
                        btnDelete.FlatStyle = FlatStyle.Popup;
                        btnDelete.DefaultCellStyle.BackColor = Color.FromArgb(248, 251, 255);
                        btnDelete.UseColumnTextForButtonValue = true;
                        this.cusDGV.Columns.Add(btnDelete);
                    }
                }
                cusDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                for (int i = 0; i < this.cusDGV.Rows.Count; i++)
                {
                    cusDGV.Rows[i].Height = 50;
                }
                cusDGV.Columns[0].Width = 100;
                cusDGV.Columns[1].Width = 150;
                cusDGV.Columns[2].Width = 200;
                cusDGV.Columns[3].Width = 200;
                cusDGV.Columns[4].Width = 150;
                cusDGV.Columns[5].Width = 150;
                cusDGV.Columns[6].Width = 80;
                cusDGV.Columns[7].Width = 80;
            };

            empDGV.DataBindingComplete += (obj, args) =>
            {
                if (empDGV.Columns.Count < 7 && cusDGV.Columns.Count > 5)
                {
                    DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                    {
                        btnEdit.Name = "Edit";
                        btnEdit.HeaderText = "Edit";
                        btnEdit.Text = "Edit";
                        btnEdit.FlatStyle = FlatStyle.Popup;
                        btnEdit.DefaultCellStyle.BackColor = Color.FromArgb(248, 251, 255);
                        btnEdit.UseColumnTextForButtonValue = true;
                        this.empDGV.Columns.Add(btnEdit);
                    }
                    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                    {
                        btnDelete.Name = "Delete";
                        btnDelete.HeaderText = "Delete";
                        btnDelete.Text = "Delete";
                        btnDelete.FlatStyle = FlatStyle.Popup;
                        btnDelete.DefaultCellStyle.BackColor = Color.FromArgb(248, 251, 255);
                        btnDelete.UseColumnTextForButtonValue = true;
                        this.empDGV.Columns.Add(btnDelete);
                    }
                }
                for (int i = 0; i < this.empDGV.Rows.Count; i++)
                {
                    empDGV.Rows[i].Height = 50;
                }
                empDGV.Columns[0].Width = 100;
                empDGV.Columns[1].Width = 150;
                empDGV.Columns[2].Width = 200;
                empDGV.Columns[3].Width = 200;
                empDGV.Columns[4].Width = 200;
                empDGV.Columns[5].Width = 200;
                empDGV.Columns[6].Width = 80;
                empDGV.Columns[7].Width = 80;
                empDGV.Refresh();
            };
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
            this.Event_ChoosePageCustomer(sender, e);
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
                    if (cusDGV.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                    {
                        if (e.ColumnIndex == cusDGV.Columns["Edit"].Index)
                            Console.WriteLine("Edit Customer ID = " + cusDGV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        if (e.ColumnIndex == cusDGV.Columns["Delete"].Index)
                            Console.WriteLine("Delete Customer ID = " + cusDGV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    }
                    else
                    {
                        this.GetCustomerDetailRecord(e.RowIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                cusSalePetDetailDGV.DataSource = null;
                cusSaleMerchandiseDetailDGV.DataSource = null;
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
