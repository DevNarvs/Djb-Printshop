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
namespace AnchorTry
{
    public partial class ChangePricing : Form
    {
        string itemName = "";
        public ChangePricing()
        {
            InitializeComponent();
        }
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Narvs\source\repos\AnchorTry\AnchorTry\Database.mdf;Integrated Security=True";


        private void ChangePricing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbsetPriceList.tbl_PriceList' table. You can move, or remove it, as needed.
            this.tbl_PriceListTableAdapter.Fill(this.dbsetPriceList.tbl_PriceList);

        }
        private void cbPaper_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemName = cbPaper.Text;
            using (var con = new SqlConnection(conString))
            {
                con.Open();

                string qry = "Select * from tbl_PriceList where ItemName = @itemName";

                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("itemName", itemName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int getPrice = reader.GetInt32(2);
                            txtCurrPrice.Text = getPrice.ToString();
                        }
                    }
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            try
            {
                using (var con = new SqlConnection(conString))
                {
                    con.Open();

                    string qry = "UPDATE tbl_PriceList Set Price = @price where ItemName = @itemName";

                    using (SqlCommand cmd = new SqlCommand(qry, con))
                    {
                        cmd.Parameters.AddWithValue("@itemName", itemName);
                        cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated Successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
