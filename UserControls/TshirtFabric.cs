using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace FDS_application.UserControls
{
    public partial class TshirtFabric : UserControl
    {
        private int orderId;
        private string productSKU = "Infi1";
        private string size;
        private ItemGetDAO itemDAO;

        public void SetOrderId(int orderId)
        {
            this.orderId = orderId;
        }
        private CustomerDAO orderDAO = new CustomerDAO();

        public TshirtFabric(ItemGetDAO itemDAO) : this()  // Overloaded constructor
        {
            this.itemDAO = itemDAO;  // Set the instance
        }
        public TshirtFabric()
        {
            InitializeComponent();
            quanTxt.TextChanged += quanTxt_TextChanged;
            sizeText1.TextChanged += sizeText1_TextChanged;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void quanTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, backspace, and enter key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            int quantity;
            size = sizeText1.Text;
            string design = designText2.Text;
            string material = materialTxt2.Text;
            string note = noteText2.Text;


            // Check if the quantity is a valid integer
            if (int.TryParse(quanTxt.Text, out quantity))
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


        private void quanTxt_TextChanged(object sender, EventArgs e)
        {
            // Update the price display based on the new size and quantity
            UpdatePriceDisplay();
        }

        private void sizeText1_TextChanged(object sender, EventArgs e)
        {
            // Update the price display based on the new size and quantity
            size = sizeText1.Text;
            UpdatePriceDisplay();
        }

        private void UpdatePriceDisplay()
        {
            // Check if both the quantity and size are valid integers
            if (int.TryParse(quanTxt.Text, out int quantity) && !string.IsNullOrEmpty(size))
            {
                // Update the text of the label based on the entered quantity and size
                priceDisplay.Text = $"{orderDAO.GetUnitPriceBySkuAndSize(productSKU, size) * quantity} PHP";
            }
            else
            {
                // Handle invalid input, e.g., display an error message
                priceDisplay.Text = "Invalid input";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TshirtFabric_Load(object sender, EventArgs e)
        {

        }
    }
}
