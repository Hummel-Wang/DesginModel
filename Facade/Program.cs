using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        private const int _amount = 12000;
        static void Main(string[] args)
        {
            #region 正常模式
            //Bank bank = new Bank();
            //Loan loan = new Loan();
            //Credit credit = new Credit();

            //Customer customer = new Customer("Ann McKinsey");

            //bool eligible = true;
            //if (!bank.HasSufficientSavings(customer, _amount))
            //{
            //    eligible = false;
            //}
            //else if (!loan.HasNoBadLoans(customer))
            //{
            //    eligible = false;
            //}
            //else if (!credit.HasGoodCredit(customer))
            //{
            //    eligible = false;
            //}

            //Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));
            //Console.ReadLine();
            #endregion

            #region 外观者模式
            Mortgage mortgage = new Mortgage();
            Customer customer = new Customer("Ann McKinsey");
            bool eligable = mortgage.IsEligible(customer, 125000);
            Console.WriteLine("\n" + customer.Name + " has been " + (eligable ? "Approved" : "Rejected"));
            Console.ReadLine();
            #endregion
        }
    }
}
