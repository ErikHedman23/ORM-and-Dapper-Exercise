using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace ORM_Dapper
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
   
}
