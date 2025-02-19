using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Accounting.Ui.Components
{
    public partial class WindowAnimation : Component
    {
        public WindowAnimation()
        {
            InitializeComponent();
            this.CheckNull();
        }

        public WindowAnimation(System.Windows.Forms.Form window)
        {
            this.Window = window;
            this.CheckNull();
        }

        public WindowAnimation(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            this.CheckNull();
        }

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
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

        public bool Enable { get; set; } = true;

        private void Start(object sender, EventArgs e)
        {
            if (this.Enable)
            {
                this.Window.Opacity = 0;
                timer.Start();
            }
                
        }

        private void Stop()
        {
            this.timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.Window.Opacity < 1)
            {
                this.Window.Opacity += 0.10;
            }
            else
            {
                this.Stop();
            }
        }

        private void CheckNull()
        {
            if (this.Window != null)
            {
                this.Window.Load += new EventHandler(Start);
            }
            timer.Interval = 60;
            timer.Tick += new EventHandler(this.Timer_Tick);
        }
    }
}
