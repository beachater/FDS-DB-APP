using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FDS_application.UserControls
{
    public partial class SuppliesUC : UserControl
    {
        BindingSource suppliesBindingSource = new BindingSource();
        BindingSource supplyOrderedBindingSource = new BindingSource();
        //Order_SuppliesDAO supDAO = new Order_SuppliesDAO();
        //SeeOrderDAO soDAO = new SeeOrderDAO();

        public SuppliesUC()
        {
            InitializeComponent();
            suppliesBindingSource.DataSource = Order_SuppliesDAO.Instance.GetStock();
            productsDataGridView1.DataSource = suppliesBindingSource;
            supplyOrderedBindingSource.DataSource = SeeOrderDAO.Instance.GetSupplyOrders();
            SODataGridView.DataSource = supplyOrderedBindingSource;
            prodcutStocksDataGrid.Refresh();
            SODataGridView.Refresh();

            quanTxt.KeyPress += NumericTextBox_KeyPress;
            amountTxt.KeyPress += DecimalTextBox_KeyPress;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void LoadProducts()
        {
            try
            {
                List<string> product = SeeOrderDAO.Instance.GetProducts();  // Call the method on the DAO object
                productCmb.Items.AddRange(product.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading fabric types: " + ex.Message);
            }
        }
        private void LoadSuppliers()
        {
            try
            {
                supplierCmb.Items.Clear();  // Clear existing items before adding new ones

                List<string> suppliers = SeeOrderDAO.Instance.GetSupplierNames(productCmb.SelectedItem.ToString());
                supplierCmb.Items.AddRange(suppliers.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading fabric types: " + ex.Message);
            }
        }
        private void quanTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SuppliesUC_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void productCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void supplierCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DecimalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters, and a single dot for decimals
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one dot in the textbox
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string sku = Order_SuppliesDAO.Instance.GetSku(productCmb.SelectedItem.ToString());

            if (int.TryParse(quanTxt.Text, out int quantity) && decimal.TryParse(amountTxt.Text, out decimal amount))
            {
                string supplier = supplierCmb.SelectedItem.ToString();
                Order_SuppliesDAO.Instance.InsertSupplyOrder(quantity, amount, supplier, sku);

                supplyOrderedBindingSource.DataSource = SeeOrderDAO.Instance.GetSupplyOrders();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values for quantity and amount.");
            }
            SODataGridView.Refresh();

        }

        private void productsDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void SODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == SODataGridView.Columns["in_stock"].Index && e.RowIndex >= 0)
            {
                SODataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);

                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)SODataGridView.Rows[e.RowIndex].Cells["in_stock"];

                bool isChecked = !Convert.ToBoolean(cell.Value);

                // Retrieve the relevant data for the row
                int supplyId = Convert.ToInt32(SODataGridView.Rows[e.RowIndex].Cells["SupplyID"].Value);
                string sku = Order_SuppliesDAO.Instance.GetSku(SODataGridView.Rows[e.RowIndex].Cells["Product"].Value.ToString());

                // Update the database with the new value
                Order_SuppliesDAO.Instance.UpdateInStockStatus(supplyId, isChecked, sku);
            }
            else if (e.ColumnIndex == SODataGridView.Columns["supDelete"].Index && e.RowIndex >= 0)
            {
                // Get the order item ID from the selected row
                int supplyID = Convert.ToInt32(SODataGridView.Rows[e.RowIndex].Cells["SupplyID"].Value);

                // Call the DAO method to delete the order item
                bool deleted = Order_SuppliesDAO.Instance.DeleteSupplyOrderItem(supplyID);

                if (deleted)
                {
                    Console.WriteLine($"Successfully deleted supply order item with SupplyID: {supplyID}");
                }
                else
                {
                    Console.WriteLine($"Failed to delete supply order item with SupplyID: {supplyID}");
                }

                // Remove the row from the DataGridView
                SODataGridView.Rows.RemoveAt(e.RowIndex);
            }

            supplyOrderedBindingSource.DataSource = SeeOrderDAO.Instance.GetSupplyOrders();
            suppliesBindingSource.DataSource = Order_SuppliesDAO.Instance.GetStock();
            prodcutStocksDataGrid.Refresh();
            SODataGridView.Refresh();

        }
    }
}
