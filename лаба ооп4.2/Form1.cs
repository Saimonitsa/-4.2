using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба_ооп4._2
{
    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.observes += new System.EventHandler(this.UpdateFromModel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

        }

        private void UpdateFromModel(object sender, EventArgs e)
        {
            textBox1.Text = model.getA().ToString();
            numericUpDown1.Value = model.getA();
            trackBar1.Value = model.getA();

            textBox2.Text = model.getB().ToString();
            numericUpDown2.Value = model.getB();
            trackBar2.Value = model.getB();

            textBox3.Text = model.getC().ToString();
            numericUpDown3.Value = model.getC();
            trackBar3.Value = model.getC();
        }

    }

    public class Model
    {
        int a, b, c;
        public System.EventHandler observes;
        public void setA(int a)
        {
            if (a > c)
                this.a = c;
            else
                this.a = a;
            Properties.Settings.Default.a = a;
            observes.Invoke(this, null);

        }
        public void setB(int b)
        {
            if (b <= c && b >= a)
                this.b = b;
            else
                this.b = a;
            Properties.Settings.Default.b = b;
            observes.Invoke(this, null);

        }
        public void setC(int c)
        {
            this.c = c;
            Properties.Settings.Default.c = c;
            observes.Invoke(this, null);

        }
        public int getA()
        {
            return a;
        }

        public int getB()
        {
            return b;
        }

        public int getC()
        {
            return c;
        }


    }
}
