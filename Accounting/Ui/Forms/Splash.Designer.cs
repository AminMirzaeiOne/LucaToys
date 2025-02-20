namespace Accounting.Ui.Forms
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiProcessBar1 = new Sunny.UI.UIProcessBar();
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.خروجازبرنامهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.شروعمجددبرنامهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.دربارهبرنامهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundPictureBox1 = new Accounting.Ui.Controls.RoundPictureBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiToolTip1 = new Sunny.UI.UIToolTip(this.components);
            this.uiContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(711, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "نرم افزار حسابداری و انبارداری";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(758, 320);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(207, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "فروشگاه Luca Toys";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uiProcessBar1
            // 
            this.uiProcessBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.uiProcessBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiProcessBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiProcessBar1.Location = new System.Drawing.Point(-1, 611);
            this.uiProcessBar1.MinimumSize = new System.Drawing.Size(3, 3);
            this.uiProcessBar1.Name = "uiProcessBar1";
            this.uiProcessBar1.Radius = 1;
            this.uiProcessBar1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiProcessBar1.RectSize = 2;
            this.uiProcessBar1.ShowValue = false;
            this.uiProcessBar1.Size = new System.Drawing.Size(1052, 23);
            this.uiProcessBar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiProcessBar1.TabIndex = 4;
            this.uiProcessBar1.Text = "uiProcessBar1";
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uiContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.خروجازبرنامهToolStripMenuItem,
            this.شروعمجددبرنامهToolStripMenuItem,
            this.toolStripSeparator1,
            this.دربارهبرنامهToolStripMenuItem});
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(253, 154);
            // 
            // خروجازبرنامهToolStripMenuItem
            // 
            this.خروجازبرنامهToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_exit_40;
            this.خروجازبرنامهToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.خروجازبرنامهToolStripMenuItem.Name = "خروجازبرنامهToolStripMenuItem";
            this.خروجازبرنامهToolStripMenuItem.Size = new System.Drawing.Size(252, 48);
            this.خروجازبرنامهToolStripMenuItem.Text = "خروج از برنامه";
            this.خروجازبرنامهToolStripMenuItem.Click += new System.EventHandler(this.خروجازبرنامهToolStripMenuItem_Click);
            // 
            // شروعمجددبرنامهToolStripMenuItem
            // 
            this.شروعمجددبرنامهToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_restart_40;
            this.شروعمجددبرنامهToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.شروعمجددبرنامهToolStripMenuItem.Name = "شروعمجددبرنامهToolStripMenuItem";
            this.شروعمجددبرنامهToolStripMenuItem.Size = new System.Drawing.Size(252, 48);
            this.شروعمجددبرنامهToolStripMenuItem.Text = "شروع مجدد برنامه";
            this.شروعمجددبرنامهToolStripMenuItem.Click += new System.EventHandler(this.شروعمجددبرنامهToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // دربارهبرنامهToolStripMenuItem
            // 
            this.دربارهبرنامهToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_about_40;
            this.دربارهبرنامهToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.دربارهبرنامهToolStripMenuItem.Name = "دربارهبرنامهToolStripMenuItem";
            this.دربارهبرنامهToolStripMenuItem.Size = new System.Drawing.Size(252, 48);
            this.دربارهبرنامهToolStripMenuItem.Text = "درباره برنامه";
            this.دربارهبرنامهToolStripMenuItem.Click += new System.EventHandler(this.دربارهبرنامهToolStripMenuItem_Click);
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.roundPictureBox1.BackgroundImage = global::Accounting.Properties.Resources.LucaLogoMain2;
            this.roundPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundPictureBox1.BorderRadius = ((byte)(210));
            this.roundPictureBox1.Location = new System.Drawing.Point(758, 33);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(210, 210);
            this.roundPictureBox1.TabIndex = 3;
            this.roundPictureBox1.TabStop = false;
            // 
            // uiButton1
            // 
            this.uiButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.uiButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton1.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.uiButton1.Location = new System.Drawing.Point(853, 391);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 15;
            this.uiButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.uiButton1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiButton1.Size = new System.Drawing.Size(156, 78);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 5;
            this.uiButton1.Text = "1.0.0";
            this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiToolTip1.SetToolTip(this.uiButton1, "برای کپی نسخه کلیک کنید");
            // 
            // uiToolTip1
            // 
            this.uiToolTip1.BackColor = System.Drawing.Color.White;
            this.uiToolTip1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.uiToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiToolTip1.OwnerDraw = true;
            this.uiToolTip1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Splash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::Accounting.Properties.Resources.SplashImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 620);
            this.ContextMenuStrip = this.uiContextMenuStrip1;
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiProcessBar1);
            this.Controls.Add(this.roundPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.uiContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Controls.RoundPictureBox roundPictureBox1;
        private Sunny.UI.UIProcessBar uiProcessBar1;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem خروجازبرنامهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem شروعمجددبرنامهToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem دربارهبرنامهToolStripMenuItem;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIToolTip uiToolTip1;
    }
}