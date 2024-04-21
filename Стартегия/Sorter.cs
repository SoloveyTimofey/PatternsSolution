using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Стартегия
{
    public class Sorter
    {
        ISortMethod sortMethod;
        public Sorter(ISortMethod sortMethod)
        {
            this.sortMethod = sortMethod;
        }

        public void Sort(int[] array)
        {
            sortMethod.Sort(array);
        }

        public void SetSortStrategy(ISortMethod sortMethod)
        {
            this.sortMethod = sortMethod;
        }
    }
}
