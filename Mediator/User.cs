using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Посредник.Mediator;

namespace Посредник
{
    public class User
    {
        public string Name { get; set; }
        private IChatMediator chatMediator { get; set; }
        public User(string name, IChatMediator chatMediator)
        {
            Name = name;
            this.chatMediator = chatMediator;

            chatMediator.AddUser(this);
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{Name} sends message: {message}");
            chatMediator.SendMessage(this, message);
        }
        public void ReceiveMessage(User sender, string message) 
        {
            Console.WriteLine($"{Name} receives message: {message}\tfrom: {sender.Name}");
        }
    }
}
