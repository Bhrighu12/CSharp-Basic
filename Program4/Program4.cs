using System;

namespace Program4
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            String r, n, d;
            int b;
            Console.WriteLine("Enter Empno: ");
            r = Console.ReadLine();
            Console.WriteLine("Enter EmpName: ");
            n = Console.ReadLine();
            Console.WriteLine("Enter Designation: ");
            d = Console.ReadLine();
            Console.WriteLine("Enter Basic Salary: ");
            b = Convert.ToInt32(Console.ReadLine());
            float hra = b * 0.15f;
            float da = b * 0.3f;
            double t = b + hra + da;
            Console.WriteLine("Details are:");
            Console.WriteLine("Emp no: " + r);
            Console.WriteLine("EmpName: " + n);
            Console.WriteLine("Designation: " + d);
            Console.WriteLine("Basic Salary: " + b);
            Console.WriteLine("Total Salary: " + t);
            Console.ReadKey();
        }
    }
}
