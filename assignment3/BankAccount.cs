using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.assignment3
{
    public delegate void UpdateBalanceHandler(double balance);
    internal class BankAccount
    {
        private double balance;
        public event UpdateBalanceHandler BalanceChanged;

        public BankAccount(double balance)
        {
            this.balance = balance;
            BalanceChanged += NotifyChangedbalance;
        }
        public BankAccount()
        {
            BalanceChanged += NotifyChangedbalance;
        }
        public double Balance
        {
            get => balance;
            set
            {
                balance = value; // Kiểm tra xem event BalanceChanged có null hay không trước khi gọi nó.
                BalanceChanged?.Invoke(balance);
            }
            }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                BalanceChanged(amount);
            }
            else
            {
                Console.WriteLine("Failed.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                BalanceChanged(amount);
            }
            else
            {
                Console.WriteLine("Failed.");
            }
        }

        public void NotifyChangedbalance(double balance)
        {
            Console.WriteLine("Balance changed: " + balance);
        }
    }
}
