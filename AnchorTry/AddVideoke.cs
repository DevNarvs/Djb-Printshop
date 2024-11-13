using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnchorTry
{
    public partial class AddVideoke : Form
    {
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Narvs\source\repos\AnchorTry\AnchorTry\Database.mdf;Integrated Security=True";

        public AddVideoke()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnVideoke_Click(object sender, EventArgs e)
        {

        }
        private void btnUpload_Click(object sender, EventArgs e)
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
            // Displays a MessageBox with OK and Cancel buttons
            DialogResult result = MessageBox.Show("Do you want to Add?", "Confirmation", MessageBoxButtons.OKCancel);

            // Check which button was clicked
            if (result == DialogResult.OK)
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
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Cancelled.");
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
