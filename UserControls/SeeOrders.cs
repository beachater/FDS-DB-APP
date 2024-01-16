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
    public partial class SeeOrders : UserControl
    {
        BindingSource seeOrderBindingSource = new BindingSource();
        SeeOrderDAO seeOrder = new SeeOrderDAO();
        ItemGetDAO dao = new ItemGetDAO();
        public SeeOrders()
        {
            InitializeComponent();
            seeOrderBindingSource.DataSource = seeOrder.GetOrders();
            dataGridView1.DataSource = seeOrderBindingSource;
            guna2DataGridView1.DataSource = seeOrderBindingSource;
            dataGridView1.Refresh();
         


        }

        private void SeeOrders_Load(object sender, EventArgs e)
        {
     

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            seeOrderBindingSource.DataSource = seeOrder.GetOrders();
  
            seeOrderBindingSource.ResetBindings(false);
          ;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Get the order item ID from the selected row
                int orderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);

                // Call the DAO method to delete the order item
                dao.DeleteOrderTransaction(orderId);

                // Remove the row from the DataGridView
                dataGridView1.Rows.RemoveAt(e.RowIndex);

                // Optional: Update any totals or refresh the DataGridView
                // totalItemDataGrid.Refresh();
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Get the order item ID from the selected row
                int orderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);

                // Call the DAO method to delete the order item
                dao.DeleteOrderTransaction(orderId);

                // Remove the row from the DataGridView
                dataGridView1.Rows.RemoveAt(e.RowIndex);

                // Optional: Update any totals or refresh the DataGridView
                // totalItemDataGrid.Refresh();
            }

        }
    }
}
