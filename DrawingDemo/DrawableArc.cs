using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace DrawingDemo
{
    public class DrawableArc : Parent, IWritable
    {
        protected float Start { get; }
        protected float End { get; }
        public DrawableArc(Color color, bool filled, Rectangle rectangle, float start, float end) : base(color, filled, rectangle)
        {
            Start = start;
            End = end;
        }
        public override void Draw(Graphics g)
        {
            if (Filled == true)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillPie(brush, Rectangle, Start, End);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawArc(pen, Rectangle, Start, End);
            }
        }
        public void Write(TextWriter writer)
        {
            writer.WriteLine($"{Start} {End}");
        }
    }
}
