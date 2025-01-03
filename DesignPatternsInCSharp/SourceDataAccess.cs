namespace DesignPatternsInCSharp;
using Dapper;
public class SourceDataAccess
{
    public string? database;

    public string? Database => database;

    private string sql = "SELECT * FROM products";
    private List<Product> products = new List<Product>();
// using (var connection = private new SqlConnection(connString))
// {
//     connection.Open();
//     using (var command = private new SqlCommand(sql, connection))
//     {
//         using (var reader = command.ExecuteReader())
//         {
//             private var product = new Product
//             {
//                 ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
//                 ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
//                 SupplierID = reader.GetInt32(reader.GetOrdinal("SupplierID")),
//                 CategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID")),
//                 UnitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice")),
//                 UnitsInStock = reader.GetInt32(reader.GetOrdinal("UnitsInStock")),
//                 UnitsOnOrder = reader.GetInt32(reader.GetOrdinal("UnitsOnOrder")),
//                 Discontinued = reader.GetBoolean(reader.GetOrdinal("Discontinued")),
//                 DiscontinuedDate = reader.GetDateTime(reader.GetOrdinal("DiscontinuedDate"))
//             };
//             products.Add(product);
//         }
//     }
// }

    
}