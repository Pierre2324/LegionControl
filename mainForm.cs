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
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }
        private void btnStatus_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnStatus.ClientRectangle,
               Color.Cyan, 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }
        private void btnFanCurve_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnFanCurve.ClientRectangle,
               Color.Cyan, 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }
    }
}