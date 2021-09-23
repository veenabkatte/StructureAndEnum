using System;
using System.Collections.Generic;
using System.Text;

namespace StructureAndEnum
{
    class EnumDemo
    {
        static void Main()
        {
            Console.WriteLine($"{GstStateCodes.GJ}={GstStateCodes.GJ.GetHashCode()}");
            Console.WriteLine($"{GstStateCodes.GJ}={Convert.ToInt32(GstStateCodes.GJ)}");
            //var names = Enum.GetNames(typeof(GstStateCodes));
            var names = Enum.GetValues(typeof(GstStateCodes));
            foreach (var name in names)
            {
                Console.WriteLine($"{name}={name.GetHashCode()}");
            }

            Employee employee = new Employee();
            Console.WriteLine(employee.GetEmp(100, "Scott", Gender.Male));

            Console.ReadLine();

        }
    }
}
