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
    public class bllPetCategory
    {
        dalPetCategory dal = new dalPetCategory();

        public void Load()
        {
            this.dal.Load();
        }

        public ObservableCollection<PetCategory> GetLocal()
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

        public IQueryable<PetCategory> GetAll()
        {
            return this.dal.GetAll();
        }

        public PetCategory Find(string id)
        {
            return this.dal.Find(id);
        }

        public void Save(PetCategory petCategory)
        {
            this.dal.Save(petCategory);
        }

        public void Modify(PetCategory petCategory)
        {
            this.dal.Modify(petCategory);
        }

        public void Delete(string id)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.dal.Delete(id);
        }

        public IQueryable<Pet> GetAllPetEachType(string label)
        {
            return this.dal.GetAllPetEachType(label);
        }

        public void CancelChanged()
        {
            this.dal.CancelChanged();
        }

        public List<dynamic> GetTopSalePetCategory()
        {
            return this.dal.GetTopSalePetCategory();
        }
        public int GetTotalPetEachType(string label)
        {
            return this.dal.GetTotalPetEachType(label);
        }
    }
}
