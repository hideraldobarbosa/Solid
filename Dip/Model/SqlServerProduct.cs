namespace Dip.Model
{
    class SqlServerProduct : DbProduct
    {
        public string GetProductById(string id)
        {
            return $"SqlServer: Exibindo dados do produto {id}.";
        }
    }
}
