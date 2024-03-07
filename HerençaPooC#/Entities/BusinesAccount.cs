using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerençaPooC_.Entities
{
    internal class BusinesAccount : Account
    {
        public double LoanLimit { get; set; }
        
        public BusinesAccount() { }

        public BusinesAccount(int number, string holder, double balance, double loanLimit) : base(number,holder,balance) 
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit) 
            { 
                Balance += amount;
            }
        }
    }
}
