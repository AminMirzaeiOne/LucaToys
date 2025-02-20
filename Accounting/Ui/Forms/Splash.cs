using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.Ui.Forms
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.uiContextMenuStrip1.Style = Sunny.UI.UIStyle.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.uiProcessBar1.Value < 100)
            {
                this.uiProcessBar1.Value += 1;
            }
            else
            {
                this.timer1.Stop();
                this.Cursor = Cursors.Arrow;
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void خروجازبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void شروعمجددبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        private void دربارهبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
