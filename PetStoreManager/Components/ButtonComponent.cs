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
    public partial class ButtonComponent : UserControl
    {
        private Color default_color;
        private Color default_color_background;
        private Color default_color_panel;
        private Color default_color_line;

        public ButtonComponent()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 115, 196);
            this.effectPanelComp.BackgroundColor = Color.FromArgb(31, 132, 203);
            this.effectLineComp.BorderColor = Color.FromArgb(52, 143, 206);
        }

        #region Properties
        [Category("Custom Properties")]
        private Image _image;

        public Image Image
        {
            get { return _image; }
            set { _image = value; this.imgComp.Image = value; }
        }

        [Category("Custom Properties")]
        private string _title;

        public string Title 
        {
            get { return _title; }
            set { _title = value; this.titleComp.Text = value; }
        }

        [Category("Custom Properties")]
        private Color _colorBackground;

        public Color ColorBackground 
        {
            get { return _colorBackground; }
            set { _colorBackground = value; this.BackColor = value; this.default_color_background = value;  this.default_color = value; }
        }

        [Category("Custom Properties")]
        private Color _colorPanel;

        public Color ColorPanel
        {
            get { return _colorPanel; }
            set { _colorPanel = value; this.effectPanelComp.BackgroundColor = value; this.default_color_panel = value;  }
        }


        [Category("Custom Properties")]
        private Color _colorLineSmall;

        public Color ColorLineSmall
        {
            get { return _colorLineSmall; }
            set { _colorLineSmall = value; this.effectLineComp.BorderColor = value; this.default_color_line = value; }
        }
        #endregion

        private void ButtonComponent_Load(object sender, EventArgs e)
        {
            this.BackColor = this.default_color_background;
            this.effectPanelComp.BackgroundColor = this.default_color;
            this.effectLineComp.BorderColor = this.default_color;
            this.arrowIconComp.Visible = false;
        }

        private void ButtonComponent_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = this.default_color_panel;
            this.effectPanelComp.BackgroundColor = this.default_color_panel;
            this.effectLineComp.BorderColor = this.default_color_line;
            this.arrowIconComp.Visible = true;
        }

        private void ButtonComponent_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = this.default_color_background;
            this.effectPanelComp.BackgroundColor = this.default_color;
            this.effectLineComp.BorderColor = this.default_color;
            this.arrowIconComp.Visible = false;
        }

        private void ButtonComponent_Click(object sender, EventArgs e)
        {

        }
    }
}
