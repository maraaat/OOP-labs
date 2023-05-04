using OOP_SIXTH_LAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FOURTH_LAB
{
    interface Figure
    {
        void Draw();
        public Point getPosition();
        public bool IsSelected(Point XY);
        public void unselect();
        public void select();
        public void changeselect();
        public bool IsActive();
        public int GetR();
        public void IncR();
        public void DecR();
        public void GoLeft();
        public void GoRight();
        public void GoUp();
        public void GoDown();
        public void SetPen(int x1, int y1, int z1);

        public int GetLeft();
        public int GetRight();
        public int GetUp();
        public int GetDown();
    }
    interface ToCreateFigure
    {
        Figure figurecreate(int x, int y, int x1, int y1, int z1);
        public void ClearBack();

    }

    class AddTriangle : ToCreateFigure
    {
        private Graphics graphics;
        public Figure figurecreate(int x, int y, int x1, int y1, int z1)
        {
            return new Triangle(30, x, y, graphics, x1, y1, z1);
        }
        public AddTriangle(Graphics graphics)
        {
            this.graphics = graphics;
        }
        public void ClearBack()
        {
            graphics.Clear(Color.White);
        }

    }
    class AddCircle : ToCreateFigure
    {
        private Graphics graphics;
        public Figure figurecreate(int x, int y, int x1, int y1, int z1)
        {
            return new CCircle(30, x, y, graphics, x1, y1, z1);
        }
        public AddCircle(Graphics graphics)
        {
            
            this.graphics = graphics;
        }
        public void ClearBack()
        {
            graphics.Clear(Color.White);
        }
    }
    class AddQuad : ToCreateFigure
    {
        private Graphics graphics;
        public Figure figurecreate(int x, int y, int x1, int y1, int z1)
        {
            return new Quad(30, x, y, graphics, x1, y1, z1);
        }
        public AddQuad(Graphics graphics)
        {
            this.graphics = graphics;
        }
        public void ClearBack()
        {
            graphics.Clear(Color.White);
        }
    }
}
