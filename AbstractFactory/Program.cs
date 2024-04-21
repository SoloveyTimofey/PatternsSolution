using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select which furniture you want to create: " +
                    "\n1. Vintage" +
                    "\n2. Modern");
                int selectionChoice = int.Parse(Console.ReadLine());

                FurnitureFactory furnitureFactory;
                switch (selectionChoice)
                {
                    case 1:
                        furnitureFactory = new VintageFurnitureFactory();
                        break;
                    case 2:
                        furnitureFactory = new ModernFurnitureFactory();
                        break;
                    default:
                        continue;
                }

                Console.WriteLine($"\nActions with just created {furnitureFactory.GetType()} furniture:\n");

                Table table= furnitureFactory.CreateTable();
                Chair chair = furnitureFactory.CreateChair();

                table.Put();
                chair.Sit();

                Console.WriteLine();
            }
        }
    }
}
