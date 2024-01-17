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
    public partial class SuppliesUC : UserControl
    {
        BindingSource suppliesBindingSource = new BindingSource();
        BindingSource supplyOrderedBindingSource = new BindingSource();
        Order_SuppliesDAO supDAO = new Order_SuppliesDAO();
        SeeOrderDAO soDAO = new SeeOrderDAO();

        public SuppliesUC()
        {
            InitializeComponent();
            suppliesBindingSource.DataSource = supDAO.GetStock();
            productsDataGridView1.DataSource = suppliesBindingSource;
            supplyOrderedBindingSource.DataSource = soDAO.GetSupplyOrders();
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
                List<string> product = soDAO.GetProducts();  // Call the method on the DAO object
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

                List<string> suppliers = soDAO.GetSupplierNames(productCmb.SelectedItem.ToString());
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
            string sku = supDAO.GetSku(productCmb.SelectedItem.ToString());

            if (int.TryParse(quanTxt.Text, out int quantity) && decimal.TryParse(amountTxt.Text, out decimal amount))
            {
                string supplier = supplierCmb.SelectedItem.ToString();
                supDAO.InsertSupplyOrder(quantity, amount, supplier, sku);

                supplyOrderedBindingSource.DataSource = soDAO.GetSupplyOrders();
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
                string sku = supDAO.GetSku(SODataGridView.Rows[e.RowIndex].Cells["Product"].Value.ToString());

                // Update the database with the new value
                supDAO.UpdateInStockStatus(supplyId, isChecked, sku);
            }
            supplyOrderedBindingSource.DataSource = soDAO.GetSupplyOrders();
            suppliesBindingSource.DataSource = supDAO.GetStock();


            prodcutStocksDataGrid.Refresh();
            SODataGridView.Refresh();

        }
    }
}
