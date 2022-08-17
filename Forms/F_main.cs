using LegionControl.Utils;

namespace LegionControl
{
    public partial class F_main : Form
    {
        Memory memory = new Memory();

        Button currentBtn;
        string currentBtnStr;
        Form currentForm;

        static System.Windows.Forms.Timer timerLabelsRTS = new System.Windows.Forms.Timer();

        int exitValue;

        public F_main()
        {
            InitializeComponent();

            DeviceDetection.Initialize();
            memory.Initialize();

            labelModel.Text = DeviceDetection.model;

            timerLabelsRTS.Tick += timerLabelsRTS_Tick;
            timerLabelsRTS.Interval = 1500;
            timerLabelsRTS.Start();

            //Open status page on app load
            OpenChildForm(new Forms.F_status(), (Button)btnStatus);

            //Make the status button cyan when the app is launched
            currentBtn = (Button)btnStatus;
            currentBtn.BackColor = Color.Cyan;
            currentBtn.ForeColor = Color.Black;
            currentBtn.Image = LegionControl.Properties.Resources.StatusOn;
            currentBtnStr = "StatusOn";


        }

        private void timerLabelsRTS_Tick(object sender, EventArgs e)
        {
            if (exitValue == 0)
            {
                RealTimeStats.GetRTS();

                Invoke((Action)delegate () { labelRpmCPU_RTS.Text = RealTimeStats.rpmCurrentCPU + " RPM"; });
                Invoke((Action)delegate () { labelRpmGPU_RTS.Text = RealTimeStats.rpmCurrentGPU + " RPM"; });
                Invoke((Action)delegate () { labelTempCPU_RTS.Text = RealTimeStats.tempCurrentCPU + " °C"; });
                Invoke((Action)delegate () { labelTempGPU_RTS.Text = RealTimeStats.tempCurrentGPU + " °C"; });

                Application.DoEvents();
            }
        }

        private void btnStatus_CLick(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.F_status(), sender);
            ActivateButton(sender, "Status");
            labelCurrentPage.Text = "Status";
        }

        private void btnFanCurve_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.F_fanCurve(), sender);
            ActivateButton(sender, "FanCurve");
            labelCurrentPage.Text = "FanCurve";
        }

        private void btnPowerModes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.F_powerModes(), sender);
            ActivateButton(sender, "PowerModes");
            labelCurrentPage.Text = "PowerModes";
        }

        private void btnBattery_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.F_Battery(), sender);
            ActivateButton(sender, "Battery");
            labelCurrentPage.Text = "Battery";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.F_settings(), sender);
            ActivateButton(sender, "Settings");
            labelCurrentPage.Text = "Settings";
        }

        private void ActivateButton(object btnSender, string btnSenderStr)
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

        private void OpenChildForm(Form childForm, object btnSender)
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

        private void Exit(object sender, FormClosingEventArgs e)
        {
            exitValue = 1;
            using StreamWriter file = new("t.txt");
            memory.Exit();
            file.WriteLineAsync("ll");
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
        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelTop.ClientRectangle,
               Color.Cyan, 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void labelTextCPU_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, labelTextCPU.ClientRectangle,
               Color.Cyan, 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void labelTextGPU_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, labelTextGPU.ClientRectangle,
                Color.Cyan, 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void labelTempCPU_RTS_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, labelTempCPU_RTS.ClientRectangle,
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void labelTempGPU_RTS_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, labelTempGPU_RTS.ClientRectangle,
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void labelRpmCPU_RTS_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, labelRpmCPU_RTS.ClientRectangle,
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void labelRpmGPU_RTS_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, labelRpmGPU_RTS.ClientRectangle,
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void panelCurrentPage_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelCurrentPage.ClientRectangle,
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void panelRTS_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelRTS.ClientRectangle,
               Color.Cyan, 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void panelModel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelRTS.ClientRectangle,
               Color.Cyan, 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(255, 25, 25, 25), 1, ButtonBorderStyle.Solid, // top
               Color.Cyan, 1, ButtonBorderStyle.Solid, // right
               Color.Cyan, 1, ButtonBorderStyle.Solid);// bottom
        }
    }
}