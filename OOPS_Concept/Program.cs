using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Akur",1000);
            Console.WriteLine($" ACCOUNT{account.Number} {account.Owener}");
            Console.ReadLine();
        }
    }
}
