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
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.MaximizeBox = false;
            ucPomodoro1.BringToFront();

        }



        public Form1()
        {
            InitializeComponent();

        }

        private void btnGoals_Click(object sender, EventArgs e)
        {
            ucGoals1.BringToFront();
            pnSideBar.Height = btnGoals.Height;
            pnSideBar.Top = btnGoals.Top;
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            ucPomodoro1.Set_Timer(ucSettings1.timer);
            ucPomodoro1.SetLblTimer();
            ucPomodoro1.BringToFront();
            pnSideBar.Height = btnPomodoro.Height;
            pnSideBar.Top = btnPomodoro.Top;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ucSettings1.BringToFront();
            pnSideBar.Height = btnSettings.Height;
            pnSideBar.Top = btnSettings.Top;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnSideBar.Height = btnExit.Height;
            pnSideBar.Top = btnExit.Top;
            Application.Exit();
        }

        private void ucGoals1_Load(object sender, EventArgs e)
        {

        }
    }
}
