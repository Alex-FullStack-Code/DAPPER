namespace TestDapper.Repository
{
    using Microsoft.Extensions.Configuration;
    using Dapper;

    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Threading.Tasks;

    using Interfaces;
    using Models;

    public class ProductRepository : IProductRepository
    {
        private readonly IConfiguration configuration;
        public ProductRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        } 

        public async Task<int> AddAsync(Product product)
        {
            var sql = @" SET IDENTITY_INSERT products ON INSERT INTO products (product_id,product_name,brand_id,category_id,model_year,list_price) VALUES (@product_id,@product_name,@brand_id,@category_id,@model_year,@list_price); SET IDENTITY_INSERT products OFF ";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();

                var result = await connection.ExecuteAsync(sql, product);
                return result;
            }
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<Product>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> UpdateAsync(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
