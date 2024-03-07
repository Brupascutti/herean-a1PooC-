using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerençaPooC_.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterstRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(double interstRate, int number, string holder, double balance):base(number, holder, balance) 
        {
            InterstRate = interstRate;
        }

        public void UpdateBalance() 
        {
            Balance += Balance * InterstRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
