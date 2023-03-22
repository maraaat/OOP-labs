using System.Diagnostics.Metrics;

namespace OOP_FOURTH_LAB_2
{
    public partial class MVC : Form
    {
        Model model1;

        public MVC()
        {
            InitializeComponent();
            model1 = new Model();
            model1.observers += new System.EventHandler(this.UpdateFromModel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            model1.setA(Properties.Settings.Default.A);
            model1.setB(Properties.Settings.Default.B);
            model1.setC(Properties.Settings.Default.C);
        }
        private void MVC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.A = model1.getA();
            Properties.Settings.Default.B = model1.getB();
            Properties.Settings.Default.C = model1.getC();
            Properties.Settings.Default.Save();
        }
        private void l1_Click(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
           // model1.setA(Int32.Parse(tb1.Text));
        }

        private void trBar1_Scroll(object sender, EventArgs e)
        {
           
        }

        private void traBar1_Scroll(object sender, EventArgs e)
        {
            model1.setA(traBar1.Value);
        }

        private void trBar2_Scroll(object sender, EventArgs e)
        {
            model1.setB(trBar2.Value);
        }

        private void trBar3_Scroll(object sender, EventArgs e)
        {
            model1.setC(trBar3.Value);
        }

        private void tb1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model1.setA(Int32.Parse(tb1.Text));
            }
        }
        private void tb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model1.setB(Int32.Parse(tb2.Text));
            }
        }
        private void tb3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model1.setC(Int32.Parse(tb3.Text));
            }
        }

        private void nud1_ValueChanged(object sender, EventArgs e)
        {
            model1.setA((int)(nud1.Value));
        }

        private void nud2_ValueChanged(object sender, EventArgs e)
        {
            model1.setB((int)(nud2.Value));
        }

        private void nud3_ValueChanged(object sender, EventArgs e)
        {
            model1.setC((int)(nud3.Value));
        }


        private void UpdateFromModel(object sender, EventArgs e)
        {
            tb1.Text = model1.getA().ToString();
            nud1.Text = model1.getA().ToString();
            traBar1.Value = model1.getA();

            tb2.Text = model1.getB().ToString();
            nud2.Text = model1.getB().ToString();
            trBar2.Value = model1.getB();

            tb3.Text = model1.getC().ToString();
            nud3.Text = model1.getC().ToString();
            trBar3.Value = model1.getC();
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
        }

       
    }

    public class Model
    {
        private int A;
        private int B;
        private int C;

        public System.EventHandler observers;
        public int checkvalue(int value)
        {
            if (value < 0)
            {
                return 0;
            }
            else if (value > 100)
            {
                return 100;
            }
            return value;
        }

        public void setA(int a)
        {
           a = checkvalue(a);
           if (a>C)
            {
                C = a;
            }
           if (a>B)
            {
                B = a;
            }
            A = a;
            observers.Invoke(this, null);
        }
        public void setB(int b)
        {
            b = checkvalue(b);
            if (b < A)
            {
                B = A;
            }
            else if (b > C)
            {
                B = C;
            }
            else
            {
                B = b;
            }
            observers.Invoke(this, null);
        }
        public void setC(int c)
        {
            c = checkvalue(c);
            if (c < A)
            {
                A = c;
            }
            if (c < B)
            {
                B = c;
            }
            C = c;
            observers.Invoke(this, null);
        }
        public int getA()
        {
            return A;
        }
        public int getB()
        {
            return B;
        }
        public int getC()
        {
            return C;
        }
    }
}