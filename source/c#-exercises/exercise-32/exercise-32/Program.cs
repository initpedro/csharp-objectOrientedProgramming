﻿using System;
using exercise_32.Entities;

namespace exercise32 {
    internal class Program {
        static void Main(string[] args) {
            ////BusinessAccount account = new BusinessAccount(8010, "Pedro", 100.0, 500.0);
            ////Console.WriteLine(account.Balance);

            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //// Upcasting
            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            ////Downcasting - operação insegura
            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100.0);

            //// BusinessAccount acc5 = (BusinessAccount)acc3;

            //// Se acc3 for instância de BusinnesAccount
            //if (acc3 is BusinessAccount) {
            //    //BusinessAccount acc5 = (BusinessAccount)acc3;
            //    BusinessAccount acc5 = acc3 as BusinessAccount;
            //    acc5.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}

            //if (acc3 is SavingsAccount) {
            //    //SavingsAccount acc5 = (SavingsAccount)acc3;
            //    SavingsAccount acc5 = acc3 as SavingsAccount;
            //    acc5.Updatebalance();
            //    Console.WriteLine("Update!");

            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingsAccount(1002, "Anna", 500, 0.01);
            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
