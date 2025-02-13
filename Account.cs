using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankApp;

namespace Bankify
{

    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get;  set; }
        public BankFeatures Profile { get; }

        public Account(string accountNumber, decimal balance, BankFeatures profile)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Profile = profile;
        }
    }

}