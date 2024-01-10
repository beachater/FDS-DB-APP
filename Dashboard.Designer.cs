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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashOrder));
            this.dashboard_top = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboardSide = new System.Windows.Forms.Panel();
            this.dashboardOrderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.orderIcon = new System.Windows.Forms.Panel();
            this.dashboardResourcesHistory = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dashboardOrderSuppliesPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dashboardSuppliersPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dashboardSuppliesPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dashboard_top.SuspendLayout();
            this.dashboardSide.SuspendLayout();
            this.dashboardOrderPanel.SuspendLayout();
            this.dashboardResourcesHistory.SuspendLayout();
            this.dashboardOrderSuppliesPanel.SuspendLayout();
            this.dashboardSuppliersPanel.SuspendLayout();
            this.dashboardSuppliesPanel.SuspendLayout();
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
            this.dashboardSide.Controls.Add(this.dashboardOrderPanel);
            this.dashboardSide.Controls.Add(this.dashboardResourcesHistory);
            this.dashboardSide.Controls.Add(this.dashboardOrderSuppliesPanel);
            this.dashboardSide.Controls.Add(this.dashboardSuppliersPanel);
            this.dashboardSide.Controls.Add(this.dashboardSuppliesPanel);
            this.dashboardSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardSide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboardSide.Location = new System.Drawing.Point(0, 70);
            this.dashboardSide.Name = "dashboardSide";
            this.dashboardSide.Size = new System.Drawing.Size(208, 570);
            this.dashboardSide.TabIndex = 1;
            // 
            // dashboardOrderPanel
            // 
            this.dashboardOrderPanel.BackColor = System.Drawing.Color.Transparent;
            this.dashboardOrderPanel.Controls.Add(this.label1);
            this.dashboardOrderPanel.Controls.Add(this.orderIcon);
            this.dashboardOrderPanel.ForeColor = System.Drawing.Color.Black;
            this.dashboardOrderPanel.Location = new System.Drawing.Point(0, 32);
            this.dashboardOrderPanel.Name = "dashboardOrderPanel";
            this.dashboardOrderPanel.Size = new System.Drawing.Size(208, 56);
            this.dashboardOrderPanel.TabIndex = 3;
            this.dashboardOrderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dashboardOrderPanel_Paint);
            this.dashboardOrderPanel.MouseEnter += new System.EventHandler(this.dashOrder_MouseEnter);
            this.dashboardOrderPanel.MouseLeave += new System.EventHandler(this.dashOrder_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // orderIcon
            // 
            this.orderIcon.BackColor = System.Drawing.Color.Transparent;
            this.orderIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orderIcon.BackgroundImage")));
            this.orderIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.orderIcon.Location = new System.Drawing.Point(12, 18);
            this.orderIcon.Name = "orderIcon";
            this.orderIcon.Size = new System.Drawing.Size(28, 28);
            this.orderIcon.TabIndex = 2;
            this.orderIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // dashboardResourcesHistory
            // 
            this.dashboardResourcesHistory.Controls.Add(this.panel9);
            this.dashboardResourcesHistory.Controls.Add(this.label5);
            this.dashboardResourcesHistory.ForeColor = System.Drawing.Color.Black;
            this.dashboardResourcesHistory.Location = new System.Drawing.Point(0, 252);
            this.dashboardResourcesHistory.Name = "dashboardResourcesHistory";
            this.dashboardResourcesHistory.Size = new System.Drawing.Size(250, 56);
            this.dashboardResourcesHistory.TabIndex = 7;
            this.dashboardResourcesHistory.MouseEnter += new System.EventHandler(this.dashboardResourcesHistory_MouseEnter);
            this.dashboardResourcesHistory.MouseLeave += new System.EventHandler(this.dashboardResourcesHistory_MouseLeave);
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Location = new System.Drawing.Point(12, 15);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(28, 28);
            this.panel9.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(46, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Resource Summary";
            // 
            // dashboardOrderSuppliesPanel
            // 
            this.dashboardOrderSuppliesPanel.Controls.Add(this.panel7);
            this.dashboardOrderSuppliesPanel.Controls.Add(this.label4);
            this.dashboardOrderSuppliesPanel.ForeColor = System.Drawing.Color.Black;
            this.dashboardOrderSuppliesPanel.Location = new System.Drawing.Point(0, 196);
            this.dashboardOrderSuppliesPanel.Name = "dashboardOrderSuppliesPanel";
            this.dashboardOrderSuppliesPanel.Size = new System.Drawing.Size(250, 56);
            this.dashboardOrderSuppliesPanel.TabIndex = 6;
            this.dashboardOrderSuppliesPanel.MouseEnter += new System.EventHandler(this.dashboardOrderSuppliesPanel_MouseEnter);
            this.dashboardOrderSuppliesPanel.MouseLeave += new System.EventHandler(this.dashboardOrderSuppliesPanel_MouseLeave);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(12, 15);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(28, 28);
            this.panel7.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Order Supplies";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dashboardSuppliersPanel
            // 
            this.dashboardSuppliersPanel.Controls.Add(this.panel5);
            this.dashboardSuppliersPanel.Controls.Add(this.label3);
            this.dashboardSuppliersPanel.ForeColor = System.Drawing.Color.Black;
            this.dashboardSuppliersPanel.Location = new System.Drawing.Point(0, 140);
            this.dashboardSuppliersPanel.Name = "dashboardSuppliersPanel";
            this.dashboardSuppliersPanel.Size = new System.Drawing.Size(250, 56);
            this.dashboardSuppliersPanel.TabIndex = 5;
            this.dashboardSuppliersPanel.MouseEnter += new System.EventHandler(this.dashboardSuppliersPanel_MouseEnter);
            this.dashboardSuppliersPanel.MouseLeave += new System.EventHandler(this.dashboardSuppliersPanel_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(12, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(28, 28);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Suppliers";
            // 
            // dashboardSuppliesPanel
            // 
            this.dashboardSuppliesPanel.Controls.Add(this.panel3);
            this.dashboardSuppliesPanel.Controls.Add(this.label2);
            this.dashboardSuppliesPanel.ForeColor = System.Drawing.Color.Black;
            this.dashboardSuppliesPanel.Location = new System.Drawing.Point(0, 84);
            this.dashboardSuppliesPanel.Name = "dashboardSuppliesPanel";
            this.dashboardSuppliesPanel.Size = new System.Drawing.Size(250, 56);
            this.dashboardSuppliesPanel.TabIndex = 4;
            this.dashboardSuppliesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_2);
            this.dashboardSuppliesPanel.MouseEnter += new System.EventHandler(this.dashboardSuppliesPanel_MouseEnter);
            this.dashboardSuppliesPanel.MouseLeave += new System.EventHandler(this.dashboardSuppliesPanel_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(12, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(28, 28);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplies";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(331, 133);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(208, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // dashOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.guna2Button1);
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
            this.dashboardOrderPanel.ResumeLayout(false);
            this.dashboardOrderPanel.PerformLayout();
            this.dashboardResourcesHistory.ResumeLayout(false);
            this.dashboardResourcesHistory.PerformLayout();
            this.dashboardOrderSuppliesPanel.ResumeLayout(false);
            this.dashboardOrderSuppliesPanel.PerformLayout();
            this.dashboardSuppliersPanel.ResumeLayout(false);
            this.dashboardSuppliersPanel.PerformLayout();
            this.dashboardSuppliesPanel.ResumeLayout(false);
            this.dashboardSuppliesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dashboard_top;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel dashboardSide;
        private System.Windows.Forms.Panel orderIcon;
        private System.Windows.Forms.Panel dashboardOrderPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel dashboardSuppliesPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel dashboardResourcesHistory;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel dashboardOrderSuppliesPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel dashboardSuppliersPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}