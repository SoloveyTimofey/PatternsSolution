using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Посетитель
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Lion(),
                new Monkey(),
                new Lion()
            };

            FeedVisitor feedVisitor = new FeedVisitor();

            foreach (var animal in animals)
            {
                animal.Accept(feedVisitor);
            }
            Console.WriteLine(feedVisitor.stringBuilder);

            PetVisitor petVisitor = new PetVisitor();

            foreach(var animal in animals)
            {
                animal.Accept(petVisitor);
            }
            Console.WriteLine(petVisitor.stringBuilder);

            Console.ReadLine();
        }
    }
}
