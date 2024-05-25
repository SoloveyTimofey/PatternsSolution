using System;

namespace Цепочка_обязанностей
{
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

        public override string Execute(TypeOfWork command)
        {
            if (command==TypeOfWork.Load)
            {
                return $"{Name} did {command}";
            }
            return base.Execute(command);
        }
    }
}
