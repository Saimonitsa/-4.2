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
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar2.Scroll += trackBar2_Scroll;
            trackBar3.Scroll += trackBar3_Scroll;

            textBox1.DataBindings.Add("Text", Properties.Settings.Default, "a");
            textBox2.DataBindings.Add("Text", Properties.Settings.Default, "b");
            textBox3.DataBindings.Add("Text", Properties.Settings.Default, "c");


            numericUpDown1.DataBindings.Add("Text", Properties.Settings.Default, "a");
            numericUpDown2.DataBindings.Add("Text", Properties.Settings.Default, "b");
            numericUpDown3.DataBindings.Add("Text", Properties.Settings.Default, "c");

            trackBar1.DataBindings.Add("Text", Properties.Settings.Default, "a");
            trackBar2.DataBindings.Add("Text", Properties.Settings.Default, "b");
            trackBar3.DataBindings.Add("Text", Properties.Settings.Default, "c");

            this.FormClosing += (o, e) => Properties.Settings.Default.Save();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setA(Convert.ToInt32(textBox1.Text));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            model.setA(Decimal.ToInt32(numericUpDown1.Value));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            model.setA(Decimal.ToInt32(trackBar1.Value));
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setB(Convert.ToInt32(textBox2.Text));
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            model.setB(Decimal.ToInt32(numericUpDown2.Value));
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            model.setB(Decimal.ToInt32(trackBar2.Value));
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setC(Convert.ToInt32(textBox3.Text));
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            model.setC(Decimal.ToInt32(numericUpDown3.Value));
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            model.setC(Decimal.ToInt32(trackBar3.Value));
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
