using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Итератор.Iterator;

namespace Итератор
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int[] oneDArr = { 1, 2, 3, 4, 5, 6, 7,8};
            OneDementionalIterator oneDIt = new OneDementionalIterator(oneDArr);

            for (oneDIt.First();oneDIt.IsDone();oneDIt.Next())
            {
                Console.Write(oneDIt.CurrentItem()+"\t");
            }

            Console.WriteLine();
            SkipOddIterator skipOddIt = new SkipOddIterator(oneDArr);

            for (skipOddIt.First();skipOddIt.IsDone();skipOddIt.Next())
            {
                Console.WriteLine(oneDIt.CurrentItem()+"\t");
            }


            Console.ReadLine();
        }
    }
}
