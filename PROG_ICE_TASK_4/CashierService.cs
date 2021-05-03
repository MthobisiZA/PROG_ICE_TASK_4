using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PROG_ICE_TASK_4
{
    class CashierService
    {
        public void collectPayment(Order o)
        {
            // user or order of user:
            MessageBox.Show("Collecting Payment from "+ o.Name);
        }
    }
}
