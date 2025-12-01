namespace CheatCracker
{
    partial class Loader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DllLoader = new TextBox();
            BACK = new Button();
            selectdll = new Button();
            browse = new Button();
            selecttaskmanager = new Button();
            RefreshTaskManager = new Button();
            RUNDLL = new Button();
            TaskManager = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // DllLoader
            // 
            DllLoader.BackColor = Color.FromArgb(128, 128, 255);
            DllLoader.Location = new Point(1, 322);
            DllLoader.Multiline = true;
            DllLoader.Name = "DllLoader";
            DllLoader.ScrollBars = ScrollBars.Vertical;
            DllLoader.Size = new Size(503, 247);
            DllLoader.TabIndex = 1;
            // 
            // BACK
            // 
            BACK.BackColor = Color.FromArgb(128, 128, 255);
            BACK.FlatStyle = FlatStyle.Flat;
            BACK.Location = new Point(942, 12);
            BACK.Name = "BACK";
            BACK.Size = new Size(75, 29);
            BACK.TabIndex = 2;
            BACK.Text = "Back";
            BACK.UseVisualStyleBackColor = false;
            BACK.Click += BACK_Click;
            // 
            // selectdll
            // 
            selectdll.BackColor = Color.FromArgb(128, 128, 255);
            selectdll.FlatStyle = FlatStyle.Flat;
            selectdll.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectdll.Location = new Point(412, 293);
            selectdll.Name = "selectdll";
            selectdll.Size = new Size(75, 23);
            selectdll.TabIndex = 3;
            selectdll.Text = "Select";
            selectdll.UseVisualStyleBackColor = false;
            selectdll.Click += selectdll_Click;
            // 
            // browse
            // 
            browse.BackColor = Color.FromArgb(128, 128, 255);
            browse.FlatStyle = FlatStyle.Flat;
            browse.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            browse.Location = new Point(1, 293);
            browse.Name = "browse";
            browse.Size = new Size(75, 23);
            browse.TabIndex = 4;
            browse.Text = "DLL";
            browse.UseVisualStyleBackColor = false;
            browse.Click += browse_Click;
            // 
            // selecttaskmanager
            // 
            selecttaskmanager.BackColor = Color.FromArgb(255, 128, 255);
            selecttaskmanager.FlatStyle = FlatStyle.Flat;
            selecttaskmanager.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selecttaskmanager.Location = new Point(954, 293);
            selecttaskmanager.Name = "selecttaskmanager";
            selecttaskmanager.Size = new Size(75, 23);
            selecttaskmanager.TabIndex = 5;
            selecttaskmanager.Text = "Select";
            selecttaskmanager.UseVisualStyleBackColor = false;
            selecttaskmanager.Click += selecttaskmanager_Click;
            // 
            // RefreshTaskManager
            // 
            RefreshTaskManager.BackColor = Color.FromArgb(255, 128, 255);
            RefreshTaskManager.FlatStyle = FlatStyle.Flat;
            RefreshTaskManager.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RefreshTaskManager.Location = new Point(543, 293);
            RefreshTaskManager.Name = "RefreshTaskManager";
            RefreshTaskManager.Size = new Size(75, 23);
            RefreshTaskManager.TabIndex = 6;
            RefreshTaskManager.Text = "Refresh";
            RefreshTaskManager.UseVisualStyleBackColor = false;
            RefreshTaskManager.Click += RefreshTaskManager_Click;
            // 
            // RUNDLL
            // 
            RUNDLL.BackColor = Color.FromArgb(255, 128, 255);
            RUNDLL.FlatStyle = FlatStyle.Flat;
            RUNDLL.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RUNDLL.Location = new Point(478, 264);
            RUNDLL.Name = "RUNDLL";
            RUNDLL.Size = new Size(75, 23);
            RUNDLL.TabIndex = 7;
            RUNDLL.Text = "Run";
            RUNDLL.UseVisualStyleBackColor = false;
            RUNDLL.Click += RUNDLL_Click;
            // 
            // TaskManager
            // 
            TaskManager.BackColor = Color.FromArgb(255, 128, 255);
            TaskManager.FormattingEnabled = true;
            TaskManager.Location = new Point(510, 322);
            TaskManager.Name = "TaskManager";
            TaskManager.ScrollAlwaysVisible = true;
            TaskManager.Size = new Size(519, 251);
            TaskManager.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(400, 112);
            label1.Name = "label1";
            label1.Size = new Size(239, 43);
            label1.TabIndex = 9;
            label1.Text = "DLL Loader ";
            // 
            // Loader
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1029, 570);
            Controls.Add(label1);
            Controls.Add(TaskManager);
            Controls.Add(RUNDLL);
            Controls.Add(RefreshTaskManager);
            Controls.Add(selecttaskmanager);
            Controls.Add(browse);
            Controls.Add(selectdll);
            Controls.Add(BACK);
            Controls.Add(DllLoader);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Loader";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox DllLoader;
        private Button BACK;
        private Button selectdll;
        private Button browse;
        private Button selecttaskmanager;
        private Button RefreshTaskManager;
        private Button RUNDLL;
        private ListBox TaskManager;
        private Label label1;
    }
}