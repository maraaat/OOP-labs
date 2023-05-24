using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_SIXTH_LAB.Observer;

namespace OOP_SIXTH_LAB.Shapes
{
    public class Cpointer : CShape
    {
        Point p1;
        Point p2;
        CShape shape1;
        CShape shape2;
        public Cpointer(Point click, Graphics graphics, string Name)
        {
            position = new Point(0, 0);
            cc = graphics;
            //this.Colored = 'B';
            this.Name = Name;
        }

        public void addShapes(CShape s1, CShape s2)
        {
            shape1 = s1;
            shape2 = s2;
            shape2.AddObserver(shape1);
        }

        public override void Save(StreamWriter stream)
        {
            stream.WriteLine("P");
            stream.WriteLine("{0} {1} {2} {3}", position.X, position.Y, R);
        }

        public override void Load(StreamReader stream)
        {
            string[] values = stream.ReadLine().Split(' ');
            position.X = int.Parse(values[0]);
            position.Y = int.Parse(values[1]);
            R = int.Parse(values[2]);
            //Colored = char.Parse(values[3]);
        }
        override public void Draw()
        {
            //Point startPoint = new Point(10, 10);
            //Point endPoint = new Point(100, 100);

            //// Создаем объект Pen для рисования линии
            //Pen pen = new Pen(Color.Black);

            //// Рисуем линию между начальной и конечной точками
            //g.DrawLine(pen, startPoint, endPoint);
            return;
        }

        public void Del()
        {
            shape1.RemoveObserver();
            shape2.RemoveObserver();
        }
    }
}
