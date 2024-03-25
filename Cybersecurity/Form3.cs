using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Cybersecurity
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            exploitlabel.Visible = true;
            cve.Visible = true;

            // Call a method to read the file and set the text to the label
            SetCVELabelText();
        }

        private void SetCVELabelText()
        {
            try
            {
                string filePath = @"C:\Users\Teacher\Desktop\CyberWorld\exploits_sorted.txt";

                // Check if the file exists
                if (!File.Exists(filePath))
                {
                    MessageBox.Show($"File not found: {filePath}");
                    return;
                }

                // Read the first three lines from the file
                string[] lines = File.ReadLines(filePath).Take(1003).ToArray();

                // Log the number of lines read
                Console.WriteLine($"Number of lines read from file: {lines.Length}");

                if (lines == null || lines.Length == 0)
                {
                    MessageBox.Show("No data found in the file.");
                    return;
                }

                var codeDescriptions = lines.Select(line =>
                {
                    try
                    {
                        // Parse JSON object
                        dynamic obj = JsonConvert.DeserializeObject(line);

                        // Extract 'codes' and 'description' fields
                        string codes = obj.codes;
                        string description = obj.description;

                        // Combine 'codes' and 'description' into the desired format
                        return $"{codes} | {description}";
                    }
                    catch (Exception ex)
                    {
                        // Log any parsing errors
                        Console.WriteLine($"Error parsing JSON: {ex.Message}");
                        return "Parsing error";
                    }
                });

                // Join the extracted codes and descriptions into a single string
                string cveText = string.Join(Environment.NewLine, codeDescriptions);

                // Log the generated CVE text
                Console.WriteLine($"CVE Text: {cveText}");

                // Set the text to the label
                cve.Visible = true;
                cve.Text = cveText;
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., file not found, permissions issue)
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
