namespace SOLID.D.Correct.interfaces
{
    public interface IProductService
    {
        Product Add(Product product);
        Product Update(Product product);
        bool Remove(int id);
        Product GetById(int id);
    }
}
