using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Компоновщик
{
    public class Directory : FileSystemItem
    {
        private List<FileSystemItem> children = new List<FileSystemItem>();
        public Directory(string name, FileSystemItem owner):base(name, owner) { }

        public override void Add(FileSystemItem item)
        {
            children.Add(item);
        }

        public override void Remove(FileSystemItem item)
        {
            children.Remove(item);
        }

        public override void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Directory {name}");
            Console.ResetColor();

            foreach (FileSystemItem item in children)
            {
                item.Display();
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
