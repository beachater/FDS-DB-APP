namespace FDS_application.UserControls
{
    partial class TshirtFabric
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
            this.quantitytxt = new System.Windows.Forms.Label();
            this.sizetxt = new System.Windows.Forms.Label();
            this.materialtxt = new System.Windows.Forms.Label();
            this.quanTxt = new System.Windows.Forms.TextBox();
            this.sizeText1 = new System.Windows.Forms.TextBox();
            this.materialTxt2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addItem = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.priceDisplay = new System.Windows.Forms.Label();
            this.noteText2 = new System.Windows.Forms.RichTextBox();
            this.notetxt = new System.Windows.Forms.Label();
            this.designText2 = new System.Windows.Forms.TextBox();
            this.designtxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // quantitytxt
            // 
            this.quantitytxt.AutoSize = true;
            this.quantitytxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytxt.Location = new System.Drawing.Point(13, 28);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(63, 16);
            this.quantitytxt.TabIndex = 0;
            this.quantitytxt.Text = "Quantity";
            this.quantitytxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // sizetxt
            // 
            this.sizetxt.AutoSize = true;
            this.sizetxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizetxt.Location = new System.Drawing.Point(164, 28);
            this.sizetxt.Name = "sizetxt";
            this.sizetxt.Size = new System.Drawing.Size(32, 16);
            this.sizetxt.TabIndex = 1;
            this.sizetxt.Text = "Size";
            this.sizetxt.Click += new System.EventHandler(this.label2_Click);
            // 
            // materialtxt
            // 
            this.materialtxt.AutoSize = true;
            this.materialtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialtxt.Location = new System.Drawing.Point(13, 135);
            this.materialtxt.Name = "materialtxt";
            this.materialtxt.Size = new System.Drawing.Size(104, 16);
            this.materialtxt.TabIndex = 3;
            this.materialtxt.Text = "T-shirt Material";
            this.materialtxt.Click += new System.EventHandler(this.label3_Click);
            // 
            // quanTxt
            // 
            this.quanTxt.Location = new System.Drawing.Point(16, 47);
            this.quanTxt.Name = "quanTxt";
            this.quanTxt.Size = new System.Drawing.Size(100, 20);
            this.quanTxt.TabIndex = 4;
            this.quanTxt.TextChanged += new System.EventHandler(this.quanTxt_TextChanged);
            this.quanTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quanTxt_KeyPress);
            // 
            // sizeText1
            // 
            this.sizeText1.Location = new System.Drawing.Point(167, 47);
            this.sizeText1.Name = "sizeText1";
            this.sizeText1.Size = new System.Drawing.Size(100, 20);
            this.sizeText1.TabIndex = 5;
            this.sizeText1.TextChanged += new System.EventHandler(this.sizeText1_TextChanged);
            // 
            // materialTxt2
            // 
            this.materialTxt2.Location = new System.Drawing.Point(16, 154);
            this.materialTxt2.Name = "materialTxt2";
            this.materialTxt2.Size = new System.Drawing.Size(180, 20);
            this.materialTxt2.TabIndex = 6;
            this.materialTxt2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.panel2.Controls.Add(this.addItem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 72);
            this.panel2.TabIndex = 11;
            // 
            // addItem
            // 
            this.addItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addItem.FillColor = System.Drawing.Color.DimGray;
            this.addItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem.ForeColor = System.Drawing.Color.White;
            this.addItem.Location = new System.Drawing.Point(105, 14);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(180, 45);
            this.addItem.TabIndex = 11;
            this.addItem.Text = "Proceed ";
            this.addItem.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.panel3.Controls.Add(this.priceDisplay);
            this.panel3.Controls.Add(this.noteText2);
            this.panel3.Controls.Add(this.notetxt);
            this.panel3.Controls.Add(this.designText2);
            this.panel3.Controls.Add(this.designtxt);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.materialTxt2);
            this.panel3.Controls.Add(this.quantitytxt);
            this.panel3.Controls.Add(this.sizeText1);
            this.panel3.Controls.Add(this.sizetxt);
            this.panel3.Controls.Add(this.quanTxt);
            this.panel3.Controls.Add(this.materialtxt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 411);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // priceDisplay
            // 
            this.priceDisplay.AutoSize = true;
            this.priceDisplay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceDisplay.Location = new System.Drawing.Point(15, 330);
            this.priceDisplay.Name = "priceDisplay";
            this.priceDisplay.Size = new System.Drawing.Size(15, 16);
            this.priceDisplay.TabIndex = 18;
            this.priceDisplay.Text = "..";
            // 
            // noteText2
            // 
            this.noteText2.Location = new System.Drawing.Point(16, 215);
            this.noteText2.Name = "noteText2";
            this.noteText2.Size = new System.Drawing.Size(358, 77);
            this.noteText2.TabIndex = 17;
            this.noteText2.Text = "";
            this.noteText2.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // notetxt
            // 
            this.notetxt.AutoSize = true;
            this.notetxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notetxt.Location = new System.Drawing.Point(14, 196);
            this.notetxt.Name = "notetxt";
            this.notetxt.Size = new System.Drawing.Size(102, 16);
            this.notetxt.TabIndex = 16;
            this.notetxt.Text = "Customer Note";
            // 
            // designText2
            // 
            this.designText2.Location = new System.Drawing.Point(16, 100);
            this.designText2.Name = "designText2";
            this.designText2.Size = new System.Drawing.Size(251, 20);
            this.designText2.TabIndex = 15;
            this.designText2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // designtxt
            // 
            this.designtxt.AutoSize = true;
            this.designtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designtxt.Location = new System.Drawing.Point(13, 81);
            this.designtxt.Name = "designtxt";
            this.designtxt.Size = new System.Drawing.Size(51, 16);
            this.designtxt.TabIndex = 14;
            this.designtxt.Text = "Design";
            this.designtxt.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 13;
            this.label8.Tag = "";
            this.label8.Text = "Price";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // TshirtFabric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "TshirtFabric";
            this.Size = new System.Drawing.Size(391, 483);
            this.Load += new System.EventHandler(this.TshirtFabric_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label quantitytxt;
        private System.Windows.Forms.Label sizetxt;
        private System.Windows.Forms.Label materialtxt;
        private System.Windows.Forms.TextBox quanTxt;
        private System.Windows.Forms.TextBox sizeText1;
        private System.Windows.Forms.TextBox materialTxt2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox designText2;
        private System.Windows.Forms.Label designtxt;
        private System.Windows.Forms.RichTextBox noteText2;
        private System.Windows.Forms.Label notetxt;
        private Guna.UI2.WinForms.Guna2Button addItem;
        private System.Windows.Forms.Label priceDisplay;
    }
}
