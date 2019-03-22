using EntityFrem.DAL;
using EntityFrem.Domains;
using System;

namespace EntityFrem
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student()
                {
                     StudentName="Eysan",
                     StudentID=212,
                     
                };
                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
            Console.WriteLine("Successful");
            Console.ReadLine();
        }
    }
}
