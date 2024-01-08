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
            this.monitorOffBtn = new System.Windows.Forms.Button();
            this.moveAllWindowsBtn = new System.Windows.Forms.Button();
            this.bombBtn = new System.Windows.Forms.Button();
            this.monitorSpamBtn = new System.Windows.Forms.Button();
            this.freezeAllWindowsBtn = new System.Windows.Forms.Button();
            this.modemBombBtn = new System.Windows.Forms.Button();
            this.bsodCrashBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.intervalBar)).BeginInit();
            this.SuspendLayout();
            // 
            // spamAltF4Btn
            // 
            this.spamAltF4Btn.Location = new System.Drawing.Point(16, 15);
            this.spamAltF4Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spamAltF4Btn.Name = "spamAltF4Btn";
            this.spamAltF4Btn.Size = new System.Drawing.Size(100, 28);
            this.spamAltF4Btn.TabIndex = 0;
            this.spamAltF4Btn.Text = "Spam Alt+F4";
            this.spamAltF4Btn.UseVisualStyleBackColor = true;
            this.spamAltF4Btn.Click += new System.EventHandler(this.spamAltF4Btn_Click);
            // 
            // spamSetDrawBtn
            // 
            this.spamSetDrawBtn.Location = new System.Drawing.Point(124, 15);
            this.spamSetDrawBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spamSetDrawBtn.Name = "spamSetDrawBtn";
            this.spamSetDrawBtn.Size = new System.Drawing.Size(123, 28);
            this.spamSetDrawBtn.TabIndex = 1;
            this.spamSetDrawBtn.Text = "Spam SetDraw";
            this.spamSetDrawBtn.UseVisualStyleBackColor = true;
            this.spamSetDrawBtn.Click += new System.EventHandler(this.spamSetDrawBtn_Click);
            // 
            // volMaxBtn
            // 
            this.volMaxBtn.Location = new System.Drawing.Point(16, 50);
            this.volMaxBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.volMaxBtn.Name = "volMaxBtn";
            this.volMaxBtn.Size = new System.Drawing.Size(187, 28);
            this.volMaxBtn.TabIndex = 2;
            this.volMaxBtn.Text = "Lock volume at max";
            this.volMaxBtn.UseVisualStyleBackColor = true;
            this.volMaxBtn.Click += new System.EventHandler(this.volMaxBtn_Click);
            // 
            // volMinBtn
            // 
            this.volMinBtn.Location = new System.Drawing.Point(16, 86);
            this.volMinBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.volMinBtn.Name = "volMinBtn";
            this.volMinBtn.Size = new System.Drawing.Size(187, 28);
            this.volMinBtn.TabIndex = 3;
            this.volMinBtn.Text = "Lock volume at min";
            this.volMinBtn.UseVisualStyleBackColor = true;
            this.volMinBtn.Click += new System.EventHandler(this.volMinBtn_Click);
            // 
            // spamMuteKeyBtn
            // 
            this.spamMuteKeyBtn.Location = new System.Drawing.Point(211, 50);
            this.spamMuteKeyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spamMuteKeyBtn.Name = "spamMuteKeyBtn";
            this.spamMuteKeyBtn.Size = new System.Drawing.Size(172, 28);
            this.spamMuteKeyBtn.TabIndex = 4;
            this.spamMuteKeyBtn.Text = "Spam mute key";
            this.spamMuteKeyBtn.UseVisualStyleBackColor = true;
            this.spamMuteKeyBtn.Click += new System.EventHandler(this.spamMuteKeyBtn_Click);
            // 
            // spamSleepKeyBtn
            // 
            this.spamSleepKeyBtn.Location = new System.Drawing.Point(255, 15);
            this.spamSleepKeyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spamSleepKeyBtn.Name = "spamSleepKeyBtn";
            this.spamSleepKeyBtn.Size = new System.Drawing.Size(128, 28);
            this.spamSleepKeyBtn.TabIndex = 5;
            this.spamSleepKeyBtn.Text = "Spam Sleep key";
            this.spamSleepKeyBtn.UseVisualStyleBackColor = true;
            this.spamSleepKeyBtn.Click += new System.EventHandler(this.spamSleepKeyBtn_Click);
            // 
            // spamControlKeyBtn
            // 
            this.spamControlKeyBtn.Location = new System.Drawing.Point(211, 86);
            this.spamControlKeyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spamControlKeyBtn.Name = "spamControlKeyBtn";
            this.spamControlKeyBtn.Size = new System.Drawing.Size(172, 28);
            this.spamControlKeyBtn.TabIndex = 6;
            this.spamControlKeyBtn.Text = "Spam Control key";
            this.spamControlKeyBtn.UseVisualStyleBackColor = true;
            this.spamControlKeyBtn.Click += new System.EventHandler(this.spamControlKeyBtn_Click);
            // 
            // spamEscapeKeyBtn
            // 
            this.spamEscapeKeyBtn.Location = new System.Drawing.Point(391, 86);
            this.spamEscapeKeyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spamEscapeKeyBtn.Name = "spamEscapeKeyBtn";
            this.spamEscapeKeyBtn.Size = new System.Drawing.Size(147, 28);
            this.spamEscapeKeyBtn.TabIndex = 7;
            this.spamEscapeKeyBtn.Text = "Spam Escape key";
            this.spamEscapeKeyBtn.UseVisualStyleBackColor = true;
            this.spamEscapeKeyBtn.Click += new System.EventHandler(this.spamEscapeKeyBtn_Click);
            // 
            // spamBackKeyBtn
            // 
            this.spamBackKeyBtn.Location = new System.Drawing.Point(391, 50);
            this.spamBackKeyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spamBackKeyBtn.Name = "spamBackKeyBtn";
            this.spamBackKeyBtn.Size = new System.Drawing.Size(147, 28);
            this.spamBackKeyBtn.TabIndex = 8;
            this.spamBackKeyBtn.Text = "Spam Back key";
            this.spamBackKeyBtn.UseVisualStyleBackColor = true;
            this.spamBackKeyBtn.Click += new System.EventHandler(this.spamBackKeyBtn_Click);
            // 
            // spamDeleteKeyBtn
            // 
            this.spamDeleteKeyBtn.Location = new System.Drawing.Point(391, 15);
            this.spamDeleteKeyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spamDeleteKeyBtn.Name = "spamDeleteKeyBtn";
            this.spamDeleteKeyBtn.Size = new System.Drawing.Size(147, 28);
            this.spamDeleteKeyBtn.TabIndex = 9;
            this.spamDeleteKeyBtn.Text = "Spam Delete key";
            this.spamDeleteKeyBtn.UseVisualStyleBackColor = true;
            this.spamDeleteKeyBtn.Click += new System.EventHandler(this.spamDeleteKeyBtn_Click);
            // 
            // intervalBar
            // 
            this.intervalBar.Location = new System.Drawing.Point(16, 310);
            this.intervalBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.intervalBar.Maximum = 750;
            this.intervalBar.Name = "intervalBar";
            this.intervalBar.Size = new System.Drawing.Size(521, 56);
            this.intervalBar.TabIndex = 10;
            this.intervalBar.Value = 10;
            this.intervalBar.Scroll += new System.EventHandler(this.intervalBar_Scroll);
            // 
            // intervalLbl
            // 
            this.intervalLbl.AutoSize = true;
            this.intervalLbl.Location = new System.Drawing.Point(17, 287);
            this.intervalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.intervalLbl.Name = "intervalLbl";
            this.intervalLbl.Size = new System.Drawing.Size(124, 16);
            this.intervalLbl.TabIndex = 11;
            this.intervalLbl.Text = "Spamming Interval: ";
            // 
            // killSpammersBtn
            // 
            this.killSpammersBtn.Location = new System.Drawing.Point(391, 122);
            this.killSpammersBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.killSpammersBtn.Name = "killSpammersBtn";
            this.killSpammersBtn.Size = new System.Drawing.Size(147, 28);
            this.killSpammersBtn.TabIndex = 12;
            this.killSpammersBtn.Text = "Kill spammers";
            this.killSpammersBtn.UseVisualStyleBackColor = true;
            this.killSpammersBtn.Click += new System.EventHandler(this.killSpammersBtn_Click);
            // 
            // monitorOffBtn
            // 
            this.monitorOffBtn.Location = new System.Drawing.Point(211, 123);
            this.monitorOffBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monitorOffBtn.Name = "monitorOffBtn";
            this.monitorOffBtn.Size = new System.Drawing.Size(172, 28);
            this.monitorOffBtn.TabIndex = 13;
            this.monitorOffBtn.Text = "Turn monitor off";
            this.monitorOffBtn.UseVisualStyleBackColor = true;
            this.monitorOffBtn.Click += new System.EventHandler(this.monitorOffBtn_Click);
            // 
            // moveAllWindowsBtn
            // 
            this.moveAllWindowsBtn.Location = new System.Drawing.Point(15, 122);
            this.moveAllWindowsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moveAllWindowsBtn.Name = "moveAllWindowsBtn";
            this.moveAllWindowsBtn.Size = new System.Drawing.Size(183, 28);
            this.moveAllWindowsBtn.TabIndex = 14;
            this.moveAllWindowsBtn.Text = "Move all windows";
            this.moveAllWindowsBtn.UseVisualStyleBackColor = true;
            this.moveAllWindowsBtn.Click += new System.EventHandler(this.moveAllWindowsBtn_Click);
            // 
            // bombBtn
            // 
            this.bombBtn.Location = new System.Drawing.Point(211, 160);
            this.bombBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bombBtn.Name = "bombBtn";
            this.bombBtn.Size = new System.Drawing.Size(144, 28);
            this.bombBtn.TabIndex = 15;
            this.bombBtn.Text = "Nedry\'s Bomb";
            this.bombBtn.UseVisualStyleBackColor = true;
            this.bombBtn.Click += new System.EventHandler(this.bombBtn_Click);
            // 
            // monitorSpamBtn
            // 
            this.monitorSpamBtn.Location = new System.Drawing.Point(363, 160);
            this.monitorSpamBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monitorSpamBtn.Name = "monitorSpamBtn";
            this.monitorSpamBtn.Size = new System.Drawing.Size(172, 28);
            this.monitorSpamBtn.TabIndex = 16;
            this.monitorSpamBtn.Text = "Spam monitor off";
            this.monitorSpamBtn.UseVisualStyleBackColor = true;
            this.monitorSpamBtn.Click += new System.EventHandler(this.monitorSpamBtn_Click);
            // 
            // freezeAllWindowsBtn
            // 
            this.freezeAllWindowsBtn.Location = new System.Drawing.Point(20, 159);
            this.freezeAllWindowsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.freezeAllWindowsBtn.Name = "freezeAllWindowsBtn";
            this.freezeAllWindowsBtn.Size = new System.Drawing.Size(177, 28);
            this.freezeAllWindowsBtn.TabIndex = 17;
            this.freezeAllWindowsBtn.Text = "Decimate all Windows";
            this.freezeAllWindowsBtn.UseVisualStyleBackColor = true;
            this.freezeAllWindowsBtn.Click += new System.EventHandler(this.freezeAllWindowsBtn_Click);
            // 
            // modemBombBtn
            // 
            this.modemBombBtn.Location = new System.Drawing.Point(211, 196);
            this.modemBombBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modemBombBtn.Name = "modemBombBtn";
            this.modemBombBtn.Size = new System.Drawing.Size(144, 28);
            this.modemBombBtn.TabIndex = 18;
            this.modemBombBtn.Text = "Modem Bomb";
            this.modemBombBtn.UseVisualStyleBackColor = true;
            this.modemBombBtn.Click += new System.EventHandler(this.modemBombBtn_Click);
            // 
            // bsodCrashBtn
            // 
            this.bsodCrashBtn.Location = new System.Drawing.Point(363, 196);
            this.bsodCrashBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bsodCrashBtn.Name = "bsodCrashBtn";
            this.bsodCrashBtn.Size = new System.Drawing.Size(144, 28);
            this.bsodCrashBtn.TabIndex = 19;
            this.bsodCrashBtn.Text = "BSOD Crash";
            this.bsodCrashBtn.UseVisualStyleBackColor = true;
            this.bsodCrashBtn.Click += new System.EventHandler(this.bsodCrashBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Spam Brightness Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 28);
            this.button2.TabIndex = 21;
            this.button2.Text = "Spam Brightness Down";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 388);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bsodCrashBtn);
            this.Controls.Add(this.modemBombBtn);
            this.Controls.Add(this.freezeAllWindowsBtn);
            this.Controls.Add(this.monitorSpamBtn);
            this.Controls.Add(this.bombBtn);
            this.Controls.Add(this.moveAllWindowsBtn);
            this.Controls.Add(this.monitorOffBtn);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button monitorOffBtn;
        private System.Windows.Forms.Button moveAllWindowsBtn;
        private System.Windows.Forms.Button bombBtn;
        private System.Windows.Forms.Button monitorSpamBtn;
        private System.Windows.Forms.Button freezeAllWindowsBtn;
        private System.Windows.Forms.Button modemBombBtn;
        private System.Windows.Forms.Button bsodCrashBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

