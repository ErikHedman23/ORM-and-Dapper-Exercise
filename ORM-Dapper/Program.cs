using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using ORM_Dapper;
using System.Data;


var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);

#region Department Section


//var departmentRepo = new DapperDepartmentRepository(conn);

//departmentRepo.InsertDepartment("Erik's Department");

//var departments = departmentRepo.GetAllDepartments();

//foreach (var department in departments)
//{
//    Console.WriteLine($"{department.DepartmentID} | {department.Name}");
//}

#endregion

#region Product Section

var productRepository = new DapperProductRepository(conn);

productRepository.CreateProduct("Erik's C# Code", 700.00, 1, true, 10000);

var products = productRepository.GetAllProducts();

foreach (var product in products)
{
    Console.WriteLine($"{product.ProductID} | {product.Name} | {product.Price} | {product.CategoryID} | {product.OnSale} | {product.StockLevel}");
}

#endregion