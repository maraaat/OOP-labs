﻿using OOP_SIXTH_LAB.Shapes;
using OOP_SIXTH_LAB.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_SIXTH_LAB;
using OOP_FOURTH_LAB;

namespace OOP_SIXTH_LAB.Observer
{
    public class TreeViewObserver : Cobject, Cobserver
    {
        public bool ctrlPressed = false;
        private TreeView _treeView;
        public TreeViewObserver(TreeView treeView)
        {
            _treeView = treeView;
        }

        public string getNameSelected()
        {
            if (_treeView.SelectedNode == null) return "Null";
            return _treeView.SelectedNode.Text;
        }
        public void pushChange()
        {
            NotifyEveryone();
        }
        public void OnSubjectChanged(Cobject obj)
        {
            _treeView.Nodes.Clear();
            TreeNode tn = new TreeNode("Фигуры");
            if (obj is Container o)
                processNode(tn, o.GetShapes());
            _treeView.Nodes.Add(tn);
            _treeView.ExpandAll();
        }

        public void OnSubjectSelect(Cobject obj)
        {
            int i = 0;
            foreach (TreeNode tn in _treeView.Nodes[0].Nodes)
            {
                if (tn.Text == obj.Who())
                {
                    _treeView.SelectedNode = _treeView.Nodes[0].Nodes[i];
                }
                i++;
            }
        }

        private void processNode(TreeNode tn, List<CShape> o)
        {
            // Проходим по объектам в переданной группе
            foreach (CShape oo in o)
            {
                // Создаем новый дочерний узел для текущего объекта
                TreeNode t = new TreeNode(oo.Who());

                if (oo is CDecorator)
                {
                    t.BackColor = System.Drawing.Color.Gray;
                    _treeView.SelectedNode = t;
                }

                // Если объект является группой, то рекурсивно обрабатываем его дочерние объекты
                if (oo is CGroup ooo)
                {
                    processNode(t, ooo.getShapes());
                }

                // Добавляем созданный узел к родительскому узлу
                tn.Nodes.Add(t);
            }
        }

        public void whiteColor()
        {
            processNodeColor(_treeView.Nodes[0]);
        }

        private void processNodeColor(TreeNode tn)
        {
            foreach (TreeNode t in tn.Nodes)
            {
                if (t.Nodes.Count > 1)
                    processNodeColor(t);
                t.BackColor = System.Drawing.Color.White;

            }
        }

        public void OnSubjectMove(int x, int y)
        {
        }

    }
}
