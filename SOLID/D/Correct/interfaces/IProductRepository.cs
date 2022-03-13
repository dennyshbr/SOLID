namespace SOLID.D.Correct.interfaces
{
    public interface IProductRepository
    {
        Product Insert(Product product);
        Product Update(Product product);
        void Delete(int id);
        Product GetById(int id);
    }
}
