namespace CheatCracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ENTER = new Button();
            Password = new TextBox();
            username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Signin = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // ENTER
            // 
            ENTER.Location = new Point(353, 291);
            ENTER.Name = "ENTER";
            ENTER.Size = new Size(75, 23);
            ENTER.TabIndex = 0;
            ENTER.Text = "ENTER";
            ENTER.UseVisualStyleBackColor = true;
            ENTER.Click += ENTER_Click;
            // 
            // Password
            // 
            Password.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.ForeColor = Color.FromArgb(255, 128, 255);
            Password.Location = new Point(338, 262);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(100, 23);
            Password.TabIndex = 2;
            // 
            // username
            // 
            username.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.FromArgb(255, 128, 255);
            username.Location = new Point(338, 233);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(100, 23);
            username.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Consolas", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(281, 73);
            label1.Name = "label1";
            label1.Size = new Size(234, 58);
            label1.TabIndex = 4;
            label1.Text = "CrackNet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 255);
            label2.Location = new Point(636, 409);
            label2.Name = "label2";
            label2.Size = new Size(152, 24);
            label2.TabIndex = 5;
            label2.Text = "Coded by swipv";
            // 
            // Signin
            // 
            Signin.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Signin.Location = new Point(353, 390);
            Signin.Name = "Signin";
            Signin.Size = new Size(75, 23);
            Signin.TabIndex = 6;
            Signin.Text = "login";
            Signin.UseVisualStyleBackColor = true;
            Signin.Click += Signin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 0, 192);
            label3.Location = new Point(333, 215);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 7;
            label3.Text = "create account";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 442);
            Controls.Add(label3);
            Controls.Add(Signin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(username);
            Controls.Add(Password);
            Controls.Add(ENTER);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ENTER;
        private TextBox Password;
        private TextBox username;
        private Label label1;
        private Label label2;
        private Button Signin;
        private Label label3;
    }
}
