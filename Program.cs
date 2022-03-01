using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program to get the employee details and display them
            string name, add, city;
            int empID, age;
            Console.Write("name: ");
            name = Console.ReadLine();
            empID = int.Parse(Console.ReadLine());
            Console.Write("address: ");
            add = Console.ReadLine();
            Console.Write("city: ");
            city = Console.ReadLine();
            Console.Write("age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("the details of {0}:", name);
            Console.WriteLine("employee id :" + empID);
            Console.WriteLine("age :" + add);
            Console.WriteLine("city:" + city);
            Console.ReadLine();
            

            //n natural numbers

        }
    }
}
