using System;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using Microsoft.Win32;

namespace Cybersecurity
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();

            // Set the form's border style to fixed and disable minimize box
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Initialize the MySQL connection
            string connectionString = "Server=localhost;Database=cyberworld;Uid=root;";
            connection = new MySqlConnection(connectionString);

            // Check database connection
            connection.Open();

            // Subscribe to the Click event of the Login button
            Login.Click += Login_Click;

            Register.Click += Register_Click;
        }



        private void Login_Click(object sender, EventArgs e)
        {
            string username = email.Text;
            string userPassword = password.Text;

            try
            {
                string query = "SELECT password FROM users WHERE username = @username";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                // Fetch the hashed password from the database
                string hashedPassword = command.ExecuteScalar() as string;

                if (hashedPassword != null && BCrypt.Net.BCrypt.Verify(userPassword, hashedPassword))
                {
                    MessageBox.Show("Login successful!");

                    // Hide Form1
                    this.Hide();

                    // Create an instance of Form2 and show it
                    Form2 form2 = new Form2();
                    form2.ShowDialog(); // Use ShowDialog to make Form2 modal
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        private async void Register_Click(object sender, EventArgs e)
        {
            string username = email.Text;
            string userPassword = password.Text;

            try
            {
                // Disable the Register button to prevent multiple clicks
                Register.Enabled = false;

                connection.Open();

                // Check if the username already exists
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@username", username);
                int userCount = Convert.ToInt32(await checkCommand.ExecuteScalarAsync());

                if (userCount > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                    return; // Exit registration process
                }

                // Hash the password using bcrypt
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(userPassword);

                // Insert user into the database with hashed password
                string insertQuery = "INSERT INTO users (username, password) VALUES (@username, @password)";
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@username", username);
                insertCommand.Parameters.AddWithValue("@password", hashedPassword);
                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Registration successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Re-enable the Register button after registration process completes
                Register.Enabled = true;

                connection.Close();
            }
        }
    }
}
