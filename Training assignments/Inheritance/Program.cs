namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // intialization through constructor
            //Result result = new Result( rn : 3 , name : "ajay" , score : 5 , marks : new List<int> { 3,4,5,4,3} );

            Result result = new Result();

            result.GetDetails();
            result.CalculateScore();

            Console.WriteLine("\n\n----------->>>>>>>>>>>>>>>>> Student Details -------------->>>>>>>>>>>>>>>\n");
            result.DisplayDetails();
        }
    }
}