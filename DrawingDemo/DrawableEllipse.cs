using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawingDemo
{
    public class DrawableEllipse : Parent
    {
        public DrawableEllipse(Color color, bool filled, Rectangle rectangle) : base(color, filled, rectangle) { }
        public override void Draw(Graphics g)
        {
            if (Filled == true)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillEllipse(brush, Rectangle);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawEllipse(pen, Rectangle);
            }
        }
    }
}
