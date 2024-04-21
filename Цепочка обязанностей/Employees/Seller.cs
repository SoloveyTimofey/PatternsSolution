using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цепочка_обязанностей
{
    public class Seller : Employee
    {
        public Seller(string name) : base(name)
        {
        }

        public void Sell(string product)
        {
            Console.WriteLine($"New task with {product} made by {Name}");
        }
        public override void NewProductArrived(string product)
        {
            Sell(product);
        }

        public override string Execute(TypeOfWork command)
        {
            if (command == TypeOfWork.Sell)
            {
                return $"{Name} did {command}";
            }
            return base.Execute(command);
        }
    }
}
