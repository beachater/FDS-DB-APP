using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using MaterialSkin;
using FDS_application.UserControls;

namespace FDS_application
{
    public partial class dashOrder : Form
    {

       
        public dashOrder()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Load_1(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //this.showOrderPanel.Visible = true;
            //this.showSuppliesPanel.Visible = false;
        }
        /*
        private void dashOrder_MouseEnter(object sender, EventArgs e)
        {
            this.dashboardOrderPanel.BackColor = Color.LightBlue; // Change background color
            this.dashboardOrderPanel.Size = new Size(this.dashboardOrderPanel.Width + 5, this.dashboardOrderPanel.Height + 5); // Increase size
        }

        private void dashOrder_MouseLeave(object sender, EventArgs e)
        {
            this.dashboardOrderPanel.BackColor = Color.FromArgb(186, 189, 141); // Revert to default color
            this.dashboardOrderPanel.Size = new Size(this.dashboardOrderPanel.Width - 5, this.dashboardOrderPanel.Height - 5);
        }
        
        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void dashboardSuppliesPanel_MouseEnter(object sender, EventArgs e)
        {
            this.dashboardSuppliesPanel.BackColor = Color.LightBlue; // Change background color
            this.dashboardSuppliesPanel.Size = new Size(this.dashboardSuppliesPanel.Width + 5, this.dashboardSuppliesPanel.Height + 5); // Increase size
        }

        private void dashboardSuppliersPanel_MouseEnter(object sender, EventArgs e)
        {
            this.dashboardSuppliersPanel.BackColor = Color.LightBlue; // Change background color
            this.dashboardSuppliersPanel.Size = new Size(this.dashboardSuppliersPanel.Width + 5, this.dashboardSuppliersPanel.Height + 5); // Increase size
        }

        private void dashboardOrderSuppliesPanel_MouseEnter(object sender, EventArgs e)
        {
            this.dashboardOrderSuppliesPanel.BackColor = Color.LightBlue; // Change background color
            this.dashboardOrderSuppliesPanel.Size = new Size(this.dashboardOrderSuppliesPanel.Width + 5, this.dashboardOrderSuppliesPanel.Height + 5); // Increase size
        }

        private void dashboardResourcesHistory_MouseEnter(object sender, EventArgs e)
        {
            this.dashboardResourcesHistory.BackColor = Color.LightBlue; // Change background color
            this.dashboardResourcesHistory.Size = new Size(this.dashboardResourcesHistory.Width + 5, this.dashboardResourcesHistory.Height + 5); // Increase size
        }

        private void dashboardSuppliesPanel_MouseLeave(object sender, EventArgs e)
        {
            this.dashboardSuppliesPanel.BackColor = Color.FromArgb(186, 189, 141); // Revert to default color
            this.dashboardSuppliesPanel.Size = new Size(this.dashboardSuppliesPanel.Width - 5, this.dashboardSuppliesPanel.Height - 5);
        }

        private void dashboardSuppliersPanel_MouseLeave(object sender, EventArgs e)
        {
            this.dashboardSuppliersPanel.BackColor = Color.FromArgb(186, 189, 141); // Revert to default color
            this.dashboardSuppliersPanel.Size = new Size(this.dashboardSuppliersPanel.Width - 5, this.dashboardSuppliersPanel.Height - 5);
        }

        private void dashboardOrderSuppliesPanel_MouseLeave(object sender, EventArgs e)
        {
            this.dashboardOrderSuppliesPanel.BackColor = Color.FromArgb(186, 189, 141); // Revert to default color
            this.dashboardOrderSuppliesPanel.Size = new Size(this.dashboardOrderSuppliesPanel.Width - 5, this.dashboardOrderSuppliesPanel.Height - 5);
        }

        private void dashboardResourcesHistory_MouseLeave(object sender, EventArgs e)
        {
            this.dashboardResourcesHistory.BackColor = Color.FromArgb(186, 189, 141); // Revert to default color
            this.dashboardResourcesHistory.Size = new Size(this.dashboardResourcesHistory.Width - 5, this.dashboardResourcesHistory.Height - 5);
        }
        */
        /*private void dashboardOrderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //this.showOrderPanel.Visible = false;
            //this.showSuppliesPanel.Visible = true;
        }
        */
        
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Clear();
            dashboardPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void gOrderButton_Click(object sender, EventArgs e)
        {
            customerInfoUC uc = new customerInfoUC();
            addUserControl(uc);
        }

        private void panel1_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void gSuppliesButton_Click(object sender, EventArgs e)
        {
            SuppliesUC uc1 = new SuppliesUC();
            addUserControl(uc1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SeeOrders soUc = new SeeOrders();
            addUserControl(soUc);
        }

    }
}
