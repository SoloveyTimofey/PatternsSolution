using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Компоновщик
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileSystemItem firstDirectory = new Directory("FirstDir", null);

            FileSystemItem secondDirectory = new Directory("SecondDir", firstDirectory);

            secondDirectory.Add(new File("secondImg.jpg", secondDirectory));
            secondDirectory.Add(new File("dirDesc.txt", secondDirectory));

            firstDirectory.Add(new File("img.jpg", firstDirectory));
            firstDirectory.Add(new File("class.cs", firstDirectory));
            firstDirectory.Add(new File("product.cs", firstDirectory));
            firstDirectory.Add(new File("names.json", firstDirectory));

            firstDirectory.Add(secondDirectory);

            FileSystemItem thirdDirectory = new Directory("ThirdDir", secondDirectory);
            thirdDirectory.Add(new File("thirdhDesc", thirdDirectory));
            thirdDirectory.Add(new File("thirdhImg", thirdDirectory));
            FileSystemItem fourthDirectory = new Directory("FourthDir", secondDirectory);

            secondDirectory.Add(thirdDirectory);
            secondDirectory.Add(fourthDirectory);

            firstDirectory.Display();

            Console.WriteLine("\n**** Second Directory **** \n");

            secondDirectory.Display();

            Console.WriteLine("\n**** Second Directory Owner**** \n");
            secondDirectory.GetOwner()?.Display();

            Console.ReadLine();
        }
    }
}
