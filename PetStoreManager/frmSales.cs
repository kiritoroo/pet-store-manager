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
    
    public partial class frmSales : Form
    {
        CultureInfo cul;
        string groupSep;
        string sFormat;

        saleManager sBll;
        List<sale> sList; 
        public frmSales()
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
            for (int i = 0; i < this.salDGV.Columns.Count; i++)
            {
                this.salDGV.Columns[i].HeaderCell.Style.Font = fontStype1;
            }
            this.salDGV.DefaultCellStyle.Font = fontStype2;

            for (int i = 0; i < this.salPetDetailDGV.Columns.Count; i++)
            {
                this.salPetDetailDGV.Columns[i].HeaderCell.Style.Font = fontStype1;
            }
            this.salPetDetailDGV.DefaultCellStyle.Font = fontStype2;

            for (int i = 0; i < this.salMerchandseDetailDGV.Columns.Count; i++)
            {
                this.salMerchandseDetailDGV.Columns[i].HeaderCell.Style.Font = fontStype1;
            }
            this.salMerchandseDetailDGV.DefaultCellStyle.Font = fontStype2;
        }

        private void Load_Data_Sale()
        {
            this.sBll = new saleManager();
            this.sList = sBll.GetAll().ToList();

            this.salDGV.DataSource = sList.Select(s => new
            {
                ID = s.ID,
                SaleDate = s.saledate,
                EmployeeID = s.EmployeeID,
                CustomerID = s.CustomerID,
                SaleTax = s.SaleTax
            }).ToList();
            this.GetSaleDetailRecord(0);

            this.salSaleCount.Text = sBll.GetTotalBill().ToString();
            this.SettingDataGridView();
        }

        private void GetSaleDetailRecord(int _row)
        {
            // Get Detail Info
            salDGV.CurrentRow.Selected = true;
            salID.Text = salDGV.Rows[_row].Cells[0].FormattedValue.ToString();
            salDate.Text = salDGV.Rows[_row].Cells[1].FormattedValue.ToString();
            salTax.Text = salDGV.Rows[_row].Cells[2].FormattedValue.ToString();

            // Get Detail Work
            //------------------------------------------------- - Huy
            // - Thông tin khách hàng từng hóa đơn
            //Task Complete
            (string ID, string Phone, string ContactName) cusInfo = sBll.GetInfoCusEachSale(sList[_row]);
            salCusID.Text = cusInfo.ID;
            salCusPhone.Text = cusInfo.Phone;
            salCusName.Text = cusInfo.ContactName;


            // - Danh sách saleAnimal của từng hóa đơn
            //Task Complete
            var resultList1 = sBll.GetSalePetDetailEachSale(sList[_row]);
            if (resultList1.Any())
            {
                salPetDetailDGV.DataSource = resultList1.Select(rs => new
                {
                    ID = rs.SaleID,
                    AnimalID = rs.AnimalID,
                    SalePrice = rs.SalePrice
                }).ToList();
            }
            

            // - Tổng saleAnimal của từng hóa đơn
            // Task Complete
            this.salSalePetTotal.Text = sBll.GetTotalSalePetEachSale(sList[_row]).ToString();
            

            // - Tổng Animal của từng hóa đơn
            //Task Complete 
            this.salPetTotal.Text = sBll.GetTotalPetEachSale(sList[_row]).ToString();
            

            //------------------------------------------------- - Hieu
            /*// - Thông tin nhân viên từng hóa đơn
            //Task Uncomplete
            (string ID, string Phone, string FullName) empInfo = sBll.GetInfoEmpEachSale(sList[_row]);
            salEmpID.Text = empInfo.ID;
            salEmpPhone.Text = empInfo.Phone;
            salEmpName.Text = empInfo.FullName;
            */

            /*// - Danh sách saleMerchandise của từng hóa đơn
            //Task Uncomplete
            var resultList2 = sBll.GetSaleMerchandiseDetailEachSale(sList[_row]);
            if (resultList2.Any())
            {
                this.salMerchandseDetailDGV.DataSource = resultList2;
            }
            */

            /*// - Tổng saleMerchandise của từng hóa đơn
            //Task Uncomplete
            this.salSaleMerchandiseTotal.Text = sBll.GetTotalSaleMerchandiseEachSale(sList[_row]);
            */

            /*// - Tổng Merchandise của từng hóa đơn
            //Task Uncomplete
            this.salMerchandiseTotal.Text = sBll.GetTotalMerchandiseEachSale(sList[_row]);
            */
        }

        private void DelegateEvent()
        {
            this.Load += new EventHandler(this.Event_Load);

            this.salDGV.CellMouseClick += Event_GetSaleDetailRecord;
        }

        private void Event_Load(object sender, EventArgs e)
        {
            this.Load -= Event_Load;
            this.Load_Data_Sale();
        }

        private void Event_GetSaleDetailRecord(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (salDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    this.GetSaleDetailRecord(e.RowIndex);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }
        }

        private void bunifuPanel10_Click(object sender, EventArgs e)
        {

        }
    }
}
