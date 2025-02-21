using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace Accounting.Ui.Forms
{
    public partial class Login : Ui.Controls.SunnyFormPlus
    {
        public Login()
        {
            InitializeComponent();
            this.uiStyleManager1.Style = Sunny.UI.UIStyle.Red;
            this.uiComboBox1.BackColor = Color.FromArgb(20, 20, 20);
        }


    }
}
