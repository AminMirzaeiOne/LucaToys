﻿namespace Accounting.Ui.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.SuspendLayout();
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(498, 597);
            this.EscClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconImageSize = 20;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(2, 40, 2, 2);
            this.Resizable = true;
            this.ShowDragStretch = true;
            this.StartupSound = Accounting.Ui.Controls.SunnyFormPlus.StartupSounds.LoginSound;
            this.Text = "ورود";
            this.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.TitleHeight = 40;
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 1175, 600);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIStyleManager uiStyleManager1;
    }
}