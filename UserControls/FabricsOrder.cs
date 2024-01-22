using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FDS_application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FDS_application.UserControls
{
    public partial class FabricsOrder :System.Windows.Forms.UserControl
    {
        private int orderId;
        //private CustomerOrderTransactionDAO dao = new CustomerOrderTransactionDAO();
        private ItemGetDAO itemDAO;

        public FabricsOrder(ItemGetDAO itemDAO) : this()  // Overloaded constructor
        {
            
            this.itemDAO = itemDAO;  // Set the instance
        }
        public FabricsOrder()
        {
            InitializeComponent();
            //itemDAO = new ItemGetDAO();
        }
        public void SetOrderId(int orderId)
        {
            this.orderId = orderId;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadFabricTypes()
        {
            try
            {
                List<string> fabricTypes = CustomerOrderTransactionDAO.Instance.GetFabricTypes();  // Call the method on the DAO object
                fabricTypecmb.Items.AddRange(fabricTypes.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading fabric types: " + ex.Message);
            }
        }

        private void FabricsOrder_Load(object sender, EventArgs e)
        {
            LoadFabricTypes();
        }
        private void addUserControl(System.Windows.Forms.UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void fabricTypecmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = fabricTypecmb.SelectedItem.ToString();

            switch (selectedProduct)
            {
                case "T-shirt":
                    TshirtFabric tshirt = new TshirtFabric(itemDAO);
                    tshirt.SetOrderId(this.orderId);
                    addUserControl(tshirt);
                    break;
                case "Laces":
                    LacesFabric laces = new LacesFabric(itemDAO);
                    laces.SetOrderId(this.orderId);
                    addUserControl(laces);
                    break;
            }
        }
    }
}
