﻿using System;


namespace HerancasDemo.Entities {
    class Account {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; }

        public Account() {
        }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        void Withdraw(double amount) {
            Balance -= amount;
        }
        void Deposit(double amount) {
            Balance += amount;
        }
    }
}
