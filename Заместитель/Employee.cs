using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Заместитель
{
    public class Manager:Employee
    {
        public Manager(string name):base(name) { }

        public void MakeNewTask(string product)
        {
            Console.WriteLine($"New task with {product} made by {Name}");
        }

        public override void NewProductArrived(string product)
        {
            MakeNewTask(product);
        }
    }

    public class Loader : Employee
    {
        public Loader(string name):base(name) { }

        public void Unload(string product)
        {
            Console.WriteLine($"{product} unloaded by {Name}");
        }
        public override void NewProductArrived(string product)
        {
            Unload(product);
        }
    }

    public abstract class Employee
    {
        protected Employee(string name)
        {
            this.Name = name;
        }
        public string Name { get;set;}
        public abstract void NewProductArrived(string product);
    }
}
