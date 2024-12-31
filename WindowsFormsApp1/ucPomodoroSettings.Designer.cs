namespace WindowsFormsApp1
{
    partial class ucPomodoroSettings
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
            this.lblPomodoroSettings = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txtTimer = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPomodoroSettings
            // 
            this.lblPomodoroSettings.AutoSize = true;
            this.lblPomodoroSettings.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPomodoroSettings.ForeColor = System.Drawing.Color.Black;
            this.lblPomodoroSettings.Location = new System.Drawing.Point(203, 18);
            this.lblPomodoroSettings.Name = "lblPomodoroSettings";
            this.lblPomodoroSettings.Size = new System.Drawing.Size(522, 46);
            this.lblPomodoroSettings.TabIndex = 0;
            this.lblPomodoroSettings.Text = "Change Pomodoro Timer";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(20, 109);
            this.trackBar1.Maximum = 90;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(927, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txtTimer
            // 
            this.txtTimer.BackColor = System.Drawing.Color.Silver;
            this.txtTimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimer.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTimer.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.HidePromptOnLeave = true;
            this.txtTimer.Location = new System.Drawing.Point(438, 131);
            this.txtTimer.Mask = "00000";
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.PromptChar = ' ';
            this.txtTimer.Size = new System.Drawing.Size(53, 23);
            this.txtTimer.TabIndex = 15;
            this.txtTimer.Text = "25";
            this.txtTimer.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTimer.ValidatingType = typeof(int);
            this.txtTimer.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTimer_MaskInputRejected);
            this.txtTimer.TextChanged += new System.EventHandler(this.txtTimer_TextChanged);
            // 
            // ucPomodoroSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblPomodoroSettings);
            this.Name = "ucPomodoroSettings";
            this.Size = new System.Drawing.Size(971, 346);
            this.Load += new System.EventHandler(this.ucPomodoroSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPomodoroSettings;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.MaskedTextBox txtTimer;
    }
}
