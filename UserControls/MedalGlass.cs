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
    public partial class MedalGlass : UserControl
    {
        private int orderId;
        private string productSKU = "Infi5";
        private string size;
        private ItemGetDAO itemDAO;
        private CustomerDAO orderDAO = new CustomerDAO();

        public MedalGlass(ItemGetDAO itemDAO) : this()  // Overloaded constructor
        {
            this.itemDAO = itemDAO;  // Set the instance
        }
        public MedalGlass()
        {
            InitializeComponent();
            QuantityTxt.TextChanged += PriceDisplay_TextChanged;
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
            size = null;
            string design = DesignTxt.Text;
            string note = noteTxt.Text;
            string material = null;

            // Check if the quantity is a valid integer
            if (int.TryParse(QuantityTxt.Text, out quantity))
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
            if (int.TryParse(QuantityTxt.Text, out int quantity))
            {
                // Update the text of the label based on the entered quantity
                priceDisplay4.Text = $"{orderDAO.GetUnitPriceBySkuAndSize(productSKU, size) * quantity} PHP";
            }
            else
            {
                // Handle invalid input, e.g., display an error message
                priceDisplay4.Text = "Invalid input";
            }
        }

    }
}
