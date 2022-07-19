using Dip.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentProcess payment = new PaymentProcess();
            payment.Pay("abc1234");
            Console.ReadLine();

        }
    }
}
