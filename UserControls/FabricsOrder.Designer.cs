namespace FDS_application.UserControls
{
    partial class FabricsOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.fabricOrderTrans = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fabricTypecmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.fabricOrderTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FABRIC Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fabricOrderTrans
            // 
            this.fabricOrderTrans.Controls.Add(this.panel2);
            this.fabricOrderTrans.Location = new System.Drawing.Point(157, 0);
            this.fabricOrderTrans.Name = "fabricOrderTrans";
            this.fabricOrderTrans.Size = new System.Drawing.Size(659, 483);
            this.fabricOrderTrans.TabIndex = 1;
            this.fabricOrderTrans.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 483);
            this.panel2.TabIndex = 5;
            // 
            // fabricTypecmb
            // 
            this.fabricTypecmb.BackColor = System.Drawing.Color.Transparent;
            this.fabricTypecmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fabricTypecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fabricTypecmb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fabricTypecmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fabricTypecmb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fabricTypecmb.ForeColor = System.Drawing.Color.Black;
            this.fabricTypecmb.ItemHeight = 30;
            this.fabricTypecmb.Location = new System.Drawing.Point(24, 38);
            this.fabricTypecmb.Name = "fabricTypecmb";
            this.fabricTypecmb.Size = new System.Drawing.Size(113, 36);
            this.fabricTypecmb.TabIndex = 0;
            this.fabricTypecmb.SelectedIndexChanged += new System.EventHandler(this.fabricTypecmb_SelectedIndexChanged);
            // 
            // FabricsOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.fabricTypecmb);
            this.Controls.Add(this.fabricOrderTrans);
            this.Controls.Add(this.label1);
            this.Name = "FabricsOrder";
            this.Size = new System.Drawing.Size(548, 518);
            this.Load += new System.EventHandler(this.FabricsOrder_Load);
            this.fabricOrderTrans.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel fabricOrderTrans;
        private Guna.UI2.WinForms.Guna2ComboBox fabricTypecmb;
        private System.Windows.Forms.Panel panel2;
    }
}
