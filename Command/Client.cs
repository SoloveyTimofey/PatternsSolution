using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Команда
{
    public class Client
    {
        private readonly Stack<ICommand> transactions = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            transactions.Push(command);
        }

        public void UnexecuteLastTransaction()
        {
            if (transactions.Count>0)
            {
                ICommand lastTransaction = transactions.Pop();
                lastTransaction.Unexecute();
            }
            else
            {
                Console.WriteLine("You haven't made any trnsaction yet.");
            }
        }
    }
}
