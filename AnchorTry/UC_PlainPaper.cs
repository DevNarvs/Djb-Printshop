using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnchorTry
{
    public partial class UC_PlainPaper : UserControl
    {
        string paperType = "";
        string printType = "";
        string paperSize = "";
        string colorType = "";
        int qty = 0;
        double amount = 0;
        double payment = 0;
        double total = 0;
        double finalTotal = 0;
        double change = 0;
        int reference = 0;


        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Narvs\source\repos\AnchorTry\AnchorTry\Database.mdf;Integrated Security=True";

        public UC_PlainPaper()
        {
            InitializeComponent();
        }
        private void UC_PlainPaper_Load(object sender, EventArgs e)
        {
            //disable plain paper
            pnlPrintTypePlain.Enabled = false;
            pnlPaperSizePlain.Enabled = false;
            pnlColorPlain.Enabled = false;

            //disable photo paper
            pnlPrintTypePhoto.Enabled = false;
            pnlPackagePhoto.Enabled = false;
            pnlPaperSizePhoto.Enabled = false;
            pnlColorPhoto.Enabled = false;
        }

        //clear all btn selection
        void clear()
        {
            //clear all selected from Plain Paper
            btnPlainPaper.Checked = false;
            btnDocumentPlain.Checked = false;
            btnImagePlain.Checked = false;
            btnFullImagePlain.Checked = false;
            btnLetterPlain.Checked = false;
            btnA4Plain.Checked = false;
            btnFolioPlain.Checked = false;
            btnLegalPlain.Checked = false;
            btnColoredPlain.Checked = false;
            btnGrayscalePlain.Checked = false;

            //clear all selected from Photo Paper
            btnPhotoPaper.Checked = false;
            btnImagePhoto.Checked = false;
            btnIDPhoto.Checked = false;

            btn3RPhoto.Checked = false;
            btn4RPhoto.Checked = false;
            btn5RPhoto.Checked = false;
            btnA4Photo.Checked = false;
            btnColoredPhoto.Checked = false;

            //disable plain paper
            pnlPrintTypePlain.Enabled = false;
            pnlPaperSizePlain.Enabled = false;
            pnlColorPlain.Enabled = false;

            //disable photo paper
            pnlPrintTypePhoto.Enabled = false;
            pnlPackagePhoto.Enabled = false;
            pnlPaperSizePhoto.Enabled = false;
            pnlColorPhoto.Enabled = false;


            //clearing all textbox
            txtqty.Clear();
        }

        private void btnPlainPaper_Click(object sender, EventArgs e)
        {
            if (btnPlainPaper.Checked)
            {
                pnlPrintTypePlain.Enabled = true;
                pnlPaperSizePlain.Enabled = true;
                pnlColorPlain.Enabled = true;

                pnlPrintTypePhoto.Enabled = false;
                pnlPackagePhoto.Enabled = false;
                pnlPaperSizePhoto.Enabled = false;
                pnlColorPhoto.Enabled = false;

                //clearing all past selection
                btnDocumentPlain.Checked = false;
                btnImagePlain.Checked = false;
                btnFullImagePlain.Checked = false;
                btnLetterPlain.Checked = false;
                btnA4Plain.Checked = false;
                btnFolioPlain.Checked = false;
                btnLegalPlain.Checked = false;
                btnColoredPlain.Checked = false;
                btnGrayscalePlain.Checked = false;

                txtChange.Clear();
            }
        }

        private void btnPhotoPaper_Click(object sender, EventArgs e)
        {
            if (btnPhotoPaper.Checked)
            {
                pnlPrintTypePhoto.Enabled = true;
                pnlPackagePhoto.Enabled = true;
                pnlPaperSizePhoto.Enabled = true;
                pnlColorPhoto.Enabled = true;

                pnlPrintTypePlain.Enabled = false;
                pnlPaperSizePlain.Enabled = false;
                pnlColorPlain.Enabled = false;

                //clearing all past selection
                btnImagePhoto.Checked = false;
                btnIDPhoto.Checked = false;
                txtPackagePhoto.Enabled = false;
                btn3RPhoto.Checked = false;
                btn4RPhoto.Checked = false;
                btn5RPhoto.Checked = false;
                btnA4Photo.Checked = false;
                btnColoredPhoto.Checked = false;

                txtChange.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all selected btn
            clear();
            MessageBox.Show("Cleared Successfully!!! \nPlease Select Paper");


        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (txtqty.Text != "")
            {
                //checking paper type
                if (btnPlainPaper.Checked)
                {
                    paperType = "Plain Paper";
                }
                else if (btnPhotoPaper.Checked)
                {
                    paperType = "Photo Paper";
                }

                //Plain Paper
                //checking print Type
                if (btnDocumentPlain.Checked)
                {
                    printType = "Document";
                }
                else if (btnImagePlain.Checked)
                {
                    printType = "Image";
                }
                else if (btnFullImagePlain.Checked)
                {
                    printType = "Full Image";
                }


                //checking paper size
                if (btnLetterPlain.Checked)
                {
                    paperSize = "Letter";
                }
                else if (btnA4Plain.Checked)
                {
                    paperSize = "A4";
                }
                else if (btnFolioPlain.Checked)
                {
                    paperSize = "Folio";
                }
                else if (btnLegalPlain.Checked)
                {
                    paperSize = "Legal";
                }


                //checking color type
                if (btnColoredPlain.Checked)
                {
                    colorType = "Colored";
                }
                else if (btnGrayscalePlain.Checked)
                {
                    colorType = "Grayscale";
                }


                //Photo Paper
                //cheking print type
                if (btnImagePhoto.Checked)
                {
                    printType = "Image";
                    txtPackagePhoto.Enabled = false;
                }
                else if (btnIDPhoto.Checked)
                {
                    printType = "ID";
                }


                //checking paper size
                if (btn3RPhoto.Checked)
                {
                    paperSize = "3R";
                }
                else if (btn4RPhoto.Checked)
                {
                    paperSize = "4R";
                }
                else if (btn5RPhoto.Checked)
                {
                    paperSize = "5R";
                }
                else if (btnA4Photo.Checked)
                {
                    paperSize = "A4";
                }
                else if (txtPackagePhoto.Text != null)
                {
                    if (txtPackagePhoto.Text == "Package A")
                    {
                        paperSize = "Package A";
                    }
                    else if (txtPackagePhoto.Text == "Package B")
                    {
                        paperSize = "Package B";
                    }
                    else if (txtPackagePhoto.Text == "Package C")
                    {
                        paperSize = "Package C";
                    }
                    else if (txtPackagePhoto.Text == "Package D")
                    {
                        paperSize = "Package D";
                    }
                    else if (txtPackagePhoto.Text == "Package E")
                    {
                        paperSize = "Package E";
                    }
                }


                //checking color
                if (btnColoredPhoto.Checked)
                {
                    colorType = "Colored";
                }


                //checking qty
                qty = Convert.ToInt32(txtqty.Text);


                //setting reference 
                reference = Convert.ToInt32(lblReference.Text);


                //checking amount
                //Document to Colored flow
                if (paperType == "Plain Paper" && printType == "Document" && paperSize == "Letter" && colorType == "Colored")
                {
                    amount = 8 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Document" && paperSize == "A4" && colorType == "Colored")
                {
                    amount = 8 * qty;
                    total = amount;

                }
                else if (paperType == "Plain Paper" && printType == "Document" && paperSize == "Folio" && colorType == "Colored")
                {
                    amount = 10 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Document" && paperSize == "Legal" && colorType == "Colored")
                {
                    amount = 10 * qty;
                    total = amount;

                }


                //Document to Grayscale flow
                if (paperType == "Plain Paper" && printType == "Document" && paperSize == "Letter" && colorType == "Grayscale")
                {
                    amount = 5 * qty;
                    total = amount;

                }
                else if (paperType == "Plain Paper" && printType == "Document" && paperSize == "A4" && colorType == "Grayscale")
                {
                    amount = 6 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Document" && paperSize == "Folio" && colorType == "Grayscale")
                {
                    amount = 7 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Document" && paperSize == "Legal" && colorType == "Grayscale")
                {
                    amount = 7 * qty;
                    total = amount;
                }


                //Image to Colored flow
                if (paperType == "Plain Paper" && printType == "Image" && paperSize == "Letter" && colorType == "Colored")
                {
                    amount = 10 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Image" && paperSize == "A4" && colorType == "Colored")
                {
                    amount = 10 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Image" && paperSize == "Folio" && colorType == "Colored")
                {
                    amount = 12 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Image" && paperSize == "Legal" && colorType == "Colored")
                {
                    amount = 12 * qty;
                    total = amount;
                }


                //Image to Grayscale flow
                if (paperType == "Plain Paper" && printType == "Image" && paperSize == "Letter" && colorType == "Grayscale")
                {
                    amount = 5 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Image" && paperSize == "A4" && colorType == "Grayscale")
                {
                    amount = 5 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Image" && paperSize == "Folio" && colorType == "Grayscale")
                {
                    amount = 10 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Image" && paperSize == "Legal" && colorType == "Grayscale")
                {
                    amount = 10 * qty;
                    total = amount;
                }


                //Full image to Colored flow
                if (paperType == "Plain Paper" && printType == "Full Image" && paperSize == "Letter" && colorType == "Colored")
                {
                    amount = 12 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Full Image" && paperSize == "A4" && colorType == "Colored")
                {
                    amount = 12 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Full Image" && paperSize == "Folio" && colorType == "Colored")
                {
                    amount = 15 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Full Image" && paperSize == "Legal" && colorType == "Colored")
                {
                    amount = 15 * qty;
                    total = amount;
                }


                //Full image to Grayscale flow
                if (paperType == "Plain Paper" && printType == "Full Image" && paperSize == "Letter" && colorType == "Grayscale")
                {
                    amount = 8 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Full Image" && paperSize == "A4" && colorType == "Grayscale")
                {
                    amount = 8 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Full Image" && paperSize == "Folio" && colorType == "Grayscale")
                {
                    amount = 10 * qty;
                    total = amount;
                }
                else if (paperType == "Plain Paper" && printType == "Full Image" && paperSize == "Legal" && colorType == "Grayscale")
                {
                    amount = 10 * qty;
                    total = amount;
                }


                //checking amount
                //Photo Paper
                //Image to Colored flow
                if (paperType == "Photo Paper" && printType == "Image" && paperSize == "3R" && colorType == "Colored")
                {
                    amount = 8 * qty;
                    total = amount;
                }
                else if (paperType == "Photo Paper" && printType == "Image" && paperSize == "4R" && colorType == "Colored")
                {
                    amount = 10 * qty;
                    total = amount;
                }
                else if (paperType == "Photo Paper" && printType == "Image" && paperSize == "5R" && colorType == "Colored")
                {
                    amount = 12 * qty;
                    total = amount;
                }
                if (paperType == "Photo Paper" && printType == "Image" && paperSize == "A4" && colorType == "Colored")
                {
                    amount = 30 * qty;
                    total = amount;
                }

                //ID to Colored flow
                if (paperType == "Photo Paper" && printType == "ID" && paperSize == "Package A" && colorType == "Colored")
                {
                    amount = 30 * qty;
                    total = amount;
                }
                else if (paperType == "Photo Paper" && printType == "ID" && paperSize == "Package B" && colorType == "Colored")
                {
                    amount = 30 * qty;
                    total = amount;
                }
                else if (paperType == "Photo Paper" && printType == "ID" && paperSize == "Package C" && colorType == "Colored")
                {
                    amount = 40 * qty;
                    total = amount;
                }
                else if (paperType == "Photo Paper" && printType == "ID" && paperSize == "Package D" && colorType == "Colored")
                {
                    amount = 40 * qty;
                    total = amount;
                }
                else if (paperType == "Photo Paper" && printType == "ID" && paperSize == "Package E" && colorType == "Colored")
                {
                    amount = 50 * qty;
                    total = amount;
                }


                if (btnColoredPlain.Checked || btnGrayscalePlain.Checked || btnColoredPhoto.Checked)
                {
                    using (var con = new SqlConnection(conString))
                    {
                        try
                        {

                            con.Open();
                            string qry = "INSERT INTO tbl_printshop (PaperType, PrintType, PaperSize, ColorType, Quantity, Amount, Reference) VALUES (@paperType, @printType, @paperSize, @colorType, @qty, @amount, @reference)";
                            SqlCommand cmd = new SqlCommand(qry, con);
                            cmd.Parameters.AddWithValue("@paperType", paperType);
                            cmd.Parameters.AddWithValue("@printType", printType);
                            cmd.Parameters.AddWithValue("@paperSize", paperSize);
                            cmd.Parameters.AddWithValue("@colorType", colorType);
                            cmd.Parameters.AddWithValue("@qty", qty);
                            cmd.Parameters.AddWithValue("@amount", amount);
                            cmd.Parameters.AddWithValue("@reference", reference);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            con.Open();
                            string qryDisplay = "Select * from tbl_printshop where Reference = @ref AND Amount != @amount";
                            SqlCommand cmdView = new SqlCommand(qryDisplay, con);
                            cmdView.Parameters.AddWithValue("@ref", reference);
                            cmdView.Parameters.AddWithValue("@amount", 0);
                            cmdView.CommandText = qryDisplay;

                            SqlDataAdapter daView = new SqlDataAdapter(cmdView);
                            DataTable dtView = new DataTable();
                            daView.Fill(dtView);
                            dgvMain.DataSource = dtView;
                            con.Close();

                            if (txtTotal.Text == "")
                            {
                                finalTotal = amount;
                                txtTotal.Text = finalTotal.ToString();
                            }
                            else
                            {
                                double textTotal = double.Parse(txtTotal.Text);
                                finalTotal = textTotal + amount;
                                txtTotal.Text = finalTotal.ToString();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the details!");
                }
                    


                //clear all selected from Plain Paper
                btnPlainPaper.Checked = false;
                btnDocumentPlain.Checked = false;
                btnImagePlain.Checked = false;
                btnFullImagePlain.Checked = false;
                btnLetterPlain.Checked = false;
                btnA4Plain.Checked = false;
                btnFolioPlain.Checked = false;
                btnLegalPlain.Checked = false;
                btnColoredPlain.Checked = false;
                btnGrayscalePlain.Checked = false;

                //clear all selected from Photo Paper
                btnPhotoPaper.Checked = false;
                btnImagePhoto.Checked = false;
                btnIDPhoto.Checked = false;

                btn3RPhoto.Checked = false;
                btn4RPhoto.Checked = false;
                btn5RPhoto.Checked = false;
                btnA4Photo.Checked = false;
                btnColoredPhoto.Checked = false;

                //disable plain paper
                pnlPrintTypePlain.Enabled = false;
                pnlPaperSizePlain.Enabled = false;
                pnlColorPlain.Enabled = false;

                //disable photo paper
                pnlPrintTypePhoto.Enabled = false;
                pnlPackagePhoto.Enabled = false;
                pnlPaperSizePhoto.Enabled = false;
                pnlColorPhoto.Enabled = false;


                //txtTotal.Text = total.ToString();
                txtqty.Clear();

            }
            else
            {
                MessageBox.Show("Please Input Quantity");
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            payment = double.Parse(txtPayment.Text);

            if (payment >= finalTotal)
            {
                change = payment - finalTotal;
                txtChange.Text = change.ToString();
            }
            else
            {
                MessageBox.Show("Insufficient Payment");
            }
        }

        private void btnIDPhoto_Click(object sender, EventArgs e)
        {
            txtPackagePhoto.Enabled = true;

            //disabling paper size
            btn3RPhoto.Enabled = false;
            btn4RPhoto.Enabled = false;
            btn5RPhoto.Enabled = false;
            btnA4Photo.Enabled = false;
        }

        private void btnImagePhoto_Click(object sender, EventArgs e)
        {
            txtPackagePhoto.Enabled = false;

            //enabling paper size
            btn3RPhoto.Enabled = true;
            btn4RPhoto.Enabled = true;
            btn5RPhoto.Enabled = true;
            btnA4Photo.Enabled = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtChange.Text != "")
            {
                //disable plain paper
                pnlPrintTypePlain.Enabled = false;
                pnlPaperSizePlain.Enabled = false;
                pnlColorPlain.Enabled = false;

                //disable photo paper
                pnlPrintTypePhoto.Enabled = false;
                pnlPackagePhoto.Enabled = false;
                pnlPaperSizePhoto.Enabled = false;
                pnlColorPhoto.Enabled = false;

                clear();

                txtTotal.Text = "";
                txtPayment.Text = "";
                txtChange.Text = "";

                dgvMain.DataSource = null;

            }
        }
    }
}
