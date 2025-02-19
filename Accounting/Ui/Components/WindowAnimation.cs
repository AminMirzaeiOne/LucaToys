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

        public WindowAnimation(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
