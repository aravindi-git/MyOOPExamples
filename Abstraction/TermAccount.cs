using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class TermAccount : BankAccount
    {
        private DateTime startingDate; 
        private int termInDays; 
        public TermAccount(string accountNumber, string accountName, DateTime startingDate) : base(accountNumber, accountName)
        {
            termInDays = 30;
            this.startingDate = startingDate;
        }

        public override void CalculateInterest()
        {
            decimal currentBalance = base.CalculateBalance();
            decimal interest = (currentBalance * 15) / 100;

            Console.WriteLine($"Your interest is: :  {interest}.");
        }

        public override void  Withdraw(decimal amount)
        {
            if((startingDate - DateTime.Now).TotalDays < termInDays)
            {
                Console.WriteLine("The term of your account is not completed yet... "); 
            }
            else
            {
                base.Withdraw(amount);
            }

        }

        public void  CalculateRenewalDate()
        {
            Console.WriteLine($"Your account's renewal date is: {startingDate.AddDays(termInDays)}"); 
        }
    }
}
