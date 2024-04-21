using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компоновщик
{
    public class File : FileSystemItem
    {
        public File(string name, FileSystemItem owner) : base(name, owner) { }
        public override void Display()
        {
            Console.WriteLine($"Name: {name}\tOwner: {owner}");
        }

        public override void Add(FileSystemItem item)
        {
            throw new NotImplementedException();
        }

        public override void Remove(FileSystemItem item)
        {
            throw new NotImplementedException();
        }
    }
}
