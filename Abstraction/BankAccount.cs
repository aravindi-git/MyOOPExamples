namespace Abstraction
{
    public abstract class BankAccount
    {
        private string accountNumber;
        private string accountName;
        private decimal balance; 

        public BankAccount (string accountNumber, string accountName)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = 0;
        }

        public void  Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Your account balance is :  {balance}.");
        }

        public virtual void Withdraw(decimal amount)
        {
            
            if(balance > amount)
            {

                balance -= amount; 
                Console.WriteLine($"Your account balance is :  {balance}.");
            }
            else
            {
                Console.WriteLine("The balance is less than the withdrawing amount. ");
            }
               
        }

        public abstract void CalculateInterest ();

        protected decimal CalculateBalance ()
        {
            return balance; 
        }


    }
}
