using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Команда
{
    public class ATM
    {
        private decimal balance = 100;

        public (bool, string) WithrawMoney(decimal amount)
        {
            (bool, string) valueToReturn;
            if (balance>=amount)
            {
                balance -= amount;
                valueToReturn = (true, $"Withdrawn: {amount}$, Ramining balance: {amount}$");
            }
            else
            {
                valueToReturn = (false, $"Not enough money on balance");
            }

            return valueToReturn;
        }
        public (bool, string) PutMoney(decimal amount)
        {
            balance += amount;

            return (true, $"You have putted {amount}$, Current balance: {balance}$");
        }
    }
}
