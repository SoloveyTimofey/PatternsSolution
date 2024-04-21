using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Состояние
{
    public class ReadyBurgerState : IBurgerState
    {
        public void Order(Reception reception)
        {
            Console.WriteLine("You've already ordered the burger.");
        }

        public void Pay(Reception reception)
        {
            Console.WriteLine("You've already paid for the burger.");
        }

        public void TakeBurger(Reception reception)
        {
            Console.WriteLine("You successfuly take the burger.");
        }

        public IBurgerState NextState(Reception reception)
        {
            Console.WriteLine("There is no next state.");
            return this;
        }
        public IBurgerState PreviousState(Reception reception)
        {
            Console.WriteLine("Well, we'll return your money.");
            return new OrderingBurgerState();
        }
    }
}
