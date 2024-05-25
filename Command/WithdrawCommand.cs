using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Команда
{
    public class WithdrawCommand : ICommand
    {
        private readonly ATM _ATM;
        private decimal _amount;
        private ComandStatus _status;
        public WithdrawCommand(ATM atm, decimal amount)
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
                var result = _ATM.WithrawMoney(_amount);
                _status = new ComandStatus(true, result.Item1);
                Console.WriteLine(result.Item2);
            }
        }

        public void Unexecute()
        {
            if ( _status.isExecuted&&_status.isSuccessful==true)
            {
                Console.WriteLine(_ATM.PutMoney(_amount).Item2);
            }
            else
            {
                Console.WriteLine("Error! You cannot do this operation.");
            }
        }
    }
}
