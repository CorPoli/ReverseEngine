namespace CheatCracker
{
    partial class DOMAINS
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
            SAVE = new Button();
            btnClear = new Button();
            btnBrowse = new Button();
            BACK = new Button();
            txtOutput = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // SAVE
            // 
            SAVE.BackColor = Color.FromArgb(255, 128, 255);
            SAVE.FlatStyle = FlatStyle.Flat;
            SAVE.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SAVE.Location = new Point(713, 204);
            SAVE.Name = "SAVE";
            SAVE.Size = new Size(75, 23);
            SAVE.TabIndex = 0;
            SAVE.Text = "Save";
            SAVE.UseVisualStyleBackColor = false;
            SAVE.Click += SAVE_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 255);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(364, 204);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(255, 128, 255);
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(8, 204);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "file";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // BACK
            // 
            BACK.BackColor = Color.FromArgb(255, 128, 255);
            BACK.FlatStyle = FlatStyle.Flat;
            BACK.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BACK.Location = new Point(713, 16);
            BACK.Name = "BACK";
            BACK.Size = new Size(75, 23);
            BACK.TabIndex = 3;
            BACK.Text = "Back";
            BACK.UseVisualStyleBackColor = false;
            BACK.Click += BACK_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.FromArgb(255, 128, 255);
            txtOutput.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOutput.Location = new Point(0, 233);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Both;
            txtOutput.Size = new Size(799, 216);
            txtOutput.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 255);
            label1.Location = new Point(228, 26);
            label1.Name = "label1";
            label1.Size = new Size(337, 140);
            label1.TabIndex = 5;
            label1.Text = "Checks .exe and dlls for:\r\nsus ips \r\nsus keywords eg: rat\r\nand domains/webhooks\r\nand apis";
            // 
            // DOMAINS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtOutput);
            Controls.Add(BACK);
            Controls.Add(btnBrowse);
            Controls.Add(btnClear);
            Controls.Add(SAVE);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DOMAINS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DOMAINS";
            Load += DOMAINS_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SAVE;
        private Button btnClear;
        private Button btnBrowse;
        private Button BACK;
        private TextBox txtOutput;
        private Label label1;
    }
}