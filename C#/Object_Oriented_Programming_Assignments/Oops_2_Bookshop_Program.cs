using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Oop_s_2_Book_Shop
{
    public class BookShop
    {
        string Name;
        string Title;
        string Publisher;
        int Price;

        public void Assignvalues(string Name, string Title, string Publisher, int Price)
        {
            this.Name = Name;
            this.Title = Title;
            this.Publisher = Publisher;
            this.Price = Price;
        }
        public void DisplayValues()
        {
            Console.WriteLine("The Name of Author :" + Name);
            Console.WriteLine("Name of Title :" + Title);
            Console.WriteLine("The Name of Publisher is :" + Publisher);
            Console.WriteLine("The price of Book is :" + Price);
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                BookShop bookShop = new BookShop();
                bookShop.Assignvalues("Yaseen", "KGN", "King of India", 4000);
                bookShop.DisplayValues();
                Console.ReadLine();

            }
        }
    }
}
