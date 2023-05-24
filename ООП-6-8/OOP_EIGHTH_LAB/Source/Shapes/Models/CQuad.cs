using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Source.Shapes
{
    class CQuad : Shape
    {
        public CQuad()
        {
            _x = 0; _y = 0;
        }
        public CQuad(int x, int y) { _x= x; _y = y; }
        public override Shape clone() { return new CQuad(); }
        public override bool inShape(int x, int y)
        {
            bool isIn = false;
            if ((x > _x - _width) && (x < _x + _width) && (y > _y - _height) && (y < _y + _height))
                isIn = true;
            return isIn;
        }
        public override void draw(Graphics gr)
        {
            int centerX = _x - _width / 2;
            int centerY = _y - _height / 2;
            _shapePen.Color = _color;
            gr.DrawRectangle(_shapePen, centerX, centerY, _width * 2, _height * 2);
            _shapePen.Color = Color.Black;
        }
        public override void save(StreamWriter stream)
        {
            string write = "Square\nX = " + _x.ToString()
                + "\nY = " + _y.ToString() + "\nHeight = " + _height.ToString()
                + "\nWidth = " + _width.ToString();
            stream.WriteLine(write);
            string color = _color.ToString();
            //color = color.Trim('[', ']');
            stream.WriteLine("Color = " + color);
        }
        public override void load(StreamReader stream)
        {
            string[] ColorValues = new string[4];
            int[] value = new int[4];
            string[] values = new string[5];
            for (int i = 0; i < 5; ++i)
            {
                string[] line = stream.ReadLine().Split(' ');
                if (i != 4) { values[i] = line.Last(); }
                else
                {
                    ColorValues[0] = line[3];
                    ColorValues[1] = line[4];
                    ColorValues[2] = line[5];
                    ColorValues[3] = line.Last();
                }
            }
            _x = int.Parse(values[0]);
            _y = int.Parse(values[1]);
            _height = int.Parse(values[2]);
            _width = int.Parse(values[3]);
            for (int i = 0; i < 4; ++i)
            {
                int.TryParse(string.Join("", ColorValues[i].Where(c => char.IsDigit(c))), out value[i]);
            }

            _color = Color.FromArgb(value[0], value[1], value[2], value[3]);
        }
        public override string className() { return "Square"; }
    }
}
