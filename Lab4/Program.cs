using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Good> ListGood = new List<Good>();
            Sale book_Sale = new Sale("Book");
            Sale journal_Sale = new Sale("Journal");
            Sale notebook_Sale = new Sale("NoteBook");

            ListGood.Add(new Book(book_Sale, "Мастер и маргарита", 250, "Булгаков", "Роман", "Эксмо"));
            ListGood.Add(new Book(book_Sale, "Война и мир", 350, "Толстой", "Роман", "Эксмо"));
            ListGood.Add(new Good(notebook_Sale, "Животные", 60));
            ListGood.Add(new Good(journal_Sale, "Вестник", 150));
            ListGood.Add(new Good(notebook_Sale, "Цветы", 60));
            ListGood.Add(new Book(book_Sale, "Преступление и наказание", 300, "Достоевский", "Роман", "Эксмо"));
            ListGood.Add(new Good(journal_Sale, "Наука", 160));

            foreach (Good g in ListGood)
            {
                if (g is Book)
                {
                    Book b = g as Book;
                    Console.WriteLine("Наименование товара: {0}\n Заголовок: {1}\n Цена: {2}\nАвтор: {3}\nЖанр: {4}\nИздательство: {5}", g.Good_Name, g.Book_Title, g.Price, b.Book_Author, b.Book_Genre, b.Book_Publisher);
                }
                else Console.WriteLine("Наименование товара: {0}\nЗаголовок:{1} \nЦена:{2}\n", g.Good_Name, g.Book_Title, g.Price);
            }
            Console.ReadLine();
        }
    }
}
