using SOLID.D.Correct.interfaces;

namespace SOLID.D.Correct
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Add(Product product)
        {
            if (product.Id != 0)
            {
                return null;
            }

            Product productRegistered = _productRepository.Insert(product);

            return productRegistered;
        }

        public Product Update(Product product)
        {
            if (product.Id == 0)
            {
                return null;
            }

            var productUpdate = _productRepository.Update(product);

            return productUpdate;
        }

        public bool Remove(int id)
        {
            if (id == 0)
            {
                return false;
            }

            _productRepository.Delete(id);

            return true;
        }

        public Product GetById(int id)
        {
            if (id == 0)
            {
                return null;
            }

            return _productRepository.GetById(id);
        }
    }
}
