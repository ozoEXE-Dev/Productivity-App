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
    public partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            InitializeComponent();
        }
        public int timer { get; set; } = 25;
        private void MoveButtomBar(Button btn)
        {
            pnBottomBarSettings.BringToFront();
            pnBottomBarSettings.Width = btn.Width;
            pnBottomBarSettings.Left = btn.Left;
        }
       

        private void btnSettingsPomodoro_Click(object sender, EventArgs e)
        {
            ucPomodoroSettings1.BringToFront();
            MoveButtomBar((Button)sender);
        }

        private void btnSettingsTheme_Click(object sender, EventArgs e)
        {
            //user control of themes settings here
            MoveButtomBar((Button)sender);
        }

        private void ucPomodoroSettings1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            timer = ucPomodoroSettings1.timer;
        }
    }
}
