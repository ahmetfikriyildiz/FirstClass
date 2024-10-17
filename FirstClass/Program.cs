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
            //Öğrencilerin ve öğretmenlerin bilgilerini yönetmek için Person adında genel bir sınıf oluşturmanız isteniyor.
            //Bu sınıfın özellikleri şunlar olmalı: Ad, Soyad, Doğum Tarihi.
            //Person adında bir sınıf oluşturun ve bu özellikleri içeren public property'ler (get/set) tanımlayın.
            //Main metodu içinde, bu sınıftan birkaç öğrenci ve öğretmen nesnesi oluşturun ve bilgilerini konsola yazdırın.

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
