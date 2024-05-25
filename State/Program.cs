using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Состояние
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reception reception = new Reception();

            reception.Order();
            reception.NextState();
            reception.Pay();
            reception.NextState();
            reception.TakeBurger();

            reception.ResetState();
            Console.WriteLine();

            reception.Order();
            reception.PreviousState();
            reception.NextState();
            reception.Pay();
            reception.NextState();
            reception.TakeBurger();
            reception.PreviousState();

            reception.ResetState();

            Console.ReadLine();
        }
    }
}
