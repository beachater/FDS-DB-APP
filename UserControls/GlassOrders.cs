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
        private int orderId;
        private CustomerOrderTransactionDAO dao = new CustomerOrderTransactionDAO();
        public GlassOrders()
        {
            InitializeComponent();
        }
        private void LoadFabricTypes()
        {
            try
            {
                List<string> glasstypes = dao.GetGlassTypes();  // Call the method on the DAO object
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
                    PlaqueGlass plaque = new PlaqueGlass();
                    plaque.SetOrderId(this.orderId);
                    addUserControl(plaque);
                    break;
                case "Medal":
                    MedalGlass medals = new MedalGlass();
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
