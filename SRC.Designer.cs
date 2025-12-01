namespace CheatCracker
{
    partial class SRC
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
            txtOutput = new TextBox();
            btnBrowse = new Button();
            btnSave = new Button();
            BACK = new Button();
            btnClear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.FromArgb(255, 128, 255);
            txtOutput.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOutput.Location = new Point(0, 176);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Both;
            txtOutput.Size = new Size(800, 273);
            txtOutput.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(255, 128, 255);
            btnBrowse.BackgroundImageLayout = ImageLayout.None;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(12, 147);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "file";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 128, 255);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(713, 147);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // BACK
            // 
            BACK.BackColor = Color.FromArgb(255, 128, 255);
            BACK.FlatStyle = FlatStyle.Flat;
            BACK.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BACK.Location = new Point(713, 12);
            BACK.Name = "BACK";
            BACK.Size = new Size(75, 23);
            BACK.TabIndex = 3;
            BACK.Text = "Back";
            BACK.UseVisualStyleBackColor = false;
            BACK.Click += BACK_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 255);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(367, 147);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 255);
            label1.Location = new Point(338, 50);
            label1.Name = "label1";
            label1.Size = new Size(190, 24);
            label1.TabIndex = 5;
            label1.Text = ".exe/dll to src";
            // 
            // SRC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(BACK);
            Controls.Add(btnSave);
            Controls.Add(btnBrowse);
            Controls.Add(txtOutput);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SRC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SRC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOutput;
        private Button btnBrowse;
        private Button btnSave;
        private Button BACK;
        private Button btnClear;
        private Label label1;
    }
}