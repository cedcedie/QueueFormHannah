using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueFormHannah
{
    public partial class LineForm : Form
    {
        private Timer timer;
        public LineForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }
        private void DisplayNextInQueue()
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                label1.Text = CashierClass.CashierQueue.Peek();
            }
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            DisplayNextInQueue();
        }
    }
}