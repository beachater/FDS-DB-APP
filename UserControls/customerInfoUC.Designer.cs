namespace FDS_application.UserControls
{
    partial class customerInfoUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.organizationTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contactnumTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastnameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstnameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.organizationTxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.contactnumTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lastnameTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.firstnameTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(176, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 282);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(142, 225);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Text = "Proceed ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // organizationTxt
            // 
            this.organizationTxt.Location = new System.Drawing.Point(24, 184);
            this.organizationTxt.Name = "organizationTxt";
            this.organizationTxt.Size = new System.Drawing.Size(177, 20);
            this.organizationTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Organization";
            // 
            // contactnumTxt
            // 
            this.contactnumTxt.Location = new System.Drawing.Point(24, 127);
            this.contactnumTxt.Name = "contactnumTxt";
            this.contactnumTxt.Size = new System.Drawing.Size(177, 20);
            this.contactnumTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact Number";
            // 
            // lastnameTxt
            // 
            this.lastnameTxt.Location = new System.Drawing.Point(262, 70);
            this.lastnameTxt.Name = "lastnameTxt";
            this.lastnameTxt.Size = new System.Drawing.Size(177, 20);
            this.lastnameTxt.TabIndex = 5;
            this.lastnameTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // firstnameTxt
            // 
            this.firstnameTxt.Location = new System.Drawing.Point(24, 70);
            this.firstnameTxt.Name = "firstnameTxt";
            this.firstnameTxt.Size = new System.Drawing.Size(177, 20);
            this.firstnameTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.dashboardPanel.Controls.Add(this.panel1);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(816, 570);
            this.dashboardPanel.TabIndex = 1;
            this.dashboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dashboardPanel_Paint);
            // 
            // customerInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.dashboardPanel);
            this.Name = "customerInfoUC";
            this.Size = new System.Drawing.Size(816, 570);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dashboardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contactnumTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastnameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstnameTxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TextBox organizationTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel dashboardPanel;
    }
}
