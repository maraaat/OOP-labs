using OOP_FOURTH_LAB;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace OOP_SIXTH_LAB
{
    class Triangle : Figure
    {
        protected int R;
        protected int R2;
        protected Point position;
        protected Boolean Selected;
        Graphics cc;
        Pen pen;
        Pen blackPen = new Pen(Color.FromArgb(0, 0, 0), 3);
        Pen redPen = new Pen(Color.Teal, 3);

        protected int width, height;

        public Triangle(int radius, int x, int y, Graphics graphics, int x1, int y1, int z1)
        {
            SetPen(x1, y1, z1);
            this.R = radius;
            this.R2 = radius;
            this.position = new Point(x, y); 
            this.cc = graphics;
            width = 2 * R;
            height = R;
        }

        public void SetPen(int x1, int y1, int z1)
        {
            this.blackPen = new Pen(Color.FromArgb(x1, y1, z1), 3);
        }
        
        public void Draw()
        {

            if (Selected)
            {

                pen = redPen;
                pen.DashStyle = DashStyle.Dash;
                var pointstoquad = new Point[]
                 {
                new Point((position.X-33)+R/5, (position.Y-33)+R/5),
                new Point((position.X-33)+R/5, (position.Y+33)),
                new Point((position.X+27)+R2/5, (position.Y+33)),
                new Point((position.X+27)+R2/5, (position.Y-33)+R/5)

                };
                cc.DrawPolygon(pen, pointstoquad);
            }
            pen = blackPen;
            var points = new Point[]
            {
            new Point(position.X, (position.Y-30)+R/5),
            new Point((position.X-27)+R/10, position.Y+30),
            new Point((position.X+27)+R2/10, position.Y+30)
            };
            cc.DrawPolygon(pen, points);

        }
        public Point getPosition()
        {
            return position;
        }

        public bool IsSelected(Point XY)
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
            Selected = false;
        }
        public void changeselect()
        {
            Selected = !Selected;
        }
        public bool IsActive()
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
            R--;
            R2++;
        }
        public void DecR()
        {
            R++;
            R2--;
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
            return position.X + R / 2;
        }
        public int GetRight()
        {
            return position.X + R * 2 + 25;

        }
        public int GetUp()
        {
            return position.Y + R;
        }
        public int GetDown()
        {
            return position.Y + R * 3 + 5;
        }
    }
}
