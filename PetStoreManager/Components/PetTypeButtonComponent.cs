using PetStoreManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStoreManager.Components
{
    public partial class PetTypeButtonComponent : UserControl
    {
        public Color color_default;
        public Color color_hover;
        public PetTypeButtonComponent()
        {
            InitializeComponent();
        }

        #region Properties
        [Category("Custom Properties")]
        private Image _image;   

        public Image Image
        {
            get { return _image; }
            set { _image = value; this.iconComp.Image = value; }
        }

        [Category("Custom Properties")]
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; this.titleComp.Text = value; }
        }

        [Category("Custom Properties")]
        private string _idText;

        public string IdText
        {
            get { return _idText; }
            set { _idText = value; this.idComp.Text = value;  }
        }
        #endregion


        private void PetTypeButtonComponent_Load(object sender, EventArgs e)
        {
            this.color_default = Color.FromArgb(34, 45, 49);
            this.color_hover = Color.FromArgb(81, 92, 99);
            this.BackColor = this.color_default;
        }

        private void PetTypeButtonComponent_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = this.color_hover;
        }

        private void PetTypeButtonComponent_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = this.color_default;
        }

        private void PetTypeButtonComponent_Click(object sender, EventArgs e)
        {

        }
    }
}
