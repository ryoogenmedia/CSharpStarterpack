namespace SharpStarter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            this.panelSubSetting.Visible = false;
        }

        private void hideSubMenus()
        {
            if (this.panelSubSetting.Visible)
            {
                this.panelSubSetting.Visible = false;
            }
        }

        private void showSubMenus(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        // BUTTON SETTING
        private void btnSetting_Click(object sender, EventArgs e)
        {
            showSubMenus(this.panelSubSetting);
        }
        

        // BUTTON DASHBOARD
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            hideSubMenus();
        }
    }
}
