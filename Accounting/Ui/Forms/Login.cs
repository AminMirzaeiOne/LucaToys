﻿using System;
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
    public partial class Login : Ui.Controls.SunnyFormPlus
    {
        public Login()
        {
            InitializeComponent();
            this.uiStyleManager1.Style = Sunny.UI.UIStyle.Purple;
        }
    }
}
