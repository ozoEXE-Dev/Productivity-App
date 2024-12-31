using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ucPomodoroSettings : UserControl
    {
        public ucPomodoroSettings()
        {
            InitializeComponent();
        }

        public int timer { get; set; } = 0;

        private void ucPomodoroSettings_Load(object sender, EventArgs e)
        {
            txtTimer.Text = "25";
            trackBar1.Value = 25;
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 90;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtTimer.Text = trackBar1.Value.ToString();
            timer = trackBar1.Value;

        }

        private bool IsDigitFrom1To90(string text)
        {
            int result = Convert.ToInt32(text);
            int[] arr = new int[90];
            for (int i = 0; i <= 89; i++)
            {
                arr[i] = i+1;
                if (result == arr[i])
                    return true;
            }
            return false;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTimer_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtTimer_TextChanged(object sender, EventArgs e)
        {
            if (txtTimer.Text != "" && IsDigitFrom1To90(txtTimer.Text))
            {
                trackBar1.Value = Convert.ToInt32(txtTimer.Text);
                timer = trackBar1.Value;

            }
        }

        
    }
}
