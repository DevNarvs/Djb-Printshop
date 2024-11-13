using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Image = System.Drawing.Image;


namespace AnchorTry
{
    public partial class ucVideoke : UserControl
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Narvs\source\repos\AnchorTry\AnchorTry\Database.mdf;Integrated Security=True";


        private List<int> imageIds; // List to hold image IDs from the database
        private int currentImageIndex = 0; // Track the current image index

        DateTime fullSelectedDateTime = DateTime.Now;
        DateTime selectedDate = DateTime.Now.Date;
        int getVideokeID = 0;


        public ucVideoke()
        {
            InitializeComponent();
            LoadImageIds(); // Load image IDs from the database on startup
            DisplayImage(); // Display the first image
            TimeOut(fullSelectedDateTime, selectedDate);

        }

        private void LoadImageIds()
        {
            imageIds = new List<int>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string query = "SELECT Id FROM tbl_Videoke ORDER BY Id "; // Adjust as needed
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            imageIds.Add(reader.GetInt32(0)); // Add each image ID to the list
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image IDs: " + ex.Message);
            }
        }
        private void DisplayImage()
        {
            if (imageIds.Count == 0)
            {
                lblAvailable.Text = "No Available Videoke.";
                return;
            }

            // Retrieve the image data from the database based on the current index
            byte[] imageData = GetImageFromDatabase(imageIds[currentImageIndex]);

            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox1.Image = Image.FromStream(ms); // Display the image in the PictureBox
                }

                if (imageIds.Count < 0)
                {
                    lblFileName.Text = "No Available";
                    lblAvailable.Text = $"Avaiable Videoke : " + imageIds.Count;
                }
                else
                {
                    // Optionally display the image name
                    lblFileName.Text = $"Videoke ID: {imageIds[currentImageIndex]}";
                    lblAvailable.Text = $"Avaiable Videoke : " + imageIds.Count;
                }
            }
        }
        private byte[] GetImageFromDatabase(int imageId)
        {
            byte[] imageData = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string query = "SELECT Image FROM tbl_Videoke WHERE Id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", imageId);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            imageData = (byte[])result; // Retrieve the image data
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving image: " + ex.Message);
            }

            return imageData;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" | txtContact.Text == "" || txtHr.Text == "" || txtMins.Text == "" || txtTT.Text == "")
            {
                MessageBox.Show("Please Enter Customer Details");
            }
            else
            {
                if (lblAvailable.Text == "No Available Videoke.")
                {
                    MessageBox.Show("No Available Videoke.");
                }
                else
                {
                    //Date
                    string datePickerValue = datePicker.Value.ToString("D");
                    //Time
                    DateTime time = DateTime.Now;
                    string stringTime = time.ToString("g");


                    //End of Reservation Date
                    selectedDate = datePicker.Value.Date;

                    string selectedTime = txtHr.Text + ":" + txtMins.Text + " " + txtTT.Text;

                    DateTime selectedDateTime;
                    if (!DateTime.TryParse(selectedTime, out selectedDateTime))
                    {
                        MessageBox.Show("Invalid time format. Please enter a valid time.");
                        return; // Exit the method if the time format is invalid
                    }

                    // Get the current date and time
                    DateTime currDate = DateTime.Now;

                    // Get the date for tomorrow
                    DateTime selectedNextDay = selectedDate.AddDays(1);

                    DateTime selectedCurrFullDate = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day,
                       selectedDateTime.Hour, selectedDateTime.Minute, 0); // Create full DateTime object

                    // Combine the selected date with the selected time for next day (End of reservation)
                    fullSelectedDateTime = new DateTime(selectedNextDay.Year, selectedNextDay.Month, selectedNextDay.Day,
                        selectedDateTime.Hour, selectedDateTime.Minute, 0); // Create full DateTime object

                    // Proceed with reservation
                    reservationFunction(selectedTime, datePickerValue, stringTime, fullSelectedDateTime, selectedCurrFullDate);
                }
            }
        }

        private void reservationFunction(string time, string date, string reservationTime, DateTime endReservation, DateTime selectedCurrFullDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    // Check if there is an existing reservation for the selected videoke within the next 24 hours
                    string checkQuery = "SELECT COUNT(*) FROM tbl_Reservation WHERE Videoke_ID = @videokeID AND End_Reservation > @selectedDate";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@videokeID", imageIds[currentImageIndex]);
                        checkCommand.Parameters.AddWithValue("@selectedDate", selectedCurrFullDate);

                        int reservationCount = (int)checkCommand.ExecuteScalar();
                        if (reservationCount > 0)
                        {
                            MessageBox.Show("This Videoke is already reserved for the next 24 hours.");
                            return; // Exit the function if there is an existing reservation
                        }
                    }
                }

                string getPaymentOption = "";


                if (btnDP.Checked == true)
                {
                    getPaymentOption = "Down Payment";
                }
                else if (btnFP.Checked == true)
                {
                    getPaymentOption = "Fully Paid";
                }

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    // SQL query to insert the image data
                    string query = "INSERT INTO tbl_Reservation (Name, Address, Contact, Delivery_Time, Date, End_Reservation, PaymentOption, Payment, Videoke_ID, Reservation_Time ) VALUES (@name, @address, @contact, @time, @date, @endReservation, @paymentOption, @payment, @videokeID, @reserveTime )";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL query
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@address", txtAddress.Text);
                        command.Parameters.AddWithValue("@Contact", txtContact.Text);
                        command.Parameters.AddWithValue("@time", time);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@endReservation", endReservation.ToString());
                        command.Parameters.AddWithValue("@paymentOption", getPaymentOption);
                        command.Parameters.AddWithValue("@payment", txtPayment.Text);
                        command.Parameters.AddWithValue("@videokeID", imageIds[currentImageIndex]);
                        command.Parameters.AddWithValue("@reserveTime", reservationTime);



                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Videoke reserved successfully.");

                        try
                        {
                            using (SqlConnection con = new SqlConnection(conString))
                            {
                                con.Open();

                                string qry = "UPDATE tbl_Videoke SET Status = @status WHERE Id = @id";

                                using (SqlCommand cmd = new SqlCommand(qry, con))
                                {
                                    cmd.Parameters.AddWithValue("@status", "Rented");
                                    cmd.Parameters.AddWithValue("id", imageIds[currentImageIndex]);

                                    int rowAffected1 = cmd.ExecuteNonQuery();

                                    con.Close();

                                    txtName.Clear();
                                    txtAddress.Clear();
                                    txtContact.Clear();
                                    txtHr.Text = null;
                                    txtMins.Text = null;
                                    txtTT.Text = null;
                                    txtPayment.Text = null;
                                    btnDP.Checked = false;
                                    btnFP.Checked = false;


                                    refreshGridView();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }
        private void TimeOut(DateTime fullSelectedDateTime, DateTime selectedDate)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();


                    string qryDisplay = "Select Id from tbl_Videoke where Status = @status";
                    SqlCommand cmdView = new SqlCommand(qryDisplay, con);
                    cmdView.Parameters.AddWithValue("@status", "Rented");

                    using (SqlDataReader reader = cmdView.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            getVideokeID = reader.GetInt32(0);
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            if (getVideokeID != 0)
            {
                DateTime getEndReservation = DateTime.Now;


                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        con.Open();

                        string qry = "Select * from tbl_Reservation where Videoke_ID = @id";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        cmd.Parameters.AddWithValue("@id", getVideokeID);

                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                getEndReservation = rdr.GetDateTime(8);
                            }
                            rdr.Close();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


                try
                {
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        con.Open();
                        string qry = "UPDATE tbl_Videoke SET Status = @status WHERE Id = @id";

                        using (SqlCommand cmd = new SqlCommand(qry, con))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");
                            cmd.Parameters.AddWithValue("id", getVideokeID);

                            int rowAffected1 = cmd.ExecuteNonQuery();

                            if (rowAffected1 > 0)
                            {
                                LoadImageIds(); // Load image IDs from the database on startup
                                DisplayImage(); // Display the first image
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                //}
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (imageIds.Count == 0) return; // No images available

            // Decrement the index and wrap around if necessary
            currentImageIndex = (currentImageIndex - 1 + imageIds.Count) % imageIds.Count;
            DisplayImage(); // Display the previous image
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (imageIds.Count == 0) return; // No images available

            // Increment the index and wrap around if necessary
            currentImageIndex = (currentImageIndex + 1) % imageIds.Count;
            DisplayImage(); // Display the next image
        }
       
        private void ucVideoke_Load(object sender, EventArgs e)
        {
            datePicker.Format = DateTimePickerFormat.Short;
            refreshGridView();
            datePicker.MinDate = DateTime.Today;

            if (lblAvailable.Text == "No Available Videoke.")
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }




        }
        private void refreshGridView()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string qryDisplay = "Select * from tbl_Reservation ORDER BY Id Desc";
                SqlCommand cmdView = new SqlCommand(qryDisplay, con);
                cmdView.CommandText = qryDisplay;

                SqlDataAdapter daView = new SqlDataAdapter(cmdView);
                DataTable dtView = new DataTable();
                daView.Fill(dtView);
                dgvTransactions.DataSource = dtView;
                con.Close();
            }
        }

        private void btnUpdatePayment_CheckedChanged(object sender, EventArgs e)
        {
            if (btnUpdatePayment.Checked == true)
            {
                txtID.Enabled = true;
                txtUpdatedPayment.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else if (btnUpdatePayment.Checked == false)
            {
                txtID.Enabled = false;
                txtUpdatedPayment.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(conString))
            {
                con.Open();

                string qry = "UPDATE tbl_Reservation SET Payment = @payment where Id = @id";
                using (SqlCommand cmd = new SqlCommand (qry, con))
                {
                    cmd.Parameters.AddWithValue("@payment", txtUpdatedPayment.Text);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Paid Successfully");

                    refreshGridView();
                    txtID.Text = "";
                    txtUpdatedPayment.Text = "";
                }
            }
        }
    }
}
