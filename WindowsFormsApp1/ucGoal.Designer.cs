namespace WindowsFormsApp1
{
    partial class ucGoal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chklGoal1 = new System.Windows.Forms.CheckedListBox();
            this.chklGoal2 = new System.Windows.Forms.CheckedListBox();
            this.txtGoal2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtGoal1 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chklGoal1
            // 
            this.chklGoal1.BackColor = System.Drawing.Color.DarkGray;
            this.chklGoal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chklGoal1.CheckOnClick = true;
            this.chklGoal1.ContextMenuStrip = this.contextMenuStrip1;
            this.chklGoal1.Font = new System.Drawing.Font("AF_Diwani", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chklGoal1.FormattingEnabled = true;
            this.chklGoal1.Location = new System.Drawing.Point(34, 53);
            this.chklGoal1.Name = "chklGoal1";
            this.chklGoal1.Size = new System.Drawing.Size(339, 205);
            this.chklGoal1.TabIndex = 0;
            // 
            // chklGoal2
            // 
            this.chklGoal2.BackColor = System.Drawing.Color.DarkGray;
            this.chklGoal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chklGoal2.ContextMenuStrip = this.contextMenuStrip2;
            this.chklGoal2.Font = new System.Drawing.Font("AF_Diwani", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chklGoal2.FormattingEnabled = true;
            this.chklGoal2.Location = new System.Drawing.Point(550, 53);
            this.chklGoal2.Name = "chklGoal2";
            this.chklGoal2.Size = new System.Drawing.Size(339, 205);
            this.chklGoal2.TabIndex = 2;
            // 
            // txtGoal2
            // 
            this.txtGoal2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGoal2.Location = new System.Drawing.Point(556, 277);
            this.txtGoal2.Name = "txtGoal2";
            this.txtGoal2.Size = new System.Drawing.Size(333, 20);
            this.txtGoal2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "SubGoal 1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Silver;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(544, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(339, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "SubGoal 2";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGoal1
            // 
            this.txtGoal1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGoal1.Location = new System.Drawing.Point(29, 277);
            this.txtGoal1.Name = "txtGoal1";
            this.txtGoal1.Size = new System.Drawing.Size(333, 20);
            this.txtGoal1.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnStart.FlatAppearance.BorderSize = 5;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(383, 288);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(166, 55);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Add Task";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Silver;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.Color.Silver;
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // ucGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtGoal1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtGoal2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chklGoal2);
            this.Controls.Add(this.chklGoal1);
            this.Name = "ucGoal";
            this.Size = new System.Drawing.Size(971, 346);
            this.Load += new System.EventHandler(this.ucGoal_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox chklGoal1;
        private System.Windows.Forms.CheckedListBox chklGoal2;
        private System.Windows.Forms.TextBox txtGoal2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtGoal1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
    }
}
