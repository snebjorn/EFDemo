using System;
using EFDemo.DAL;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new DemoContext())
            {
                var students = ctx.Students;

                // print students
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
