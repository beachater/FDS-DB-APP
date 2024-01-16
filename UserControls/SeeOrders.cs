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
        SeeOrderDAO seeOrder = new SeeOrderDAO();
        ItemGetDAO dao = new ItemGetDAO();
        public SeeOrders()
        {
            InitializeComponent();
            seeOrderBindingSource.DataSource = seeOrder.GetOrders();
            //seeOrderItemBindingSource = seeOrder.GetOrderItems()
            //dataGridView1.DataSource = seeOrderBindingSource;
            guna2DataGridView1.DataSource = seeOrderBindingSource;
            guna2DataGridView1.Refresh();
         


        }

        private void SeeOrders_Load(object sender, EventArgs e)
        {
     

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            seeOrderBindingSource.DataSource = seeOrder.GetOrders();
  
            seeOrderBindingSource.ResetBindings(false);
          ;

        }
/*
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Get the order item ID from the selected row
                int orderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);

                // Call the DAO method to delete the order item
                dao.DeleteOrderTransaction(orderId);

                // Remove the row from the DataGridView
                dataGridView1.Rows.RemoveAt(e.RowIndex);

                // Optional: Update any totals or refresh the DataGridView
                // totalItemDataGrid.Refresh();
            }
        }
*/

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == guna2DataGridView1.Columns["newDelete"].Index && e.RowIndex >= 0)
            {
                // Get the order item ID from the selected row
                int orderId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);

                // Call the DAO method to delete the order item
                dao.DeleteOrderTransaction(orderId);

                // Remove the row from the DataGridView
                guna2DataGridView1.Rows.RemoveAt(e.RowIndex);

              
            }
            if (e.ColumnIndex == guna2DataGridView1.Columns["newCheckItem"].Index && e.RowIndex >= 0)
            {
                    Console.WriteLine(" check item check item check items");

                
                int orderId = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);

                seeOrderItemBindingSource.DataSource = seeOrder.GetOrderItems(orderId);
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
                        dao.UpdateOrderStatus(orderId, selectedValue);

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
    }
}
