namespace TestDapper.Repository
{ 
    using TestDapper.Interfaces;

    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IProductRepository productRepository)
        {
            this.Products = productRepository;
        }
        public IProductRepository Products { get; }
    }
}
