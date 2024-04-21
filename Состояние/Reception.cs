using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Состояние
{
    public class Reception
    {
        private IBurgerState _state;
        public Reception()
        {
            _state = new OrderingBurgerState();
        }
        public void Order()
        {
            _state.Order(this);
        }
        public void Pay()
        {
            _state.Pay(this);
        }
        public void TakeBurger()
        {
            _state.TakeBurger(this);
        }

        public void NextState()
        {
            _state = _state.NextState(this);
        }
        public void PreviousState()
        {
            _state = _state.PreviousState(this);
        }

        public void ResetState()
        {
            _state = new OrderingBurgerState();
        }
    }
}
