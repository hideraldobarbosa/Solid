using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Model
{
    class OracleDB : DbProduct    {
        public string GetProductById(string id)
        {
            return $"Oracle: Exibindo dados do produto {id}.";
        }
    }
}
