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
    public partial class QueueingForm : Form
    {
        private CashierClass cashier;
        private Timer timer;
        public QueueingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            CashierWindowQueueForm cash = new CashierWindowQueueForm();
            cash.Show();
            LineForm line = new LineForm();
            line.Show();
        }
        private void btnCashier_Click_1(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void lblQueue_Click(object sender, EventArgs e)
        {

        }
    }
}
