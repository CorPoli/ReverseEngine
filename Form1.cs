using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CheatCracker
{
    public partial class Form1 : Form
    {
        private static readonly string filePath = "users.json";

        public Form1()
        {
            InitializeComponent();
        }

       
        public class UserAccount
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        
        private List<UserAccount> LoadUsers()
        {
            if (!File.Exists(filePath))
                return new List<UserAccount>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<UserAccount>>(json);
        }

        
        private void SaveUsers(List<UserAccount> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        
        private void ENTER_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = Password.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            var users = LoadUsers();

           
            foreach (var u in users)
            {
                if (u.Username == user)
                {
                    MessageBox.Show("This username already exists!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            
            users.Add(new UserAccount { Username = user, Password = pass });
            SaveUsers(users);

            MessageBox.Show("Account created! You are now logged in.", "Success");

            
            home h = new home();
            h.Show();
            this.Hide();
        }

        
        private void Signin_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = Password.Text;

            var users = LoadUsers();

            foreach (var u in users)
            {
                if (u.Username == user && u.Password == pass)
                {
                    MessageBox.Show("Login Successful!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    home h = new home();
                    h.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Incorrect username or password!", "Access Denied",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
