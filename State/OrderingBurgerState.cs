using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Состояние
{
    public class OrderingBurgerState : IBurgerState
    {
        private bool isOrdered;
        public void Order(Reception reception)
        {
            isOrdered = true;
            Console.WriteLine("You succesfully ordered the burger.");
        }
        public void Pay(Reception reception)
        {
            Console.WriteLine("First orger the burger.");
        }
        public void TakeBurger(Reception reception)
        {
            Console.WriteLine("Burger is ordering. You cannot take it now.");
        }
        public IBurgerState PreviousState(Reception reception)
        {
            Console.WriteLine("There is no previous state.");
            return this;
        }
        public IBurgerState NextState(Reception reception)
        {
            if (isOrdered)
            {
                return new PayingBurgerState();
            }
            else
            {
                Console.WriteLine("You haven't ordered the burger yet.");
                return this;
            }
        }
    }
}
