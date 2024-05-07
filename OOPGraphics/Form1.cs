using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPGraphics
{
    public partial class Form1 : Form
    {
        
        private Canvas _ThisCanvas;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sets the colour button to the colour chosen
            colorDialog1.ShowDialog();
            ColourButton.BackColor= colorDialog1.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // instantiates the canvas at the start and sets the canvas to draw on the white panel on the form
            _ThisCanvas = new Canvas(panel1.CreateGraphics());
        }


        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Circle C = new Circle();
                C.Colour = ColourButton.BackColor;
                C.Xpos = e.X;
                C.Ypos = e.Y;
                C.Size = trackBar1.Value;
                C.Draw(_ThisCanvas);
                               
            }
            if(e.Button == MouseButtons.Right)
            {
                Square C = new Square();
                C.Colour = ColourButton.BackColor;
                C.Xpos = e.X;
                C.Ypos = e.Y;
                C.Size = trackBar1.Value;
                C.Draw(_ThisCanvas);
            }
            if(e.Button == MouseButtons.Middle)
            {
                Robot C = new Robot();
                C.Colour = ColourButton.BackColor;
                C.Xpos = e.X;
                C.Ypos = e.Y;
                C.Size = trackBar1.Value;
                C.Draw(_ThisCanvas);
            }
            //instantiate appropriate shape depending on which mouse button pressed (left or right).
            //set x and y coordinates to e.X, e.Y
            //set colour and size to ColourButton.BackColour and trackbar1.value
            //call shape draw method
           

        }


    }
}
