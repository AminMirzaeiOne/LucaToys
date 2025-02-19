using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Ui.Components
{
    public partial class WindowSound : Component
    {
        public WindowSound()
        {
            InitializeComponent();
            this.CheckNull();
        }

        public WindowSound(System.Windows.Forms.Form window)
        {
            this.Window = window;
            this.CheckNull();
        }

        public WindowSound(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            this.CheckNull();
        }

        private System.Windows.Forms.Form window = new System.Windows.Forms.Form();

        public System.Windows.Forms.Form Window
        {
            get { return this.window; }
            set
            {
                this.window = value;
                this.CheckNull();
            }
        }

        public bool Enable { get; set; }

        private void Start(object sender, EventArgs e)
        {
            if (this.Enable)
            {
                using (SoundPlayer sound = new SoundPlayer())
                {
                    sound.Stream = Properties.Resources.SplashSound;
                    sound.Play();
                }
            }
           
        }

        private void CheckNull()
        {
            if (this.Window != null)
            {
                this.Window.Load += new EventHandler(Start);
            }
        }
    }
}
