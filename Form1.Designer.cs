namespace FDS_application
{
    partial class Tst
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
            this.btnNewService = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindService = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewService
            // 
            this.btnNewService.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnNewService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewService.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewService.Location = new System.Drawing.Point(244, 380);
            this.btnNewService.Name = "btnNewService";
            this.btnNewService.Size = new System.Drawing.Size(195, 112);
            this.btnNewService.TabIndex = 0;
            this.btnNewService.Text = "New Service";
            this.btnNewService.UseVisualStyleBackColor = true;
            this.btnNewService.UseWaitCursor = true;
            this.btnNewService.Click += new System.EventHandler(this.testButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.panel1.Location = new System.Drawing.Point(445, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 745);
            this.panel1.TabIndex = 2;
            this.panel1.UseWaitCursor = true;
            // 
            // btnFindService
            // 
            this.btnFindService.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnFindService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindService.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindService.Location = new System.Drawing.Point(12, 380);
            this.btnFindService.Name = "btnFindService";
            this.btnFindService.Size = new System.Drawing.Size(195, 112);
            this.btnFindService.TabIndex = 2;
            this.btnFindService.Text = "Find Service";
            this.btnFindService.UseVisualStyleBackColor = true;
            this.btnFindService.UseWaitCursor = true;
            this.btnFindService.Click += new System.EventHandler(this.btnFindService_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(24, 83);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 16);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(24, 115);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(58, 16);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Password";
            this.lblPass.Click += new System.EventHandler(this.lblPass_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(108)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.tbUsername);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.lblPass);
            this.panel2.Location = new System.Drawing.Point(152, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 199);
            this.panel2.TabIndex = 7;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(115, 83);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(174, 20);
            this.tbUsername.TabIndex = 7;
            this.tbUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(115, 115);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(174, 20);
            this.tbPassword.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Image = global::FDS_application.Properties.Resources.infinytArtwerks_logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-301, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(918, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox2.Image = global::FDS_application.Properties.Resources.Untitled_design__2_;
            this.pictureBox2.Location = new System.Drawing.Point(-95, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(556, 677);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // Tst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.btnFindService);
            this.Controls.Add(this.btnNewService);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewService;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnFindService;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
    }
}

