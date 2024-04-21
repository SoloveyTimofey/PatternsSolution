using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель
{
    public abstract class Animal
    {
        public abstract void Accept(IVisitor visitor);
    }
}
