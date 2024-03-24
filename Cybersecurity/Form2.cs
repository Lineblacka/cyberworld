using System;
using System.Diagnostics;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace Cybersecurity
{
    public partial class Form2 : Form
    {
        // Your GitHub repository URL
        private const string RepositoryUrl = "https://api.github.com/repos/Lineblacka/cyberworld";

        // Initialize typing timer and resultToShow variables
        private Timer typingTimer;
        private string resultToShow;
        private int currentIndex;

        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Initialize typing timer
            typingTimer = new Timer();
            typingTimer.Interval = 30; // Adjust typing speed here (milliseconds)
            typingTimer.Tick += TypingTimer_Tick;

            // Attach KeyDown event handler to ipinput textbox
            ipinput.KeyDown += ipinput_KeyDown;

            // Fetch last commit message from GitHub repository and display it
            FetchLastCommitMessage();
        }

        // Fetch last commit message from GitHub repository
        private void FetchLastCommitMessage()
        {
            var client = new RestClient(RepositoryUrl);
            var request = new RestRequest("/commits", RestSharp.Method.Get); // Use RestSharp.Method.GET directly
            request.AddParameter("per_page", 1); // Fetch only the last commit
            request.AddHeader("User-Agent", "RestSharp"); // GitHub requires User-Agent header
            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var jsonResponse = JArray.Parse(response.Content);
                var lastCommitMessage = jsonResponse[0]["commit"]["message"].ToString();
                latestupdate.Text = "- " + lastCommitMessage;
            }
            else
            {
                // Handle unsuccessful response
                MessageBox.Show("Failed to fetch last commit message from GitHub.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TypingTimer_Tick(object sender, EventArgs e)
        {
            // Check if there are characters left to display
            if (currentIndex < resultToShow.Length)
            {
                // Display the next character
                pingresult.Text += resultToShow[currentIndex];
                currentIndex++;
            }
            else
            {
                // Stop the timer when all characters are displayed
                typingTimer.Stop();
            }
        }

        private void ipinput_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Get the IP address from the textbox
                string ipAddress = ipinput.Text.Trim();

                // Validate the IP address (you might want to add more validation)
                if (!string.IsNullOrEmpty(ipAddress))
                {
                    // Start the ping process
                    resultToShow = RunPing(ipAddress);

                    // Display the typing animation
                    pingresult.Visible = true;
                    currentIndex = 0;
                    pingresult.Text = "";
                    typingTimer.Start();
                }
                else
                {
                    // Inform the user to enter a valid IP address
                    MessageBox.Show("Please enter a valid IP address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private string RunPing(string ipAddress)
        {
            // Create process info
            MessageBox.Show("Started pinging...", "Notification");
            ProcessStartInfo psi = new ProcessStartInfo("ping", $"-n 4 {ipAddress}");
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            // Start the process
            Process process = Process.Start(psi);

            // Read the output
            string output = process.StandardOutput.ReadToEnd();

            // Wait for process to exit
            process.WaitForExit();

            return output;
        }
    }
}
