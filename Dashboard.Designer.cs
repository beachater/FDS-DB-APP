namespace FDS_application
{
    partial class dashOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dashboard_top = new System.Windows.Forms.Panel();
            this.dashboardSide = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.gSuppliesButton = new Guna.UI2.WinForms.Guna2Button();
            this.gOrderButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dashboard_top.SuspendLayout();
            this.dashboardSide.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboard_top
            // 
            this.dashboard_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.dashboard_top.Controls.Add(this.panel2);
            this.dashboard_top.Controls.Add(this.panel1);
            this.dashboard_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboard_top.Location = new System.Drawing.Point(0, 0);
            this.dashboard_top.Name = "dashboard_top";
            this.dashboard_top.Size = new System.Drawing.Size(1024, 70);
            this.dashboard_top.TabIndex = 0;
            // 
            // dashboardSide
            // 
            this.dashboardSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.dashboardSide.Controls.Add(this.guna2Button1);
            this.dashboardSide.Controls.Add(this.guna2Button2);
            this.dashboardSide.Controls.Add(this.gSuppliesButton);
            this.dashboardSide.Controls.Add(this.gOrderButton);
            this.dashboardSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardSide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboardSide.Location = new System.Drawing.Point(0, 70);
            this.dashboardSide.Name = "dashboardSide";
            this.dashboardSide.Size = new System.Drawing.Size(208, 570);
            this.dashboardSide.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Location = new System.Drawing.Point(208, 70);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(816, 570);
            this.dashboardPanel.TabIndex = 4;
            this.dashboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_3);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.DimGray;
            this.guna2Button1.BackgroundImage = global::FDS_application.Properties.Resources.icons8_home_50;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.guna2Button1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.guna2Button1.Location = new System.Drawing.Point(1, 56);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(208, 56);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "Orders";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.DimGray;
            this.guna2Button2.BackgroundImage = global::FDS_application.Properties.Resources.icons8_home_50;
            this.guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.guna2Button2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.guna2Button2.Location = new System.Drawing.Point(1, 112);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(208, 56);
            this.guna2Button2.TabIndex = 10;
            this.guna2Button2.Text = "Order History";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // gSuppliesButton
            // 
            this.gSuppliesButton.BackColor = System.Drawing.Color.DimGray;
            this.gSuppliesButton.BackgroundImage = global::FDS_application.Properties.Resources.icons8_home_50;
            this.gSuppliesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gSuppliesButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gSuppliesButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.gSuppliesButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.gSuppliesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gSuppliesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gSuppliesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gSuppliesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gSuppliesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.gSuppliesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gSuppliesButton.ForeColor = System.Drawing.Color.Black;
            this.gSuppliesButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.gSuppliesButton.Location = new System.Drawing.Point(1, 168);
            this.gSuppliesButton.Name = "gSuppliesButton";
            this.gSuppliesButton.Size = new System.Drawing.Size(208, 56);
            this.gSuppliesButton.TabIndex = 8;
            this.gSuppliesButton.Text = "Supplies";
            this.gSuppliesButton.Click += new System.EventHandler(this.gSuppliesButton_Click);
            // 
            // gOrderButton
            // 
            this.gOrderButton.BackColor = System.Drawing.Color.DimGray;
            this.gOrderButton.BackgroundImage = global::FDS_application.Properties.Resources.icons8_home_50;
            this.gOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gOrderButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gOrderButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.gOrderButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.gOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gOrderButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.gOrderButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gOrderButton.ForeColor = System.Drawing.Color.Black;
            this.gOrderButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.gOrderButton.Location = new System.Drawing.Point(1, 0);
            this.gOrderButton.Name = "gOrderButton";
            this.gOrderButton.Padding = new System.Windows.Forms.Padding(5);
            this.gOrderButton.Size = new System.Drawing.Size(208, 56);
            this.gOrderButton.TabIndex = 4;
            this.gOrderButton.Text = "New Order";
            this.gOrderButton.Click += new System.EventHandler(this.gOrderButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FDS_application.Properties.Resources.infinytArtwerks_logo_removebg_preview;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(27, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 58);
            this.panel2.TabIndex = 1;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(7, 12);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(99, 45);
            this.guna2Button3.TabIndex = 2;
            this.guna2Button3.Text = "Log Out";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(906, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 70);
            this.panel1.TabIndex = 3;
            // 
            // dashOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dashboardSide);
            this.Controls.Add(this.dashboard_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.btnOrder_Load_1);
            this.dashboard_top.ResumeLayout(false);
            this.dashboardSide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dashboard_top;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel dashboardSide;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Button gOrderButton;
        private System.Windows.Forms.Panel dashboardPanel;
        private Guna.UI2.WinForms.Guna2Button gSuppliesButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Panel panel1;
    }
}