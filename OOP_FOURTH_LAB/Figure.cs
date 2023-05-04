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

    }
    interface ToCreateFigure
    {
        Figure figurecreate(int x, int y);
        public void ClearBack();
    }

    class AddFigure : ToCreateFigure
    {
        private Graphics graphics;
        public Figure figurecreate(int x, int y)
        {
            return new CCircle(30, x, y, graphics);
        }
        public AddFigure(Graphics graphics)
        {
            this.graphics = graphics;
        }
        public void ClearBack()
        {
            graphics.Clear(Color.White);
        }
    }
}
