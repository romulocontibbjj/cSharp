using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            Ex2();
        }

        static void Ex1()
        {
            //BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            //Console.WriteLine(account.Balance);
            //account.Deposit(200.0);
            //Console.WriteLine(account.Balance);

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //Upcasting -> da SubClasse para a Super-Classe
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DownCasting -> da Super-Classe para a SubClasse
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);


            //BusinessAccount acc5 = (BusinessAccount)acc3; //Erro - Tipos Incompatívels

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3; ou cod abaixo
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3; desde jeito ou como no código abaixo "as"
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }
        }

        static void Ex2()
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance.ToString());
            Console.WriteLine(acc2.Balance.ToString());
        }

    }

}
