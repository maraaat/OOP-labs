using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FOURTH_LAB
{
    class Container
    {

        private List<Figure> elements;
        Graphics c;
        public Container()
        {
            elements = new List<Figure>();
        }

        public void SetColor(Figure xy, int x1, int y1, int z1)
        {
            xy.SetPen(x1, y1, z1);
        }

        public void AddElem(Figure xy)
        {
            unselectall();
            if (SelectedOrNot(xy.getPosition())) return;
            xy.changeselect();
            
            elements.Add(xy);

        }
        public void AddElemAndSelectOne(Figure xy)
        {
            unselectall();
            if (SelectedOrNot2(xy.getPosition())) return;
            xy.changeselect();
            elements.Add(xy);

        }
        public bool SelectedOrNot(Point xy)
        {
            bool res = false;
            foreach (Figure element in elements)
            {
                res = element.IsSelected(xy) || res;       
            }
            return res;
        }
        public bool SelectedOrNot2(Point xy)
        {
            bool res = false;
            foreach (Figure element in elements)
            {
                res = element.IsSelected(xy) || res;
                if (res)
                {
                    return res;
                    
                }
            }
            res = false;
            return res;
        }
        public void drawall()
        {

            foreach (Figure element in elements)
            {
                element.Draw();
            }
        }
        public void unselectall()
        {
            foreach (Figure element in elements)
            {
                element.unselect();
            }
        }

        public void DeleteSelectedElements()
        {

            List<Figure> deletedel = new List<Figure>();
            foreach (Figure element in elements)
            {
                if (element.IsActive())
                {
                    deletedel.Add(element);
                }
            }
            foreach (Figure element in deletedel)
            {
                elements.Remove(element);
            }

        }

        public void DeleteAll()
        {
            elements.Clear();
        }

        public void MakeSelected(Figure xy)
        {
            if (SelectedOrNot(xy.getPosition())) return;
            xy.changeselect();
        }
        public void MakeSelectedToOnlyOneMode(Figure xy)
        {
            if (SelectedOrNot2(xy.getPosition())) return;
            xy.changeselect();
        }


        public void IncElements()
        {

            List<Figure> deletedel = new List<Figure>();
            foreach (Figure element in elements)
            {
                if (element.IsActive())
                {
                        element.IncR();

                }
            }

        }
        public void DecElements()
        {

            List<Figure> deletedel = new List<Figure>();
            foreach (Figure element in elements)
            {
                if (element.IsActive())
                {
                    element.DecR();
                }
            }

        }
        public void MoveLeft(int X)
        {

            List<Figure> deletedel = new List<Figure>();
            foreach (Figure element in elements)
            {
                if (element.IsActive())
                {   
                    if(X < element.GetLeft())
                    {
                        element.GoLeft();
                    }
                    
                }
            }

        }
        public void MoveRight(int X)
        {

            List<Figure> deletedel = new List<Figure>();
            foreach (Figure element in elements)
            {
                if (element.IsActive())
                {
                    if (X > element.GetRight())
                    {
                        element.GoRight();
                    }
                }
            }

        }
        public void MoveUp(int Y)
        {
            List<Figure> deletedel = new List<Figure>();
            foreach (Figure element in elements)
            {
                if (element.IsActive())
                {
                    if (Y < element.GetUp())
                    {
                        element.GoUp();
                    }
                }
            }

        }
        public void MoveDown(int Y)
        {

            List<Figure> deletedel = new List<Figure>();
            foreach (Figure element in elements)
            {
                if (element.IsActive())
                {
                    if (Y > element.GetDown())
                    {
                        element.GoDown();
                    }
                }
            }

        }
    }
}

