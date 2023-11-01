namespace Assigment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            string choice = "y";
            do
            {

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

                            //Console.Write("Enter product Code : ");
                            //pcode = Console.ReadLine();
                            var product = new Product();
                            products.Add(product);
                            product.GetDetails();
                            break;
                        case 2:
                            Console.WriteLine("\n | Products | \n");
                            foreach (var p in products)
                            {
                                p.DisplayDetails(Product.brand);
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
                            Console.WriteLine("\n | Products | \n");
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

                            var product = products.Where(p => p.pcode == pcode).ToList()[0];

                            if (product.qty_in_stock < qty)
                            {
                                Console.WriteLine($"Available Quantity of {product.pname} is lesser than you want");
                            }
                            else
                            {
                                double discount = 0;
                                if (DateTime.Now.Day == 26)
                                {
                                    discount = 50;
                                }
                                else
                                {
                                    discount = product.distcount_allowed;
                                }
                                product.qty_in_stock -= qty;

                                Console.WriteLine("\n| Your bill |\n");
                                Console.WriteLine($"Product code : {pcode}\nProduct Name : {product.pname}\nQuantity : {qty}\nPrice : {product.price}\n" +
                                    $"Discount : {discount}\n Brand : {Product.brand}\n");
                                Console.WriteLine("------------------");

                                Console.WriteLine($"\nTotal Amount : {qty*product.price*(100 - discount)/100}₹\n");
                            }
                            break;
                    }
                }


                Console.WriteLine("Want to Continue ? y or n : ");
                choice = Console.ReadLine();
            } while (choice == "y");

        }
    }
}