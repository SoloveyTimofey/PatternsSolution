using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Стартегия
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 4, 4, 3, 4, 54 };

            Sorter sorter = new Sorter(new BubbleSortStrategy());

            sorter.Sort(arr);

            sorter.SetSortStrategy(new InsertionSortStrategy());

            sorter.Sort(arr);

            Console.ReadLine();
        }
    }
}
