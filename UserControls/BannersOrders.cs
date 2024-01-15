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
    public partial class BannersOrders : UserControl
    {
        private int orderId;
        private string productSKU = "Infi3";
        private string size;
        private ItemGetDAO itemDAO;
        private CustomerDAO orderDAO = new CustomerDAO();
        public void SetOrderId(int orderId)
        {
            this.orderId = orderId;
        }
        public BannersOrders(ItemGetDAO itemDAO) : this()  // Overloaded constructor
        {
            this.itemDAO = itemDAO;  // Set the instance
        }
        public BannersOrders()
        {
            InitializeComponent();
            quantityTxt.TextChanged += quantityTxt_TextChanged;
            sizeTxt.TextChanged += sizeTxt_TextChanged;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and enter key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void BannersOrders_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int quantity;
            size = sizeTxt.Text;
            string design = designTxt.Text;
            string note = noteTxt.Text;
            string material = null;

            // Check if the quantity is a valid integer
            if (int.TryParse(quantityTxt.Text, out quantity))
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
                    if (sizeValue <= 100)
                    {
                        sizeValue = 100;
                    }
                    else if (sizeValue <= 500)
                    {
                        sizeValue = 500;
                    }
                    else if (sizeValue <= 1000)
                    {
                        sizeValue = 1000;
                    }
                    else if (sizeValue > 1000)
                    {
                        sizeValue = 1001; // Set a default value for sizes greater than 1000
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
            if (int.TryParse(sizeTxt.Text, out int sizeValue))
            {
                // Check and adjust size based on different conditions
                if (sizeValue <= 100)
                {
                    sizeValue = 100;
                }
                else if (sizeValue <= 500)
                {
                    sizeValue = 500;
                }
                else if (sizeValue <= 1000)
                {
                    sizeValue = 1000;
                }
                else if (sizeValue > 1000)
                {
                    sizeValue = 1001; // Set a default value for sizes greater than 1000
                }

                size = sizeValue.ToString();
            }
            UpdatePriceDisplay();
        }

        private void UpdatePriceDisplay()
        {
            // Check if both the quantity and size are valid integers
            if (int.TryParse(quantityTxt.Text, out int quantity) && !string.IsNullOrEmpty(size))
            {
                // Update the text of the label based on the entered quantity and size
                priceDisplay2.Text = $"{orderDAO.GetUnitPriceBySkuAndSize(productSKU, size) * quantity} PHP";
            }
            else
            {
                // Handle invalid input, e.g., display an error message
                priceDisplay2.Text = "Invalid input";
            }
        }


    }
}
