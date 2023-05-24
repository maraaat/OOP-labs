using OOP_SIXTH_LAB.Factory;
using OOP_SIXTH_LAB.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_SIXTH_LAB.Shapes
{
    public class CDecorator : CShape
    {
        public CShape shape;
        private Graphics cc;
        public CDecorator(CShape shape)
        {
            cc = shape.getGraphics();
            this.shape = shape;

        }

        public override void Save(StreamWriter stream)
        {
            shape.Save(stream);
        }

        public override void Load(StreamReader stream)
        {
            shape.Load(stream);
        }
        override public void Draw()
        {
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            if (shape is CGroup group)
            {
                foreach (CShape innerShape in group.getShapes())
                {
                    CDecorator decorator = new CDecorator(innerShape);
                    decorator.Draw();
                }
            }
            else
            {
                cc.DrawRectangle(pen, shape.getPosition().X - (shape.getRadius()*2 +10)/2 , shape.getPosition().Y - (shape.getRadius() *2 + 10) /2, shape.getRadius()*2 + 10, shape.getRadius()*2 + 10);
                shape.Draw();
            }
        }

        override public bool canMove(int x, int y, int width, int height)
        {
            if (shape is CGroup group)
                return group.canMove(x, y, width, height);
            else if (shape.getPosition().X + shape.getRadius()*2 / 2 + x < width &&
                shape.getPosition().X - shape.getRadius()*2 / 2 + x > 0 &&
                shape.getPosition().Y + shape.getRadius()*2 / 2 + y < height &&
                shape.getPosition().Y - shape.getRadius()*2 / 2 + y > 0)
                return true;
            else
                return false;
        }
        override public bool checkPosition(Point point)
        {
            return shape.checkPosition(point);
        }

        override public Point getPosition()
        {
            return shape.getPosition();
        }

        override public int getRadius()
        {
            return shape.getRadius();
        }

        override public void move(int x, int y)
        {
            shape.move(x, y);
        }

        override public void ChangeSize(int s)
        {
            shape.ChangeSize(s);
        }

        override public void SetColor(int x1, int y1, int z1)
        {
            shape.SetColor(x1, y1, z1);
        }
        public override string Who()
        {
            return shape.Who();
        }
        override public void AddObserver(Cobserver o)
        {
            shape.AddObserver(o);
        }
        override public void RemoveObserver()
        {
            shape.RemoveObserver();
        }

        override public void NotifyEveryone()
        {
            shape.NotifyEveryone();
        }

        override public void NotifyEveryoneSelect()
        {
            shape.NotifyEveryoneSelect();
        }

        public void OnSubjectMove(int x, int y)
        {
            shape.move(x, y);
        }
    }
}
