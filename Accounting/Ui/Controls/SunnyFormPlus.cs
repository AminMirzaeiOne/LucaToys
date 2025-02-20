using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.Ui.Controls
{
    public class SunnyFormPlus : Sunny.UI.UIForm
    {
        public SunnyFormPlus()
        {
            this.timerShow.Tick += new EventHandler(this.TimerShow_Tick);
            this.timerShow.Interval = 30;
            this.timerClose.Tick += new EventHandler(this.TimerClose_Tick);
            this.timerClose.Interval = 30;
        }

        public enum StartupSounds { None, SplashSound, LoginSound }

        private StartupSounds startupSounds = StartupSounds.None;
        private SoundPlayer player = new SoundPlayer();
        private System.Windows.Forms.Timer timerShow = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer timerClose = new System.Windows.Forms.Timer();
        private bool closeCancel = true;
        public System.Boolean Animation { get; set; } = true;


        public StartupSounds StartupSound
        {
            get { return this.startupSounds; }
            set
            {
                this.startupSounds = value;
                switch (value)
                {
                    case StartupSounds.SplashSound:
                        this.player.Stream = Properties.Resources.SplashSound;
                        break;
                    case StartupSounds.LoginSound:
                        this.player.Stream = Properties.Resources.LoginSound;
                        break;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.StartupSound != StartupSounds.None)
            {
                this.player.Play();
            }

            if (this.Animation)
            {
                this.Opacity = 0;
                this.timerShow.Start();
            }
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = closeCancel;
            if (this.Animation && this.closeCancel)
            {
                this.Opacity = 1;
                this.timerClose.Start();
                e.Cancel = this.closeCancel;
                
            }
        }

        private void TimerShow_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.10;
            }
            else
            {
                this.timerShow.Stop();
                this.Opacity = 1;
            }
        }

        private void TimerClose_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.10;
            }
            else
            {
                this.timerClose.Stop();
                this.closeCancel = false;
                this.Close();
            }
        }


    }
}
