using Dip.Model;
using System.Configuration;

namespace Dip.Factory
{
    class DbProductFactory
    {
        public static DbProduct Create()
        {
            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SqlServerProduct();

            }
            else if (ConfigurationManager.AppSettings["DB"] == "MONGODB")
            {
                return new MongoDbProduct();
            }
            else 
            {
                return new OracleDB();
            }
        }
    }
}
