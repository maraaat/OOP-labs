using OOP_FOURTH_LAB;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace OOP_SIXTH_LAB.Shapes
{
    class Triangle : CShape
    {

        public Triangle(Point pos, Graphics graphics, int x1, int y1, int z1, string Name)
        {
            SetPen(x1, y1, z1);

            position = pos;
            cc = graphics; 
            this.Name = Name;

        }

        public override void SetPen(int x1, int y1, int z1)
        {
            mainPen = new Pen(Color.FromArgb(x1, y1, z1), 3);
        }

        public override void Draw()
        {

            pen = mainPen;
            double angle = Math.PI / 6;
            Point[] vertices = new Point[3];
            for (int i = 0; i < 3; i++)
            {
                double x = position.X + (R * Math.Cos(angle)) / 0.85;
                double y =position.Y + (R * Math.Sin(angle) + 9) / 0.75;
                vertices[i] = new Point((int)x, (int)y);
                angle += 2 * Math.PI / 3;
            };
            cc.DrawPolygon(mainPen, vertices);

        }

    }
}
