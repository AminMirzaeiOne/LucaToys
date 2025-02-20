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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundLabel2 = new Accounting.Ui.Controls.RoundLabel();
            this.roundLabel1 = new Accounting.Ui.Controls.RoundLabel();
            this.windowAnimation1 = new Accounting.Ui.Components.WindowAnimation(this.components);
            this.windowSound1 = new Accounting.Ui.Components.WindowSound(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Accounting.Properties.Resources.LucaLogoSplash;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(757, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(707, 278);
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
            this.label2.Location = new System.Drawing.Point(754, 340);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(207, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "فروشگاه Luca Toys";
            // 
            // roundLabel2
            // 
            this.roundLabel2.BackColor = System.Drawing.Color.IndianRed;
            this.roundLabel2.BorderRadius = ((byte)(20));
            this.roundLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel2.ForeColor = System.Drawing.Color.White;
            this.roundLabel2.Image = global::Accounting.Properties.Resources.icons8_programmer_32;
            this.roundLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundLabel2.Location = new System.Drawing.Point(775, 407);
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
            this.roundLabel1.Location = new System.Drawing.Point(581, 407);
            this.roundLabel1.Name = "roundLabel1";
            this.roundLabel1.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.roundLabel1.Size = new System.Drawing.Size(182, 75);
            this.roundLabel1.TabIndex = 2;
            this.roundLabel1.Text = "نسخه : 1.0.0";
            this.roundLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windowAnimation1
            // 
            this.windowAnimation1.Enable = true;
            this.windowAnimation1.Window = this;
            // 
            // windowSound1
            // 
            this.windowSound1.Enable = false;
            this.windowSound1.Window = this;
            // 
            // Splash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::Accounting.Properties.Resources.SplashImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 620);
            this.Controls.Add(this.roundLabel2);
            this.Controls.Add(this.roundLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.WindowAnimation windowAnimation1;
        private Components.WindowSound windowSound1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controls.RoundLabel roundLabel1;
        private Controls.RoundLabel roundLabel2;
    }
}