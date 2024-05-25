using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цепочка_обязанностей
{
    public class Advertiser : Employee
    {
        public Advertiser(string name) : base(name)
        {
        }

        public override void NewProductArrived(string product)
        {
            Console.WriteLine($"{product} advertised by {Name}");
        }

        public override string Execute(TypeOfWork command)
        {
            if (command == TypeOfWork.Advertise)
            {
                return $"{Name} did {command}";
            }
            return base.Execute(command);
        }
    }
}
