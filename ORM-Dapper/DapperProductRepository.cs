using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public DapperProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM Products;");
        }

        public void CreateProduct(string name, double price, int categoryID, bool onSale, int stockLevel)
        {
            _conn.Execute("INSERT INTO Products (Name, Price, CategoryID, OnSale, StockLevel) VALUES (@name, @price, @categoryID, @onSale, @stockLevel)",
                new { name = name, price = price, categoryID = categoryID, onSale = onSale, stockLevel = stockLevel });
        }
    }
}
