using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }
        private void t_Tick(object sender , EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string tim = "";
            if(hh >= 10)
            {
                tim += hh;
            }
            else
            {
                tim += "0" + hh;
            }
            tim += ":";
            if(mm >= 10)
            {
                tim += mm;
            }
            else
            {
                tim += "0" + mm;
            }tim += ":";
            
            if(ss >= 10)
            {
                tim += ss;
            }
            else
            {
                tim += "0" + ss;
            }
            label1.Text = tim;
        }

     
    }
}
