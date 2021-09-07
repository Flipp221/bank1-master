using System;
using System.Collections.Generic;
using System.Text;

namespace bank1
{
    class Operation
    {
        public static void ShowBalance(Account acc)
        {
            Console.WriteLine(acc.Balance);
        }
        public static void Transaction(Account acc, Account acc1, double sum)
        {
            acc.Balance -= sum;
            acc1.Balance += sum;
            Console.WriteLine("Transaction completed");
        }
        public static int Widthraw(Account account, double sum)
        {
            if (sum % 1 < 1)
            {
                account.Balance -= sum;
            }
            return 0;
        }
        public static int Deposit(Account accountgetter , double sum)
        {
            accountgetter.Balance += sum;
            Console.WriteLine("Deposit comleted");
            return 0;
        }
        public static int Credit(Account aaccountgettercc, double Sum)
        {
            return 0;
        }
    }
}
