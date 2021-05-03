using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PROG_ICE_TASK_4
{
    class BaristaService
    {
        public void makeCoffee(Order o)
        {
            // output message for coffee to make:
            MessageBox.Show("Making coffee-"+o.Coffee);
        }
    }
}
