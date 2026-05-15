using Microsoft.Data.SqlClient;
using System.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories
{
    public class ProductRepository
    {
        private readonly string _connectionString = "Data Source=PERI\\SQLEXPRESS;Initial Catalog=ecommerce;Integrated Security=True;Trust Server Certificate=True";

        private SqlConnection CreateConnection() => new SqlConnection(_connectionString);

        private SqlCommand CreateCommand(string storedProc, SqlConnection connection)
        {
            var command = new SqlCommand(storedProc, connection);
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }

        private Product MapProduct(SqlDataReader reader)
        {
            return new Product
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                Name = reader.GetString(reader.GetOrdinal("name")),
                Description = reader.GetString(reader.GetOrdinal("description")),
                Category = reader.GetString(reader.GetOrdinal("category")),
                Price = reader.GetDecimal(reader.GetOrdinal("price")),
                StockQuantity = reader.GetInt32(reader.GetOrdinal("stock_quantity")),
                IsActive = reader.GetBoolean(reader.GetOrdinal("is_active")),
                Discount = reader.GetDecimal(reader.GetOrdinal("discount")),
                CreatedAt = reader.GetDateTime(reader.GetOrdinal("created_at")),
                UpdatedAt = reader.IsDBNull(reader.GetOrdinal("updated_at"))
                    ? null
                    : reader.GetDateTime(reader.GetOrdinal("updated_at"))
            };
        }

        private void AddProductParams(SqlCommand command, Product product)
        {
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@description", product.Description);
            command.Parameters.AddWithValue("@category", product.Category);
            command.Parameters.AddWithValue("@price", product.Price);
            command.Parameters.AddWithValue("@stockQuantity", product.StockQuantity);
            command.Parameters.AddWithValue("@isActive", product.IsActive);
            command.Parameters.AddWithValue("@discount", product.Discount);
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new();

            try
            {
                using var connection = CreateConnection();
                connection.Open();
                using var command = CreateCommand("sp_GetProducts", connection);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                    products.Add(MapProduct(reader));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            return products;
        }

        public Product? GetProduct(int id)
        {
            try
            {
                using var connection = CreateConnection();
                connection.Open();
                using var command = CreateCommand("sp_GetProduct", connection);
                command.Parameters.AddWithValue("@id", id);
                using var reader = command.ExecuteReader();

                if (reader.Read())
                    return MapProduct(reader);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }

            return null;
        }

        public void CreateProduct(Product product)
        {
            try
            {
                using var connection = CreateConnection();
                connection.Open();
                using var command = CreateCommand("sp_CreateProduct", connection);
                AddProductParams(command, product);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                using var connection = CreateConnection();
                connection.Open();
                using var command = CreateCommand("sp_UpdateProduct", connection);
                command.Parameters.AddWithValue("@id", product.Id);
                AddProductParams(command, product);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }
        }

        public void DeleteProduct(int id)
        {
            try
            {
                using var connection = CreateConnection();
                connection.Open();
                using var command = CreateCommand("sp_DeleteProduct", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }
        }
    }
}
