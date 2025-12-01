using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CheatCracker
{
    public partial class DOMAINS : Form
    {
        public DOMAINS()
        {
            InitializeComponent();

            this.AllowDrop = true;
            this.DragEnter += DOMAINS_DragEnter;
            this.DragDrop += DOMAINS_DragDrop;
        }

        private void DOMAINS_Load(object sender, EventArgs e)
        {

        }


        private void BACK_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }


        private void SAVE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOutput.Text))
            {
                MessageBox.Show("Nothing to save.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Text File (*.txt)|*.txt",
                Title = "Save Scan Results"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, txtOutput.Text, Encoding.UTF8);
                MessageBox.Show("Saved successfully!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Executable Files (*.exe;*.dll)|*.exe;*.dll",
                Title = "Select a File to Scan"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
                ScanFile(ofd.FileName);
        }



        private void DOMAINS_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void DOMAINS_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
                ScanFile(files[0]);
        }



        private void ScanFile(string filePath)
        {
            txtOutput.Text = "Scanning file...\r\n";

            try
            {
                string results = RunDomainScanner(filePath);
                txtOutput.Text = results;
            }
            catch (Exception ex)
            {
                txtOutput.Text = $"ERROR scanning file:\r\n{ex}";
            }
        }



        private string RunDomainScanner(string filePath)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("===== DOMAIN / URL / IP SCAN RESULTS =====");
            sb.AppendLine("File: " + Path.GetFileName(filePath));
            sb.AppendLine("------------------------------------------\r\n");

            byte[] bytes = File.ReadAllBytes(filePath);
            var strings = ExtractStrings(bytes, 4);

            
            Regex urlRegex = new Regex(@"https?://[^\s""']+");
            Regex ipRegex = new Regex(@"\b(?:\d{1,3}\.){3}\d{1,3}\b");
            Regex domainRegex = new Regex(@"\b[a-zA-Z0-9.-]+\.[a-zA-Z]{2,10}\b");
            Regex webhookRegex = new Regex(@"https://discord(?:app)?\.com/api/webhooks/[^\s""']+");

            string[] keywords =
            {
                "webhook", "token", "grab", "inject", "parasite", "steal",
                "login", "ftp", "smtp", "discord", "async", "rat"
            };

            foreach (var s in strings)
            {
                bool flagged = false;

                if (webhookRegex.IsMatch(s))
                {
                    sb.AppendLine("[DISCORD WEBHOOK] " + s);
                    flagged = true;
                }

                if (urlRegex.IsMatch(s))
                {
                    sb.AppendLine("[URL] " + s);
                    flagged = true;
                }

                if (ipRegex.IsMatch(s))
                {
                    sb.AppendLine("[IP] " + s);
                    flagged = true;
                }

                if (!flagged && domainRegex.IsMatch(s))
                {
                    sb.AppendLine("[DOMAIN] " + s);
                    flagged = true;
                }

                foreach (string k in keywords)
                {
                    if (s.ToLower().Contains(k))
                    {
                        sb.AppendLine("[SUSPICIOUS STRING] " + s);
                        break;
                    }
                }
            }

            if (sb.ToString().Trim().Length < 50)
                sb.AppendLine("No indicators found.");

            return sb.ToString();
        }

       
        private static string[] ExtractStrings(byte[] bytes, int minLength = 4)
        {
            List<string> results = new List<string>();
            StringBuilder sb = new StringBuilder();
            int count = 0;

            foreach (byte b in bytes)
            {
                if (b >= 32 && b <= 126)
                {
                    sb.Append((char)b);
                    count++;
                }
                else
                {
                    if (count >= minLength)
                        results.Add(sb.ToString());

                    sb.Clear();
                    count = 0;
                }
            }

            
            if (count >= minLength)
                results.Add(sb.ToString());

            return results.ToArray();
        }
    }
}
