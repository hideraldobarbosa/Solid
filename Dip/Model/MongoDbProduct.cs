using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Model
{
    class MongoDbProduct : DbProduct
    {
        public string GetProductById(string id)
        {
            return $"MongoDb: Exibindo dados do produto {id}.";
        }
    }
}
