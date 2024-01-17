namespace FDS_application.UserControls
{
    partial class OrderUC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gWoodButton = new Guna.UI2.WinForms.Guna2Button();
            this.gGlassButton = new Guna.UI2.WinForms.Guna2Button();
            this.gBannersButton = new Guna.UI2.WinForms.Guna2Button();
            this.gFabricsbutton = new Guna.UI2.WinForms.Guna2Button();
            this.ordersPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentMethodcmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.TotalPriceDisp = new System.Windows.Forms.Label();
            this.totalItemDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.recipientLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemGetDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemGetDAOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalItemDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGetDAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGetDAOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gWoodButton);
            this.panel1.Controls.Add(this.gGlassButton);
            this.panel1.Controls.Add(this.gBannersButton);
            this.panel1.Controls.Add(this.gFabricsbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 52);
            this.panel1.TabIndex = 0;
            // 
            // gWoodButton
            // 
            this.gWoodButton.BorderColor = System.Drawing.Color.Empty;
            this.gWoodButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.gWoodButton.CustomBorderColor = System.Drawing.Color.Black;
            this.gWoodButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.gWoodButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gWoodButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gWoodButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gWoodButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gWoodButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.gWoodButton.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gWoodButton.ForeColor = System.Drawing.Color.Black;
            this.gWoodButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.gWoodButton.Location = new System.Drawing.Point(612, 1);
            this.gWoodButton.Name = "gWoodButton";
            this.gWoodButton.Size = new System.Drawing.Size(204, 50);
            this.gWoodButton.TabIndex = 5;
            this.gWoodButton.Text = "Wood";
            this.gWoodButton.Click += new System.EventHandler(this.gWoodButton_Click);
            // 
            // gGlassButton
            // 
            this.gGlassButton.BorderColor = System.Drawing.Color.Empty;
            this.gGlassButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.gGlassButton.CustomBorderColor = System.Drawing.Color.Black;
            this.gGlassButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.gGlassButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gGlassButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gGlassButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gGlassButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gGlassButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.gGlassButton.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gGlassButton.ForeColor = System.Drawing.Color.Black;
            this.gGlassButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.gGlassButton.Location = new System.Drawing.Point(408, 1);
            this.gGlassButton.Name = "gGlassButton";
            this.gGlassButton.Size = new System.Drawing.Size(204, 50);
            this.gGlassButton.TabIndex = 4;
            this.gGlassButton.Text = "Glass";
            this.gGlassButton.Click += new System.EventHandler(this.gGlassButton_Click);
            // 
            // gBannersButton
            // 
            this.gBannersButton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.gBannersButton.CustomBorderColor = System.Drawing.Color.Black;
            this.gBannersButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.gBannersButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gBannersButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gBannersButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gBannersButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gBannersButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.gBannersButton.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gBannersButton.ForeColor = System.Drawing.Color.Black;
            this.gBannersButton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.gBannersButton.Location = new System.Drawing.Point(204, 1);
            this.gBannersButton.Name = "gBannersButton";
            this.gBannersButton.Size = new System.Drawing.Size(204, 50);
            this.gBannersButton.TabIndex = 3;
            this.gBannersButton.Text = "Banners";
            this.gBannersButton.Click += new System.EventHandler(this.gBannersButton_Click);
            // 
            // gFabricsbutton
            // 
            this.gFabricsbutton.BorderColor = System.Drawing.Color.Empty;
            this.gFabricsbutton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gFabricsbutton.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.gFabricsbutton.CustomBorderColor = System.Drawing.Color.Black;
            this.gFabricsbutton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.gFabricsbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gFabricsbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gFabricsbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gFabricsbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gFabricsbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.gFabricsbutton.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gFabricsbutton.ForeColor = System.Drawing.Color.Black;
            this.gFabricsbutton.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(36)))));
            this.gFabricsbutton.Location = new System.Drawing.Point(0, 1);
            this.gFabricsbutton.Name = "gFabricsbutton";
            this.gFabricsbutton.Size = new System.Drawing.Size(204, 50);
            this.gFabricsbutton.TabIndex = 2;
            this.gFabricsbutton.Text = "Fabrics";
            this.gFabricsbutton.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // ordersPanel
            // 
            this.ordersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.ordersPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ordersPanel.Location = new System.Drawing.Point(0, 52);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(548, 518);
            this.ordersPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.paymentMethodcmb);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.TotalPriceDisp);
            this.panel2.Controls.Add(this.totalItemDataGrid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.recipientLabel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(548, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 518);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 22;
            this.label1.Tag = "";
            this.label1.Text = "Payment Method";
            // 
            // paymentMethodcmb
            // 
            this.paymentMethodcmb.BackColor = System.Drawing.Color.Transparent;
            this.paymentMethodcmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paymentMethodcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethodcmb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentMethodcmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentMethodcmb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodcmb.ForeColor = System.Drawing.Color.Black;
            this.paymentMethodcmb.ItemHeight = 30;
            this.paymentMethodcmb.Items.AddRange(new object[] {
            "In-Store",
            "G-Cash",
            "Bank"});
            this.paymentMethodcmb.Location = new System.Drawing.Point(9, 368);
            this.paymentMethodcmb.Name = "paymentMethodcmb";
            this.paymentMethodcmb.Size = new System.Drawing.Size(140, 36);
            this.paymentMethodcmb.TabIndex = 21;
            this.paymentMethodcmb.SelectedIndexChanged += new System.EventHandler(this.paymentMethodcmb_SelectedIndexChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DimGray;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(44, 457);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 20;
            this.guna2Button1.Text = "Check Out";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // TotalPriceDisp
            // 
            this.TotalPriceDisp.AutoSize = true;
            this.TotalPriceDisp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceDisp.Location = new System.Drawing.Point(6, 320);
            this.TotalPriceDisp.Name = "TotalPriceDisp";
            this.TotalPriceDisp.Size = new System.Drawing.Size(24, 18);
            this.TotalPriceDisp.TabIndex = 19;
            this.TotalPriceDisp.Text = "   .";
            // 
            // totalItemDataGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            this.totalItemDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.totalItemDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.totalItemDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.totalItemDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.totalItemDataGrid.ColumnHeadersHeight = 30;
            this.totalItemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.totalItemDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalItemDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.totalItemDataGrid.Location = new System.Drawing.Point(9, 100);
            this.totalItemDataGrid.Name = "totalItemDataGrid";
            this.totalItemDataGrid.RowHeadersVisible = false;
            this.totalItemDataGrid.Size = new System.Drawing.Size(246, 205);
            this.totalItemDataGrid.TabIndex = 17;
            this.totalItemDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.totalItemDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.totalItemDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.totalItemDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.totalItemDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.totalItemDataGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.totalItemDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.totalItemDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.totalItemDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.totalItemDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.totalItemDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.totalItemDataGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.totalItemDataGrid.ThemeStyle.ReadOnly = false;
            this.totalItemDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.totalItemDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.totalItemDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.totalItemDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.totalItemDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.totalItemDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.totalItemDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.totalItemDataGrid_CellContentClick);
            // 
            // deleteColumn
            // 
            this.deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.deleteColumn.HeaderText = "";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Text = "Delete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 16;
            // 
            // recipientLabel
            // 
            this.recipientLabel.AutoSize = true;
            this.recipientLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientLabel.Location = new System.Drawing.Point(6, 38);
            this.recipientLabel.Name = "recipientLabel";
            this.recipientLabel.Size = new System.Drawing.Size(54, 18);
            this.recipientLabel.TabIndex = 15;
            this.recipientLabel.Text = "label1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 14;
            this.label9.Tag = "";
            this.label9.Text = "Recipient";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 12;
            this.label7.Tag = "";
            this.label7.Text = "Total Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 11;
            this.label6.Tag = "";
            this.label6.Text = "Total Items";
            // 
            // itemGetDAOBindingSource
            // 
            this.itemGetDAOBindingSource.DataSource = typeof(FDS_application.ItemGetDAO);
            // 
            // itemGetDAOBindingSource1
            // 
            this.itemGetDAOBindingSource1.DataSource = typeof(FDS_application.ItemGetDAO);
            // 
            // OrderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ordersPanel);
            this.Controls.Add(this.panel1);
            this.Name = "OrderUC";
            this.Size = new System.Drawing.Size(816, 570);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalItemDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGetDAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGetDAOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button gFabricsbutton;
        private Guna.UI2.WinForms.Guna2Button gBannersButton;
        private Guna.UI2.WinForms.Guna2Button gWoodButton;
        private Guna.UI2.WinForms.Guna2Button gGlassButton;
        private System.Windows.Forms.Panel ordersPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label recipientLabel;
        private Guna.UI2.WinForms.Guna2DataGridView totalItemDataGrid;
        private System.Windows.Forms.BindingSource itemGetDAOBindingSource;
        private System.Windows.Forms.BindingSource itemGetDAOBindingSource1;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.Label TotalPriceDisp;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox paymentMethodcmb;
    }
}
