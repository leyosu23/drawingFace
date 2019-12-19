using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace DrawingDemo
{
    public class DrawableBezier : IDrawable, IWritable
    {
        protected Color Color { get; }
        protected Point Start { get; }
        protected Point First { get; }
        protected Point Second { get; }
        protected Point End { get; }
        public DrawableBezier(Color color, Point start, Point end, Point first, Point second)
        {
            Color = color;
            Start = start;
            End = end;
            First = first;
            Second = second;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color);
            g.DrawBezier(pen, Start, First, Second, End);
        }
        public void Write(TextWriter writer)
        {
            writer.WriteLine($"{Color} {Start} {First} {Second} {End}");
        }
    }
}
