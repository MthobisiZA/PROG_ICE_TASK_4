using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PROG_ICE_TASK_4
{
    class DBServices
    {
        public void writeToDB(Order o) 
        {
            // output to user of what has been ordered:
            MessageBox.Show("Writing to DB: " + o.ToString());
        }
    }
}
