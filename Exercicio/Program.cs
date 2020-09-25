using Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char Outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hours: ");
                double valueHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(Outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(name, hours, valueHours, additional));
                }
                else
                {
                    list.Add(new Employee(name, hours, valueHours));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
