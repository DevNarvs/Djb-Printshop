﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AnchorTry
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipsem,
            int nHeightEllipse
            );

        public Dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
        }
        //auto generated reference
        static string GenerateReferenceNumber()
        {
            // Use current date/time to ensure uniqueness
            string timestamp = DateTime.Now.ToString("MMddss");

            // Generate a random number
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 999); // Adjust range as needed

            // Combine timestamp and random number to create the reference
            string referenceNumber = timestamp + randomNumber.ToString();

            return referenceNumber;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
        }
        private void btnPrintshop_Click(object sender, EventArgs e)
        {
            UC_PlainPaper uc = new UC_PlainPaper();
            addUserControl(uc);

            uc.lblReference.Text = GenerateReferenceNumber();
        }

        private void btnWallets_Click(object sender, EventArgs e)
        {
            ucWallets uc = new ucWallets();
            addUserControl(uc);
        }
    }
}
