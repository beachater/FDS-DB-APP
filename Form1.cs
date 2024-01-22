using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FDS_application
{
    public partial class LoginForm : Form
    {
        private MySqlConnection mysqlconn;
      

        public LoginForm()
        {
            InitializeComponent();
            pictureBox1 = new TranspPictureBox();
            Controls.Add(pictureBox1);
            string mysqlCon = "datasource=localhost; port=3307; user=root; database=infinytartwerks; password=root";
            mysqlconn = new MySqlConnection(mysqlCon);
            
        }

       
        private void testButton_Click(object sender, EventArgs e)
        {
            frmNewService f2 = new frmNewService();
            f2.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFindService_Click(object sender, EventArgs e)
        {
            frmFindService f3 = new frmFindService();
            f3.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username2, password2;

            username2 = tbUsername.Text;
            password2 = tbPassword.Text;

            SeeOrderDAO.Instance.setUser(username2, password2);

            if (SeeOrderDAO.Instance.TestConnection())
            {
                // Connection succeeded, proceed to call user control or form
                // Example: Open a new form
                // SomeOtherForm form = new SomeOtherForm();
                //form.Show();
                ItemGetDAO.Instance.setUser(username2, password2);
                CustomerDAO.Instance.setUser(username2, password2);
                OrderHistoryDAO.Instance.setUser(username2, password2);
                Order_SuppliesDAO.Instance.setUser(username2, password2);
                CustomerOrderTransactionDAO.Instance.setUser(username2, password2);
                MessageBox.Show("Connection succeeds");
                dashOrder dashorderForm = new dashOrder();
                dashorderForm.Show();
                this.Hide();

      
            }
            else
            {
                // Connection failed, handle accordingly (show an error message, etc.)
                MessageBox.Show("Connection failed. Check your username and password.");
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
