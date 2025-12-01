using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CheatCracker
{
    public partial class Loader : Form
    {
        private string selectedDll = "";
        private Process selectedProcess = null;

        public Loader()
        {
            InitializeComponent();

            
            DllLoader.AllowDrop = true;
            DllLoader.DragEnter += DllLoader_DragEnter;
            DllLoader.DragDrop += DllLoader_DragDrop;
        }

       

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "DLL Files (*.dll)|*.dll";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedDll = ofd.FileName;
                DllLoader.Text = selectedDll;
            }
        }

        private void DllLoader_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void DllLoader_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0 && Path.GetExtension(files[0]).ToLower() == ".dll")
            {
                selectedDll = files[0];
                DllLoader.Text = selectedDll;
            }
        }

        private void selectdll_Click(object sender, EventArgs e)
        {
            if (File.Exists(selectedDll))
                MessageBox.Show("DLL selected:\n" + selectedDll);
            else
                MessageBox.Show("Please choose a valid DLL.");
        }

        

        private void RefreshTaskManager_Click(object sender, EventArgs e)
        {
            TaskManager.Items.Clear();

            foreach (Process p in Process.GetProcesses())
            {
                TaskManager.Items.Add($"{p.ProcessName} (PID: {p.Id})");
            }
        }

        private void selecttaskmanager_Click(object sender, EventArgs e)
        {
            if (TaskManager.SelectedItem == null)
            {
                MessageBox.Show("Please select a process.");
                return;
            }

            string text = TaskManager.SelectedItem.ToString();
            int pid = int.Parse(text.Split(new string[] { "PID:" }, StringSplitOptions.None)[1]
                .Replace(")", "")
                .Trim());

            selectedProcess = Process.GetProcessById(pid);

            MessageBox.Show("Process selected:\n" + selectedProcess.ProcessName);
        }

        

        private void RUNDLL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedDll))
            {
                MessageBox.Show("Select a DLL first.");
                return;
            }

            try
            {
                Assembly asm = Assembly.LoadFrom(selectedDll);
                MessageBox.Show("DLL loaded successfully into this app .\n  injection performed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading DLL:\n" + ex.Message);
            }
        }

        

        private void BACK_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }
    }
}
