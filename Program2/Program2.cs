using System;

namespace Program2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            String r, fn, ln, sem, spl;
            Console.WriteLine("Enter Roll no: ");
            r = Console.ReadLine();
            Console.WriteLine("Enter First name: ");
            fn = Console.ReadLine();
            Console.WriteLine("Enter Last name: ");
            ln = Console.ReadLine();
            Console.WriteLine("Enter Semester: ");
            sem = Console.ReadLine();
            Console.WriteLine("Enter Specialization: ");
            spl = Console.ReadLine();
            Console.WriteLine("Details are:");
            Console.WriteLine("Roll no: " + r);
            Console.WriteLine("Name: " + fn + " " + ln);
            Console.WriteLine("Semester: " + sem);
            Console.WriteLine("Specialization: " + spl);
            Console.ReadKey();
        }
    }
}
