using System;
using System.Collections.Generic;
using System.Text;

namespace PROG_ICE_TASK_4
{
    class Order
    {
        public Order()
        {
        }
        //
        public Order(string name, int donuts, int coffee)
        {
            Name = name;
            Donuts = donuts;
            Coffee = coffee;
        }
        // getters and setters of fields:
        public string Name { get; set; }
        public int Donuts { get; set; }
        public int Coffee { get; set; }
        //
        //
        //
        //
        public override string ToString() // ovrride method
        {
            return this.Name + ":" + this.Donuts + "donuts &" + this.Coffee + "coffee";
        }
    }
}
