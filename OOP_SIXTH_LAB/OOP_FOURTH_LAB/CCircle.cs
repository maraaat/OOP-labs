using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        protected Pen pen;
        protected Pen blackPen = new Pen(Color.FromArgb(0, 0, 0), 3);
        protected Pen redPen = new Pen(Color.Teal, 3);

        protected int width;
        protected int height;

        public CCircle(int radius, int x, int y, Graphics graphics, int x1, int y1, int z1)
        {
            SetPen(x1, y1, z1);
            this.R = radius;
            this.position = new Point(x, y);
            this.cc = graphics;

            this.width = R * 2;
            this.height = R * 2;
        }
        public void SetPen(int x1, int y1, int z1)
        {
            this.blackPen = new Pen(Color.FromArgb(x1, y1, z1), 3);
        }
        public void Draw()
        {
            //pen.DashStyle = DashStyle.Dash;
            //cc.DrawRectangle(pen, position.X - R, position.Y - R, R * 2, R * 2);
            if (Selected) {
                
                pen = redPen; 
                pen.DashStyle = DashStyle.Dash;
                cc.DrawRectangle(pen, position.X - R, position.Y - R, R * 2, R * 2);
            }
             pen = blackPen;

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
        public int GetR()
        {
            return R;
        }
        public void IncR()
        {
            R++;
        }
        public void DecR()
        {
            R--;
        }
        public void GoLeft()
        {
            position.X -= 1;
        }
        public void GoRight()
        {
            position.X += 1;
        }
        public void GoUp()
        {
            position.Y -= 1;
        }
        public void GoDown()
        {
            position.Y += 1;
        }

        public int GetLeft()
        {
            return position.X+R/2;
        }
        public int GetRight()
        {
            return position.X + R*2+20;

        }
        public int GetUp()
        {
            return position.Y+R;
        }
        public int GetDown()
        {
            return position.Y+R*3+5;
        }

    }
}
