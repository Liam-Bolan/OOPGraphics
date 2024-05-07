using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOPGraphics
{
    abstract class  Shape
    {
        protected int _x;
        protected int _y;
        protected int _size;
        protected Color _colour;
        
        

        public int Xpos
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Ypos
        {
            get { return _y; }
            set { _y = value; }
        }
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public Color Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
       
        public virtual void CalcArea(Canvas x)
        {
            double area = _size * _size;
        }
        
        // integer attributes _x,_y coordinates
        // integer attribute _size
        // Color attribute _colour
        // abstract method to draw - abstract because we know we need to draw but dont know what we're drawing
        public abstract void Draw(Canvas c);
        
        // abstract method to calculate area (in pixels) - again abstract because we dont know how to calculate.
        
    }
}
