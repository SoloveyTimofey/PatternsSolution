using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посредник.Mediator
{
    public interface IChatMediator
    {
        void SendMessage(User sender, string message);
        void AddUser(User user);
    }
}
