using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDS_application.UserControls
{
    public partial class OrderUC : System.Windows.Forms.UserControl
    {
        BindingSource totalItemsBindingSource = new BindingSource();
        private int orderId;
        ItemGetDAO itemDAO = new ItemGetDAO();


        public OrderUC()
        {
            InitializeComponent();
            
            itemDAO.SetOrderId(orderId);

            itemDAO.DataChanged += ItemDAO_DataChanged;

            totalItemsBindingSource.DataSource = itemDAO.GetItems();
            totalItemDataGrid.DataSource = totalItemsBindingSource;

        }
        public void SetRecipientName(string firstName, string lastName)
        {
            
            recipientLabel.Text = $"{firstName} {lastName}";
        }
        public void SetOrderId(int orderId)
        {
            this.orderId = orderId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void addUserControl(System.Windows.Forms.UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ordersPanel.Controls.Clear();
            ordersPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void gOrderButton_Click(object sender, EventArgs e)
        {
            
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //ItemGetDAO itemDAO = new ItemGetDAO();
            itemDAO.SetOrderId(orderId);

            FabricsOrder uc = new FabricsOrder(itemDAO);

            uc.SetOrderId(this.orderId);

            addUserControl(uc);
        }

        private void gBannersButton_Click(object sender, EventArgs e)
        {
            BannersOrders uc = new BannersOrders();
            uc.SetOrderId(this.orderId);
            addUserControl(uc);
        }

        private void gGlassButton_Click(object sender, EventArgs e)
        {
            GlassOrders uc = new GlassOrders();
            uc.SetOrderId(this.orderId);
            addUserControl(uc);
        }

        private void gWoodButton_Click(object sender, EventArgs e)
        {
            WoodOrders uc = new WoodOrders();
            uc.SetOrderId(this.orderId);
            addUserControl(uc);
        }
        private void ItemDAO_DataChanged(object sender, EventArgs e)
        {
            totalItemsBindingSource.DataSource = itemDAO.GetItems();
            itemDAO.SetOrderId(orderId);
            totalItemsBindingSource.ResetBindings(false);
        }

        private void test_Click(object sender, EventArgs e)
        {
            itemDAO.SetOrderId(orderId);
            totalItemsBindingSource.DataSource = itemDAO.GetItems();

            totalItemsBindingSource.ResetBindings(false);
            

        }

    }
}
