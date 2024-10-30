using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    internal class Book : IComparable<Book>
    {
        private string? title;
        private string? author;
        private int releaseyear;
        private int pages;
        public int Releaseyear
        {
            get => releaseyear;
            private set
            {
                if (value <= 0) releaseyear = 1;
                else releaseyear = value;
            }
        }
        public int Pages 
        {
            get => pages; 
            private set 
            {
                if (value <= 0) pages = 1;
                else pages = value;
            } 
        }
        //public Book (string title, string author, int releaseyear, int pages)
        //{
        //    this.title = title;
        //    this.author = author;
        //    this.releaseyear = releaseyear;
        //    this.pages = pages;
        //}


        public void SetBook(string title, string author, int releaseyear, int pages) 
        {
            this.title = title;
            this.author = author;
            this.Releaseyear = (int)releaseyear;
            this.Pages = (int)pages;
        }

        public void PrintBook() 
        {
            Console.WriteLine($"Book title: \"{this.title ?? "Unknown"}\" \nAuthor: \"{this.author ?? "Unknown"}\" \nRelease year: {this.releaseyear} \nPage amount: {this.pages}\n");
        }

        public int CompareTo(Book? other)
        {
            if(other == null) throw new ArgumentNullException();
            if (this.Releaseyear == other.releaseyear) return 0;
            if (this.Releaseyear > other.releaseyear) return 1;
            else return -1;
        }

        
    }
}
