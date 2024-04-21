using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель
{
    public class Lion : Animal
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitLion(this);
        }
    }
}
