using System;
using System.Collections.Generic;
using System.Text;

namespace PROG_ICE_TASK_4
{
    class ProcessOrder
    {
        public delegate void processOrderDelegate(Order o); // delegate

        public event processOrderDelegate OrderSubmitted; // event 


        public void processTheOrder(Order o) 
        {
            CashierService cs = new CashierService();
            BaristaService bs = new BaristaService();
            DonutierService ds = new DonutierService();
            DBServices dbs = new DBServices();

            OrderSubmitted += cs.collectPayment;
            OrderSubmitted += bs.makeCoffee;
            OrderSubmitted += ds.packDonuts;
            OrderSubmitted += dbs.writeToDB;




            //// lets cashier know to collect cash:
            //cs.collectPayment(o);
            //// lets barister know to make coffee:
            //bs.makeCoffee(o);
            //// lets donutier know to pack donuts:
            //ds.packDonuts(o);
          
            OnOrderSubmitted(o);
        }

        protected virtual void OnOrderSubmitted(Order o) 
        {
            if (OrderSubmitted!= null) 
            {
                OrderSubmitted(o);
            }
        }
    }
}
