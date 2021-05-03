using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_ICE_TASK_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            int donuts = Convert.ToInt32(txbDonuts.Text);
            int coffee = Convert.ToInt32(txbCoffee.Text);

            if (string.IsNullOrEmpty(txbName.Text))
            {
                // error provider if name is left blank:
                errorProvider.SetError(txbName,"Please Enter Name!");

            }
            else
            {
                // error provider disappers if name is entered:
                errorProvider.SetError(txbName,null);

                Order o = new Order(name, donuts, coffee);

                ProcessOrder p = new ProcessOrder();
                p.processTheOrder(o);
            }
        }
    }
}
