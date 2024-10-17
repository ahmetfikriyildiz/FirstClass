using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Ad: {FirstName}, Soyad: {LastName}, Doğum Tarihi: {BirthDate.ToShortDateString()}");
        }
    }
}
