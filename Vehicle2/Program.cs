using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E = new Employee("John", 10, 36000);
            Console.WriteLine(E.Name);
            Console.WriteLine(E.age);
            Console.WriteLine(E.salary);
            Console.ReadLine();


        }
    }
    public class Employee
    {
        public string Name;
        public int age;
        public int salary;
        public Employee(String Name, int age, int salary)
        {

            this.Name = Name;
            this.age = age;
            this.salary = salary;
        }
    }
}
       
