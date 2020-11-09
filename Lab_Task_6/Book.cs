using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_6
{
    class Book
    {
        String bookName;
        String bookAuthor;
        String bookId;
        String bookType;
        int bookCopy;
        public String BookName
        {
            set{ bookName = value; }
            get{ return bookName; }
        }
        public String BookAuthor
        {
            set { bookAuthor = value; }
            get { return bookAuthor; }
        }
        public String BookId
        {
            set { bookId = value; }
            get { return bookId; }
        }
        public String BookType
        {
            set { bookType = value; }
            get { return bookType; }
        }
        public int BookCopy
        {
            set { bookCopy = value; }
            get { return bookCopy; }
        }
        public Book()
        {
            Console.WriteLine("This Empty Constructor for Book Class");
        }
        public Book(String bookName, String bookAuthor, String bookId, String bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }
        public void showInfo()
        {
            Console.WriteLine(bookName);
            Console.WriteLine(bookAuthor);
            Console.WriteLine(bookId);
            Console.WriteLine(bookType);
            Console.WriteLine(bookCopy);
        }
        public void AddBookCopy(int x)
        {
            if(x>=0)
            {
                Console.WriteLine("Previous Amount : " + bookCopy);
                Console.WriteLine("Your Deposit : " + x);
                bookCopy = bookCopy + x;
                Console.WriteLine("Current Book " + bookCopy );
            }
        }
    }
}
