using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class DapperProductRepository : iProductRepository
    {
        private readonly IDbConnection _conn;

        public DapperProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void CreateProduct(string name, double price, int categoryID)
        {
            throw new NotImplementedException();
        }

        internal void GetAllProducts()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> iProductRepository.GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM products;");
        }
    }
}
