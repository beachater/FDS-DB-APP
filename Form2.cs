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
    public partial class frmNewService : Form
    {
        public frmNewService()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblTrackService_Click(object sender, EventArgs e)
        {
            UCFindService fs1 = new UCFindService();
            fs1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tst f1 = new Tst();
            f1.Show();
            this.Hide();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LightBlue; // Change background color
            panel2.Size = new Size(panel2.Width + 5, panel2.Height + 5); // Increase size
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = SystemColors.Control; // Revert to default color
            panel2.Size = new Size(panel2.Width - 5, panel2.Height - 5); // Restore original size
        }
    
        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.LightBlue; // Change background color
            panel3.Size = new Size(panel3.Width + 5, panel3.Height + 5); // Increase size
        }
        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control; // Revert to default color
            panel3.Size = new Size(panel3.Width - 5, panel3.Height - 5); // Restore original size
        }
        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.LightBlue; // Change background color
            panel4.Size = new Size(panel4.Width + 5, panel4.Height + 5); // Increase size
        }
        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = SystemColors.Control; // Revert to default color
            panel4.Size = new Size(panel4.Width - 5, panel4.Height - 5); // Restore original size
        }
        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.LightBlue; // Change background color
            panel5.Size = new Size(panel5.Width + 5, panel5.Height + 5); // Increase size
        }
        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = SystemColors.Control; // Revert to default color
            panel5.Size = new Size(panel5.Width - 5, panel5.Height - 5); // Restore original size
        }
        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = Color.LightBlue; // Change background color
            panel6.Size = new Size(panel6.Width + 5, panel6.Height + 5); // Increase size
        }
        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = SystemColors.Control; // Revert to default color
            panel6.Size = new Size(panel6.Width - 5, panel6.Height - 5); // Restore original size
        }
        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = Color.LightBlue; // Change background color
            panel7.Size = new Size(panel7.Width + 5, panel7.Height + 5); // Increase size
        }
        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = SystemColors.Control; // Revert to default color
            panel7.Size = new Size(panel7.Width - 5, panel7.Height - 5); // Restore original size
        }

       
    }
}
