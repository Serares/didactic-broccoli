namespace LawOfDemeter
{
    /**
     *  A module should only have knowledge of and talk
     *  directly to closely related modules
    */
    public class Customer
    {
        private BankAccount account;
        // The wallet behavior is violating the LoD principle
        public Wallet Wallet { get; set; }
        public Customer(BankAccount account)
        {
            this.account = account;
        }

        public decimal CheckAccountBalance()
        {
            // ❗ accessing balance through Wallet and Account
            // create tight coupling
            // return Wallet.Account.Balance;
            return account.GetBalance();
        }
    }

    public class Wallet
    {
        public BankAccount? Account { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
