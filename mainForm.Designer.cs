namespace LegionControl
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnBattery = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnPowerModes = new System.Windows.Forms.Button();
            this.btnFanCurve = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.boxLogo = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menuPanel.Controls.Add(this.btnSettings);
            this.menuPanel.Controls.Add(this.btnBattery);
            this.menuPanel.Controls.Add(this.btnStatus);
            this.menuPanel.Controls.Add(this.btnPowerModes);
            this.menuPanel.Controls.Add(this.btnFanCurve);
            this.menuPanel.Controls.Add(this.panelLogo);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.menuPanel.Size = new System.Drawing.Size(200, 700);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::LegionControl.Properties.Resources.Settings;
            this.btnSettings.Location = new System.Drawing.Point(0, 400);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 50);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSettings_Paint);
            // 
            // btnBattery
            // 
            this.btnBattery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnBattery.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnBattery.FlatAppearance.BorderSize = 0;
            this.btnBattery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBattery.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBattery.ForeColor = System.Drawing.Color.White;
            this.btnBattery.Image = global::LegionControl.Properties.Resources.Battery;
            this.btnBattery.Location = new System.Drawing.Point(0, 350);
            this.btnBattery.Name = "btnBattery";
            this.btnBattery.Size = new System.Drawing.Size(200, 50);
            this.btnBattery.TabIndex = 4;
            this.btnBattery.Text = "Battery";
            this.btnBattery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBattery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBattery.UseVisualStyleBackColor = false;
            this.btnBattery.Paint += new System.Windows.Forms.PaintEventHandler(this.btnBattery_Paint);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnStatus.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Image = global::LegionControl.Properties.Resources.Status;
            this.btnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatus.Location = new System.Drawing.Point(0, 200);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(200, 50);
            this.btnStatus.TabIndex = 1;
            this.btnStatus.Text = "Status";
            this.btnStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_CLick);
            this.btnStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.btnStatus_Paint);
            // 
            // btnPowerModes
            // 
            this.btnPowerModes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnPowerModes.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnPowerModes.FlatAppearance.BorderSize = 0;
            this.btnPowerModes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPowerModes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPowerModes.ForeColor = System.Drawing.Color.White;
            this.btnPowerModes.Image = global::LegionControl.Properties.Resources.PowerMode;
            this.btnPowerModes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPowerModes.Location = new System.Drawing.Point(0, 300);
            this.btnPowerModes.Name = "btnPowerModes";
            this.btnPowerModes.Size = new System.Drawing.Size(200, 50);
            this.btnPowerModes.TabIndex = 3;
            this.btnPowerModes.Text = "Power Modes";
            this.btnPowerModes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPowerModes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPowerModes.UseVisualStyleBackColor = false;
            this.btnPowerModes.Click += new System.EventHandler(this.btnPowerModes_Click);
            this.btnPowerModes.Paint += new System.Windows.Forms.PaintEventHandler(this.btnPowerModes_Paint);
            // 
            // btnFanCurve
            // 
            this.btnFanCurve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnFanCurve.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnFanCurve.FlatAppearance.BorderSize = 0;
            this.btnFanCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFanCurve.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFanCurve.ForeColor = System.Drawing.Color.White;
            this.btnFanCurve.Image = global::LegionControl.Properties.Resources.FanCurve;
            this.btnFanCurve.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFanCurve.Location = new System.Drawing.Point(0, 250);
            this.btnFanCurve.Name = "btnFanCurve";
            this.btnFanCurve.Size = new System.Drawing.Size(200, 50);
            this.btnFanCurve.TabIndex = 2;
            this.btnFanCurve.Text = "Fan Curve";
            this.btnFanCurve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFanCurve.UseVisualStyleBackColor = false;
            this.btnFanCurve.Click += new System.EventHandler(this.btnFanCurve_Click);
            this.btnFanCurve.Paint += new System.Windows.Forms.PaintEventHandler(this.btnFanCurve_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.boxLogo);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(199, 200);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // boxLogo
            // 
            this.boxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxLogo.Location = new System.Drawing.Point(25, 25);
            this.boxLogo.Name = "boxLogo";
            this.boxLogo.Size = new System.Drawing.Size(150, 150);
            this.boxLogo.TabIndex = 0;
            this.boxLogo.TabStop = false;
            this.boxLogo.Click += new System.EventHandler(this.boxLogo_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.menuPanel);
            this.Name = "mainForm";
            this.Text = "LegionControl";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Panel panelLogo;
        private PictureBox boxLogo;
        private Button btnStatus;
        private Button btnFanCurve;
        private Button btnSettings;
        private Button btnBattery;
        private Button btnPowerModes;
    }
}