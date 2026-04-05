using System;

namespace OOPBasics
{
    class Account
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { if(value >= 0) balance = value; }
        }
    }

    class EncapsulationDemo
    {
        static void Main()
        {
            Account acc = new Account();
            acc.Balance = 500;
            Console.WriteLine(acc.Balance);
        }
    }
}