namespace ShutdownApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            txtTimeHours = new TextBox();
            txtTimeMinutes = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblCountdown = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(41, 244);
            button1.Name = "button1";
            button1.Size = new Size(219, 46);
            button1.TabIndex = 0;
            button1.Text = "Start Shutdown";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(324, 244);
            button2.Name = "button2";
            button2.Size = new Size(219, 46);
            button2.TabIndex = 1;
            button2.Text = "Abort Shutdown";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtTimeHours
            // 
            txtTimeHours.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTimeHours.Location = new Point(215, 172);
            txtTimeHours.Name = "txtTimeHours";
            txtTimeHours.ShortcutsEnabled = false;
            txtTimeHours.Size = new Size(67, 23);
            txtTimeHours.TabIndex = 2;
            txtTimeHours.Text = "0";
            // 
            // txtTimeMinutes
            // 
            txtTimeMinutes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTimeMinutes.Location = new Point(302, 172);
            txtTimeMinutes.Name = "txtTimeMinutes";
            txtTimeMinutes.Size = new Size(67, 23);
            txtTimeMinutes.TabIndex = 3;
            txtTimeMinutes.Text = "0";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(215, 154);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Hours";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(302, 154);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "Minutes";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(286, 175);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 6;
            label3.Text = ":";
            // 
            // lblCountdown
            // 
            lblCountdown.BackColor = SystemColors.ControlDark;
            lblCountdown.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCountdown.Location = new Point(50, 46);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(479, 71);
            lblCountdown.TabIndex = 7;
            lblCountdown.Text = "Time Remaining: N/A";
            lblCountdown.TextAlign = ContentAlignment.MiddleCenter;
            lblCountdown.Click += lblCountdown_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(584, 361);
            Controls.Add(lblCountdown);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTimeMinutes);
            Controls.Add(txtTimeHours);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "Form1";
            Text = "Shutdown Timer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtTimeHours;
        private TextBox txtTimeMinutes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblCountdown;
    }
}
