using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DrawingDemo
{
    public abstract class Parent : IDrawable
    {
        protected Color Color { get; }
        protected bool Filled { get; }
        protected Rectangle Rectangle { get; }
        public Parent(Color color, bool filled, Rectangle rectangle)
        {
            Color = color;
            Filled = filled;
            Rectangle = rectangle;
        }
        public abstract void Draw(Graphics graphics);
    }
}
