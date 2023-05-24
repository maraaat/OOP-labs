using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_SIXTH_LAB;
using OOP_SIXTH_LAB.Factory;
using OOP_SIXTH_LAB.Shapes;
using OOP_SIXTH_LAB.Observer;
using System.Xml.Linq;

namespace OOP_FOURTH_LAB
{
    public partial class Form1 : Form
    {
        Graphics g; //в качестве холста
        Bitmap map; //буфер для изображения
        ShapeCreator Creation;
        Boolean ctrlpress = false;// флажок зажатия контрола
        int typeOfShape = 0;

        const string filename = "C:/Users/Asus/Documents/GitHub/OOP/OOP_SIXTH_LAB/OOP_FOURTH_LAB/data.txt";
        Container container;
        TreeViewObserver observer;
        int razWidth;
        int razHeight;

        public Form1()
        {
            //FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            map = new Bitmap(1920, 1080);// определяем битмап
            pictureBox1.Image = map;
            Creation = new ShapeCreator(Graphics.FromImage(pictureBox1.Image));// определяем конвеер кругов
            observer = new TreeViewObserver(treeV1);
            container = new Container(observer);
            razWidth = this.Width - pictureBox1.Width;
            razHeight = this.Height - pictureBox1.Height;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Teal);
            Pen blackPen = new Pen(Color.Black, 4);
            g.DrawRectangle(blackPen, pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Width, pictureBox1.Height);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Width = this.Width - razWidth;
            panel1.Height = this.Height - razHeight;
            pictureBox1.Width = this.Width - razWidth;
            pictureBox1.Height = this.Height - razHeight;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)// определяем зажатие клавиши контрол
            {
                ctrlpress = true;
                container.ctrlChange();
            }
            if (e.KeyCode == Keys.Delete)
            {
                Graphics.FromImage(map).Clear(Color.White);
                container.delSelected();
            }
            if (e.KeyCode == Keys.A)
            {

                container.Move(-5, 0, panel1.Width, panel1.Height);
            }
            if (e.KeyCode == Keys.S)
            {
                container.Move(0, 5, panel1.Width, panel1.Height);
            }
            if (e.KeyCode == Keys.D)
            {
                container.Move(5, 0, panel1.Width, panel1.Height);
            }
            if (e.KeyCode == Keys.W)
            {
                container.Move(0, -5, panel1.Width, panel1.Height);
            }

            if (e.KeyCode == Keys.E)
            {
                container.ChangeSize(1, panel1.Width, panel1.Height);
            }

            if (e.KeyCode == Keys.Q)
            {
                container.ChangeSize(-1, panel1.Width, panel1.Height);
            }
            if (e.KeyCode == Keys.G)
            {
                container.Compose(Creation.createCGroup());
            }
            if (e.KeyCode == Keys.R)
            {
                container.unCompose();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) != Keys.Control && ctrlpress == true)
            {
                container.ctrlPressed = !container.ctrlPressed;
                ctrlpress = !ctrlpress;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics.FromImage(map).Clear(Color.White);
            container.Draw();
            pictureBox1.Image = map;
            tStrip1.Refresh();
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics.FromImage(map).Clear(Color.White);
            container.delshapes();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (container.CheckPosition(e.Location) == false && ctrlpress == false)
            {
                if (typeOfShape == 0)
                {
                    container.Add(Creation.createCCircle(e.Location, (int)trBar1.Value, (int)trBar2.Value, (int)trBar3.Value));

                }
                else if (typeOfShape == 1)
                {
                    container.Add(Creation.createSquare(e.Location, (int)trBar1.Value, (int)trBar2.Value, (int)trBar3.Value));
                }
                else if (typeOfShape == 2)
                {
                    container.Add(Creation.createTriangle(e.Location, (int)trBar1.Value, (int)trBar2.Value, (int)trBar3.Value));
                }


            }
            else if (typeOfShape == 3 && container.countSelected() == 2)
            {
                container.AddPointer(Creation.createPointer(e.Location));
            }
            pictureBox1.Invalidate();
            razWidth = this.Width - pictureBox1.Width;
            razHeight = this.Height - pictureBox1.Height;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tsCircle_Click(object sender, EventArgs e)
        {
            typeOfShape = 0;
           // toolStripDropDownButton1.Image = global::ООП_4.Properties.Resources.Circle;
            tStrip1.Refresh();
        }

        private void tsTriangle_Click(object sender, EventArgs e)
        {
            typeOfShape = 2;
            //toolStripDropDownButton1.Image = global::ООП_4.Properties.Resources.Triangle;
            tStrip1.Refresh();
        }

        private void tsQuad_Click(object sender, EventArgs e)
        {
            typeOfShape = 1;
            // toolStripDropDownButton1.Image = global::ООП_4.Properties.Resources.Square;
            tStrip1.Refresh();
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
        {        }

        private void tsSaveBtn_Click(object sender, EventArgs e)
        {
            container.Save();
        }

        private void tsLoadBtn_Click(object sender, EventArgs e)
        {
            CShapeArray array = new CShapeArray(Graphics.FromImage(map));
            container.Load(array);
            container.NotifyEveryone();
        }

        private void tsGroupBtn_Click(object sender, EventArgs e)
        {
            container.Compose(Creation.createCGroup());
        }

        private void tsSingleBtn_Click(object sender, EventArgs e)
        {
            container.unCompose();
        }

        private void tsArrow_Click(object sender, EventArgs e)
        {
            typeOfShape = 3;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            observer.NotifyEveryone();
            if (ctrlpress == false)
                observer.whiteColor();
            e.Node.BackColor = Color.Gray;
        }

        private void pb1_Click(object sender, MouseEventArgs e)
        {
        }
   

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            container.ctrlPressed = !container.ctrlPressed;
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            container.selectMany = !container.selectMany;
        }
    }
    
}
