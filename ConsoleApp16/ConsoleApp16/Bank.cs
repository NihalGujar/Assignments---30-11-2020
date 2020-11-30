using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Bank
    {
        int rs;
        int Netbalance;
        public int NetBalance
        {
            get { return Netbalance; }
            set { Netbalance = value; }
        }

        public Bank(int rs)
        {
            this.rs = rs;
        }
        public void deposit()
        {
            Netbalance = Netbalance + rs;
            Console.WriteLine(Netbalance);
            
            //Console.WriteLine("task one");

        }

        public void withdrawal()
        {
            Netbalance = Netbalance - rs;
            Console.WriteLine(Netbalance);
            //Console.WriteLine("task two");
        }
    }
}
