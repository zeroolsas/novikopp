using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Class1
    {
        public string Name { get; set; }
        public static readonly int MinAge = 1;
        public const string typeName = "Person";

        public Class1(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {Name} {MinAge} {typeName}");
        }
    }
}
