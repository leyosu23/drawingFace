using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace DrawingDemo
{
    public class DrawableRectangle : Parent, IWritable
    {
        public DrawableRectangle(Color color, bool filled, Rectangle rectangle) : base(color, filled, rectangle)
        {
        }
        public override void Draw(Graphics g)
        {
            if (Filled == true)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillRectangle(brush, Rectangle);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawRectangle(pen, Rectangle);
            }
        }
        public void Write(TextWriter writer)
        {
            writer.WriteLine($"{Color.ToKnownColor()} {Filled} {Rectangle}");
        }
    }
}
