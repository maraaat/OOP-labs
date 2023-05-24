namespace OOP_FOURTH_LAB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.tStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsFigure = new System.Windows.Forms.ToolStripSplitButton();
            this.tsCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTriangle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQuad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveBtn = new System.Windows.Forms.ToolStripButton();
            this.tsLoadBtn = new System.Windows.Forms.ToolStripButton();
            this.tsGroupBtn = new System.Windows.Forms.ToolStripButton();
            this.tsSingleBtn = new System.Windows.Forms.ToolStripButton();
            this.tsArrow = new System.Windows.Forms.ToolStripButton();
            this.TextColor = new System.Windows.Forms.Button();
            this.trBar1 = new System.Windows.Forms.TrackBar();
            this.trBar2 = new System.Windows.Forms.TrackBar();
            this.trBar3 = new System.Windows.Forms.TrackBar();
            this.treeV1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBar3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(884, 565);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(967, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear all";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb1
            // 
            this.cb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb1.AutoSize = true;
            this.cb1.BackColor = System.Drawing.Color.Teal;
            this.cb1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb1.Location = new System.Drawing.Point(946, 60);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(129, 24);
            this.cb1.TabIndex = 2;
            this.cb1.Text = "OnlyOneObject";
            this.cb1.UseVisualStyleBackColor = false;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb2.AutoSize = true;
            this.cb2.BackColor = System.Drawing.Color.Teal;
            this.cb2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb2.Location = new System.Drawing.Point(946, 90);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(108, 24);
            this.cb2.TabIndex = 3;
            this.cb2.Text = "Select many";
            this.cb2.UseVisualStyleBackColor = false;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged);
            // 
            // tStrip1
            // 
            this.tStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFigure,
            this.tsSaveBtn,
            this.tsLoadBtn,
            this.tsGroupBtn,
            this.tsSingleBtn,
            this.tsArrow,
            this.toolStripButton1});
            this.tStrip1.Location = new System.Drawing.Point(0, 0);
            this.tStrip1.Name = "tStrip1";
            this.tStrip1.Size = new System.Drawing.Size(1132, 57);
            this.tStrip1.TabIndex = 4;
            this.tStrip1.Text = "toolStrip1";
            // 
            // tsFigure
            // 
            this.tsFigure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFigure.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCircle,
            this.tsTriangle,
            this.tsQuad});
            this.tsFigure.Image = ((System.Drawing.Image)(resources.GetObject("tsFigure.Image")));
            this.tsFigure.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsFigure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFigure.Name = "tsFigure";
            this.tsFigure.Size = new System.Drawing.Size(66, 54);
            this.tsFigure.Text = "toolStripSplitButton1";
            // 
            // tsCircle
            // 
            this.tsCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCircle.Image = global::OOP_SIXTH_LAB.Properties.Resources.icons8_полнолуние_50;
            this.tsCircle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCircle.Name = "tsCircle";
            this.tsCircle.Size = new System.Drawing.Size(214, 56);
            this.tsCircle.Text = "f";
            this.tsCircle.Click += new System.EventHandler(this.tsCircle_Click);
            // 
            // tsTriangle
            // 
            this.tsTriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsTriangle.Image = global::OOP_SIXTH_LAB.Properties.Resources.icons8_треугольник_50;
            this.tsTriangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsTriangle.Name = "tsTriangle";
            this.tsTriangle.Size = new System.Drawing.Size(214, 56);
            this.tsTriangle.Text = "f";
            this.tsTriangle.Click += new System.EventHandler(this.tsTriangle_Click);
            // 
            // tsQuad
            // 
            this.tsQuad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsQuad.Image = global::OOP_SIXTH_LAB.Properties.Resources.icons8_стоп_50;
            this.tsQuad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsQuad.Name = "tsQuad";
            this.tsQuad.Size = new System.Drawing.Size(214, 56);
            this.tsQuad.Text = "f";
            this.tsQuad.Click += new System.EventHandler(this.tsQuad_Click);
            // 
            // tsSaveBtn
            // 
            this.tsSaveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSaveBtn.Image = global::OOP_SIXTH_LAB.Properties.Resources.save_78935;
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
            this.tsLoadBtn.Image = global::OOP_SIXTH_LAB.Properties.Resources.load_39552;
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
            this.tsGroupBtn.Image = global::OOP_SIXTH_LAB.Properties.Resources.connect_icon_161112;
            this.tsGroupBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsGroupBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGroupBtn.Name = "tsGroupBtn";
            this.tsGroupBtn.Size = new System.Drawing.Size(52, 54);
            this.tsGroupBtn.Text = "toolStripButton3";
            this.tsGroupBtn.Click += new System.EventHandler(this.tsGroupBtn_Click);
            // 
            // tsSingleBtn
            // 
            this.tsSingleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSingleBtn.Image = global::OOP_SIXTH_LAB.Properties.Resources.matric_binary_icon_161120;
            this.tsSingleBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSingleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSingleBtn.Name = "tsSingleBtn";
            this.tsSingleBtn.Size = new System.Drawing.Size(52, 54);
            this.tsSingleBtn.Text = "toolStripButton4";
            this.tsSingleBtn.Click += new System.EventHandler(this.tsSingleBtn_Click);
            // 
            // tsArrow
            // 
            this.tsArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsArrow.Image = global::OOP_SIXTH_LAB.Properties.Resources.rightarrow_79765;
            this.tsArrow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsArrow.Name = "tsArrow";
            this.tsArrow.Size = new System.Drawing.Size(52, 54);
            this.tsArrow.Text = "toolStripButton1";
            this.tsArrow.Click += new System.EventHandler(this.tsArrow_Click);
            // 
            // TextColor
            // 
            this.TextColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextColor.Location = new System.Drawing.Point(946, 120);
            this.TextColor.Name = "TextColor";
            this.TextColor.Size = new System.Drawing.Size(164, 43);
            this.TextColor.TabIndex = 8;
            this.TextColor.UseVisualStyleBackColor = false;
            // 
            // trBar1
            // 
            this.trBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trBar1.Location = new System.Drawing.Point(947, 169);
            this.trBar1.Maximum = 255;
            this.trBar1.Name = "trBar1";
            this.trBar1.Size = new System.Drawing.Size(163, 45);
            this.trBar1.TabIndex = 9;
            this.trBar1.ValueChanged += new System.EventHandler(this.trBar1_ValueChanged);
            // 
            // trBar2
            // 
            this.trBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trBar2.Location = new System.Drawing.Point(947, 204);
            this.trBar2.Maximum = 255;
            this.trBar2.Name = "trBar2";
            this.trBar2.Size = new System.Drawing.Size(163, 45);
            this.trBar2.TabIndex = 10;
            this.trBar2.ValueChanged += new System.EventHandler(this.trBar2_ValueChanged);
            // 
            // trBar3
            // 
            this.trBar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trBar3.Location = new System.Drawing.Point(947, 240);
            this.trBar3.Maximum = 255;
            this.trBar3.Name = "trBar3";
            this.trBar3.Size = new System.Drawing.Size(163, 45);
            this.trBar3.TabIndex = 11;
            this.trBar3.ValueChanged += new System.EventHandler(this.trBar3_ValueChanged);
            // 
            // treeV1
            // 
            this.treeV1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.treeV1.FullRowSelect = true;
            this.treeV1.HideSelection = false;
            this.treeV1.Location = new System.Drawing.Point(937, 282);
            this.treeV1.Name = "treeV1";
            this.treeV1.ShowPlusMinus = false;
            this.treeV1.Size = new System.Drawing.Size(183, 278);
            this.treeV1.TabIndex = 12;
            this.treeV1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel1.Location = new System.Drawing.Point(43, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 563);
            this.panel1.TabIndex = 13;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 54);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeV1);
            this.Controls.Add(this.trBar3);
            this.Controls.Add(this.trBar2);
            this.Controls.Add(this.trBar1);
            this.Controls.Add(this.TextColor);
            this.Controls.Add(this.tStrip1);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.button1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tStrip1.ResumeLayout(false);
            this.tStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBar3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private PictureBox pictureBox1;
        private CheckBox cb1;
        private CheckBox cb2;
        private ToolStrip tStrip1;
        private ToolStripSplitButton tsFigure;
        private ToolStripMenuItem tsCircle;
        private ToolStripMenuItem tsTriangle;
        private ToolStripMenuItem tsQuad;
        private Button TextColor;
        private TrackBar trBar1;
        private TrackBar trBar2;
        private TrackBar trBar3;
        private ToolStripButton tsSaveBtn;
        private ToolStripButton tsLoadBtn;
        private ToolStripButton tsGroupBtn;
        private ToolStripButton tsSingleBtn;
        private ToolStripButton tsArrow;
        private TreeView treeV1;
        private Panel panel1;
        private ToolStripButton toolStripButton1;
    }
}