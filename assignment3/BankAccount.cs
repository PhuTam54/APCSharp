using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.assignment3
{
    public delegate void UpdateBalanceHandler(decimal balance, string typeOfChange);
    internal class BankAccount
    {
        private decimal balance;
        public event UpdateBalanceHandler BalanceChanged;

        public BankAccount(decimal balance)
        {
            this.balance = balance;
            BalanceChanged += NotifyChangedbalance;
        }
        public BankAccount()
        {
            BalanceChanged += NotifyChangedbalance;
        }

        public override string ToString()
        {
            return "" +balance;
        }
        public decimal Balance
        {
            get => balance;
            set
            {
                balance = value; // Kiểm tra xem event BalanceChanged có null hay không trước khi gọi nó.
                BalanceChanged?.Invoke(balance, "Balance: ");
            }
            }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                BalanceChanged(amount, "+");
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Failed.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount < Balance)
            {
                BalanceChanged(amount, "-");
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Failed.");
            }
        }

        public void NotifyChangedbalance(decimal balance, string typeOfChange)
        {
            Console.WriteLine(typeOfChange + balance);
        }
    }
}
