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

namespace FDS_application
{
    public partial class OrderHistory : UserControl
    {
        BindingSource seeOrderHistoryBindingSource = new BindingSource();
        BindingSource seeOrderItemHistoryBindingSource = new BindingSource();
        OrderHistoryDAO ordH = new OrderHistoryDAO();
        SeeOrderDAO seeOrder = new SeeOrderDAO();
        ItemGetDAO dao = new ItemGetDAO();
        public OrderHistory()
        {
            InitializeComponent();
            seeOrderHistoryBindingSource.DataSource = ordH.GetOrderHistory();
            orderHistorDataGrid.DataSource = seeOrderHistoryBindingSource;
            orderHistorDataGrid.Refresh();
            

        }

        private void orderHistorDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == orderHistorDataGrid.Columns["newCheckItem"].Index && e.RowIndex >= 0)
            {
                Console.WriteLine(" check item check item check items");


                int orderId = Convert.ToInt32(orderHistorDataGrid.Rows[e.RowIndex].Cells["OrderID"].Value);

                seeOrderItemHistoryBindingSource.DataSource = seeOrder.GetOrderItems(orderId);
                checkOHItemDataGrid.DataSource = seeOrderItemHistoryBindingSource;
                checkOHItemDataGrid.Refresh();




            }
        }
    }
}
