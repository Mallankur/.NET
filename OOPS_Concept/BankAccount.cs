using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    internal class BankAccount
    {
        public string Number { get;  }
        public string Owener { get; set; }
        public decimal Balance { get; }
        public BankAccount(string name , decimal inintalbalence)
        {
            this .Owener = name;
            this .Balance = inintalbalence;
        }
        public void MakeDeposit(decimal amount , DateTime date   , string  note  )
        {

        }
        public void MakeWithdrawl(decimal amount , DateTime  date ,string note )
        {

        }
    }
}
