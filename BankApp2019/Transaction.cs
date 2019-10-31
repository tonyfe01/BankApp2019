﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp2019
{
    enum TypeOfTransaction
    {
        Credit,
        Debit
    }
    class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public String Description { get; set; }
        public decimal Amount { get; set; }
        public TypeOfTransaction TransactionType { get; set; }
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }

    }
 
}
