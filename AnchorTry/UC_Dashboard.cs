using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace AnchorTry
{
    public partial class UC_Dashboard : UserControl
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Narvs\source\repos\AnchorTry\AnchorTry\Database.mdf;Integrated Security=True";

        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            //Videoke
            using (var con = new SqlConnection(conString))
            {
                con.Open();
                string qry = "Select SUM(Payment) AS TotalPayment from tbl_reservation";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    object result = cmd.ExecuteScalar();
                    decimal totalPayment = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    lblTotalVideoke.Text = totalPayment.ToString();
                }
            }

            //Printshop
            using (var con = new SqlConnection(conString))
            {
                con.Open();
                string qry = "Select SUM(Amount) AS TotalPayment from tbl_printshop";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    object result = cmd.ExecuteScalar();
                    decimal totalPayment = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    lblTotalPrintshop.Text = totalPayment.ToString();
                }
            }

            //E-Wallet
            using (var con = new SqlConnection(conString))
            {
                con.Open();
                string qry = "Select SUM(Total) AS TotalPayment from tbl_eWallet";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    object result = cmd.ExecuteScalar();
                    decimal totalPayment = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    lblEWallet.Text = totalPayment.ToString();
                }
            }
        }
    }
}
