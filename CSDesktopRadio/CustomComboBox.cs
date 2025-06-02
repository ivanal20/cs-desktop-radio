using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CSDesktopRadio
{
    public class RoundedComboBox : ComboBox
    {
        public Color BorderColor { get; set; } = Color.Gray;
        public int BorderRadius { get; set; } = 8;
        public Color BackgroundColor { get; set; } = Color.White;
        public Color ArrowColor { get; set; } = Color.Gray;

        public RoundedComboBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = BackgroundColor;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.DoubleBuffered = true;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            using (SolidBrush textBrush = new SolidBrush(ForeColor))
            {
                e.Graphics.DrawString(Items[e.Index].ToString(), Font, textBrush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            // Рисуем фон и границу
            using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
            using (SolidBrush brush = new SolidBrush(BackgroundColor))
            using (Pen pen = new Pen(BorderColor, 1))
            {
                g.FillPath(brush, path);
                g.DrawPath(pen, path);
            }

            // Рисуем стрелку
            DrawArrow(g);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void DrawArrow(Graphics g)
        {
            int arrowSize = 6;
            Point middle = new Point(Width - 18, Height / 2);

            Point[] arrowPoints = new Point[]
            {
            new Point(middle.X - arrowSize, middle.Y - arrowSize / 2),
            new Point(middle.X + arrowSize, middle.Y - arrowSize / 2),
            new Point(middle.X, middle.Y + arrowSize / 2)
            };

            using (SolidBrush brush = new SolidBrush(ArrowColor))
            {
                g.FillPolygon(brush, arrowPoints);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate(); // Перерисовать при изменении размера
        }
    }
}
