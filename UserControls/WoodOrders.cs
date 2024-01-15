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
    public partial class WoodOrders : UserControl
    {
        private int orderId;
        private string productSKU = "Infi6";
        private string size;
        private ItemGetDAO itemDAO;

        private CustomerDAO orderDAO = new CustomerDAO();
        public WoodOrders(ItemGetDAO itemDAO) : this()  // Overloaded constructor
        {
            this.itemDAO = itemDAO;  // Set the instance
        }
        public WoodOrders()
        {
            InitializeComponent();
            QuantityTxt.TextChanged += quantityTxt_TextChanged;
            SizeTxt.TextChanged += sizeTxt_TextChanged;
        }
        public void SetOrderId(int orderId)
        {
            this.orderId = orderId;
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
            size = SizeTxt.Text;
            string design = DesignTxt.Text;
            string note = NoteTxt.Text;
            string material = null;

            // Check if the quantity is a valid integer
            if (int.TryParse(QuantityTxt.Text, out quantity))
            {
                // Now 'quantity' holds the parsed integer value

                if (string.IsNullOrEmpty(size))
                {
                    MessageBox.Show("Please enter a valid size.");
                    return;
                }

                // Convert size to an integer
                if (int.TryParse(size, out int sizeValue))
                {
                    // Check and adjust size based on different conditions
                    if (sizeValue <= 35)
                    {
                        sizeValue = 35;
                    }
                    else if (sizeValue <= 60)
                    {
                        sizeValue = 60;
                    }
                    else if (sizeValue <= 108)
                    {
                        sizeValue = 108;
                    }
                    else
                    {
                        sizeValue = 109; // Set a default value for sizes greater than 1000
                    }

                    size = sizeValue.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid size.");
                    return;
                }

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
        private void quantityTxt_TextChanged(object sender, EventArgs e)
        {
            UpdatePriceDisplay();
        }

        private void sizeTxt_TextChanged(object sender, EventArgs e)
        {
            //size = sizeTxt.Text;
            if (int.TryParse(SizeTxt.Text, out int sizeValue))
            {
                // Check and adjust size based on different conditions
                if (sizeValue <= 35)
                {
                    sizeValue = 35;
                }
                else if (sizeValue <= 60)
                {
                    sizeValue = 60;
                }
                else if (sizeValue <= 108)
                {
                    sizeValue = 108;
                }
                else
                {
                    sizeValue = 109; // Set a default value for sizes greater than 1000
                }

                size = sizeValue.ToString();
            }
            UpdatePriceDisplay();
        }

        private void UpdatePriceDisplay()
        {
            // Check if both the quantity and size are valid integers
            if (int.TryParse(QuantityTxt.Text, out int quantity) && !string.IsNullOrEmpty(size))
            {
                // Update the text of the label based on the entered quantity and size
                priceDisplay3.Text = $"{orderDAO.GetUnitPriceBySkuAndSize(productSKU, size) * quantity} PHP";
            }
            else
            {
                // Handle invalid input, e.g., display an error message
                priceDisplay3.Text = "Invalid input";
            }
        }
    }
}
