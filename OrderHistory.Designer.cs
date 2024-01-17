namespace FDS_application
{
    partial class OrderHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.orderHistorDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkOHItemDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.newCheckItem = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistorDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOHItemDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 32);
            this.label7.TabIndex = 17;
            this.label7.Tag = "";
            this.label7.Text = "Completed orders";
            // 
            // orderHistorDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.orderHistorDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderHistorDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.orderHistorDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderHistorDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderHistorDataGrid.ColumnHeadersHeight = 20;
            this.orderHistorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderHistorDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.newCheckItem});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderHistorDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.orderHistorDataGrid.GridColor = System.Drawing.Color.DarkKhaki;
            this.orderHistorDataGrid.Location = new System.Drawing.Point(16, 59);
            this.orderHistorDataGrid.Name = "orderHistorDataGrid";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderHistorDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.orderHistorDataGrid.RowHeadersVisible = false;
            this.orderHistorDataGrid.Size = new System.Drawing.Size(787, 281);
            this.orderHistorDataGrid.TabIndex = 15;
            this.orderHistorDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.orderHistorDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.orderHistorDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.orderHistorDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.orderHistorDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.orderHistorDataGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.orderHistorDataGrid.ThemeStyle.GridColor = System.Drawing.Color.DarkKhaki;
            this.orderHistorDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderHistorDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderHistorDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderHistorDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.orderHistorDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderHistorDataGrid.ThemeStyle.HeaderStyle.Height = 20;
            this.orderHistorDataGrid.ThemeStyle.ReadOnly = false;
            this.orderHistorDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.orderHistorDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderHistorDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderHistorDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.orderHistorDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.orderHistorDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderHistorDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.orderHistorDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderHistorDataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 18;
            this.label1.Tag = "";
            this.label1.Text = "Order items";
            // 
            // checkOHItemDataGrid
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.checkOHItemDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.checkOHItemDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.checkOHItemDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkOHItemDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.checkOHItemDataGrid.ColumnHeadersHeight = 20;
            this.checkOHItemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.checkOHItemDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.checkOHItemDataGrid.GridColor = System.Drawing.Color.DarkKhaki;
            this.checkOHItemDataGrid.Location = new System.Drawing.Point(16, 383);
            this.checkOHItemDataGrid.Name = "checkOHItemDataGrid";
            this.checkOHItemDataGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkOHItemDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.checkOHItemDataGrid.RowHeadersVisible = false;
            this.checkOHItemDataGrid.Size = new System.Drawing.Size(787, 163);
            this.checkOHItemDataGrid.TabIndex = 16;
            this.checkOHItemDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.checkOHItemDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.checkOHItemDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.checkOHItemDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.checkOHItemDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.checkOHItemDataGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.checkOHItemDataGrid.ThemeStyle.GridColor = System.Drawing.Color.DarkKhaki;
            this.checkOHItemDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkOHItemDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.checkOHItemDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOHItemDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.checkOHItemDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.checkOHItemDataGrid.ThemeStyle.HeaderStyle.Height = 20;
            this.checkOHItemDataGrid.ThemeStyle.ReadOnly = true;
            this.checkOHItemDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.checkOHItemDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.checkOHItemDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOHItemDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.checkOHItemDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.checkOHItemDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.checkOHItemDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // newCheckItem
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chartreuse;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.newCheckItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.newCheckItem.HeaderText = "                      ";
            this.newCheckItem.Name = "newCheckItem";
            this.newCheckItem.Text = "Check Item";
            this.newCheckItem.UseColumnTextForButtonValue = true;
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.orderHistorDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkOHItemDataGrid);
            this.Name = "OrderHistory";
            this.Size = new System.Drawing.Size(816, 570);
            ((System.ComponentModel.ISupportInitialize)(this.orderHistorDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOHItemDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView orderHistorDataGrid;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView checkOHItemDataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn newCheckItem;
    }
}
