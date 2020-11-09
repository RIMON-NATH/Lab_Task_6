using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_6
{
    class Account
    {
        String accName;
        String acid;
        int balance;
        public String AccName
        {
            set { accName = value; }
            get { return accName; }
        }
        public String Acid
        {
            set { acid = value; }
            get { return acid; }
        }
        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public Account()
        {
            Console.WriteLine("This Is Empty Constructor For Account Class");
        }
        public Account(String accName, String acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public void Deposit(int amount)
        {
            if (amount >= 0)
            {
                Console.WriteLine("Previous Amount : " + balance);
                Console.WriteLine("Your Deposit : " + amount + "$");
                balance = balance + amount;
                Console.WriteLine("Current Balance " + balance + " $");

            }
            else
            {
                Console.WriteLine("You Have No Sufficient Balance");
            }
        }
        public void Withdraw(int amount)
        {
            if (amount > 0 && amount < balance)
            {
                Console.WriteLine("Previous Amount : " + balance);
                Console.WriteLine("You withdraw " + amount + " $");
                balance = balance - amount;
                Console.WriteLine("Current Balance " + balance + " $");
            }
            else
            {
                if (amount < 0)
                {
                    Console.WriteLine("Invalid Balance");
                }
                else if (amount > balance)
                {
                    Console.WriteLine("You Have not Enough $");
                }
            }
        }
    }
}
