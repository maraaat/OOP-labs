using System.Configuration;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace OOP_FOURTH_LAB
{
    public partial class Form1 : Form
    {
        Graphics g; //в качестве холста
        Bitmap buf; //буфер для изображения
        Container elements = new Container();
        ToCreateFigure circle;
        public Form1()
        {
            InitializeComponent();
            buf = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            circle = new AddFigure(Graphics.FromImage(buf));
        }

        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Teal);
            Pen blackPen = new Pen(Color.Black, 4);
            g.DrawRectangle(blackPen, 50, 50, 800, 550);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            elements.drawall();
            pictureBox1.Image = buf;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (cb2.Checked && cb1.Checked)
            {
                elements.MakeSelectedToOnlyOneMode(circle.figurecreate(e.X, e.Y));
                pictureBox1.Invalidate();
            }
            else if (cb2.Checked)
            {
                elements.MakeSelected(circle.figurecreate(e.X, e.Y));
                pictureBox1.Invalidate();
            }
            else if (cb1.Checked)
            {
                elements.AddElemAndSelectOne(circle.figurecreate(e.X, e.Y));
                pictureBox1.Invalidate();
            }
            else
            {
                elements.AddElem(circle.figurecreate(e.X, e.Y));
                pictureBox1.Invalidate();
            }
        }

        private void MakeActive()
        {
            elements.SelectedOrNot(System.Windows.Forms.Control.MousePosition);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            elements.DeleteAll();
            buf = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            circle = new AddFigure(Graphics.FromImage(buf));

        }


        private void button2_Click(object sender, EventArgs e)
        {
            elements.DeleteSelectedElements();
            circle.ClearBack();
        }
    }
        
    
}