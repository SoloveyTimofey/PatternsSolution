using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Команда
{
    public class PutCommand : ICommand
    {
        private readonly ATM _ATM;
        private decimal _amount;
        private ComandStatus _status;
        public PutCommand(ATM atm, decimal amount)
        {
            _ATM = atm;
            _amount = amount;
        }
        public void Execute()
        {
            if (_status.isExecuted)
            {
                Console.WriteLine("Error! You have already executed this command.");
            }
            else
            {
                var status = _ATM.PutMoney(_amount);
                _status = new ComandStatus(true, status.Item1);
                Console.WriteLine(status.Item2);
            }
        }

        public void Unexecute()
        {
            if ( _status.isExecuted)
            {
                Console.WriteLine(_ATM.WithrawMoney(_amount).Item2);
            }
            else
            {
                Console.WriteLine("Error! You cannot do this operation.");
            }
        }
    }
}
