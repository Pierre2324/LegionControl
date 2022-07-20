namespace LegionControl
{
    public partial class formMain : Form
    {
        private Button currentBtn;
        private string currentBtnStr;
        private Form currentForm;

        public formMain()
        {
            InitializeComponent();
        }

        private void btnStatus_CLick(object sender, EventArgs e)
        {
            openChildForm(new Forms.formStatus(), sender);
            activateButton(sender, "Status");
        }

        private void btnFanCurve_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.formFanCurve(), sender);
            activateButton(sender, "FanCurve");
        }

        private void btnPowerModes_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.formPowerModes(), sender);
            activateButton(sender, "PowerModes");
        }

        private void btnBattery_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.formBattery(), sender);
            activateButton(sender, "Battery");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.formSettings(), sender);
            activateButton(sender, "Settings");
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

        private void mainForm_Load(object sender, EventArgs e)
        {
            //Open status page on app load
            openChildForm(new Forms.formStatus(), (Button)btnStatus);

            //Make the status button cyan when the app is launched
            currentBtn = (Button)btnStatus;
            currentBtn.BackColor = Color.Cyan;
            currentBtn.ForeColor = Color.Black;
            currentBtn.Image = LegionControl.Properties.Resources.StatusOn;
            currentBtnStr = "StatusOn";
        }

        private void activateButton(object btnSender, string btnSenderStr)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    //Off
                    currentBtn.BackColor = Color.FromArgb(255, 25, 25, 25);
                    currentBtn.ForeColor = Color.White;
                    currentBtnStr = currentBtnStr.Remove(currentBtnStr.Length - 2, 2);
                    currentBtnStr += "Off";
                    currentBtn.Image = (Image)LegionControl.Properties.Resources.ResourceManager.GetObject(currentBtnStr);

                    //On
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = Color.Cyan;
                    currentBtn.ForeColor = Color.Black;
                    currentBtnStr = btnSenderStr + "On";
                    currentBtn.Image = (Image)LegionControl.Properties.Resources.ResourceManager.GetObject(currentBtnStr);

                }
            }
        }

        private void openChildForm(Form childForm, object btnSender)
        {
            if(currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelWindow.Controls.Add(childForm);
            this.panelWindow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
    }
}