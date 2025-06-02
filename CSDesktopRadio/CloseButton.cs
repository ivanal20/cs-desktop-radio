using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CSDesktop
{
    public class CustomButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle bounds = this.ClientRectangle;
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 4;

                // Левый верхний угол
                path.AddLine(bounds.Left, bounds.Top, bounds.Right - radius, bounds.Top);
                path.AddArc(bounds.Right - 2 * radius, bounds.Top, 2 * radius, 2 * radius, 270, 90);

                // Правый нижний угол
                path.AddLine(bounds.Right, bounds.Top + radius, bounds.Right, bounds.Bottom);

                // Левый нижний угол
                path.AddLine(bounds.Right, bounds.Bottom, bounds.Left, bounds.Bottom);
                path.AddLine(bounds.Left, bounds.Bottom, bounds.Left, bounds.Top);

                this.Region = new Region(path);
            }
        }
    }
}
