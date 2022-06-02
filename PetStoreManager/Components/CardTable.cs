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
    public partial class CardTable : UserControl
    {
        private Color default_color;
        private Color default_color_background;
        private Color default_color_panel;
        private Color default_color_line;

        public CardTable()
        {
            InitializeComponent();
            this.DelegateEvent();
        }

        #region Properties
        [Category("Custom Properties")]
        private frmDashboard _formParent;

        public frmDashboard FormParent
        {
            get { return _formParent; }
            set { _formParent = value; }
        }

        [Category("Custom Properties")]
        private Image _ctIcon;

        public Image CtIcon
        {
            get { return _ctIcon; }
            set { _ctIcon = value; this.ctIcon.Image = value; }
        }

        [Category("Custom Properties")]
        private string _ctLabel;

        public string CtLabel 
        {
            get { return _ctLabel; }
            set { _ctLabel = value; this.ctLabel.Text = value; }
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
            set { _colorPanel = value; this.ctPanelEffect.BackgroundColor = value; this.default_color_panel = value;  }
        }


        [Category("Custom Properties")]
        private Color _colorLineSmall;

        public Color ColorLineSmall
        {
            get { return _colorLineSmall; }
            set { _colorLineSmall = value; this.ctLineEffect.BorderColor = value; this.default_color_line = value; }
        }
        #endregion

        #region Events
        private void DelegateEvent()
        {
            this.Load += new EventHandler(this.Event_Load);

            this.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.ctArrowEffect.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.ctIcon.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.ctLabel.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.ctLineEffect.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);
            this.ctPanelEffect.MouseMove += new MouseEventHandler(this.Event_Mouse_Move);

            this.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.ctArrowEffect.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.ctIcon.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.ctLabel.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.ctLineEffect.MouseLeave += new EventHandler(this.Event_Mouse_Leave);
            this.ctPanelEffect.MouseLeave += new EventHandler(this.Event_Mouse_Leave);

            this.MouseClick += new MouseEventHandler(this.Event_Mouse_Click);
            this.ctArrowEffect.MouseClick += new MouseEventHandler(this.Event_Mouse_Click);
            this.ctIcon.MouseClick += new MouseEventHandler(this.Event_Mouse_Click);
            this.ctLabel.MouseClick += new MouseEventHandler(this.Event_Mouse_Click);
            this.ctLineEffect.MouseClick += new MouseEventHandler(this.Event_Mouse_Click);
            this.ctPanelEffect.MouseClick += new MouseEventHandler(this.Event_Mouse_Click);
        }

        private void Event_Load(object sender, EventArgs e)
        {
            this.BackColor = this.default_color_background;
            this.ctPanelEffect.BackgroundColor = this.default_color;
            this.ctLineEffect.BorderColor = this.default_color;
            this.ctArrowEffect.Visible = false;
        }

        private void Event_Mouse_Move(object sender, MouseEventArgs e)
        {
            this.BackColor = this.default_color_panel;
            this.ctPanelEffect.BackgroundColor = this.default_color_panel;
            this.ctLineEffect.BorderColor = this.default_color_line;
            this.ctArrowEffect.Visible = true;
        }

        private void Event_Mouse_Leave(object sender, EventArgs e)
        {
            this.BackColor = this.default_color_background;
            this.ctPanelEffect.BackgroundColor = this.default_color;
            this.ctLineEffect.BorderColor = this.default_color;
            this.ctArrowEffect.Visible = false;
        }

        private void Event_Mouse_Click(object sender, MouseEventArgs e)
        {
            this.FormParent.mainEffectPanel.BackgroundColor = this.default_color_panel;
        }
        #endregion
    }
}
