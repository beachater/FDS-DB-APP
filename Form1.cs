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
    public partial class Tst : Form
    {
        private MySqlConnection mysqlconn;
      

        public Tst()
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
            string username, password;

            username = tbUsername.Text;
            password = tbPassword.Text;


            String query = "SELECT * FROM USERS WHERE userName = '"+tbUsername.Text+"' AND password = '"+tbPassword.Text+"' ";
            MySqlDataAdapter msda = new MySqlDataAdapter(query, mysqlconn);

            DataTable dtable = new DataTable();
            msda.Fill(dtable);

            if(dtable.Rows.Count > 0)
            {
                username = tbUsername.Text;
                password = tbPassword.Text;

                dashOrder d1 = new dashOrder();
                d1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid deets");
            }
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
