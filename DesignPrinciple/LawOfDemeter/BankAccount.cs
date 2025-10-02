using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfDemeter
{
    public class BankAccount
    {
        public decimal Balance { get; set; }
        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public decimal GetBalance()
        {
            return Balance;
        }
    }
}
