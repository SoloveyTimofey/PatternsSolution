using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Команда
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            ATM atm = new ATM();

            client.ExecuteCommand(new WithdrawCommand(atm, 50));
            client.ExecuteCommand(new WithdrawCommand(atm, 52));
            client.UnexecuteLastTransaction();

            Console.WriteLine();
            client.ExecuteCommand(new PutCommand(atm, 100));
            client.UnexecuteLastTransaction();

            Console.ReadLine();
        }
    }
}
