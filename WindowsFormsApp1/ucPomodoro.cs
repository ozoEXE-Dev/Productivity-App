using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class ucPomodoro : UserControl 
    {
        static public TimeSpan Timerr { set; get; } = TimeSpan.FromMinutes(25);
        TimeSpan TempTimer = Timerr;

        public ucPomodoro()
        {
            InitializeComponent();
        }
        SoundPlayer Alarm = new SoundPlayer(@"file:///D:/Youssef/Programming/repos/WindowsFormsApp1/WindowsFormsApp1/Resources/rooster.wav"); 

        public void SetLblTimer()
        {
            lblTimer.Text = Timerr.ToString();
        }

        public void Set_Timer(int result)
        {
            Timerr = TimeSpan.FromMinutes(result);
            TempTimer = Timerr;
        }

        private void ucPomodoro_Load(object sender, EventArgs e)
        {
            lblTimer.Text = Timerr.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TempTimer -= TimeSpan.FromSeconds(1);
            lblTimer.Text = TempTimer.ToString();
            if (TempTimer < TimeSpan.FromSeconds(1)) {
                timer1.Enabled = false;
                Alarm.PlayLooping();
            }
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Alarm.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            TempTimer = Timerr;
            lblTimer.Text = Timerr.ToString();
        }
    }
}
