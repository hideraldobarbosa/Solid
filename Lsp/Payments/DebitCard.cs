using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Payments
{
    class DebitCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Verificar o Saldo....");
            Console.WriteLine("Saldo Disponivel!");
        }
    }
}
