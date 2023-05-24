using OOP_SIXTH_LAB.Shapes;
using OOP_SIXTH_LAB.Observer;
using OOP_SIXTH_LAB.Factory;
using OOP_SIXTH_LAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Security.Cryptography;

namespace OOP_FOURTH_LAB
{
    class Container : CShape, Cobserver
    {
        const string filename = "C:/Users/Asus/Documents/GitHub/OOP/OOP_SIXTH_LAB/OOP_FOURTH_LAB/data.txt";
        StreamWriter stream = null;
        private List<CShape> shapes;
        public bool ctrlPressed = false;
        public bool selectMany = false;
        public CDecorator decorator;
        private TreeViewObserver treeViewObserver;
        public Container(TreeViewObserver treeViewObserver)
        {
            shapes = new List<CShape>(); 
            this.treeViewObserver = treeViewObserver;
            treeViewObserver.AddObserver(this);
            this.AddObserver(treeViewObserver);
        }

        override public void Draw()
        {
            foreach (CShape shape in shapes)
                shape.Draw();
        }

        public int countSelected()
        {
            int i = 0;
            foreach (CShape shape in shapes)
            {
                if (shape is CDecorator)
                {
                    i++;
                }
            }
            return i;
        }
        public void AddPointer(CShape Pointer)
        {
            int s1 = -1;
            int s2 = -1;
            int i = 0;
            foreach (CShape shape in shapes)
            {
                if (shape is CDecorator && s1 == -1)
                    s1 = i;
                else if (shape is CDecorator)
                {
                    s2 = i;
                }
                i++;
            }
            if (Pointer is Cpointer p)
            {
                p.addShapes(shapes[s2], shapes[s1]);
            }
            shapes.Add(Pointer);
            this.NotifyEveryone();

        }
        public void Save()
        {
            try
            {
                stream = new StreamWriter(filename);
                stream.WriteLine("{0}", shapes.Count);

                foreach (CShape shape in shapes)
                {
                    shape.Save(stream);
                }


            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

        public void Load(CShapeArray array)
        {
            array.LoadShapes(filename);
            shapes = array.getList();
        }
        public void Compose(CGroup group)
        {
            int i = 0;
            for (; i < shapes.Count;)
            {
                if (shapes[i] is CDecorator decorator)
                {
                    if (decorator.shape is CShape shape)
                    {
                        group.addShape(shape);
                        shapes.RemoveAt(i);
                        continue;
                    }
                }
                i++;
            }
            group.AddObserver(treeViewObserver);
            decorator = new CDecorator(group);
            shapes.Add(decorator); 
            this.NotifyEveryone();
            decorator.NotifyEveryoneSelect();
        }

        public void unCompose()
        {
            int i = 0;
            int j = shapes.Count;
            for (; i < j;)
            {
                if (shapes[i] is CDecorator decorator)
                {
                    if (decorator.shape is CGroup group)
                    {
                        foreach (CShape innerShape in group.getShapes())
                        {
                            CDecorator dec = new CDecorator(innerShape);
                            shapes.Add(dec);
                        }
                        j--;
                        shapes.RemoveAt(i);
                        continue;
                    }
                }
                i++;
            }
            this.NotifyEveryone();
        }

        public void unSelectAll()
        {
            int i = 0;
            for (; i < shapes.Count;)
            {
                if (shapes[i] is CDecorator decorator)
                {
                    if (decorator.shape is CShape shape)
                    {
                        shapes[i] = shape;
                    }
                }
                i++;
            }
        }

        virtual public bool CheckPosition(Point p)
        {
            if (ctrlPressed == false)
                unSelectAll();
            if (isSelect(p))
            {
                return true;
            }
            return false;

        }
        public bool isSelect(Point point)
        {
            int i = 0;
            bool res = false;
            for (; i < shapes.Count;)
            {
                if (shapes[i] is CDecorator == false && shapes[i].checkPosition(point) == true)
                {
                    decorator = new CDecorator(shapes[i]);
                    //shapes.Add(decorator);
                    shapes.Insert(i, decorator);
                    shapes.RemoveAt(i + 1);
                    this.NotifyEveryone();
                    res = true;
                    if (selectMany == false)
                        return res;
                    continue;
                }
                i++;
            }
            return res;
        }

        public void delSelected()
        {
            int i = 0;
            for (; i < shapes.Count;)
            {
                if (shapes[i] is CDecorator == true)
                {
                    if (shapes[i] is Cpointer p)
                    {
                        p.Del();
                    }
                    shapes.RemoveAt(i);
                    continue;
                }
                i++;


            }
            this.NotifyEveryone();

        }
        public void delshapes()
        {
            for (int i = 0; i < shapes.Count;)
            {
                shapes.RemoveAt(i);
            }
            this.NotifyEveryone();
        }

        public void Add(CShape shape)
        {
            shape.AddObserver(treeViewObserver);
            decorator = new CDecorator(shape);
            shapes.Add(decorator);
            shapes.Remove(shape);
            this.NotifyEveryone();
            decorator.NotifyEveryoneSelect();
        }

        public List<CShape> getShapes()
        {
            return shapes;
        }


        public void Move(int x, int y, int width, int height)
        {
            foreach (CShape shape in shapes)
            {

                if (shape is CDecorator == true)
                {
                    if (shape.canMove(x, y, width, height) == true)
                        shape.move(x, y);
                }
            }

        }

        public void ChangeSize(int s, int width, int height)
        {

            foreach (CShape shape in shapes)
            {
                if (shape is CDecorator == true)
                {
                    if (shape.canMove(s, s, width, height) == true && shape.canMove(-s, -s, width, height) == true)
                        continue;
                    else return;
                }
            }
            foreach (CShape shape in shapes)
            {
                if (shape is CDecorator == true)
                {
                    shape.ChangeSize(s);
                }
            }
        }

        override public void SetColor(int x1, int y1, int z1)
        {
            foreach (CShape shape in shapes)
            {
                if (shape is CDecorator == true)
                {
                    shape.SetColor(x1, y1, z1);

                }
            }
        }
        public List<CShape> GetShapes() { return shapes; }

        public void OnSubjectChanged(Cobject who)
        {
            string name = treeViewObserver.getNameSelected();

            int i = 0;
            if (ctrlPressed == false)
                unSelectAll();
            for (; i < shapes.Count;)
            {

                if (shapes[i] is CDecorator == false && shapes[i].Who() == name)
                {
                    decorator = new CDecorator(shapes[i]);
                    shapes.Add(decorator);
                    shapes.RemoveAt(i);
                    break;
                }
                i++;
                i++;
            }
        }

        public void ctrlChange()
        {
            ctrlPressed = !ctrlPressed;
            treeViewObserver.ctrlPressed = !ctrlPressed;
        }

        public void OnSubjectSelect(Cobject who)
        {

        }

        public void OnSubjectMove(int x, int y)
        {
        }

    }
}

