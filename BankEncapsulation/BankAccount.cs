using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {

        public double _balance = 0;

        public void Deposit(double money)
        {
            _balance += money;
        }

        public void GetBalance()
        {
            Console.WriteLine($"{_balance}");
        }









    }



}
