using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посредник.Mediator
{
    public class ChatMediator : IChatMediator
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void SendMessage(User sender, string message)
        {
            foreach (User user in users)
            {
                if (user!=sender)
                {
                    user.ReceiveMessage(sender,message);
                }
            }
        }
    }
}
