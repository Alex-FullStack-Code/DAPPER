namespace TestDapper.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
    }
}
