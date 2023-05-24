using System.Configuration;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using OOP_SIXTH_LAB;
using OOP_SIXTH_LAB.Factory;
using OOP_SIXTH_LAB.Shapes;
using OOP_SIXTH_LAB.Observer;

namespace OOP_SIXTH_LAB.Factory
{
    public abstract class CShapeFactory
    {

        public abstract CShape CreateShape(char code);

    }

    public class CMyShapeFactory : CShapeFactory
    {
        public Graphics g;
        public int num1 = 0;
        public int num2 = 0;
        public int num3 = 0;
        public int num4 = 0;
        public CMyShapeFactory(Graphics g)
        {
            this.g = g;
        }
        public override CShape CreateShape(char code)
        {
            CShape shape = null;
            switch (code)
            {
                case 'S':
                    num1++;
                    shape = new Quad(new Point(0, 0), g, 0,0,0, "Квадрат" + num1.ToString());
                    break;
                case 'C':
                    num2++;
                    shape = new CCircle(new Point(0, 0), g, 0, 0, 0, "Круг" + num2.ToString());
                    break;
                case 'T':
                    num3++;
                    shape = new Triangle(new Point(0, 0), g, 0, 0, 0, "Треугольник" + num3.ToString());
                    break;
                case 'G':
                    num4++;
                    shape = new CGroup(g, "Группа" + num4.ToString());
                    break;
                default:
                    break;
            }
            return shape;
        }
    }
}
