﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnchorTry
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChangePricing cp = new ChangePricing();
            this.Hide();
            cp.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnVideoke_Click(object sender, EventArgs e)
        {
            AddVideoke addVideoke = new AddVideoke();
            addVideoke.Show();
            this.Hide();
        }
    }
}
