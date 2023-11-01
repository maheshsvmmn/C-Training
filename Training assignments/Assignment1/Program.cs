using System.Text;

namespace Assigment1
{
    internal class Program
    {
        static string getTable(int num)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                sb.Append($" {num} * {i} = {num * i}\n");
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int x = 9, y = 2;

            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x + y}");
            Console.WriteLine($"{x} / {y} = {x + y}");

            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{x} + {y} = {x + y}");
                    break;
                case 2:
                    Console.WriteLine($"{x} - {y} = {x - y}");
                    break;
                case 3:
                    Console.WriteLine($"{x} * {y} = {x + y}");
                    break;
                case 4:
                    Console.WriteLine($"{x} / {y} = {x + y}");
                    break;
                default:
                    Console.WriteLine("Enter correct choice");
                    break;
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Mahesh Sharma");
            }

            Console.Write("Enter number for table : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(getTable(num));

            for (int i = 100; i >= 5; i -= 3)
            {
                Console.WriteLine(i);
            }

            int z = 345;

            Console.Write(z);
            Console.WriteLine(z);

        }
    }
}