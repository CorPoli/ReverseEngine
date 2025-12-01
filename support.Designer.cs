namespace CheatCracker
{
    partial class support
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
            BACK = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BACK
            // 
            BACK.BackColor = Color.Gray;
            BACK.FlatStyle = FlatStyle.Flat;
            BACK.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BACK.Location = new Point(713, 12);
            BACK.Name = "BACK";
            BACK.Size = new Size(75, 30);
            BACK.TabIndex = 0;
            BACK.Text = "BACK";
            BACK.UseVisualStyleBackColor = false;
            BACK.Click += BACK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(582, 76);
            label1.Name = "label1";
            label1.Size = new Size(179, 43);
            label1.TabIndex = 1;
            label1.Text = "Engraved";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 192);
            label2.Location = new Point(100, 417);
            label2.Name = "label2";
            label2.Size = new Size(634, 24);
            label2.TabIndex = 2;
            label2.Text = "this program was coded by swipv on behalf of corpoli";
            // 
            // support
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._0634a989af55e800cd8b8d52a3be798d_3728921888;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BACK);
            FormBorderStyle = FormBorderStyle.None;
            Name = "support";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "support";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BACK;
        private Label label1;
        private Label label2;
    }
}