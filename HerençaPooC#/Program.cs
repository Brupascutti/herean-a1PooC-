//using HerençaPooC_.Entities;
//Account acc = new Account(1001, "Alex", 0.0);
//BusinesAccount bacc = new BusinesAccount(1002, "Maria", 0.0, 500.00);

//UPCASTING

//Account acc1 = bacc;
//Account acc2 = new BusinesAccount(1003, "bob", 0.0, 200.0);
//Account acc3 = new SavingsAccount(0.01, 1004, "Anna", 0.0);

//DOWCASTING

//BusinesAccount acc4 = (BusinesAccount)acc2;
//acc4.Loan(100.0);

//BusinesAccount acc5 = (BusinesAccount)acc3;
//if (acc3 is BusinesAccount)
//{
//    BusinesAccount acc5 = (BusinesAccount)acc3;
//    acc5.Loan(200.0);
//    Console.WriteLine("loan!");
//}
//if (acc3 is SavingsAccount)
//{
//    SavingsAccount acc5 = (SavingsAccount)acc3;
//    acc5.UpdateBalance();
//    Console.WriteLine("Update!");
//}

using System;
using HerençaPooC_.Entities;
using HerençaPooC_.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(0.01, 1002, "Anna", 500.0);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}