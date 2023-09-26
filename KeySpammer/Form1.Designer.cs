namespace KeySpammer
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.spamAltF4Btn = new System.Windows.Forms.Button();
            this.spamSetDrawBtn = new System.Windows.Forms.Button();
            this.volMaxBtn = new System.Windows.Forms.Button();
            this.volMinBtn = new System.Windows.Forms.Button();
            this.spamMuteKeyBtn = new System.Windows.Forms.Button();
            this.spamSleepKeyBtn = new System.Windows.Forms.Button();
            this.spamControlKeyBtn = new System.Windows.Forms.Button();
            this.spamEscapeKeyBtn = new System.Windows.Forms.Button();
            this.spamBackKeyBtn = new System.Windows.Forms.Button();
            this.spamDeleteKeyBtn = new System.Windows.Forms.Button();
            this.intervalBar = new System.Windows.Forms.TrackBar();
            this.intervalLbl = new System.Windows.Forms.Label();
            this.killSpammersBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.intervalBar)).BeginInit();
            this.SuspendLayout();
            // 
            // spamAltF4Btn
            // 
            this.spamAltF4Btn.Location = new System.Drawing.Point(12, 12);
            this.spamAltF4Btn.Name = "spamAltF4Btn";
            this.spamAltF4Btn.Size = new System.Drawing.Size(75, 23);
            this.spamAltF4Btn.TabIndex = 0;
            this.spamAltF4Btn.Text = "Spam Alt+F4";
            this.spamAltF4Btn.UseVisualStyleBackColor = true;
            this.spamAltF4Btn.Click += new System.EventHandler(this.spamAltF4Btn_Click);
            // 
            // spamSetDrawBtn
            // 
            this.spamSetDrawBtn.Location = new System.Drawing.Point(93, 12);
            this.spamSetDrawBtn.Name = "spamSetDrawBtn";
            this.spamSetDrawBtn.Size = new System.Drawing.Size(92, 23);
            this.spamSetDrawBtn.TabIndex = 1;
            this.spamSetDrawBtn.Text = "Spam SetDraw";
            this.spamSetDrawBtn.UseVisualStyleBackColor = true;
            this.spamSetDrawBtn.Click += new System.EventHandler(this.spamSetDrawBtn_Click);
            // 
            // volMaxBtn
            // 
            this.volMaxBtn.Location = new System.Drawing.Point(12, 41);
            this.volMaxBtn.Name = "volMaxBtn";
            this.volMaxBtn.Size = new System.Drawing.Size(140, 23);
            this.volMaxBtn.TabIndex = 2;
            this.volMaxBtn.Text = "Lock volume at max";
            this.volMaxBtn.UseVisualStyleBackColor = true;
            this.volMaxBtn.Click += new System.EventHandler(this.volMaxBtn_Click);
            // 
            // volMinBtn
            // 
            this.volMinBtn.Location = new System.Drawing.Point(12, 70);
            this.volMinBtn.Name = "volMinBtn";
            this.volMinBtn.Size = new System.Drawing.Size(140, 23);
            this.volMinBtn.TabIndex = 3;
            this.volMinBtn.Text = "Lock volume at min";
            this.volMinBtn.UseVisualStyleBackColor = true;
            this.volMinBtn.Click += new System.EventHandler(this.volMinBtn_Click);
            // 
            // spamMuteKeyBtn
            // 
            this.spamMuteKeyBtn.Location = new System.Drawing.Point(158, 41);
            this.spamMuteKeyBtn.Name = "spamMuteKeyBtn";
            this.spamMuteKeyBtn.Size = new System.Drawing.Size(129, 23);
            this.spamMuteKeyBtn.TabIndex = 4;
            this.spamMuteKeyBtn.Text = "Spam mute key";
            this.spamMuteKeyBtn.UseVisualStyleBackColor = true;
            this.spamMuteKeyBtn.Click += new System.EventHandler(this.spamMuteKeyBtn_Click);
            // 
            // spamSleepKeyBtn
            // 
            this.spamSleepKeyBtn.Location = new System.Drawing.Point(191, 12);
            this.spamSleepKeyBtn.Name = "spamSleepKeyBtn";
            this.spamSleepKeyBtn.Size = new System.Drawing.Size(96, 23);
            this.spamSleepKeyBtn.TabIndex = 5;
            this.spamSleepKeyBtn.Text = "Spam Sleep key";
            this.spamSleepKeyBtn.UseVisualStyleBackColor = true;
            this.spamSleepKeyBtn.Click += new System.EventHandler(this.spamSleepKeyBtn_Click);
            // 
            // spamControlKeyBtn
            // 
            this.spamControlKeyBtn.Location = new System.Drawing.Point(158, 70);
            this.spamControlKeyBtn.Name = "spamControlKeyBtn";
            this.spamControlKeyBtn.Size = new System.Drawing.Size(129, 23);
            this.spamControlKeyBtn.TabIndex = 6;
            this.spamControlKeyBtn.Text = "Spam Control key";
            this.spamControlKeyBtn.UseVisualStyleBackColor = true;
            this.spamControlKeyBtn.Click += new System.EventHandler(this.spamControlKeyBtn_Click);
            // 
            // spamEscapeKeyBtn
            // 
            this.spamEscapeKeyBtn.Location = new System.Drawing.Point(293, 70);
            this.spamEscapeKeyBtn.Name = "spamEscapeKeyBtn";
            this.spamEscapeKeyBtn.Size = new System.Drawing.Size(110, 23);
            this.spamEscapeKeyBtn.TabIndex = 7;
            this.spamEscapeKeyBtn.Text = "Spam Escape key";
            this.spamEscapeKeyBtn.UseVisualStyleBackColor = true;
            this.spamEscapeKeyBtn.Click += new System.EventHandler(this.spamEscapeKeyBtn_Click);
            // 
            // spamBackKeyBtn
            // 
            this.spamBackKeyBtn.Location = new System.Drawing.Point(293, 41);
            this.spamBackKeyBtn.Name = "spamBackKeyBtn";
            this.spamBackKeyBtn.Size = new System.Drawing.Size(110, 23);
            this.spamBackKeyBtn.TabIndex = 8;
            this.spamBackKeyBtn.Text = "Spam Back key";
            this.spamBackKeyBtn.UseVisualStyleBackColor = true;
            this.spamBackKeyBtn.Click += new System.EventHandler(this.spamBackKeyBtn_Click);
            // 
            // spamDeleteKeyBtn
            // 
            this.spamDeleteKeyBtn.Location = new System.Drawing.Point(293, 12);
            this.spamDeleteKeyBtn.Name = "spamDeleteKeyBtn";
            this.spamDeleteKeyBtn.Size = new System.Drawing.Size(110, 23);
            this.spamDeleteKeyBtn.TabIndex = 9;
            this.spamDeleteKeyBtn.Text = "Spam Delete key";
            this.spamDeleteKeyBtn.UseVisualStyleBackColor = true;
            this.spamDeleteKeyBtn.Click += new System.EventHandler(this.spamDeleteKeyBtn_Click);
            // 
            // intervalBar
            // 
            this.intervalBar.Location = new System.Drawing.Point(12, 124);
            this.intervalBar.Maximum = 750;
            this.intervalBar.Minimum = 1;
            this.intervalBar.Name = "intervalBar";
            this.intervalBar.Size = new System.Drawing.Size(391, 45);
            this.intervalBar.TabIndex = 10;
            this.intervalBar.Value = 10;
            this.intervalBar.Scroll += new System.EventHandler(this.intervalBar_Scroll);
            // 
            // intervalLbl
            // 
            this.intervalLbl.AutoSize = true;
            this.intervalLbl.Location = new System.Drawing.Point(13, 105);
            this.intervalLbl.Name = "intervalLbl";
            this.intervalLbl.Size = new System.Drawing.Size(100, 13);
            this.intervalLbl.TabIndex = 11;
            this.intervalLbl.Text = "Spamming Interval: ";
            // 
            // killSpammersBtn
            // 
            this.killSpammersBtn.Location = new System.Drawing.Point(293, 99);
            this.killSpammersBtn.Name = "killSpammersBtn";
            this.killSpammersBtn.Size = new System.Drawing.Size(110, 23);
            this.killSpammersBtn.TabIndex = 12;
            this.killSpammersBtn.Text = "Kill spammers";
            this.killSpammersBtn.UseVisualStyleBackColor = true;
            this.killSpammersBtn.Click += new System.EventHandler(this.killSpammersBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 181);
            this.Controls.Add(this.killSpammersBtn);
            this.Controls.Add(this.intervalLbl);
            this.Controls.Add(this.intervalBar);
            this.Controls.Add(this.spamDeleteKeyBtn);
            this.Controls.Add(this.spamBackKeyBtn);
            this.Controls.Add(this.spamEscapeKeyBtn);
            this.Controls.Add(this.spamControlKeyBtn);
            this.Controls.Add(this.spamSleepKeyBtn);
            this.Controls.Add(this.spamMuteKeyBtn);
            this.Controls.Add(this.volMinBtn);
            this.Controls.Add(this.volMaxBtn);
            this.Controls.Add(this.spamSetDrawBtn);
            this.Controls.Add(this.spamAltF4Btn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Spammer";
            ((System.ComponentModel.ISupportInitialize)(this.intervalBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spamAltF4Btn;
        private System.Windows.Forms.Button spamSetDrawBtn;
        private System.Windows.Forms.Button volMaxBtn;
        private System.Windows.Forms.Button volMinBtn;
        private System.Windows.Forms.Button spamMuteKeyBtn;
        private System.Windows.Forms.Button spamSleepKeyBtn;
        private System.Windows.Forms.Button spamControlKeyBtn;
        private System.Windows.Forms.Button spamEscapeKeyBtn;
        private System.Windows.Forms.Button spamBackKeyBtn;
        private System.Windows.Forms.Button spamDeleteKeyBtn;
        private System.Windows.Forms.TrackBar intervalBar;
        private System.Windows.Forms.Label intervalLbl;
        private System.Windows.Forms.Button killSpammersBtn;
    }
}

