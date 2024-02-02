using System;

namespace Program3
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            int bs = Convert.ToInt32(args[0]);
            int com = Convert.ToInt32(args[1]);
            float hra = bs * 0.15f;
            float da = bs * 0.3f;
            float total = bs + com + hra + da;
            Console.WriteLine("Total Salary: " + total);
            Console.ReadKey();
        }
    }
}
