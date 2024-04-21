using System;

namespace Цепочка_обязанностей
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

        public override string Execute(TypeOfWork command)
        {
            if(command==TypeOfWork.Manage)
            {
                return $"{Name} did {command}";
            }
            return base.Execute(command);
        }
    }
}
