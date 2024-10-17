using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person student1 = new Person
            {
                FirstName = "Ali",
                LastName = "Yılmaz",
                BirthDate = new DateTime(2005, 8, 15)
            };

            Person student2 = new Person
            {
                FirstName = "Ayşe",
                LastName = "Demir",
                BirthDate = new DateTime(2006, 2, 10)
            };

            // Öğretmen nesneleri oluşturma
            Person teacher1 = new Person
            {
                FirstName = "Ahmet",
                LastName = "Kara",
                BirthDate = new DateTime(1985, 5, 30)
            };

            Person teacher2 = new Person
            {
                FirstName = "Emine",
                LastName = "Çelik",
                BirthDate = new DateTime(1990, 9, 12)
            };

            // Bilgileri konsola yazdırma
            Console.WriteLine("Öğrenciler:");
            student1.PrintInfo();
            student2.PrintInfo();

            Console.WriteLine("\nÖğretmenler:");
            teacher1.PrintInfo();
            teacher2.PrintInfo();

            Console.ReadKey();

        }
    }
}
