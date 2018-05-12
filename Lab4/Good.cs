using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Good
    {
        public Sale Good_Name { get; set; }
        public string Book_Title { get; set; }

        public double Price { get; set; }

        public Good(Sale Good_Name, string Book_Title, double Price)
        {
            this.Good_Name = Good_Name;
            this.Book_Title = Book_Title;
            this.Price = Price;
        }
        public void GetInfo()
        {
            Console.WriteLine(Good_Name.ToString() + " " + Book_Title.ToString() + " " + Price.ToString());

        }
    
}
}
