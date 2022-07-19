using Lsp.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard card = new CreditCard();
            //DebitCard card = new DebitCard();
            //NubankRewards card = new NubankRewards();
            card.Validate();
            card.CollectPayment();
            Console.ReadLine();
        }
    }
}
