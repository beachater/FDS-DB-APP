using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDS_application
{
    public partial class LacesFabric : UserControl
    {
        private int orderId;
        private string productSKU = "Infi2";
        private string size;
        private ItemGetDAO itemDAO;

        public void SetOrderId(int orderId)
        {
            this.orderId = orderId;
        }
        private CustomerDAO orderDAO = new CustomerDAO();
        public LacesFabric(ItemGetDAO itemDAO) : this()  // Overloaded constructor
        {
            this.itemDAO = itemDAO;  // Set the instance
        }
        public LacesFabric()
        {
            InitializeComponent();
            quantityTxt.TextChanged += PriceDisplay_TextChanged;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tshirtFabric1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and enter key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int quantity;
            size = null;
            string design = designTxt.Text;
            string note = noteTxt.Text;
            string material = null;

            // Check if the quantity is a valid integer
            if (int.TryParse(quantityTxt.Text, out quantity))
            {
                // Now 'quantity' holds the parsed integer value
                int orderItemId = orderDAO.InsertOrderItem(orderId, productSKU, quantity, size);

                if (orderItemId > 0)
                {
                    // Insert order item specifications
                    bool orderItemSpecInserted = orderDAO.insertOrderItemSpecifications(orderItemId, size, design, material, note);

                    if (orderItemSpecInserted)
                    {
                        MessageBox.Show("Order item and specifications added successfully");
                    }
                    else
                    {
                        // Handle the case when order item specifications insertion fails
                        MessageBox.Show("Failed to insert order item specifications.");
                    }
                }
                else
                {
                    // Handle the case when order item insertion fails
                    MessageBox.Show("Failed to insert order item.");
                }
            }
            else
            {
                // Handle the case where parsing fails (invalid input)
                MessageBox.Show("Please enter a valid quantity.");
            }
            itemDAO.RaiseDataChanged();

        }

        private void PriceDisplay_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(quantityTxt.Text, out int quantity))
            {
                // Update the text of the label based on the entered quantity
                priceDisplay1.Text = $"{orderDAO.GetUnitPriceBySkuAndSize(productSKU, size) * quantity} PHP";
            }
            else
            {
                // Handle invalid input, e.g., display an error message
                priceDisplay1.Text = "Invalid input";
            }
        }
    
    }
}
