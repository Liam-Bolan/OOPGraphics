using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGraphics
{
    class Circle: Shape//inherits shape
    {
        // overridden CalculateArea method
        public override void CalcArea(Canvas C)
        {
            double area = _size * _size * Math.PI; 
        }

        // overridden Draw method to fill an ellipse
        public override void Draw(Canvas g)
        {
           SolidBrush b=new SolidBrush(_colour);
            g.GraphicsSurface.FillEllipse(b, _x, _y, _size, _size);
           
        }
    }
}
