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
    public partial class GlassOrders : UserControl
    {
        private ItemGetDAO itemDAO;
        private int orderId;
        //private CustomerOrderTransactionDAO dao = new CustomerOrderTransactionDAO();
        public GlassOrders(ItemGetDAO itemDAO) : this()  // Overloaded constructor
        {
            this.itemDAO = itemDAO;  // Set the instance
        }
        public GlassOrders()
        {
            InitializeComponent();
        }
        private void LoadFabricTypes()
        {
            try
            {
                List<string> glasstypes = CustomerOrderTransactionDAO.Instance.GetGlassTypes();  // Call the method on the DAO object
                glassTypecmb.Items.AddRange(glasstypes.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading fabric types: " + ex.Message);
            }
        }
        public void SetOrderId(int orderId)
        {
            this.orderId = orderId;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void addUserControl(System.Windows.Forms.UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            glassPanel.Controls.Clear();
            glassPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void fabricTypecmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = glassTypecmb.SelectedItem.ToString();

            switch (selectedProduct)
            {
                case "Plaque":
                    itemDAO.SetOrderId(orderId);

                    PlaqueGlass plaque = new PlaqueGlass(itemDAO);
                    plaque.SetOrderId(this.orderId);
                    addUserControl(plaque);
                    break;
                case "Medal":
                    itemDAO.SetOrderId(orderId);

                    MedalGlass medals = new MedalGlass(itemDAO);

                    medals.SetOrderId(this.orderId);
                    addUserControl(medals);
                    break;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GlassOrders_Load(object sender, EventArgs e)
        {
            LoadFabricTypes();

        }
    }
}
