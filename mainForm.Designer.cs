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
            this.btnFanCurve = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.boxLogo = new System.Windows.Forms.PictureBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menuPanel.Controls.Add(this.btnFanCurve);
            this.menuPanel.Controls.Add(this.panelLogo);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.menuPanel.Size = new System.Drawing.Size(1200, 75);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
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
            this.btnFanCurve.Location = new System.Drawing.Point(300, 0);
            this.btnFanCurve.Name = "btnFanCurve";
            this.btnFanCurve.Size = new System.Drawing.Size(150, 75);
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
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(150, 74);
            this.panelLogo.TabIndex = 0;
            // 
            // boxLogo
            // 
            this.boxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxLogo.Location = new System.Drawing.Point(25, -13);
            this.boxLogo.Name = "boxLogo";
            this.boxLogo.Size = new System.Drawing.Size(100, 100);
            this.boxLogo.TabIndex = 0;
            this.boxLogo.TabStop = false;
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
            this.btnStatus.Location = new System.Drawing.Point(150, 0);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(150, 75);
            this.btnStatus.TabIndex = 1;
            this.btnStatus.Text = "Status";
            this.btnStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_CLick);
            this.btnStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.btnStatus_Paint);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.menuPanel);
            this.Name = "mainForm";
            this.Text = "LegionControl";
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
    }
}