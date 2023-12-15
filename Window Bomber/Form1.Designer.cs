namespace Window_Bomber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.transparentLabel1 = new DarkControls.Controls.TransparentLabel();
            this.closeBtn = new DarkControls.Controls.WindowsDefaultTitleBarButton();
            this.appIcon1 = new DarkControls.Controls.AppIcon();
            this.nedryBombBtn = new DarkControls.Controls.DarkButton();
            this.modemBombBtn = new DarkControls.Controls.DarkButton();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon1)).BeginInit();
            this.SuspendLayout();
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.AutoSize = true;
            this.transparentLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel1.Location = new System.Drawing.Point(32, 4);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(125, 20);
            this.transparentLabel1.TabIndex = 8;
            this.transparentLabel1.Text = "Window Bomber";
            // 
            // closeBtn
            // 
            this.closeBtn.ButtonType = DarkControls.Controls.WindowsDefaultTitleBarButton.Type.Close;
            this.closeBtn.ClickColor = System.Drawing.Color.Red;
            this.closeBtn.ClickIconColor = System.Drawing.Color.Black;
            this.closeBtn.HoverColor = System.Drawing.Color.OrangeRed;
            this.closeBtn.HoverIconColor = System.Drawing.Color.Black;
            this.closeBtn.IconColor = System.Drawing.Color.Black;
            this.closeBtn.IconLineThickness = 2;
            this.closeBtn.Location = new System.Drawing.Point(193, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 40);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "windowsDefaultTitleBarButton1";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // appIcon1
            // 
            this.appIcon1.AppIconImage = ((System.Drawing.Image)(resources.GetObject("appIcon1.AppIconImage")));
            this.appIcon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.appIcon1.DragForm = null;
            this.appIcon1.Image = ((System.Drawing.Image)(resources.GetObject("appIcon1.Image")));
            this.appIcon1.Location = new System.Drawing.Point(0, 1);
            this.appIcon1.Name = "appIcon1";
            this.appIcon1.Scale = 3.5F;
            this.appIcon1.Size = new System.Drawing.Size(28, 28);
            this.appIcon1.TabIndex = 9;
            this.appIcon1.TabStop = false;
            // 
            // nedryBombBtn
            // 
            this.nedryBombBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.nedryBombBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nedryBombBtn.ForeColor = System.Drawing.Color.Silver;
            this.nedryBombBtn.Location = new System.Drawing.Point(12, 79);
            this.nedryBombBtn.Name = "nedryBombBtn";
            this.nedryBombBtn.Size = new System.Drawing.Size(75, 23);
            this.nedryBombBtn.TabIndex = 10;
            this.nedryBombBtn.Text = "Nedry Bomb";
            this.nedryBombBtn.UseVisualStyleBackColor = true;
            this.nedryBombBtn.Click += new System.EventHandler(this.nedryBombBtn_Click);
            // 
            // modemBombBtn
            // 
            this.modemBombBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.modemBombBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modemBombBtn.ForeColor = System.Drawing.Color.Silver;
            this.modemBombBtn.Location = new System.Drawing.Point(136, 79);
            this.modemBombBtn.Name = "modemBombBtn";
            this.modemBombBtn.Size = new System.Drawing.Size(87, 23);
            this.modemBombBtn.TabIndex = 11;
            this.modemBombBtn.Text = "Modem Bomb";
            this.modemBombBtn.UseVisualStyleBackColor = true;
            this.modemBombBtn.Click += new System.EventHandler(this.modemBombBtn_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(235, 114);
            this.Controls.Add(this.modemBombBtn);
            this.Controls.Add(this.nedryBombBtn);
            this.Controls.Add(this.appIcon1);
            this.Controls.Add(this.transparentLabel1);
            this.Controls.Add(this.closeBtn);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Basic File Box";
            ((System.ComponentModel.ISupportInitialize)(this.appIcon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkControls.Controls.WindowsDefaultTitleBarButton closeBtn;
        private DarkControls.Controls.TransparentLabel transparentLabel1;
        private DarkControls.Controls.AppIcon appIcon1;
        private DarkControls.Controls.DarkButton nedryBombBtn;
        private DarkControls.Controls.DarkButton modemBombBtn;
    }
}

