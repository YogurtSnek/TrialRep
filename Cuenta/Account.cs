using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cuenta
{
    public class Account
    {
        private double balance;

        public Account(double balance)
        {
            this.balance = balance;
        }

      
        public void deposit(double balance)
        {
            this.balance += balance;
            Console.WriteLine("Your new balance after the deposit is: " + this.balance);
        }

        public void withdraw(double balance)
        {
            this.balance -= balance;
            Console.WriteLine("Your new balance after the withdrawal is: " + this.balance);
        }

         public void state()
         {
            Console.WriteLine("The balance of this account is: " + balance);
         }

        private double getBalance() { return balance; }


        private void setBalance(double balance)
            { this.balance = balance; }

       
    }
}