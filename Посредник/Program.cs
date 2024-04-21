using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Посредник.Mediator;

namespace Посредник
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();
            User Bob = new User("Bob", chatMediator);
            User Marley = new User("Marley", chatMediator);
            User Kenedy = new User("Kenedy", chatMediator);
            User Pitter = new User("Pitter", chatMediator);

            Bob.SendMessage("Hello, i am Bob");
            Console.WriteLine();
            Pitter.SendMessage("Helo, i am Pitter");

            Console.ReadLine();
        }
    }
}
