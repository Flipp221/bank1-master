using System;

namespace bank1
{
    class Programbalance
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            Account acc2 = new Account();
            acc1.Balance = 10000;
            acc2.Balance = 1000;
            Operation.ShowBalance(acc1);
            Operation.ShowBalance(acc2);
            Operation.Transaction(acc1, acc2, 500);
            Operation.Widthraw(acc1, acc2, 800);
            Operation.Deposit(acc1, acc2, 1000);
        }
    }
}
