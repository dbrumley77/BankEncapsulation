using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {

        private double _balance = 0.00;



        public void Deposit(double money)
        {
            Console.WriteLine($"Your checking account balance is currently ${_balance}. Please make a deposit");
            Console.WriteLine();
            _balance += money;
            Console.WriteLine($"Your checking account balance after deposit is ${_balance}");
            Console.WriteLine();

        }


        public void AdditionalDeposits()
        {
            Console.WriteLine("Would you like to make another deposit: Yes or No");
            string userAnswer = Console.ReadLine().ToLower();


            if (userAnswer == "yes")
            {

                Console.WriteLine("How much is the deposit amount?");
                double depositAmount = double.Parse(Console.ReadLine());
                _balance += depositAmount;
                Console.WriteLine($"The new checking account balance is ${_balance}");
                

            }

            if (userAnswer == "no")
            {
                Console.WriteLine("Transaction completed: Have a good day");
            }



        }










    }



}
