using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Ui.Components
{
    public partial class WindowAnimation : Component
    {
        public WindowAnimation()
        {
            InitializeComponent();
        }

        public WindowAnimation(System.Windows.Forms.Form window)
        {
            this.Window = window;
            if (this.Window != null)
            {
                this.Window.Load += new EventHandler(Start);
            }
            timer.Interval = 40;
            timer.Tick += new EventHandler(this.Timer_Tick);
        }

        public WindowAnimation(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public System.Windows.Forms.Form Window { get; set; } = null;

        private void Start(object sender, EventArgs e)
        {
            this.Window.Opacity = 0;
            timer.Start();
        }

        private void Stop()
        {
            this.timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.Window.Opacity<1)
            {
                this.Window.Opacity += 0.10;
            }
            else
            {
                this.Stop();
            }
        }
    }
}
