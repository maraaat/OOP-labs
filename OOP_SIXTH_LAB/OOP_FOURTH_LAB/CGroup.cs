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
using OOP_SIXTH_LAB.Shapes;
using OOP_SIXTH_LAB;

namespace OOP_SIXTH_LAB
{
    public class CGroup : CShape
    {
        private List<CShape> shapes;

        public CGroup(Graphics cc, string Name)
        {
            this.cc = cc;
            shapes = new List<CShape>();
            this.Name = Name;
        }

        public void addShape(CShape shape)
        {
            shapes.Add(shape); 
        }

        override public void move(int x, int y)
        {
            foreach (CShape shape in shapes)
            {
                shape.move(x, y);
            }
        }


        public override void Save(StreamWriter stream)
        {
            stream.WriteLine("G");
            stream.WriteLine("{0}", shapes.Count);
            foreach (CShape shape in shapes)
            {
                shape.Save(stream);
            }
        }

        public override void Load(StreamReader stream)
        {
            //foreach (Shape shape in shapes)
            //{
            //    shape.Save(stream);
            //}
            //string[] values = stream.ReadLine().Split(' ');
            //p.X = int.Parse(values[0]);
            //p.Y = int.Parse(values[1]);
            //R = int.Parse(values[2]);
            //Colored = char.Parse(values[3]);
        }

        public List<CShape> getShapes()
        {
            return shapes;
        }
        public override bool checkPosition(Point point)
        {
            foreach (CShape shape in shapes)
            {
                if (shape.checkPosition(point))
                {
                    return true;
                }
            }
            return false;
        }
       
        override public void Draw()
        {
            foreach (CShape shape in shapes)
            {
                shape.Draw();
            }
        }

        public override Graphics getGraphics()
        {
            return cc;
        }

        override public void ChangeSize(int s)
        {
            foreach (CShape shape in shapes)
            {
                shape.ChangeSize(s);
            }
        }

        override public void SetColor(int x1, int y1, int z1)
        {
            foreach (CShape shape in shapes)
            {
                shape.SetColor( x1,  y1,  z1);
            }
        }

        public override bool canMove(int x, int y, int width, int height)
        {
            foreach (CShape shape in shapes)
            {
                if (shape.canMove(x, y, width, height) == false)
                    return false;
            }
            return true;

        }
        //override public int getRadius()
        //{
        //    return 100;
        //}
        ~CGroup()
        {
            for (int i = 0; i < shapes.Count;)
            {
                shapes[i] = null;
            }
        }
    }
}
