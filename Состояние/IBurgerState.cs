using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Состояние
{
    public interface IBurgerState
    {
        void Order(Reception reception);
        void Pay(Reception reception);
        void TakeBurger(Reception reception);
        IBurgerState NextState(Reception reception);
        IBurgerState PreviousState(Reception reception);
    }
}
