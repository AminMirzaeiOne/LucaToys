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
            this.windowAnimation1 = new Accounting.Ui.Components.WindowAnimation(this.components);
            this.windowSound1 = new Accounting.Ui.Components.WindowSound(this.components);
            this.SuspendLayout();
            // 
            // windowAnimation1
            // 
            this.windowAnimation1.Window = this;
            // 
            // windowSound1
            // 
            this.windowSound1.Window = this;
            // 
            // Splash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::Accounting.Properties.Resources.SplashImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.WindowAnimation windowAnimation1;
        private Components.WindowSound windowSound1;
    }
}