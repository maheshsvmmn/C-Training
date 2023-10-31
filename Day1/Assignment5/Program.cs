using System.Text;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account act = new Account();

            //Console.Write("Enter Account Id : ");
            //act.ID = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Account Type : ");
            //act.AccountType = Console.ReadLine();

            //Console.Write("Enter Balance : ");
            //act.Balance = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Withdraw amount : ");
            //int withdrawAmount = Convert.ToInt32(Console.ReadLine());

            //if(withdrawAmount <= act.Balance)
            //{
            //    double prevBalance = act.Balance;
            //    act.WithDraw(withdrawAmount);
            //    Console.WriteLine( act.GetDetails($"Old Balance : {prevBalance}"));

            //}
            //else
            //{
            //    Console.WriteLine( act.GetDetails("Not enough balance to delete"));
            //}


            //// bank database

            //List<Account> bankDb = new List<Account>()
            //{
            //    new Account(){
            //    ID = 2, AccountType = "savings" , Balance = 14915
            //},
            //    new Account(){
            //    ID = 3, AccountType = "savings" , Balance = 14410
            //},
            //    new Account(){
            //    ID = 4, AccountType = "savings" , Balance = 300000
            //},
            //    new Account(){
            //    ID = 5, AccountType = "current" , Balance = 7000
            //}};

            //bankDb.Insert(0, act);

            //// showing bank database
            //Console.WriteLine("\n\n<<<<<<<<<<<<<<<<<----------------- Bank Database ------------------->>>>>>>>>>>>>>>>\n\n");
            //foreach (Account a in bankDb)
            //{
            //    Console.WriteLine(a.GetDetails());
            //    Console.WriteLine();
            //}


            // using functions from myLibrary
            Console.WriteLine(myLibrary.NumerFunctions.Subtraction(5,3));
            Console.WriteLine(myLibrary.NumerFunctions.Max(4 ,5));
            Console.WriteLine(myLibrary.NumerFunctions.Min(1 ,5));

            Console.WriteLine(myLibrary.StringFunctions.GetVowelsConsonantsNumbersSpecialChars("aeifrw2342@#@"));
            Console.WriteLine(myLibrary.StringFunctions.Reverse("iam"));

            

        }
    }
}