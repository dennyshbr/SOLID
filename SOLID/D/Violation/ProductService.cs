using SOLID.D.Correct;

namespace SOLID.D.Violation
{
    public class ProductService
    {
        private ProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        public void Add(Product product)
        {
            if (product.Id != 0)
            {
                return;
            }

            _productRepository.Insert(product);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }

        public void Remove(int id)
        {
            if (id == 0)
            {
                return;
            }

            _productRepository.Delete(id);
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
