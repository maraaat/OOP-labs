namespace Project
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxMultiSelection = new System.Windows.Forms.CheckBox();
            this.checkBoxCtrl = new System.Windows.Forms.CheckBox();
            this.treeViewShapes = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSaveBtn = new System.Windows.Forms.ToolStripButton();
            this.tsLoadBtn = new System.Windows.Forms.ToolStripButton();
            this.tsGroupBtn = new System.Windows.Forms.ToolStripButton();
            this.tsUngroupBtn = new System.Windows.Forms.ToolStripButton();
            this.tsCnctBtn = new System.Windows.Forms.ToolStripButton();
            this.tsDiscnctBtn = new System.Windows.Forms.ToolStripButton();
            this.tsShapes = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsCircleShape = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTriangleShape = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQuadShape = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxDrawFigure = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxMultiSelection
            // 
            this.checkBoxMultiSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMultiSelection.BackColor = System.Drawing.Color.Teal;
            this.checkBoxMultiSelection.Location = new System.Drawing.Point(793, 623);
            this.checkBoxMultiSelection.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxMultiSelection.Name = "checkBoxMultiSelection";
            this.checkBoxMultiSelection.Size = new System.Drawing.Size(101, 28);
            this.checkBoxMultiSelection.TabIndex = 2;
            this.checkBoxMultiSelection.Text = "Select MANY";
            this.checkBoxMultiSelection.UseVisualStyleBackColor = false;
            this.checkBoxMultiSelection.CheckedChanged += new System.EventHandler(this.checkBoxMultiSelection_CheckedChanged);
            this.checkBoxMultiSelection.Click += new System.EventHandler(this.checkBoxMultiSelection_Click);
            // 
            // checkBoxCtrl
            // 
            this.checkBoxCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCtrl.BackColor = System.Drawing.Color.Teal;
            this.checkBoxCtrl.Location = new System.Drawing.Point(666, 623);
            this.checkBoxCtrl.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCtrl.Name = "checkBoxCtrl";
            this.checkBoxCtrl.Size = new System.Drawing.Size(101, 28);
            this.checkBoxCtrl.TabIndex = 1;
            this.checkBoxCtrl.Text = "Use CTRL";
            this.checkBoxCtrl.UseVisualStyleBackColor = false;
            this.checkBoxCtrl.CheckedChanged += new System.EventHandler(this.checkBoxCtrl_CheckedChanged);
            this.checkBoxCtrl.Click += new System.EventHandler(this.checkBoxCtrl_Click);
            // 
            // treeViewShapes
            // 
            this.treeViewShapes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewShapes.CheckBoxes = true;
            this.treeViewShapes.FullRowSelect = true;
            this.treeViewShapes.HideSelection = false;
            this.treeViewShapes.Location = new System.Drawing.Point(915, 272);
            this.treeViewShapes.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewShapes.Name = "treeViewShapes";
            this.treeViewShapes.Size = new System.Drawing.Size(152, 277);
            this.treeViewShapes.TabIndex = 10;
            this.treeViewShapes.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewShapes_AfterCheck);
            this.treeViewShapes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewShapes_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Teal;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSaveBtn,
            this.tsLoadBtn,
            this.tsGroupBtn,
            this.tsUngroupBtn,
            this.tsCnctBtn,
            this.tsDiscnctBtn,
            this.tsShapes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1095, 57);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsSaveBtn
            // 
            this.tsSaveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSaveBtn.Image = global::Project.Properties.Resources.save_78935;
            this.tsSaveBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSaveBtn.Name = "tsSaveBtn";
            this.tsSaveBtn.Size = new System.Drawing.Size(52, 54);
            this.tsSaveBtn.Text = "toolStripButton1";
            this.tsSaveBtn.Click += new System.EventHandler(this.tsSaveBtn_Click);
            // 
            // tsLoadBtn
            // 
            this.tsLoadBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLoadBtn.Image = global::Project.Properties.Resources.load_39552;
            this.tsLoadBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLoadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLoadBtn.Name = "tsLoadBtn";
            this.tsLoadBtn.Size = new System.Drawing.Size(52, 54);
            this.tsLoadBtn.Text = "toolStripButton2";
            this.tsLoadBtn.Click += new System.EventHandler(this.tsLoadBtn_Click);
            // 
            // tsGroupBtn
            // 
            this.tsGroupBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsGroupBtn.Image = global::Project.Properties.Resources.connect_icon_161112;
            this.tsGroupBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsGroupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGroupBtn.Name = "tsGroupBtn";
            this.tsGroupBtn.Size = new System.Drawing.Size(52, 54);
            this.tsGroupBtn.Text = "toolStripButton3";
            this.tsGroupBtn.Click += new System.EventHandler(this.tsGroupBtn_Click);
            // 
            // tsUngroupBtn
            // 
            this.tsUngroupBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUngroupBtn.Image = global::Project.Properties.Resources.matric_binary_icon_161120;
            this.tsUngroupBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsUngroupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUngroupBtn.Name = "tsUngroupBtn";
            this.tsUngroupBtn.Size = new System.Drawing.Size(52, 54);
            this.tsUngroupBtn.Text = "toolStripButton4";
            this.tsUngroupBtn.Click += new System.EventHandler(this.tsUngroupBtn_Click);
            // 
            // tsCnctBtn
            // 
            this.tsCnctBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCnctBtn.Image = global::Project.Properties.Resources.arrows_in_line_vertical_icon_175412;
            this.tsCnctBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCnctBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCnctBtn.Name = "tsCnctBtn";
            this.tsCnctBtn.Size = new System.Drawing.Size(52, 54);
            this.tsCnctBtn.Text = "toolStripButton5";
            this.tsCnctBtn.Click += new System.EventHandler(this.tsCnctBtn_Click);
            // 
            // tsDiscnctBtn
            // 
            this.tsDiscnctBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDiscnctBtn.Image = global::Project.Properties.Resources.arrows_out_line_vertical_icon_172675;
            this.tsDiscnctBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsDiscnctBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDiscnctBtn.Name = "tsDiscnctBtn";
            this.tsDiscnctBtn.Size = new System.Drawing.Size(52, 54);
            this.tsDiscnctBtn.Text = "toolStripButton6";
            this.tsDiscnctBtn.Click += new System.EventHandler(this.tsDiscnctBtn_Click);
            // 
            // tsShapes
            // 
            this.tsShapes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsShapes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCircleShape,
            this.tsTriangleShape,
            this.tsQuadShape});
            this.tsShapes.Image = global::Project.Properties.Resources.icons8_полнолуние_50;
            this.tsShapes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsShapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsShapes.Name = "tsShapes";
            this.tsShapes.Size = new System.Drawing.Size(63, 54);
            this.tsShapes.Text = "toolStripDropDownButton1";
            // 
            // tsCircleShape
            // 
            this.tsCircleShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCircleShape.Image = global::Project.Properties.Resources.icons8_полнолуние_50;
            this.tsCircleShape.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCircleShape.Name = "tsCircleShape";
            this.tsCircleShape.Size = new System.Drawing.Size(112, 56);
            this.tsCircleShape.Text = "f";
            this.tsCircleShape.Click += new System.EventHandler(this.tsCircleShape_Click);
            // 
            // tsTriangleShape
            // 
            this.tsTriangleShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsTriangleShape.Image = global::Project.Properties.Resources.icons8_треугольник_50;
            this.tsTriangleShape.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsTriangleShape.Name = "tsTriangleShape";
            this.tsTriangleShape.Size = new System.Drawing.Size(112, 56);
            this.tsTriangleShape.Text = "f";
            this.tsTriangleShape.Click += new System.EventHandler(this.tsTriangleShape_Click);
            // 
            // tsQuadShape
            // 
            this.tsQuadShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsQuadShape.Image = global::Project.Properties.Resources.icons8_стоп_50;
            this.tsQuadShape.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsQuadShape.Name = "tsQuadShape";
            this.tsQuadShape.Size = new System.Drawing.Size(112, 56);
            this.tsQuadShape.Text = "f";
            this.tsQuadShape.Click += new System.EventHandler(this.tsQuadShape_Click);
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxColor.Location = new System.Drawing.Point(911, 76);
            this.pictureBoxColor.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(142, 45);
            this.pictureBoxColor.TabIndex = 6;
            this.pictureBoxColor.TabStop = false;
            // 
            // pictureBoxDrawFigure
            // 
            this.pictureBoxDrawFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDrawFigure.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxDrawFigure.Location = new System.Drawing.Point(28, 76);
            this.pictureBoxDrawFigure.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDrawFigure.Name = "pictureBoxDrawFigure";
            this.pictureBoxDrawFigure.Size = new System.Drawing.Size(856, 527);
            this.pictureBoxDrawFigure.TabIndex = 0;
            this.pictureBoxDrawFigure.TabStop = false;
            this.pictureBoxDrawFigure.Click += new System.EventHandler(this.pictureBoxDrawFigure_Click);
            this.pictureBoxDrawFigure.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDrawFigure_Paint);
            this.pictureBoxDrawFigure.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawFigure_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(934, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Удалить все";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Location = new System.Drawing.Point(911, 126);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(142, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar2.Location = new System.Drawing.Point(911, 171);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(142, 45);
            this.trackBar2.TabIndex = 16;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar3.Location = new System.Drawing.Point(911, 211);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(142, 45);
            this.trackBar3.TabIndex = 17;
            this.trackBar3.ValueChanged += new System.EventHandler(this.trackBar3_ValueChanged);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1095, 695);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.treeViewShapes);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.checkBoxMultiSelection);
            this.Controls.Add(this.checkBoxCtrl);
            this.Controls.Add(this.pictureBoxDrawFigure);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDrawFigure;
        private System.Windows.Forms.CheckBox checkBoxMultiSelection;
        private System.Windows.Forms.CheckBox checkBoxCtrl;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.TreeView treeViewShapes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsSaveBtn;
        private System.Windows.Forms.ToolStripButton tsLoadBtn;
        private System.Windows.Forms.ToolStripButton tsGroupBtn;
        private System.Windows.Forms.ToolStripButton tsUngroupBtn;
        private System.Windows.Forms.ToolStripButton tsCnctBtn;
        private System.Windows.Forms.ToolStripButton tsDiscnctBtn;
        private System.Windows.Forms.ToolStripDropDownButton tsShapes;
        private System.Windows.Forms.ToolStripMenuItem tsCircleShape;
        private System.Windows.Forms.ToolStripMenuItem tsTriangleShape;
        private System.Windows.Forms.ToolStripMenuItem tsQuadShape;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
    }
}

