using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PROG_ICE_TASK_4
{
    class DonutierService
    {
        public void packDonuts(Order o)
        {
            //output message for amount of donuts to pack:
            MessageBox.Show("Packing donuts -"+ o.Donuts);
        }
    }
}
