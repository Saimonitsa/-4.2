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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

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

    }
}
