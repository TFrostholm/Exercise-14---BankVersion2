using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class BankAccount
    {
        private double balance;

        public BankAccount()
        {
            balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
            }
            else
            {
                Console.WriteLine("You can not deposit 0 or a negative number");
            }
            
        }

        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance = balance - amount;
                }
                else
                {
                    Console.WriteLine("Insufficent funds");
                }
            }
            else
            {
                Console.WriteLine("You can not withdraw 0 or a negative number");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
