using Cuenta;

namespace TestAcc
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account(50);
            a.state();
            a.deposit(100.0);
            a.withdraw(147.0);
        }
    }
}

