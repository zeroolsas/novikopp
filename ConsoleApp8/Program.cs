namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1("Андрей");
            Employee employee = new Employee("Саня", "BTS");

            class1.Print();
            employee.Print();
            

        }
    }
}
