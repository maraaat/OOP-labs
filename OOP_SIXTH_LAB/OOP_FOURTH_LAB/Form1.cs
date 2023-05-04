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
            //FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            buf = new Bitmap(1920, 1080);
            if(tsFigure.DefaultItem == tsTriangle)
            {
                circle = new AddTriangle(Graphics.FromImage(buf));
            }
            else if (tsFigure.DefaultItem == tsQuad)
            {
                circle = new AddQuad(Graphics.FromImage(buf));
            }
            else
            {
                circle = new AddCircle(Graphics.FromImage(buf));
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Teal);
            Pen blackPen = new Pen(Color.Black, 4);
            g.DrawRectangle(blackPen, pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            circle.ClearBack();
            elements.drawall();

            pictureBox1.Image = buf;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            if (tsFigure.DefaultItem == tsTriangle)
            {
                circle = new AddTriangle(Graphics.FromImage(buf));
            }
            else if (tsFigure.DefaultItem == tsQuad)
            {
                circle = new AddQuad(Graphics.FromImage(buf));
            }
            else
            {
                circle = new AddCircle(Graphics.FromImage(buf));
            }


            if (cb2.Checked && cb1.Checked || checkercontrol == true && cb1.Checked)
            {
                elements.MakeSelectedToOnlyOneMode(circle.figurecreate(e.X, e.Y, (int)trBar1.Value, (int)trBar2.Value, (int)trBar3.Value));
                pictureBox1.Invalidate();
            }
            else if (cb2.Checked || checkercontrol == true)
            {
                elements.MakeSelected(circle.figurecreate(e.X, e.Y, (int)trBar1.Value, (int)trBar2.Value, (int)trBar3.Value));
                pictureBox1.Invalidate();
            }
            else if (cb1.Checked)
            {
                elements.AddElemAndSelectOne(circle.figurecreate(e.X, e.Y, (int)trBar1.Value, (int)trBar2.Value, (int)trBar3.Value));
                pictureBox1.Invalidate();
            }
            else
            {
                elements.AddElem(circle.figurecreate(e.X, e.Y, (int)trBar1.Value, (int)trBar2.Value, (int)trBar3.Value));
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
            buf = new Bitmap(1920, 1080);


        }

        bool checkercontrol = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                elements.DeleteSelectedElements();
                circle.ClearBack();
            }

            if (e.KeyCode == Keys.ControlKey)
            {
                checkercontrol = true;
                
            }

            if (e.KeyCode == Keys.Q)
            {
                elements.IncElements();
                circle.ClearBack();
            }
            if (e.KeyCode == Keys.E)
            {
                elements.DecElements();
                circle.ClearBack();
            }
            if (e.KeyCode == Keys.A)
            {
                elements.MoveLeft(pictureBox1.Location.X);
                circle.ClearBack();
            }
            if (e.KeyCode == Keys.W)
            {
                elements.MoveUp(pictureBox1.Location.Y);
                circle.ClearBack();
            }
            if (e.KeyCode == Keys.D)
            {
                elements.MoveRight(pictureBox1.Location.X + pictureBox1.Width);
                circle.ClearBack();

            }
            if (e.KeyCode == Keys.S)
            {
                elements.MoveDown(pictureBox1.Location.Y + pictureBox1.Height);
                circle.ClearBack();

               
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                checkercontrol = false;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tsCircle_Click(object sender, EventArgs e)
        {
            tsFigure.Image = Image.FromFile("C:/Users/Asus/Desktop/icons8-полнолуние-50.png");
            tsFigure.DefaultItem = tsCircle;
        }

        private void tsTriangle_Click(object sender, EventArgs e)
        {
            tsFigure.Image = Image.FromFile("C:/Users/Asus/Desktop/icons8-треугольник-50.png");
            tsFigure.DefaultItem = tsTriangle;
        }

        private void tsQuad_Click(object sender, EventArgs e)
        {
            tsFigure.Image = Image.FromFile("C:/Users/Asus/Desktop/icons8-стоп-50.png");
            tsFigure.DefaultItem = tsQuad;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trBar1_ValueChanged(object sender, EventArgs e)
        {
            TextColor.BackColor = Color.FromArgb((int)trBar1.Value, (int)trBar2.Value, (int)trBar3.Value);
        }

        private void trBar2_ValueChanged(object sender, EventArgs e)
        {
            TextColor.BackColor = Color.FromArgb((int)trBar1.Value, (int)trBar2.Value, (int)trBar3.Value);
        }

        private void trBar3_ValueChanged(object sender, EventArgs e)
        {
            TextColor.BackColor = Color.FromArgb((int)trBar1.Value, (int)trBar2.Value, (int)trBar3.Value);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {


        }
    }
    
}
