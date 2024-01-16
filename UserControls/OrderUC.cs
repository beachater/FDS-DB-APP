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
        CustomerDAO cusDAO = new CustomerDAO();


        public OrderUC()
        {
            InitializeComponent();
            
            itemDAO.SetOrderId(orderId);

            itemDAO.DataChanged += ItemDAO_DataChanged;
            itemDAO.DataChanged += UpdateTotalPriceDisplay;


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
            itemDAO.SetOrderId(orderId);

            BannersOrders uc = new BannersOrders(itemDAO);
            uc.SetOrderId(this.orderId);
            addUserControl(uc);
        }

        private void gGlassButton_Click(object sender, EventArgs e)
        {
            itemDAO.SetOrderId(orderId);

            GlassOrders uc = new GlassOrders(itemDAO);
            uc.SetOrderId(this.orderId);
            addUserControl(uc);
        }

        private void gWoodButton_Click(object sender, EventArgs e)
        {
            itemDAO.SetOrderId(orderId);

            WoodOrders uc = new WoodOrders(itemDAO);
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

        private void totalItemDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the column where you want to trigger the deletion
            // Check if the clicked cell is in the button column
            if (e.ColumnIndex == totalItemDataGrid.Columns["deleteColumn"].Index && e.RowIndex >= 0)
            {
                // Get the order item ID from the selected row
                int orderItemId = Convert.ToInt32(totalItemDataGrid.Rows[e.RowIndex].Cells["ID"].Value);

                // Call the DAO method to delete the order item
                itemDAO.DeleteOrderItemSpecifications(orderItemId);

                // Remove the row from the DataGridView
                totalItemDataGrid.Rows.RemoveAt(e.RowIndex);

                // Optional: Update any totals or refresh the DataGridView
                // totalItemDataGrid.Refresh();
            }
        }
        public void UpdateTotalPriceDisplay(object sender, EventArgs e)
        {
            // Update the text of the label based on the entered quantity and size
            TotalPriceDisp.Text = $"{itemDAO.GetSumOfUnitPrices(this.orderId)} PHP";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ComboBox
            if (paymentMethodcmb.SelectedIndex != -1)
            {
                // Get the selected payment method
                string paymentMethod = paymentMethodcmb.SelectedItem.ToString();

                // Now you can use the paymentMethod variable in your method call
                cusDAO.UpdateOrderTransactionAndAddPayment(orderId, itemDAO.GetSumOfUnitPrices(this.orderId), paymentMethod);
                MessageBox.Show("SUcces");

            }
            else
            {
                // Handle the case where no payment method is selected
                MessageBox.Show("Please select a payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void paymentMethodcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
