using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace DrawingDemo
{
    public class DrawableLine : IDrawable, IWritable
    {
        protected Color Color { get; }
        protected Point Start { get; }
        protected Point End { get; }
        public DrawableLine(Color color, Point start, Point end)
        {
            Color = color;
            Start = start;
            End = end;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color);
            g.DrawLine(pen, Start, End);
        }
        public void Write(TextWriter writer)
        {
            writer.WriteLine($"{Color} {Start} {End}");
        }
    }
}
