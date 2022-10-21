using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace use_timer_reset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Timer pTimer = new System.Windows.Forms.Timer();

        //public Timer ptimer;

        private void Create_Timer_Click(object sender, EventArgs e)
        {
            pTimer.Interval = 1000;
            pTimer.Tick += new EventHandler(ptimer_Tick);
            pTimer.Enabled = true;
            pTimer.Stop();
        }

        public int nCount = 0;

        private void ptimer_Tick(object sender, EventArgs e)
        {
            label1.Text = $"{++nCount}";
        }

        private void Run_Timer_Click(object sender, EventArgs e)
        {
            pTimer.Start();
        }

        private void ReSet_Timer_Click(object sender, EventArgs e)
        {
            nCount = 0;
        }

        private void Stop_Timer_Click(object sender, EventArgs e)
        {
            pTimer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }
    }
}
