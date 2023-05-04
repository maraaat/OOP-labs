using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace OOP_FOURTH_LAB
{
    class CCircle : Figure
    {
        protected int R;
        protected Point position;
        protected Boolean Selected;
        Graphics cc;
        

        public CCircle(int radius, int x, int y, Graphics graphics)
        {
            this.R = radius;
            this.position = new Point(x, y);
            this.cc = graphics;
        }

        public void Draw()
        {
            Pen pen;
            Pen blackPen = new Pen(Color.Black, 3);
            Pen redPen = new Pen(Color.Red, 3);

            if (Selected) pen = redPen;
            else pen = blackPen;

            cc.DrawEllipse(pen, position.X - R, position.Y - R, R * 2, R * 2);

        }
        public Point getPosition()
        {
            return position;
        }

        public bool IsSelected (Point XY)
        {
            double len = Math.Sqrt(Math.Pow(XY.X - position.X, 2) + Math.Pow(XY.Y - position.Y, 2));
            if (len < R)
            {
                Selected = true;
                return true;
            }
            return false;
        }

        public void unselect()
        {
            Selected=false;
        }
        public void changeselect()
        {
            Selected = !Selected;
        }
        public bool IsActive ()
        {
            return Selected;
        }
        public void select()
        {
            Selected = true;
        }


    }
}
