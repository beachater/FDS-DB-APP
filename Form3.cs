﻿using System;
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
    public partial class frmFindService : Form
    {
        public frmFindService()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            Tst f1 = new Tst();
            f1.Show();
            this.Hide();
        }
    }
}
