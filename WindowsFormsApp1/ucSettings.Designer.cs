namespace WindowsFormsApp1
{
    partial class ucSettings
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
            this.btnSettingsPomodoro = new System.Windows.Forms.Button();
            this.pnBottomBarSettings = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucPomodoroSettings1 = new WindowsFormsApp1.ucPomodoroSettings();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettingsPomodoro
            // 
            this.btnSettingsPomodoro.AutoSize = true;
            this.btnSettingsPomodoro.FlatAppearance.BorderSize = 0;
            this.btnSettingsPomodoro.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettingsPomodoro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettingsPomodoro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettingsPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsPomodoro.Font = new System.Drawing.Font("Century Gothic", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsPomodoro.ForeColor = System.Drawing.Color.White;
            this.btnSettingsPomodoro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingsPomodoro.ImageIndex = 3;
            this.btnSettingsPomodoro.Location = new System.Drawing.Point(3, 0);
            this.btnSettingsPomodoro.Name = "btnSettingsPomodoro";
            this.btnSettingsPomodoro.Size = new System.Drawing.Size(986, 79);
            this.btnSettingsPomodoro.TabIndex = 1;
            this.btnSettingsPomodoro.Text = "Pomodoro";
            this.btnSettingsPomodoro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettingsPomodoro.UseVisualStyleBackColor = true;
            this.btnSettingsPomodoro.Click += new System.EventHandler(this.btnSettingsPomodoro_Click);
            // 
            // pnBottomBarSettings
            // 
            this.pnBottomBarSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnBottomBarSettings.ForeColor = System.Drawing.Color.Red;
            this.pnBottomBarSettings.Location = new System.Drawing.Point(9, 85);
            this.pnBottomBarSettings.Name = "pnBottomBarSettings";
            this.pnBottomBarSettings.Size = new System.Drawing.Size(986, 26);
            this.pnBottomBarSettings.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pnBottomBarSettings);
            this.panel1.Controls.Add(this.btnSettingsPomodoro);
            this.panel1.Location = new System.Drawing.Point(-9, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 103);
            this.panel1.TabIndex = 1;
            // 
            // ucPomodoroSettings1
            // 
            this.ucPomodoroSettings1.BackColor = System.Drawing.Color.Silver;
            this.ucPomodoroSettings1.Location = new System.Drawing.Point(9, 100);
            this.ucPomodoroSettings1.Name = "ucPomodoroSettings1";
            this.ucPomodoroSettings1.Size = new System.Drawing.Size(971, 354);
            this.ucPomodoroSettings1.TabIndex = 2;
            this.ucPomodoroSettings1.timer = 25;
            this.ucPomodoroSettings1.Load += new System.EventHandler(this.ucPomodoroSettings1_Load);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConfirm.FlatAppearance.BorderSize = 5;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(261, 390);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(418, 64);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.ucPomodoroSettings1);
            this.Controls.Add(this.panel1);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(980, 457);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettingsPomodoro;
        private System.Windows.Forms.Panel pnBottomBarSettings;
        private System.Windows.Forms.Panel panel1;
        public ucPomodoroSettings ucPomodoroSettings1;
        private System.Windows.Forms.Button btnConfirm;
    }
}
