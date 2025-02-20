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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.roundLabel4.Right < this.roundLabel3.Right)
            {
                this.roundLabel4.Width += 5;
            }
            else
            {
                this.timer1.Stop();
                this.Cursor = Cursors.Arrow;
            }
        }
    }
}
