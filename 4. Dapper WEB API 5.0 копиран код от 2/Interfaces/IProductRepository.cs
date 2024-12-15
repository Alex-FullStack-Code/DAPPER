namespace TestDapper.Interfaces
{
    using System.Threading.Tasks;
    using Microsoft.Extensions.Configuration;
    using Models;

    public interface IProductRepository : IGenericRepository<Product>
    {

    }
}
