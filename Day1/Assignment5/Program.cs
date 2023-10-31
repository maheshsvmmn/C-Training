namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account act = new Account(){
            //    ID = 1, AccountType = "savings" , Balance = 2000
            //};

            //Console.WriteLine(act.GetDetails());

            //Console.Write("Enter amount to withdraw : ");
            //int withdrawAmt = Convert.ToInt32(Console.ReadLine());

            //bool result = act.WithDraw(withdrawAmt);

            //if (result)
            //    Console.WriteLine(act.GetDetails());
            //else
            //    Console.WriteLine("not enough balance to deduct");

            // bank database

            List<Account> list = new List<Account>()
            {
                new Account(){
                ID = 1, AccountType = "savings" , Balance = 14915
            },
                new Account(){
                ID = 2, AccountType = "savings" , Balance = 14410
            },
                new Account(){
                ID = 3, AccountType = "savings" , Balance = 300000
            },
                new Account(){
                ID = 4, AccountType = "current" , Balance = 7000
            }};


            // showing bank database
            Console.WriteLine("<<<<<<<<<<<<<<<<<----------------- Bank Database ------------------->>>>>>>>>>>>>>>>\n\n");
            foreach (Account a in list)
            {
                Console.WriteLine(a.GetDetails());
                Console.WriteLine();
            }


        }
    }
}