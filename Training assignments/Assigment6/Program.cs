namespace Assigment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Who Are You >  ");
            string person = Console.ReadLine();

            if(person.ToLower() == "admin")
            {
                Console.WriteLine("1. Add a Product \n2. Display all Product");
                Console.Write("Enter your choice : ");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch(ch)
                {
                    case 1:
                        string pcode, pname;
                        int qty, discount;

                        Console.Write("Enter product Code : ");
                        pcode = Console.ReadLine();
                        
                        Console.Write("Enter product Name : ");
                        pname = Console.ReadLine();

                        Console.Write("Enter quantity in stock : ");
                        qty = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Entre discount allowed :");
                        discount = Convert.ToInt32(Console.ReadLine());

                        products.Add(new Product(pcode : pcode , pname : pname , qty_in_stock: qty , distcount_allowed : discount));
                        break;
                    case 2:
                        
                        foreach(var product in products)
                        {
                            product.DisplayDetails(Product.brand);
                        }
                        break;
                }
            }
            else if(person.ToLower() == "customer")
            {
                Console.WriteLine("1.Display all Products \n2. Buy a Product");
                Console.Write("Enter your choice : ");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        foreach (var p in products)
                        {
                            p.DisplayDetails(Product.brand);
                        }
                        break;
                    case 2:

                        string pcode;
                        int qty;

                        Console.Write("Enter Product code : ");
                        pcode = Console.ReadLine();

                        Console.Write("Enter Quantity : ");
                        qty= Convert.ToInt32(Console.ReadLine());

                        var product = products.Where(p => p.pcode == pcode).ToList();

                        if (product[0].qty_in_stock < qty)
                        {
                            Console.WriteLine($"Available Quantity of {product[0].pname} is lesser than you want");
                        }
                        else
                        {
                            // making a bill for coustomer
                        }
                        break;
                }
            }
        }
    }
}