using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CSDesktopRadio
{
    public class NineSlicePanel : Panel
    {
        [Category("Appearance")]
        public Image SliceImage { get; set; }

        [Category("Layout")]
        public int SliceLeft { get; set; } = 20;

        [Category("Layout")]
        public int SliceTop { get; set; } = 20;

        [Category("Layout")]
        public int SliceRight { get; set; } = 20;

        [Category("Layout")]
        public int SliceBottom { get; set; } = 20;

        public NineSlicePanel()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (SliceImage == null)
                return;

            var g = e.Graphics;
            int imgW = SliceImage.Width;
            int imgH = SliceImage.Height;

            int w = this.Width;
            int h = this.Height;

            Rectangle[] src = new Rectangle[]
            {
            new Rectangle(0, 0, SliceLeft, SliceTop),
            new Rectangle(SliceLeft, 0, imgW - SliceLeft - SliceRight, SliceTop),
            new Rectangle(imgW - SliceRight, 0, SliceRight, SliceTop),
            new Rectangle(0, SliceTop, SliceLeft, imgH - SliceTop - SliceBottom),
            new Rectangle(SliceLeft, SliceTop, imgW - SliceLeft - SliceRight, imgH - SliceTop - SliceBottom),
            new Rectangle(imgW - SliceRight, SliceTop, SliceRight, imgH - SliceTop - SliceBottom),
            new Rectangle(0, imgH - SliceBottom, SliceLeft, SliceBottom),
            new Rectangle(SliceLeft, imgH - SliceBottom, imgW - SliceLeft - SliceRight, SliceBottom),
            new Rectangle(imgW - SliceRight, imgH - SliceBottom, SliceRight, SliceBottom)
            };

            Rectangle[] dst = new Rectangle[]
            {
            new Rectangle(0, 0, SliceLeft, SliceTop),
            new Rectangle(SliceLeft, 0, w - SliceLeft - SliceRight, SliceTop),
            new Rectangle(w - SliceRight, 0, SliceRight, SliceTop),
            new Rectangle(0, SliceTop, SliceLeft, h - SliceTop - SliceBottom),
            new Rectangle(SliceLeft, SliceTop, w - SliceLeft - SliceRight, h - SliceTop - SliceBottom),
            new Rectangle(w - SliceRight, SliceTop, SliceRight, h - SliceTop - SliceBottom),
            new Rectangle(0, h - SliceBottom, SliceLeft, SliceBottom),
            new Rectangle(SliceLeft, h - SliceBottom, w - SliceLeft - SliceRight, SliceBottom),
            new Rectangle(w - SliceRight, h - SliceBottom, SliceRight, SliceBottom)
            };

            for (int i = 0; i < 9; i++)
                g.DrawImage(SliceImage, dst[i], src[i], GraphicsUnit.Pixel);
        }
    }
}
