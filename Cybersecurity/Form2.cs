using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Cybersecurity
{
    public partial class Form2 : Form
    {
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
