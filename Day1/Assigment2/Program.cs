namespace Assigment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3] { 1, 2, 3 };
            int sum = 0;

            foreach(int val in arr)
            {
                sum += val;
            }

            int maxi = int.MinValue;

            foreach(int val in arr)
            {
                maxi = Math.Max(maxi, val);
            }

            Console.WriteLine($"sum of array = {sum}");
            Console.WriteLine($"Average of array = {sum/arr.Length}");
            Console.WriteLine($"Max Element of array = {maxi}");



            int[,,] arr3d = new int[2, 2, 2] {  { { 1, 2 }, { 3, 4 } }, { { 1, 2 }, { 3, 4 } } };

            int sum3d = 0;
            foreach(int val in arr3d)
            {
                sum3d += val;
            }
            Console.WriteLine("Sum of 3d array elements is " + sum3d);
        }
    }
}