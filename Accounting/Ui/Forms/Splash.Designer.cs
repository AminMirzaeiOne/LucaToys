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
            this.roundLabel2 = new Accounting.Ui.Controls.RoundLabel();
            this.roundLabel1 = new Accounting.Ui.Controls.RoundLabel();
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
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
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
            this.uiProcessBar1.Location = new System.Drawing.Point(698, 604);
            this.uiProcessBar1.MinimumSize = new System.Drawing.Size(3, 3);
            this.uiProcessBar1.Name = "uiProcessBar1";
            this.uiProcessBar1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiProcessBar1.ShowValue = false;
            this.uiProcessBar1.Size = new System.Drawing.Size(353, 20);
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
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(265, 187);
            // 
            // خروجازبرنامهToolStripMenuItem
            // 
            this.خروجازبرنامهToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_exit_40;
            this.خروجازبرنامهToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.خروجازبرنامهToolStripMenuItem.Name = "خروجازبرنامهToolStripMenuItem";
            this.خروجازبرنامهToolStripMenuItem.Size = new System.Drawing.Size(264, 48);
            this.خروجازبرنامهToolStripMenuItem.Text = "خروج از برنامه";
            this.خروجازبرنامهToolStripMenuItem.Click += new System.EventHandler(this.خروجازبرنامهToolStripMenuItem_Click);
            // 
            // شروعمجددبرنامهToolStripMenuItem
            // 
            this.شروعمجددبرنامهToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_restart_40;
            this.شروعمجددبرنامهToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.شروعمجددبرنامهToolStripMenuItem.Name = "شروعمجددبرنامهToolStripMenuItem";
            this.شروعمجددبرنامهToolStripMenuItem.Size = new System.Drawing.Size(264, 48);
            this.شروعمجددبرنامهToolStripMenuItem.Text = "شروع مجدد برنامه";
            this.شروعمجددبرنامهToolStripMenuItem.Click += new System.EventHandler(this.شروعمجددبرنامهToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
            // 
            // دربارهبرنامهToolStripMenuItem
            // 
            this.دربارهبرنامهToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_about_40;
            this.دربارهبرنامهToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.دربارهبرنامهToolStripMenuItem.Name = "دربارهبرنامهToolStripMenuItem";
            this.دربارهبرنامهToolStripMenuItem.Size = new System.Drawing.Size(264, 48);
            this.دربارهبرنامهToolStripMenuItem.Text = "درباره برنامه";
            this.دربارهبرنامهToolStripMenuItem.Click += new System.EventHandler(this.دربارهبرنامهToolStripMenuItem_Click);
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.roundPictureBox1.BackgroundImage = global::Accounting.Properties.Resources.LucaLogoMain2;
            this.roundPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundPictureBox1.BorderRadius = ((byte)(210));
            this.roundPictureBox1.Location = new System.Drawing.Point(758, 33);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(210, 210);
            this.roundPictureBox1.TabIndex = 3;
            this.roundPictureBox1.TabStop = false;
            // 
            // roundLabel2
            // 
            this.roundLabel2.BackColor = System.Drawing.Color.IndianRed;
            this.roundLabel2.BorderRadius = ((byte)(20));
            this.roundLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel2.ForeColor = System.Drawing.Color.White;
            this.roundLabel2.Image = global::Accounting.Properties.Resources.icons8_programmer_32;
            this.roundLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundLabel2.Location = new System.Drawing.Point(732, 475);
            this.roundLabel2.Name = "roundLabel2";
            this.roundLabel2.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.roundLabel2.Size = new System.Drawing.Size(261, 75);
            this.roundLabel2.TabIndex = 2;
            this.roundLabel2.Text = "سازنده : امین میرازیی";
            this.roundLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundLabel1
            // 
            this.roundLabel1.BackColor = System.Drawing.Color.IndianRed;
            this.roundLabel1.BorderRadius = ((byte)(20));
            this.roundLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel1.ForeColor = System.Drawing.Color.White;
            this.roundLabel1.Image = global::Accounting.Properties.Resources.icons8_version_32;
            this.roundLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundLabel1.Location = new System.Drawing.Point(773, 384);
            this.roundLabel1.Name = "roundLabel1";
            this.roundLabel1.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.roundLabel1.Size = new System.Drawing.Size(182, 75);
            this.roundLabel1.TabIndex = 2;
            this.roundLabel1.Text = "نسخه : 1.0.0";
            this.roundLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Splash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::Accounting.Properties.Resources.SplashImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 620);
            this.ContextMenuStrip = this.uiContextMenuStrip1;
            this.Controls.Add(this.uiProcessBar1);
            this.Controls.Add(this.roundPictureBox1);
            this.Controls.Add(this.roundLabel2);
            this.Controls.Add(this.roundLabel1);
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
        private Controls.RoundLabel roundLabel1;
        private Controls.RoundLabel roundLabel2;
        private System.Windows.Forms.Timer timer1;
        private Controls.RoundPictureBox roundPictureBox1;
        private Sunny.UI.UIProcessBar uiProcessBar1;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem خروجازبرنامهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem شروعمجددبرنامهToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem دربارهبرنامهToolStripMenuItem;
    }
}