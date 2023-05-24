using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OOP_SIXTH_LAB.Observer;

namespace OOP_SIXTH_LAB.Shapes
{
    abstract public class CShape : Cobject, Cobserver
    {
        protected int R = 40;

        protected Point position;
        protected bool Selected;
        public Graphics cc;

        protected Pen pen;
        protected Pen mainPen = new Pen(Color.FromArgb(0, 0, 0), 3);
        
        virtual public void Save(StreamWriter stream)
        {
            return;
        }

        virtual public void Load(StreamReader stream)
        {
            return;
        }

        virtual public Point getPosition()
        {
            return position;
        }

        virtual public void ChangeSize(int s)
        {
            R += s;
        }

        virtual public void move(int x, int y)
        {
            position.X += x;
            position.Y += y;
        }

        virtual public void GoLeft()
        {
            position.X -= 1;
        }
        virtual public void GoRight()
        {
            position.X += 1;
        }
        virtual public void GoUp()
        {
            position.Y -= 1;
        }
        virtual public void GoDown()
        {
            position.Y += 1;
        }
        virtual public int getRadius()
        {
            return R;
        }

        virtual public  void SetPen(int x1, int y1, int z1)
        {
            mainPen = new Pen(Color.FromArgb(x1, y1, z1), 3);
        }

        abstract public void Draw();


        virtual public Graphics getGraphics()
        {
            return cc;
        }

        virtual public void SetColor(int x1, int y1, int z1)
        {
            mainPen = new Pen(Color.FromArgb(x1, y1, z1), 3);
        }

        virtual public bool checkPosition(Point point)
        {
            double len = Math.Sqrt(Math.Pow(point.X - position.X, 2) + Math.Pow(point.Y - position.Y, 2));
            if (len < R / 2)
            {
                return true;
            }
            return false;
        }

        virtual public bool canMove(int x, int y, int width, int height)
        {
            if (position.X + R / 2 + x < width &&
                position.X - R / 2 + x > 0 &&
                position.Y + R / 2 + y < height &&
                position.Y - R / 2 + y > 0)
                return true;
            else
                return false;
        }
        public void OnSubjectChanged(Cobject who)
        {
            return;
        }

        public void OnSubjectSelect(Cobject who)
        {
            return;
        }

        public void OnSubjectMove(int x, int y)
        {
            move(x, y);
        }
        ~CShape() { }
    }

}
