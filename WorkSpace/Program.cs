using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Citizen citizen1 = new Citizen();

            Salute(name: "Mehmet");

            //Arrays
            string[] students = new string[3];
            students[0] = "Mehmet";
            Salute(students[0]);

            for (int i = 0; i < students.Length; i++)
            {
                Salute(students[i]);
            }

            List<string> newCities = new List<string> { "Ankara", "İstanbul", "İzmir" };
            newCities.Add("Balıkesir");

            string[] cities = new[] { "Ankara", "İstanbul", "İzmir" };

            foreach (string city in newCities)
            {
                Console.WriteLine(city);
            }

            Person person1 = new Person();
            person1.Name = "Mehmet";

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        private static void Variables()
        {
            string message = "hello";
            double price = 100000;
            int number = 100;
            bool isAuthenticated = false;


            string name = "Mehmet";
            string surname = "Aslan";
            int birthDate = 1995;
            long citizenId = 1234567890;

            Console.WriteLine(message);
            Console.WriteLine(price * 1.18);
        }

        static void Salute(string name = "isimsiz")
        {
            Console.WriteLine("Selam " + name);
        }

    }


    public class Citizen
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthDate { get; set; }
        public long CitizenId { get; set; }
    };
}
