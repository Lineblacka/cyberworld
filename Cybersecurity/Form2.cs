using System;
using System.Diagnostics;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Cybersecurity
{
    public partial class Form2 : Form
    {
        private const string RepositoryUrl = "https://api.github.com/repos/Lineblacka/cyberworld";

        private string resultToShow;
        private int currentIndex;


        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            ipinput.KeyDown += ipinput_KeyDown;

            FetchAllCommitMessagesWithDates();
        }

        private void StartListening()
        {
            int listenPort = 80; // Example port
            IPAddress localAddr = IPAddress.Parse("127.0.0.1"); // Listen on localhost, adjust as necessary

            try
            {
                TcpListener listener = new TcpListener(localAddr, listenPort);
                listener.Start();

                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();

                    IPEndPoint remoteEndPoint = client.Client.RemoteEndPoint as IPEndPoint;
                    string remoteIP = remoteEndPoint.Address.ToString();
                    int remotePort = remoteEndPoint.Port;
                    string protocol = "TCP"; // Since we're using TcpListener

                    UpdateUI($"{remoteIP} {remotePort} {protocol}");

                    client.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sniffstart_Click(object sender, EventArgs e)
        {
            Thread listenerThread = new Thread(StartListening);
            listenerThread.IsBackground = true; // Mark the thread as a background thread
            listenerThread.Start();
        }


        private void UpdateUI(string message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(UpdateUI), new object[] { message });
                return;
            }
            sniffed.Text = message; // `sniffed` is your label for displaying IP, port, and protocol
        }


        private void FetchAllCommitMessagesWithDates()
        {
            var client = new RestClient(RepositoryUrl);
            var request = new RestRequest("/commits", RestSharp.Method.Get); // Use RestSharp.Method.GET directly
            request.AddParameter("per_page", 100); // Fetch a reasonable number of commits per page
            request.AddHeader("User-Agent", "RestSharp"); // GitHub requires User-Agent header
            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var jsonResponse = JArray.Parse(response.Content);
                string commitMessages = "";
                
                for (int i = 0; i < jsonResponse.Count; i++)
                {
                    var commit = jsonResponse[i];
                    var commitMessage = commit["commit"]["message"].ToString();
                    var commitDate = DateTime.Parse(commit["commit"]["author"]["date"].ToString());

                    var formattedDate = commitDate.ToString("yyyy-MM-dd");

                    commitMessages += $"{i + 1}. [{formattedDate}] - {commitMessage}{Environment.NewLine}";
                }

                latestupdate.Text = commitMessages;
            }
            else
            {
                MessageBox.Show("Failed to fetch commit messages from GitHub.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TypingTimer_Tick(object sender, EventArgs e)
        {
            if (currentIndex < resultToShow.Length)
            {
                pingresult.Text += resultToShow[currentIndex];
                currentIndex++;
            }
            else
            {
            }
        }

        private void ipinput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string ipAddress = ipinput.Text.Trim();

                if (!string.IsNullOrEmpty(ipAddress))
                {
                    resultToShow = RunPing(ipAddress);

                    
                }
                else
                {
                    MessageBox.Show("Please enter a valid IP address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private string RunPing(string ipAddress)
        {
            MessageBox.Show("Started pinging...", "Notification");
            ProcessStartInfo psi = new ProcessStartInfo("ping", $"-n 4 {ipAddress}");
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            Process process = Process.Start(psi);

            string output = process.StandardOutput.ReadToEnd();
            pingresult.Visible = true;
            currentIndex = 0;
            pingresult.Text = output;

            process.WaitForExit();

            return output;
        }

        private void sniffer_Click(object sender, EventArgs e)
        {
            //false
            pinglabel.Visible = false;
            ipinput.Visible = false;
            podipinput.Visible = false;
            pingresult.Visible = false;
            latestupdate.Visible = false;
            latestupdatelabel.Visible = false;

            //true
            snifferlabel.Visible = true;
            sniffstart.Visible = true;
        }

        private Form3 form3; // Assume form3 is initialized somewhere in your code

        private void exploits_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current form, which is Form2 in this context
            if (form3 == null || form3.IsDisposed) // Check if form3 is not already open
            {
                form3 = new Form3(); // Creates a new instance of Form3 if it doesn't exist or was disposed
                form3.FormClosed += (s, args) => this.Show(); // Optional: Shows Form2 again when Form3 is closed
            }
            form3.Show(); // Shows Form3
        }

    }
}
