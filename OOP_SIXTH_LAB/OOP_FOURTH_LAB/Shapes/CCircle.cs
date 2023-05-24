using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_FOURTH_LAB;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.IO;

namespace OOP_SIXTH_LAB.Shapes
{
    class CCircle : CShape
    {

        public CCircle(Point pos, Graphics graphics, int x1, int y1, int z1, string Name)
        {
            SetPen(x1, y1, z1);
            position = pos;
            cc = graphics;
            this.Name = Name;


        }
        public override void SetPen(int x1, int y1, int z1)
        {
            this.mainPen = new Pen(Color.FromArgb(x1, y1, z1), 3);
        }

        public override void Save(StreamWriter stream)
        {
            stream.WriteLine("C");
            stream.WriteLine("{0} {1} {2} {3}", position.X, position.Y, R); ;
        }

        public override void Load(StreamReader stream)
        {
            string[] values = stream.ReadLine().Split(' ');
            position.X = int.Parse(values[0]);
            position.Y = int.Parse(values[1]);
            R = int.Parse(values[2]);
            //mainPen.Color = char.Parse(values[3]);
        }
        public override void Draw()
        {
            Pen redPen = new Pen(Color.Teal, 3);

            cc.DrawEllipse(mainPen, position.X - R, position.Y - R, R*2, R*2);

        }

    }
}
