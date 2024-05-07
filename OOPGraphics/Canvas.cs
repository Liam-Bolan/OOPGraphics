using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGraphics
{
    class Canvas
        {
        private Graphics _GraphicsSurface;
        
        public Graphics GraphicsSurface
        {
          get { return _GraphicsSurface; }
          set { _GraphicsSurface = value; }
        }

        //constructor
        public Canvas(Graphics g)
            {
            _GraphicsSurface=g;
            }
         }
}
