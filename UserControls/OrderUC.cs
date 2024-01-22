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
        private bool isCustomerDesign = false;
        //ItemGetDAO itemDAO = new ItemGetDAO();
        //CustomerDAO cusDAO = new CustomerDAO();


        public OrderUC()
        {
            InitializeComponent();

            ItemGetDAO.Instance.SetOrderId(orderId);

            ItemGetDAO.Instance.DataChanged += ItemDAO_DataChanged;
            ItemGetDAO.Instance.DataChanged += UpdateTotalPriceDisplay;


            //totalItemsBindingSource.DataSource = itemDAO.GetItems();
            //totalItemDataGrid.DataSource = totalItemsBindingSource;


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
            ItemGetDAO.Instance.SetOrderId(orderId);

            FabricsOrder uc = new FabricsOrder(ItemGetDAO.Instance);

            uc.SetOrderId(this.orderId);

            addUserControl(uc);
        }

        private void gBannersButton_Click(object sender, EventArgs e)
        {
            ItemGetDAO.Instance.SetOrderId(orderId);

            BannersOrders uc = new BannersOrders(ItemGetDAO.Instance);
            uc.SetOrderId(this.orderId);
            addUserControl(uc);
        }

        private void gGlassButton_Click(object sender, EventArgs e)
        {
            ItemGetDAO.Instance.SetOrderId(orderId);

            GlassOrders uc = new GlassOrders(ItemGetDAO.Instance);
            uc.SetOrderId(this.orderId);
            addUserControl(uc);
        }

        private void gWoodButton_Click(object sender, EventArgs e)
        {
            ItemGetDAO.Instance.SetOrderId(orderId);

            WoodOrders uc = new WoodOrders(ItemGetDAO.Instance);
            uc.SetOrderId(this.orderId);
            addUserControl(uc);
        }
        private void ItemDAO_DataChanged(object sender, EventArgs e)
        { 
            ItemGetDAO.Instance.SetOrderId(orderId);
            totalItemsBindingSource.DataSource = ItemGetDAO.Instance.GetItems();
            totalItemDataGrid.DataSource = totalItemsBindingSource;
            for (int i = totalItemDataGrid.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = totalItemDataGrid.Rows[i];

                // Check if the row is not a new, uncommitted row
                if (!row.IsNewRow &&
                    Convert.ToInt32(row.Cells["Quant"].Value) == 0 &&
                    Convert.ToInt32(row.Cells["Price"].Value) == 0 &&
                    Convert.ToInt32(row.Cells["ID"].Value) == 0)
                {
                    totalItemDataGrid.Rows.RemoveAt(i);
                }
            }

            totalItemDataGrid.Columns["deleteColumn"].Visible = true;
            
            totalItemsBindingSource.ResetBindings(false);
        }

        private void test_Click(object sender, EventArgs e)
        {
            ItemGetDAO.Instance.SetOrderId(orderId);
            totalItemsBindingSource.DataSource = ItemGetDAO.Instance.GetItems();

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
                ItemGetDAO.Instance.DeleteOrderItemSpecifications(orderItemId);

                // Remove the row from the DataGridView
                totalItemDataGrid.Rows.RemoveAt(e.RowIndex);

                // Optional: Update any totals or refresh the DataGridView
                // totalItemDataGrid.Refresh();
            }
        }
        public void UpdateTotalPriceDisplay(object sender, EventArgs e)
        {
            decimal totalPrice = ItemGetDAO.Instance.GetSumOfUnitPrices(this.orderId);

            if (!ownDes.Checked)
            {
                //Add an additional charge of 150 if the design is not from the customer
                totalPrice += 150m;
            }

            TotalPriceDisp.Text = $"{totalPrice} PHP";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ComboBox
            if (paymentMethodcmb.SelectedIndex != -1)
            {
                string paymentMethod = paymentMethodcmb.SelectedItem.ToString();

                // Pass isCustomerDesign to the UpdateOrderTransactionAndAddPayment method
                CustomerDAO.Instance.UpdateOrderTransactionAndAddPayment(orderId, ItemGetDAO.Instance.GetSumOfUnitPrices(this.orderId), paymentMethod, ownDes.Checked);

                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Please select a payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dashOrder backtoDO = new dashOrder();
            backtoDO.Show();
            this.Hide();
            

        }

        private void paymentMethodcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ownDes_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ownDes_CheckStateChanged(object sender, EventArgs e)
        {
            //isCustomerDesign = ownDes.Checked;
            decimal totalPrice = ItemGetDAO.Instance.GetSumOfUnitPrices(this.orderId);

            if (!ownDes.Checked)
            {
                // Add an additional charge of 150 if the design is not from the customer
                totalPrice += 150m;
            }
            if (ownDes.Checked)
            {
                totalPrice += 0m;
            }

            TotalPriceDisp.Text = $"{totalPrice} PHP";

        }
    }
}
