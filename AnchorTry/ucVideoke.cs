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
                    string query = "SELECT Id FROM tbl_Videoke WHERE Status = @status ORDER BY Id "; // Adjust as needed
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@status", "Available");

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
                    string stringTime = time.ToString("t");


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

                    // Combine the selected date with the selected time
                    fullSelectedDateTime = new DateTime(selectedNextDay.Year, selectedNextDay.Month, selectedNextDay.Day,
                        selectedDateTime.Hour, selectedDateTime.Minute, 0); // Create full DateTime object




                    // Proceed with reservation
                    reservationFunction(selectedTime, datePickerValue, stringTime, fullSelectedDateTime);
                    LoadImageIds();
                    DisplayImage();
                }
            }
        }

        private void reservationFunction(string time, string date, string reservationTime, DateTime endReservation)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    // SQL query to insert the image data
                    string query = "INSERT INTO tbl_Reservation (Name, Address, Contact, Delivery_Time, Date, Reservation_Time, Videoke_ID, End_Reservation) VALUES (@name, @address, @contact,@time, @date, @reserveTime, @videokeID, @endReservation)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL query
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@address", txtAddress.Text);
                        command.Parameters.AddWithValue("@Contact", txtContact.Text);
                        command.Parameters.AddWithValue("@time", time);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@reserveTime", reservationTime);
                        command.Parameters.AddWithValue("@videokeID", imageIds[currentImageIndex]);
                        command.Parameters.AddWithValue("@endReservation", endReservation.ToString());


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
            int getVideokeID = 0;

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
                MessageBox.Show("Error: " + ex.Message);
            }

            if (getVideokeID != 0)
            {
                DateTime getEndReservation = DateTime.Now;

                //// Check if the selected date and time matches tomorrow
                //if (fullSelectedDateTime.Date == getEndReservation && fullSelectedDateTime.TimeOfDay == getEndReservation.TimeOfDay)
                //{
                //    MessageBox.Show("Status: Not Available"); // Can't reserve for tomorrow at this time
                //}
                //else if (selectedDate < getEndReservation.Date)
                //{
                //    MessageBox.Show("Status: Not Available"); // Can't reserve for tomorrow at this time
                //}
                //else
                //{

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the image in the PictureBox
                pictureBox2.Image = new Bitmap(openFileDialog.FileName);

                // Get the image name and path
                string imageName = Path.GetFileName(openFileDialog.FileName);
                string imagePath = openFileDialog.FileName;

                // Optional: Assign image name from a text box
                if (!string.IsNullOrEmpty(txtFileName.Text))
                {
                    imageName = txtFileName.Text;
                }

                // Convert the image to a byte array
                byte[] imageData = File.ReadAllBytes(imagePath);

                // Insert the image into the database
                InsertImageIntoDatabase(imageName, imageData);
            }
        }
        private void InsertImageIntoDatabase(string imageName, byte[] imageData)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    // SQL query to insert the image data
                    string query = "INSERT INTO tbl_Videoke (Name, Image, Status) VALUES (@name, @image, @status)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL query
                        command.Parameters.AddWithValue("@name", imageName);
                        command.Parameters.AddWithValue("@image", imageData);
                        command.Parameters.AddWithValue("@status", "Available");


                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
                string qryDisplay = "Select * from tbl_Reservation";
                SqlCommand cmdView = new SqlCommand(qryDisplay, con);
                cmdView.CommandText = qryDisplay;

                SqlDataAdapter daView = new SqlDataAdapter(cmdView);
                DataTable dtView = new DataTable();
                daView.Fill(dtView);
                dgvTransactions.DataSource = dtView;
                con.Close();
            }
        }
    }
}
