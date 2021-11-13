using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            double princamt, rate, interest, total_amt;
            Console.Write("Enter The Loan Amount: ");
            princamt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the no. of years: ");
            year = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the rate of interest: ");
            rate = Convert.ToDouble(Console.ReadLine());
            interest = princamt * year * rate / 100;
            total_amt = princamt + interest;
            Console.WriteLine("total Amount: {0}", total_amt);
            Console.ReadLine();
        }
    }
}
