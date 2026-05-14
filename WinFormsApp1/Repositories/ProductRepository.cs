using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories
{
    public class ProductRepository
    {
        private readonly string connectionString = "Data Source=PERI\\SQLEXPRESS;Initial Catalog=ecommerce;Integrated Security=True;Trust Server Certificate=True";

        public List<Product> GetProducts()
        {
            var products = new List<Product>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT * 
                        FROM products
                        ORDER BY ISNULL(updated_at, created_at) DESC";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product();
                                product.Id = reader.GetInt32(reader.GetOrdinal("id"));
                                product.Name = reader.GetString(reader.GetOrdinal("name"));
                                product.Description = reader.GetString(reader.GetOrdinal("description"));
                                product.Category = reader.GetString(reader.GetOrdinal("category"));
                                product.Price = reader.GetDecimal(reader.GetOrdinal("price"));
                                product.StockQuantity = reader.GetInt32(reader.GetOrdinal("stock_quantity"));
                                product.IsActive = reader.GetBoolean(reader.GetOrdinal("is_active"));
                                product.Discount = reader.GetDecimal(reader.GetOrdinal("discount"));
                                product.CreatedAt = reader.GetDateTime(reader.GetOrdinal("created_at"));
                                product.UpdatedAt = reader.IsDBNull(reader.GetOrdinal("updated_at"))
                                    ? (DateTime?)null
                                    : reader.GetDateTime(reader.GetOrdinal("updated_at"));

                                products.Add(product);
                            }
                        }
                    }
                }
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM products WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Product product = new Product();
                                product.Id = reader.GetInt32(reader.GetOrdinal("id"));
                                product.Name = reader.GetString(reader.GetOrdinal("name"));
                                product.Description = reader.GetString(reader.GetOrdinal("description"));
                                product.Category = reader.GetString(reader.GetOrdinal("category"));
                                product.Price = reader.GetDecimal(reader.GetOrdinal("price"));
                                product.StockQuantity = reader.GetInt32(reader.GetOrdinal("stock_quantity"));
                                product.IsActive = reader.GetBoolean(reader.GetOrdinal("is_active"));
                                product.Discount = reader.GetDecimal(reader.GetOrdinal("discount"));
                                product.CreatedAt = reader.GetDateTime(reader.GetOrdinal("created_at"));
                                product.UpdatedAt = reader.IsDBNull(reader.GetOrdinal("updated_at"))
                                    ? (DateTime?)null
                                    : reader.GetDateTime(reader.GetOrdinal("updated_at"));

                                return product;
                            }
                        }
                    }
                }
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO products
                        (
                            name,
                            description,
                            category,
                            price,
                            stock_quantity,
                            is_active,
                            discount
                        )
                        VALUES
                        (
                            @name,
                            @description,
                            @category,
                            @price,
                            @stockQuantity,
                            @isActive,
                            @discount
                        )";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", product.Name);
                        command.Parameters.AddWithValue("@description", product.Description);
                        command.Parameters.AddWithValue("@category", product.Category);
                        command.Parameters.AddWithValue("@price", product.Price);
                        command.Parameters.AddWithValue("@stockQuantity", product.StockQuantity);
                        command.Parameters.AddWithValue("@isActive", product.IsActive);
                        command.Parameters.AddWithValue("@discount", product.Discount);

                        command.ExecuteNonQuery();
                    }
                }
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        UPDATE products
                        SET
                            name = @name,
                            description = @description,
                            category = @category,
                            price = @price,
                            stock_quantity = @stockQuantity,
                            is_active = @isActive,
                            discount = @discount,
                            updated_at = GETDATE()
                        WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", product.Id);
                        command.Parameters.AddWithValue("@name", product.Name);
                        command.Parameters.AddWithValue("@description", product.Description);
                        command.Parameters.AddWithValue("@category", product.Category);
                        command.Parameters.AddWithValue("@price", product.Price);
                        command.Parameters.AddWithValue("@stockQuantity", product.StockQuantity);
                        command.Parameters.AddWithValue("@isActive", product.IsActive);
                        command.Parameters.AddWithValue("@discount", product.Discount);

                        command.ExecuteNonQuery();
                    }
                }
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM products WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {e.Message}");
            }
        }
    }
}
