﻿namespace FDS_application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashOrder));
            this.dashboard_top = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboardSide = new System.Windows.Forms.Panel();
            this.gSuppliesButton = new Guna.UI2.WinForms.Guna2Button();
            this.gOrderButton = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.dashboard_top.SuspendLayout();
            this.dashboardSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboard_top
            // 
            this.dashboard_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.dashboard_top.Controls.Add(this.panel2);
            this.dashboard_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboard_top.Location = new System.Drawing.Point(0, 0);
            this.dashboard_top.Name = "dashboard_top";
            this.dashboard_top.Size = new System.Drawing.Size(1024, 70);
            this.dashboard_top.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 35);
            this.panel2.TabIndex = 1;
            // 
            // dashboardSide
            // 
            this.dashboardSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.dashboardSide.Controls.Add(this.gSuppliesButton);
            this.dashboardSide.Controls.Add(this.gOrderButton);
            this.dashboardSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardSide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboardSide.Location = new System.Drawing.Point(0, 70);
            this.dashboardSide.Name = "dashboardSide";
            this.dashboardSide.Size = new System.Drawing.Size(208, 570);
            this.dashboardSide.TabIndex = 1;
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
            this.gSuppliesButton.Location = new System.Drawing.Point(1, 50);
            this.gSuppliesButton.Name = "gSuppliesButton";
            this.gSuppliesButton.Size = new System.Drawing.Size(207, 56);
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
            this.gOrderButton.Location = new System.Drawing.Point(0, 0);
            this.gOrderButton.Name = "gOrderButton";
            this.gOrderButton.Size = new System.Drawing.Size(208, 56);
            this.gOrderButton.TabIndex = 4;
            this.gOrderButton.Text = "New Order";
            this.gOrderButton.Click += new System.EventHandler(this.gOrderButton_Click);
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
    }
}