using System;
namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ATM!");
            string bankName = ChooseBank();
            double charge = ToCharge(bankName);

            Console.WriteLine($"You have chosen {bankName}.");

            string accountnumber = Login("Account No.: ");
            string PIN = Login("PIN: ");
            Console.WriteLine("Login successful!");

            double balance = 0;

            while (true)
            {
                int optionChoice = ChooseOption();
                switch (optionChoice)
                {
                    case 1:
                        balance = Functions.Deposit(balance);
                        break;
                    case 2:
                        balance = Functions.Withdraw(balance, charge, bankName);
                        break;
                    case 3:
                        Functions.CheckBalance(balance);
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static string ChooseBank()
        {
            Console.WriteLine("Choose your bank:");
            Console.WriteLine("1. BDO");
            Console.WriteLine("2. BPI");
            Console.WriteLine("3. METROBANK");
            Console.WriteLine("4. PNB");
            Console.WriteLine("5. LANDBANK");

            int bankChoice = Convert.ToInt32(Console.ReadLine());

            string bankName = "";
            switch (bankChoice)
            {
                case 1:
                    bankName = "BDO";
                    break;
                case 2:
                    bankName = "BPI";
                    break;
                case 3:
                    bankName = "METROBANK";
                    break;
                case 4:
                    bankName = "PNB";
                    break;
                case 5:
                    bankName = "LANDBANK";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting...");
                    Environment.Exit(0);
                    break;
            }

            return bankName;
        }

        static double ToCharge(string bankName)
        {
            double charge = 0;
            if (bankName != "BDO")
            {
                charge = 10;
                Console.WriteLine("You're a Non-BDO user, charge -10");
            }
            return charge;
        }

        static string Login(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static int ChooseOption()
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");

            return Convert.ToInt32(Console.ReadLine());
        }

       
    }
}