using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_SIXTH_LAB.Shapes;

namespace OOP_SIXTH_LAB.Factory
{
    public class CShapeArray
    {
        Graphics g;
        private List<CShape> shapes;

        public CShapeArray(Graphics g)
        {
            shapes = new List<CShape>();
            this.g = g;
        }
        public virtual CShape CreateShape(char code)
        {
            return null;
        }

        public List<CShape> getList() { return shapes; }
        public void LoadShapes(string filename)
        {
            CMyShapeFactory factory = new CMyShapeFactory(g);
            StreamReader stream = null;
            int count;
            CShape shape;
            try
            {
                stream = new StreamReader(filename);
                count = int.Parse(stream.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    char code = char.Parse(stream.ReadLine());
                    shape = factory.CreateShape(code);

                    if (shape is CGroup group)
                    {
                        stream = LoadGroup(filename, stream, factory, group);
                        shapes.Add(group);
                    }
                    else if (shape != null)
                    {
                        shape.Load(stream);
                        shapes.Add(shape);
                    }
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

        public StreamReader LoadGroup(string filename, StreamReader stream, CMyShapeFactory factory, CGroup group)
        {
            int gCount = int.Parse(stream.ReadLine());
            CShape shape;
            for (int j = 0; j < gCount; j++)
            {
                char code = char.Parse(stream.ReadLine());
                shape = factory.CreateShape(code);
                if (shape is CGroup _group)
                    stream = LoadGroup(filename, stream, factory, _group);
                shape.Load(stream);
                group.addShape(shape);
            }
            return stream;
        }

    }
}
