using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.Ui.Bases
{
    internal interface IRoundControl
    {
        System.Byte BorderRadius { get; set; }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius);

        void OnPaint(PaintEventArgs e);
    }
}
