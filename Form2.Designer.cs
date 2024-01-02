using System;
using System.Windows.Forms;

namespace FDS_application
{
    partial class frmNewService
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTrackService = new System.Windows.Forms.Label();
            this.btnHome1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblTrackService);
            this.panel1.Controls.Add(this.btnHome1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 83);
            this.panel1.TabIndex = 1;
            // 
            // lblTrackService
            // 
            this.lblTrackService.AutoSize = true;
            this.lblTrackService.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackService.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTrackService.Location = new System.Drawing.Point(145, 24);
            this.lblTrackService.Name = "lblTrackService";
            this.lblTrackService.Size = new System.Drawing.Size(157, 30);
            this.lblTrackService.TabIndex = 2;
            this.lblTrackService.Text = "Find Service";
            this.lblTrackService.Click += new System.EventHandler(this.lblTrackService_Click);
            // 
            // btnHome1
            // 
            this.btnHome1.Image = global::FDS_application.Properties.Resources.icons8_home_50;
            this.btnHome1.Location = new System.Drawing.Point(61, 13);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(50, 50);
            this.btnHome1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnHome1.TabIndex = 0;
            this.btnHome1.TabStop = false;
            this.btnHome1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(104, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(850, 527);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 233);
            this.panel2.TabIndex = 0;
            this.panel2.TabStop = true;
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(277, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 233);
            this.panel3.TabIndex = 1;
            this.panel3.TabStop = true;
            this.panel3.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(551, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 233);
            this.panel4.TabIndex = 2;
            this.panel4.TabStop = true;
            this.panel4.MouseEnter += new System.EventHandler(this.panel4_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(3, 242);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(268, 233);
            this.panel5.TabIndex = 3;
            this.panel5.TabStop = true;
            this.panel5.MouseEnter += new System.EventHandler(this.panel5_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.panel5_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Location = new System.Drawing.Point(277, 242);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(268, 233);
            this.panel6.TabIndex = 4;
            this.panel6.TabStop = true;
            this.panel6.MouseEnter += new System.EventHandler(this.panel6_MouseEnter);
            this.panel6.MouseLeave += new System.EventHandler(this.panel6_MouseLeave);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Location = new System.Drawing.Point(551, 242);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(268, 233);
            this.panel7.TabIndex = 5;
            this.panel7.TabStop = true;
            this.panel7.MouseEnter += new System.EventHandler(this.panel7_MouseEnter);
            this.panel7.MouseLeave += new System.EventHandler(this.panel7_MouseLeave);
            // 
            // frmNewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panel3_Paint(object sender, PaintEventArgs e) => throw new NotImplementedException();

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome1;
        private System.Windows.Forms.Label lblTrackService;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}