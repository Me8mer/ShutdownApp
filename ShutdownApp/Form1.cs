using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace ShutdownApp
{
    public partial class Form1 : Form
    {
        private Timer countdownTimer;
        private int remainingSeconds;
        public Form1()
        {
            InitializeComponent();

            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += CountdownTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int.TryParse(txtTimeHours.Text, out int hours)) && (int.TryParse(txtTimeMinutes.Text, out int minutes)))
            {
                int seconds = hours * 3600;
                seconds = seconds + (minutes * 60);
                remainingSeconds = seconds;
                Process.Start("shutdown", $"/s /t {seconds}");
                MessageBox.Show($"PC will shut down in {hours} hour(s) and {minutes} minute(s).", "Shutdown Scheduled");
                countdownTimer.Start();
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter a valid number.", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/a");
            MessageBox.Show("Shutdown canceled.", "Canceled");

            countdownTimer.Stop();
            lblCountdown.Text = "Time remaining: N/A";

        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
                lblCountdown.Text = $"Time remaining: {FormatTime(remainingSeconds)}";
            }
            else
            {
                countdownTimer.Stop();
                lblCountdown.Text = "Time remaining: N/A";
            }
        }

        private string FormatTime(int seconds)
        {
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int secs = seconds % 60;
            return $"{hours:D2}:{minutes:D2}:{secs:D2}";
        }

        private void lblCountdown_Click(object sender, EventArgs e)
        {
            
        }
    }
}
