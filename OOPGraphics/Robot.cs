using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGraphics
{
     class Robot: Shape
    {
        public override void CalcArea(Canvas x)
        {
            base.CalcArea(x);
        }
        public override void Draw(Canvas g)
        {
            SolidBrush b = new SolidBrush(_colour);
            g.GraphicsSurface.FillRectangle(b, _x+15, _y-100, _size, _size);//head   
            g.GraphicsSurface.FillRectangle(b, _x, _y, _size+30, _size+60);//body
            g.GraphicsSurface.FillRectangle(b, _x-45, _y, _size-50, _size+60);//Left arm
            g.GraphicsSurface.FillRectangle(b, _x+120, _y, _size-50, _size+60);//right arm
            g.GraphicsSurface.FillRectangle(b, _x-10, _y+50, _size-50, _size+150);//left leg
            g.GraphicsSurface.FillRectangle(b, _x+80, _y+50, _size-50, _size+150);//right leg

        }


    }
}
