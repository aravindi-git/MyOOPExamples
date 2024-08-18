using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class SavingAccount : BankAccount
    {

        public SavingAccount(string accountNumber, string accountName) : base(accountNumber, accountName)
        {
        }

        public override void CalculateInterest()
        {
            decimal currentBalance =  base.CalculateBalance();
            decimal interest =  (currentBalance * 5 ) / 100;

            Console.WriteLine($"Your interest is :  {interest}.");
        }
    }
}
