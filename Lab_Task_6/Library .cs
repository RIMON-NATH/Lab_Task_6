using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_6
{
    class Library
    {
        String libName;
        String libAddress;
        Book[] listOfBook;
        int totalBook;
        public String LibName
        {
            set { libName = value; }
            get { return libName; }
        }
        public String LibAddress
        {
            set { libAddress = value; }
            get { return libAddress; }
        }
        public Book[] ListOfBook
        {
            set { listOfBook = value; }
            get { return listOfBook; }
        }
        public int TotalBook
        {
            set { totalBook = value; }
            get { return totalBook; }
        }
        public Library()
        {
            Console.WriteLine("Empty Function");
        }
        public Library(String libName, String libAddress, Book[] listOfBook, int totalBook)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.listOfBook = listOfBook;
            this.totalBook = totalBook;
        }
        public void ShowLibInfo()
        {
            Console.WriteLine(LibName);
            Console.WriteLine(LibAddress);
            Console.WriteLine(ListOfBook);
            Console.WriteLine(TotalBook);
        }
    }
}
