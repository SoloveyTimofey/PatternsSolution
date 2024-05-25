using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Компоновщик
{
    public abstract class FileSystemItem
    {
        protected string name;
        protected FileSystemItem owner;

        protected FileSystemItem(string name, FileSystemItem owner)
        {
            this.name = name;
            this.owner = owner;
        }

        public virtual void Add(FileSystemItem item) { }
        public virtual void Remove(FileSystemItem item) { }
        public abstract void Display();
        public FileSystemItem GetOwner() => owner;
    }
}
