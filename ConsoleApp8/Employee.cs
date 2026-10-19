using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Employee : Class1
    {
        public new string Name
        {

            get => $"Уважаемый {base.Name}";
            set => base.Name = value;
        }
        public new static readonly int MinAge = 18;
        public new const string typeName = "Employee";
        public string company;
        public new void Print()
        {
            Console.WriteLine($"Имя: {Name} {company} {MinAge} {typeName}");
        }
        public Employee(string name, string company) : base(name)
        {
            this.company = company;
        }
    }
}
