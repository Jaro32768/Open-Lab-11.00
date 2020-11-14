using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Open_Lab_11._00
{
    class Library
    {
        private int numberOfBooks;
        private int numberOfStudents;
        public static List<string> studentsList = new List<string>();
        public static List<Book> booksList = new List<Book>();
        public Library() : base()
        {
            new Book();
            numberOfBooks = -1;
            numberOfStudents = -1;
        }
        public int NumberOfBooks
        {
            get => this.numberOfBooks;
            set
            {
                this.numberOfBooks = value;
            }
        }
        public int NumberOfStudents
        {
            get => this.numberOfStudents;
            set
            {
                this.numberOfStudents = value;
            }
        }
        public List<string> StudentsList
        {
            get => studentsList;
            set
            {
                studentsList.AddRange(value);
            }
        }
        public List<Book> BooksList
        {
            get => booksList;
            set
            {
                booksList.AddRange(value);
            }
        }
        public void GetVariables()
        {
            foreach(PropertyDescriptor item in TypeDescriptor.GetProperties(this))
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
