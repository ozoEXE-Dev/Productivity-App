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
    public partial class ucGoal : UserControl
    {
        public ucGoal()
        {
            InitializeComponent();
        }

        private void lblSubGoal1_Click(object sender, EventArgs e)
        {

        }

        private void ucGoal_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtGoal1.Text != "")
                chklGoal1.Items.Add(txtGoal1.Text);
            if (txtGoal2.Text != "")
                chklGoal2.Items.Add(txtGoal2.Text);
            txtGoal1.Text = "";
            txtGoal2.Text = "";
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chklGoal1.Items.Remove(chklGoal1.SelectedItem);

        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chklGoal2.Items.Remove(chklGoal2.SelectedItem);
        }
    }
}
