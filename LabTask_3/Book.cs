using System;

namespace BookInfo
{
    class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;
        public static int bookCounter = 0;
        public Book()
        {
            Book.bookCounter++;
        }
        public Book(string bookName,string bookAuthor,string bookId,string bookType,int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
            Book.bookCounter += bookCopy;
        }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookId { get; set; }
        public string BookType { get; set; }
        public string BookCopy { get; set; }
        public void showInfo()
        {
            Console.WriteLine("Book All Information----------\n");
            Console.WriteLine("Book Name: " + bookName + "\nBook Author: " + bookAuthor + "\nBook Id: " + bookId + "\nBook Type: " + bookType + "\nBook Copy: " + bookCopy + "\n");
        }
        public void addBookCopy(int x)
        {
            Book.bookCounter += x;
            this.bookCopy += x;
        }
    }
}
