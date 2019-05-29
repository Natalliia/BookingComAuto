using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingComAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi");
            Console.WriteLine("Hi again");


            List<Company> people = new List<Company>(3);
            people.Add(new Company() { Name = "Microsoft" });
            people.Add(new Company() { Name = "Microsoft" });
            people.Add(new Company() { Name = "Microsoft" });
            people.Add(new Company() { Name = "Google" });
            people.Add(new Company() { Name = "Microsoft" });
            people.Add(new Company() { Name = "Microsoft" });
            people.Add(new Company() { Name = "Google" });
            people.Add(new Company() { Name = "Apple" });
            people.Add(new Company() { Name = "Google" });

            List<string> myList3 = new List<string>();
            foreach (Company p in people)
            {
                myList3.Add(p.Name);
                Console.WriteLine(p.Name);
            }
            Console.WriteLine("*********************");
            foreach (string t in myList3)
            {
                Console.WriteLine(t);
            }
        }
    }
}
