using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Состояние
{
    public class PayingBurgerState : IBurgerState
    {
        private bool isPaid;
        public void Order(Reception reception)
        {
            Console.WriteLine("You've already ordered the burger.");
        }

        public void Pay(Reception reception)
        {
            isPaid = true;
            Console.WriteLine("You successfuly paid.");
        }

        public void TakeBurger(Reception reception)
        {
            Console.WriteLine("You cannot take the burger now.");
        }

        public IBurgerState PreviousState(Reception reception)
        {
            Console.WriteLine("Okay. Let's get back to ordering.");
            return new OrderingBurgerState();
        }
        public IBurgerState NextState(Reception reception)
        {
            if (isPaid)
            {
                return new ReadyBurgerState();
            }
            else
            {
                Console.WriteLine("You haven't paid for the burger yet.");
                return this;
            }
        }


    }
}
