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
    public partial class ucGoals : UserControl
    {
        public ucGoals()
        {
            InitializeComponent();
        }

        private void MoveBottomBar(Button btn)
        {
            pnBottomBar.BringToFront();
            pnBottomBar.Width = btn.Width;
            pnBottomBar.Left = btn.Left;
        }


        private void btnGoal1_Click_1(object sender, EventArgs e)
        {
            ucGoal1.BringToFront();
            MoveBottomBar((Button)sender);

        }

        public void BlackTheme()
        {
            btnGoal1.Text = "dfsdfs";
        }

        private void btnGoal2_Click_1(object sender, EventArgs e)
        {
            ucGoal2.BringToFront();
            MoveBottomBar((Button)sender);
        }

        private void btnGoal3_Click(object sender, EventArgs e)
        {
            ucGoal3.BringToFront();
            MoveBottomBar((Button)sender);
        }

        private void btnGoal4_Click(object sender, EventArgs e)
        {
            ucGoal4.BringToFront();
            MoveBottomBar((Button)sender);
        }

        private void btnGoal5_Click(object sender, EventArgs e)
        {
            ucGoal5.BringToFront();
            MoveBottomBar((Button)sender);
        }



        private void ucGoals_Load_1(object sender, EventArgs e)
        {
            ucGoal1.BringToFront();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucGoal2_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
  
    }
}
