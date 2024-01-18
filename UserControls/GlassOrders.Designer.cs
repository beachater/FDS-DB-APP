namespace FDS_application.UserControls
{
    partial class GlassOrders
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.glassPanel = new System.Windows.Forms.Panel();
            this.glassTypecmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.panel3.Controls.Add(this.glassPanel);
            this.panel3.Controls.Add(this.glassTypecmb);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 518);
            this.panel3.TabIndex = 15;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // glassPanel
            // 
            this.glassPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.glassPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.glassPanel.Location = new System.Drawing.Point(157, 0);
            this.glassPanel.Name = "glassPanel";
            this.glassPanel.Size = new System.Drawing.Size(391, 518);
            this.glassPanel.TabIndex = 17;
            // 
            // glassTypecmb
            // 
            this.glassTypecmb.BackColor = System.Drawing.Color.Transparent;
            this.glassTypecmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.glassTypecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.glassTypecmb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.glassTypecmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.glassTypecmb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.glassTypecmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.glassTypecmb.ItemHeight = 30;
            this.glassTypecmb.Location = new System.Drawing.Point(24, 38);
            this.glassTypecmb.Name = "glassTypecmb";
            this.glassTypecmb.Size = new System.Drawing.Size(113, 36);
            this.glassTypecmb.TabIndex = 15;
            this.glassTypecmb.SelectedIndexChanged += new System.EventHandler(this.fabricTypecmb_SelectedIndexChanged);
            // 
            // GlassOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.panel3);
            this.Name = "GlassOrders";
            this.Size = new System.Drawing.Size(548, 518);
            this.Load += new System.EventHandler(this.GlassOrders_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox glassTypecmb;
        private System.Windows.Forms.Panel glassPanel;
    }
}
