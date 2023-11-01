namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(myLibrary.NumerFunctions.Subtraction(5, 3));
            Console.WriteLine(myLibrary.NumerFunctions.Max(4, 5));
            Console.WriteLine(myLibrary.NumerFunctions.Min(1, 5));

            Console.WriteLine(myLibrary.StringFunctions.GetVowelsConsonantsNumbersSpecialChars("aeifrw2342@#@"));
            Console.WriteLine(myLibrary.StringFunctions.Reverse("iam"));
        }
    }
}