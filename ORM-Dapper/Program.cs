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

//you could even do a consol.WriteLine("Enter a new department name:")
//then do a var userInput = Console.ReadLine;  now you can insert that variable into InsertDepartments(userInput)...

//departmentRepo.InsertDepartment("Erik's Department");

//var departments = departmentRepo.GetAllDepartments();

//foreach (var department in departments)
//{
//    Console.WriteLine($"{department.DepartmentID} | {department.Name}");
//}

#endregion

#region Product Section

var productRepository = new DapperProductRepository(conn);
#region Create new Product
//productRepository.CreateProduct("Erik's C# Code", 700.00, 1, true, 10000);
#endregion

#region Update a Product
//var productToUpdate = productRepository.GetProduct(944);

//productToUpdate.StockLevel = 23;
//productToUpdate.Name = "Erik's SQL Code From C#";
//productToUpdate.Price = 25;
//productToUpdate.CategoryID = 2;
//productToUpdate.OnSale = false;

//productRepository.UpdateProduct(productToUpdate); 
#endregion

#region Delete a Product
//productRepository.DeleteProduct(944);


#endregion
var products = productRepository.GetAllProducts();

foreach (var product in products)
{
    Console.WriteLine($"{product.ProductID} | {product.Name} | {product.Price} | {product.CategoryID} | {product.OnSale} | {product.StockLevel}");
}

#endregion

