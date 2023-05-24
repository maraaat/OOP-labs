using Project.Source.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Project.Source;
using System.Runtime.InteropServices;
using Project.Source.Utils.AbstractFactory;

namespace Project
{
    public partial class FormMain : Form
    {
        // Списко фигур-прототипов
        private readonly List<Shape> prototypes = new List<Shape>() { new CCircle(), new CQuad(), new CTriangle() };
        Shape shape;
        // Контейнер, хранящий фигуры и мтоды работы с ними
        private Project.Source.Container shapes = new Project.Source.Container();
        private Tree tree;

        private const int step = 10;
        private const int size = 10;

        public FormMain()
        {
            InitializeComponent();
            //pictureBoxColor.BackColor = colorDialogShapes.Color;
            tree = new Tree(treeViewShapes);
            shapes.addObserver(tree);
            tree.addObserver(shapes);
        }

        private void pictureBoxDrawFigure_MouseDown(object sender, MouseEventArgs e)
        {
            // Проверяем, если не попали ни в одну фигуру, то создаём новую
            // Пока что используя (или патаясь использовать) паттерн прототип :)
            if (!shapes.inShapeContainer(e.X, e.Y))
            {
                shapes.addNewShape(shape, e.X-15, e.Y-15);
            }
            shapes.bindShapes();
            shapes.notify();
            pictureBoxDrawFigure.Refresh();
            treeViewShapes.Refresh();
        }

        // Если нажата клавиша delete - удаляет фигуру, ctrl - устанавливает флаг ctrl
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Delete:
                    shapes.removeSelctions();
                    shapes.notify();
                    pictureBoxDrawFigure.Refresh();
                    break;
                case Keys.ControlKey:
                    shapes.setCtrl(true, checkBoxCtrl);
                    break;
                case Keys.A:
                    shapes.moveX(-step, pictureBoxDrawFigure.Location.X, pictureBoxDrawFigure.Width);
                    pictureBoxDrawFigure.Refresh();
                    break;
                case Keys.D:
                    shapes.moveX(step, pictureBoxDrawFigure.Location.X, pictureBoxDrawFigure.Width);
                    pictureBoxDrawFigure.Refresh();
                    break;
                case Keys.S:
                    shapes.moveY(step, pictureBoxDrawFigure.Location.Y, pictureBoxDrawFigure.Height);
                    pictureBoxDrawFigure.Refresh();
                    break;
                case Keys.W:
                    shapes.moveY(-step, pictureBoxDrawFigure.Location.Y, pictureBoxDrawFigure.Height);
                    pictureBoxDrawFigure.Refresh();
                    break;
                case Keys.E:
                    shapes.changeSizeShapes(size);
                    pictureBoxDrawFigure.Refresh();
                    break;
                case Keys.Q:
                    shapes.changeSizeShapes(-size);
                    pictureBoxDrawFigure.Refresh();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            // Если отпущена кнопка ctrl, флаг "выключается" = false
            if (e.KeyCode == Keys.ControlKey)
                shapes.setCtrl(false, checkBoxCtrl);
        }

        private void pictureBoxDrawFigure_Paint(object sender, PaintEventArgs e)
        {
            shapes.drawShapes(e.Graphics);
        }

        private void checkBoxCtrl_Click(object sender, EventArgs e)
        {
            // Если галочка поставлена - ctrl включен
            shapes.setCtrl(((sender as CheckBox).Checked));
        }

        private void checkBoxMultiSelection_Click(object sender, EventArgs e)
        {
            shapes.setMultiSelection();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //string filepath = "saves.txt";
            //shapes.saveShapes(filepath);
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            //string filepath = "saves.txt";
            //IAbstractFactory factory = new CAbstractFactory();
            //shapes.loadShapes(filepath, factory);
            //shapes.notify();
        }

        private void treeViewShapes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tree.notify();
            Refresh();
        }



        private void treeViewShapes_AfterCheck(object sender, TreeViewEventArgs e)
        {
            tree.notify();
            Refresh();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void tsGroupBtn_Click(object sender, EventArgs e)
        {
            shapes.groupShapes();
            shapes.notify();
            pictureBoxDrawFigure.Refresh();
        }

        private void tsUngroupBtn_Click(object sender, EventArgs e)
        {
            shapes.ungroupShapes();
            shapes.notify();
            pictureBoxDrawFigure.Refresh();
        }

        private void tsCnctBtn_Click(object sender, EventArgs e)
        {
            shapes.bind();
        }

        private void tsDiscnctBtn_Click(object sender, EventArgs e)
        {
            shapes.deleteLine();
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shapes.removeAllSelctions();
            shapes.notify();
            pictureBoxDrawFigure.Refresh();
        }

        private void tsCircleShape_Click(object sender, EventArgs e)
        {
            shape = prototypes[0];
            tsShapes.Image = tsCircleShape.Image;
        }

        private void tsTriangleShape_Click(object sender, EventArgs e)
        {
            shape = prototypes[2];
            tsShapes.Image = tsTriangleShape.Image;
        }

        private void tsQuadShape_Click(object sender, EventArgs e)
        {
            shape = prototypes[1];
            tsShapes.Image = tsQuadShape.Image;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pictureBoxColor.BackColor = Color.FromArgb((int)trackBar1.Value, (int)trackBar2.Value, (int)trackBar3.Value);
            shapes.setShapesColor(Color.FromArgb((int)trackBar1.Value, (int)trackBar2.Value, (int)trackBar3.Value));
            pictureBoxDrawFigure.Refresh();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            pictureBoxColor.BackColor = Color.FromArgb((int)trackBar1.Value, (int)trackBar2.Value, (int)trackBar3.Value);
            shapes.setShapesColor(Color.FromArgb((int)trackBar1.Value, (int)trackBar2.Value, (int)trackBar3.Value));
            pictureBoxDrawFigure.Refresh();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            pictureBoxColor.BackColor = Color.FromArgb((int)trackBar1.Value, (int)trackBar2.Value, (int)trackBar3.Value);
            shapes.setShapesColor(Color.FromArgb((int)trackBar1.Value, (int)trackBar2.Value, (int)trackBar3.Value));
            pictureBoxDrawFigure.Refresh();
        }

        private void checkBoxMultiSelection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCtrl_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxDrawFigure_Click(object sender, EventArgs e)
        {

        }

        private void tsSaveBtn_Click(object sender, EventArgs e)
        {
            string filepath = "saves.txt";
            shapes.saveShapes(filepath);
        }

        private void tsLoadBtn_Click(object sender, EventArgs e)
        {
            string filepath = "saves.txt";
            IAbstractFactory factory = new CAbstractFactory();
            shapes.loadShapes(filepath, factory);
            shapes.notify();
            Refresh();
        }
    }
}