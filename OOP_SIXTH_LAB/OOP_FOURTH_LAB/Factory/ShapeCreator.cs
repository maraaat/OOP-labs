using OOP_FOURTH_LAB;
using OOP_SIXTH_LAB.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OOP_SIXTH_LAB.Shapes;

namespace OOP_SIXTH_LAB.Factory
{
    internal class ShapeCreator
    {
        private Graphics cc; 
        private String name1 = "Круг ";
        private String name2 = "Квадрат ";
        private String name3 = "Треугольник ";
        private String name4 = "Группа ";
        private String name5 = "Стрелка ";
        private int num1 = 0;
        private int num2 = 0;
        private int num3 = 0;
        private int num4 = 0;
        private int num5 = 0;
        public ShapeCreator(Graphics graphics)
        {
            cc = graphics;
        }

        public CCircle createCCircle(Point click, int x1, int y1, int z1)
        {
            num1++;
            return new CCircle(click, cc, x1, y1, z1, name1 + num1.ToString());
        }

        public CGroup createCGroup()
        {
            num4++;
            return new CGroup(cc, name4 + num4.ToString());
        }

        public Quad createSquare(Point click, int x1, int y1, int z1)
        {num2++;
            return new Quad(click, cc, x1, y1, z1, name2 + num2.ToString());
        }

        public Triangle createTriangle(Point click, int x1, int y1, int z1)
        {num3++;
            return new Triangle(click, cc, x1, y1, z1, name3 + num3.ToString());
        }
        public Cpointer createPointer(Point click)
        {
            num5++;
            return new Cpointer(click, cc, name5 + num5.ToString());
        }
    }
}
