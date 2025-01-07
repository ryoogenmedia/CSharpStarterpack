namespace SharpStarter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            openChildFrom(new Form3());
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
            openChildFrom(new Form3());
            hideSubMenus();
        }

        private void btnAkun_Click(object sender, EventArgs e)
        {
            hideSubMenus();
            openChildFrom(new Form2());
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            hideSubMenus();
        }

        private Form acitiveForm = null;
        private void openChildFrom(Form childForm)
        {
            if(acitiveForm != null)
                acitiveForm.Close();
            acitiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
