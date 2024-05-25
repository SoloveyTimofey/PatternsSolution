using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель
{
    public class PetVisitor : IVisitor
    {
        public StringBuilder stringBuilder = new StringBuilder();

        public void VisitLion(Lion lion)
        {
            stringBuilder.AppendLine("Stroked lion");
        }

        public void VisitMonkey(Monkey monkey)
        {
            stringBuilder.AppendLine("Stroked monkey");
        }
    }
}
