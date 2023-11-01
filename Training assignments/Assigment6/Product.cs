using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment6
{
    internal class Product
    {
        public readonly string pcode;
        public string pname;
        public int qty_in_stock;
        public int distcount_allowed;
        public double price;
        public static string brand;

        public void GetDetails()
        {
            Console.Write("Enter product Name : ");
            pname = Console.ReadLine();

            Console.Write("Enter quantity in stock : ");
            qty_in_stock = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Price : ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entre discount allowed :");
            distcount_allowed = Convert.ToInt32(Console.ReadLine());
        }
        public Product()
        {
            Console.Write("Enter product code : ");
            pcode = Console.ReadLine();
        }

        public Product(string pcode, string pname, int qty_in_stock, int distcount_allowed , double price)
        {
            this.pcode = pcode;
            this.pname = pname;
            this.qty_in_stock = qty_in_stock;
            this.distcount_allowed = distcount_allowed;
            this.price = price;
        }

        static Product()
        {
            brand = "abc";
        }

        public void DisplayDetails(string brandName)
        {
            Console.WriteLine($"Product code : {pcode}\nProduct Name : {pname}\nQuantity : {qty_in_stock}\nPrice : {price}\nDiscount : {distcount_allowed}\n Brand : {brandName}\n");
        }

    }
}
