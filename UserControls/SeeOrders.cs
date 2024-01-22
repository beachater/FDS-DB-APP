using Guna.UI2.WinForms;
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
    public partial class SeeOrders : UserControl
    {
        BindingSource seeOrderBindingSource = new BindingSource();
        BindingSource seeOrderItemBindingSource = new BindingSource();
        //SeeOrderDAO seeOrder = new SeeOrderDAO();
        //ItemGetDAO dao = new ItemGetDAO();
        public SeeOrders()
        {
            InitializeComponent();

            // Set DataSource to null to clear existing data
            guna2DataGridView1.DataSource = null;

            seeOrderBindingSource.DataSource = SeeOrderDAO.Instance.GetOrders();

            // Set the DataSource again to apply the changes
            guna2DataGridView1.DataSource = seeOrderBindingSource;

            guna2DataGridView1.DataBindingComplete += Guna2DataGridView1_DataBindingComplete;
        }

        private void SeeOrders_Load(object sender, EventArgs e)
        {
     

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == guna2DataGridView1.Columns["newDelete"].Index && e.RowIndex >= 0)
            {
                // Get the order item ID from the selected row
                int orderId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);

                // Call the DAO method to delete the order item
                ItemGetDAO.Instance.DeleteOrderTransaction(orderId);

                // Remove the row from the DataGridView
                guna2DataGridView1.Rows.RemoveAt(e.RowIndex);

              
            }
            if (e.ColumnIndex == guna2DataGridView1.Columns["newCheckItem"].Index && e.RowIndex >= 0)
            {
                    Console.WriteLine(" check item check item check items");

                
                int orderId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);

                seeOrderItemBindingSource.DataSource = SeeOrderDAO.Instance.GetOrderItems(orderId);
                guna2DataGridView2.DataSource = seeOrderItemBindingSource;
                guna2DataGridView2.Refresh();




            }

        }

        private void guna2DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = "cmbStatus";

            if (guna2DataGridView1.Columns.Contains(columnName))
            {
                int columnIndex = guna2DataGridView1.Columns[columnName].Index;

                if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
                {
                    DataGridViewComboBoxCell comboBoxCell = guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;

                    // Check if the column exists and the cell value is not null
                    if (comboBoxCell != null && comboBoxCell.Value != null)
                    {
                        // Retrieve the selected value from the ComboBox
                        string selectedValue = comboBoxCell.Value.ToString();

                        // Get the order ID from the selected row
                        int orderId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);

                        // Update the status in the database
                        ItemGetDAO.Instance.UpdateOrderStatus(orderId, selectedValue);

                        // Now you have the selected value, you can use it as needed
                        Console.WriteLine($"Selected Value: {selectedValue}");
                    }
                    else
                    {
                        // Handle the case where the column or cell value is null
                        Console.WriteLine("ComboBox column or cell value is null");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Column with name '{columnName}' does not exist.");
            }
        }
        private void Guna2DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Remove event handler before attaching to prevent multiple calls
            guna2DataGridView1.DataBindingComplete -= Guna2DataGridView1_DataBindingComplete;

            // Iterate through each row and set the selected value for the ComboBox cell
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                int orderId = Convert.ToInt32(row.Cells["OrderID"].Value);
                string status = ItemGetDAO.Instance.GetOrderStatus(orderId);

                DataGridViewComboBoxColumn cmbStatusColumn = guna2DataGridView1.Columns["cmbStatus"] as DataGridViewComboBoxColumn;
                row.Cells[cmbStatusColumn.Index].Value = status;
            }

            // Re-attach the event handler
            guna2DataGridView1.DataBindingComplete += Guna2DataGridView1_DataBindingComplete;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            // Get the search keyword from the TextBox
            string searchKeyword = searchTxt.Text.ToString().Trim().ToLower();

            // Filter the existing data based on the search keyword
            List<SeeOrderDAO.SeeOrder> filteredOrders = SeeOrderDAO.Instance.GetOrders().Where(order =>
                order.Recipient.ToLower().Contains(searchKeyword) ||
                order.PhoneN0.Contains(searchKeyword) ||
                order.OrderID.ToString().Contains(searchKeyword) ||
                order.Org.ToString().Contains(searchKeyword)
            // Add more conditions based on your needs
            ).ToList();

            // Clear existing rows in DataGridView
            guna2DataGridView1.Rows.Clear();

            // Update the BindingSource with the filtered data
            seeOrderBindingSource.DataSource = filteredOrders;

            // Refresh the DataGridView to reflect the changes
            guna2DataGridView1.Refresh();
        }
    }
}
