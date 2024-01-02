namespace FDS_application
{
    partial class frmFindService
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
            this.lblTrackService = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrackService
            // 
            this.lblTrackService.AutoSize = true;
            this.lblTrackService.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackService.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTrackService.Location = new System.Drawing.Point(145, 24);
            this.lblTrackService.Name = "lblTrackService";
            this.lblTrackService.Size = new System.Drawing.Size(170, 30);
            this.lblTrackService.TabIndex = 2;
            this.lblTrackService.Text = "Track Service";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblTrackService);
            this.panel1.Controls.Add(this.btnHome2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 83);
            this.panel1.TabIndex = 2;
            // 
            // btnHome2
            // 
            this.btnHome2.Image = global::FDS_application.Properties.Resources.icons8_home_50;
            this.btnHome2.Location = new System.Drawing.Point(61, 13);
            this.btnHome2.Name = "btnHome2";
            this.btnHome2.Size = new System.Drawing.Size(50, 50);
            this.btnHome2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnHome2.TabIndex = 0;
            this.btnHome2.TabStop = false;
            this.btnHome2.Click += new System.EventHandler(this.btnHome2_Click);
            // 
            // frmFindService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFindService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTrackService;
        private System.Windows.Forms.PictureBox btnHome2;
        private System.Windows.Forms.Panel panel1;
    }
}