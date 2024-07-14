using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Functions
    {
        public static double Deposit(double balance)
        {
            Console.Write("Enter amount to deposit: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            balance += depositAmount;
            Console.WriteLine($"Deposit successful! New balance: {balance}");
            return balance;
        }

       public static double Withdraw(double balance, double charge, string bankName)
        {
            Console.Write("Enter amount to withdraw: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            if (withdrawAmount > balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                balance -= withdrawAmount;
                if (bankName != "BDO")
                {
                    balance -= charge;
                }
                Console.WriteLine($"Withdrawal successful! New balance: {balance}");
            }
            return balance;
        }

        public static void CheckBalance(double balance)
        {
            Console.WriteLine($"Your balance is: {balance}");
        }
    }
}
