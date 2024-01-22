using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FDS_application;



namespace FDS_application.UserControls
{
    public partial class customerInfoUC : UserControl
    {
        //private CustomerDAO cusDAO = new CustomerDAO();
        private int orderId;
        public customerInfoUC()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Clear();
            dashboardPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public string FirstName
        {
            get { return firstnameTxt.Text; }
        }

        public string LastName
        {
            get { return lastnameTxt.Text; }
        }
        public void SetOrderId(int orderId)
        {
            this.orderId = orderId;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string firstName = firstnameTxt.Text;
            string lastName = lastnameTxt.Text;
            string phoneNum = contactnumTxt.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please fill in both first name and last name.");
                return;
            }

            bool success = CustomerDAO.Instance.InsertCustomer(firstName, lastName, phoneNum);

            if (success)
            {
                MessageBox.Show("Customer inserted successfully!");

                // Retrieve the customer ID
                string customerId = CustomerDAO.Instance.GetCustomerId(firstName, lastName);

                // Insert organization
                if (!string.IsNullOrWhiteSpace(organizationTxt.Text))
                {
                    int orgId = CustomerDAO.Instance.InsertOrganization(customerId, organizationTxt.Text);
                    if (orgId > 0)
                    {
                        MessageBox.Show("Organization inserted successfully!");

                        DateTime orderDate = DateTime.Now;
                        int orderId = CustomerDAO.Instance.InsertOrderTransaction(customerId, orgId, orderDate, false);

                        if (orderId > 0)
                        {
                            string fName = this.FirstName;
                            string lName = this.LastName;

                            // Pass orderId to OrderUC
                            OrderUC uc = new OrderUC();
                            uc.SetRecipientName(fName, lName);

                            // Set orderId in OrderUC
                            uc.SetOrderId(orderId);

                            addUserControl(uc);
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert order transaction.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert organization.");
                    }
                }
                else
                {
                    // If organization is not specified, proceed without it
                    DateTime orderDate = DateTime.Now;
                    int orderId = CustomerDAO.Instance.InsertOrderTransaction(customerId, 0, orderDate, false);

                    if (orderId > 0)
                    {
                        string fName = this.FirstName;
                        string lName = this.LastName;

                        // Pass orderId to OrderUC
                        OrderUC uc = new OrderUC();
                        uc.SetRecipientName(fName, lName);

                        // Set orderId in OrderUC
                        uc.SetOrderId(orderId);

                        addUserControl(uc);
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert order transaction.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Failed to insert customer.");
            }
        }



        private void dashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
