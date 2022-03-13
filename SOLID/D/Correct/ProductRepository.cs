using SOLID.D.Correct.interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.D.Correct
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>();
        }

        public Product Insert(Product product)
        {
            int maxId = _products.Select(p => p.Id).Max();

            product.Id = maxId++;

            _products.Add(product);

            return product;
        }

        public Product Update(Product product)
        {
            Product p = GetById(product.Id);

            p.Name = product.Name;
            p.Description = product.Description;
            p.Price = product.Price;

            return p;
        }

        public void Delete(int id)
        {
            Product product = GetById(id);

            _products.Remove(product);
        }

        public Product GetById(int id)
        {
            Product product = _products.FirstOrDefault(p => p.Id == id);

            return product;
        }
    }
}
