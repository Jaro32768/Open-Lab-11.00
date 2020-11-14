using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_11._00
{
    class Program
    {
        static void Main()
        {
            Library schoolLibrary = new Library();
            Library.studentsList.Add("John");
            Library.studentsList.Add("Poul");
            schoolLibrary.NumberOfBooks = 4;
            schoolLibrary.NumberOfStudents = 2;
            Book Math = new Book("Math", 150, "educational", "Some mathematician", 1950);
            Book Chemistry = new Book("Chemistry", 500, "educational", "Some chemist", 1951);
            Book English = new Book("English", 123, "educational", "Some Englishman", 1952);
            Book Physics = new Book("Physics", 470, "educational", "Some physicist", 1953);
            Console.WriteLine(Math.GetBook());
            Console.WriteLine(Chemistry.GetBook());
            Console.WriteLine(English.GetBook());
            Console.WriteLine(Physics.GetBook());
            schoolLibrary.GetVariables();
            Console.ReadKey();
        }
    }
}
