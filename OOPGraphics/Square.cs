using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGraphics
{
     class Square: Shape
    {

        public override void Draw(Canvas C)
        {
            SolidBrush b = new SolidBrush(_colour);
            C.GraphicsSurface.FillRectangle(b, _x, _y, _size, _size);
        }
    }
}
