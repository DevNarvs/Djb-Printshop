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
using System.Drawing.Printing;

namespace AnchorTry
{
    public partial class ucWallets : UserControl
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Narvs\source\repos\AnchorTry\AnchorTry\Database.mdf;Integrated Security=True";

        int charge = 0;
        double total = 0;

        public ucWallets()
        {
            InitializeComponent();
        }
        private void ucWallets_Load(object sender, EventArgs e)
        {
            refreshGrid();
            pnlEWallet.Enabled = false;
            pnlWalletType.Enabled = false;

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                int amountText = Convert.ToInt32(txtAmount.Text);
                if (txtAmount.Text != "")
                {
                    charge = (amountText / 500) * 10;
                    total = charge + amountText;

                    if (amountText <= 50)
                    {
                        charge = 5;
                        total = charge + amountText;
                        txtTotal.Text = total.ToString();
                    }
                    else if (amountText % 500 != 0 && amountText > 50)
                    {
                        charge += 10;
                        total = charge + amountText;
                        txtTotal.Text = total.ToString();
                    }
                    else
                    {
                        txtTotal.Text = total.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter the Amount");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                string wallet = "";
                string type = "";

                double payment = double.Parse(txtPayment.Text);

                if (payment < total)
                {
                    MessageBox.Show("Invalid Payment!");
                }
                else
                {
                    if (txtNumber.Text != "")
                    {
                        double change = payment - total;
                        txtChange.Text = change.ToString();

                        if (btnGcash.Checked == true)
                        {
                            wallet = "Gcash";
                        }
                        else if (btnMaya.Checked == true)
                        {
                            wallet = "Maya";
                        }
                        if (btnCashIn.Checked == true)
                        {
                            type = "Cash In";
                        }
                        else if (btnCashOut.Checked == true)
                        {
                            type = "Cash Out";
                        }
                        else if (btnBills.Checked == true)
                        {
                            type = "Bills";
                        }

                        if (type == "Cash Out" && txtReference.Text == "")
                        {
                            MessageBox.Show("Please Enter Reference Number");
                        }

                        if (txtPayment.Text == "")
                        {
                            MessageBox.Show("Please input the Payment");
                        }
                        

                        else
                        {
                            using (var con = new SqlConnection(conString))
                            {
                                try
                                {

                                    DateTime currentDate = DateTime.Now;

                                    con.Open();
                                    string qry = "INSERT INTO tbl_eWallet (Wallet, Number, Type, Amount, Total, Payment, Change, Reference, Date) VALUES (@wallet, @number, @type, @amount, @total, @payment, @change, @reference, @date)";
                                    SqlCommand cmd = new SqlCommand(qry, con);
                                    cmd.Parameters.AddWithValue("@wallet", wallet);
                                    cmd.Parameters.AddWithValue("@number", txtNumber.Text);
                                    cmd.Parameters.AddWithValue("@type", type);
                                    cmd.Parameters.AddWithValue("@amount", txtAmount.Text);
                                    cmd.Parameters.AddWithValue("@total", txtTotal.Text);
                                    cmd.Parameters.AddWithValue("@payment", txtPayment.Text);
                                    cmd.Parameters.AddWithValue("@change", txtChange.Text);
                                    cmd.Parameters.AddWithValue("@reference", txtReference.Text);
                                    cmd.Parameters.AddWithValue("@date", currentDate);
                                    cmd.ExecuteNonQuery();
                                    con.Close();

                                    refreshGrid();

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter Mobile Number");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pnlWalletType.Enabled = false;
            pnlEWallet.Enabled = false;
            txtNumber.Clear();
            txtAmount.Clear();
            txtTotal.Clear();
            txtPayment.Clear();
            txtChange.Clear();
            txtReference.Clear();
        }

        private void refreshGrid()
        {
            using (var con = new SqlConnection(conString))
            {
                con.Open();
                string qryDisplay = "Select * from tbl_eWallet";
                SqlCommand cmdView = new SqlCommand(qryDisplay, con);
                cmdView.CommandText = qryDisplay;

                SqlDataAdapter daView = new SqlDataAdapter(cmdView);
                DataTable dtView = new DataTable();
                daView.Fill(dtView);
                dgvTransactionWallet.DataSource = dtView;
                con.Close();
            }
        }

        private void clearTextBox()
        {
            btnGcash.Checked = false;
            btnMaya.Checked = false;
            btnCashIn.Checked = false;
            btnCashOut.Checked = false;
            btnBills.Checked = false;
            txtNumber.Clear();
            txtAmount.Clear();
            txtTotal.Clear();
            txtPayment.Clear();
            txtChange.Clear();
            txtReference.Clear();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtReference_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGcash_Click(object sender, EventArgs e)
        {
            pnlWalletType.Enabled = true;
        }

        private void btnMaya_Click(object sender, EventArgs e)
        {
            pnlWalletType.Enabled = true;
        }

        private void btnCashIn_CheckedChanged(object sender, EventArgs e)
        {
            pnlEWallet.Enabled = true;
        }

        private void btnCashOut_CheckedChanged(object sender, EventArgs e)
        {
            pnlEWallet.Enabled = true;
        }

        private void btnBills_CheckedChanged(object sender, EventArgs e)
        {
            pnlEWallet.Enabled = true;
        }
    }
}
