namespace LegionControl
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnStatus_CLick(object sender, EventArgs e)
        {

        }
        private void btnFanCurve_Click(object sender, EventArgs e)
        {

        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, menuPanel.ClientRectangle,
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid);// bottom
        }
        private void btnStatus_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnStatus.ClientRectangle,
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // left
               Color.Cyan, 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }
        private void btnFanCurve_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnFanCurve.ClientRectangle,
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }
        private void btnPowerModes_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnPowerModes.ClientRectangle,
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }
        private void btnBattery_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnBattery.ClientRectangle,
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }
        private void btnSettings_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnSettings.ClientRectangle,
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boxLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnPowerModes_Click(object sender, EventArgs e)
        {

        }
    }
}