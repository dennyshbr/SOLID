using Moq;
using SOLID.D;
using SOLID.D.Correct;
using SOLID.D.Correct.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SOLID.Test.D.Correct
{
    public class ProductServiceTest
    {
        private ProductService _productService;
        private Mock<IProductRepository> _mockProductRepository;

        public ProductServiceTest()
        {
            _mockProductRepository = new Mock<IProductRepository>();

            _productService = new ProductService(_mockProductRepository.Object);
        }

        [Fact]
        public void Add_ShouldReturnProduct()
        {
            _mockProductRepository
                .Setup(m => m.Insert(It.IsAny<Product>()))
                .Returns(new Product());

            Product product = new Product()
            {
                Name = "Book",
                Description = "Book",
                Price = 15
            };

            var result = _productService.Add(product);

            Assert.NotNull(result);
        }

        [Fact]
        public void Add_ShouldReturnNull()
        {
            _mockProductRepository
                .Setup(m => m.Insert(It.IsAny<Product>()))
                .Returns(new Product());

            Product product = new Product()
            {
                Id = 1,
                Name = "Book",
                Description = "Book",
                Price = 15
            };

            var result = _productService.Add(product);

            Assert.Null(result);
        }

        [Fact]
        public void Update_ShouldReturnProduct()
        {
            _mockProductRepository
                .Setup(m => m.Update(It.IsAny<Product>()))
                .Returns(new Product());

            Product product = new Product()
            {
                Id = 2,
                Name = "Pencil",
                Description = "Pencil",
                Price = 4
            };

            var result = _productService.Update(product);

            Assert.NotNull(result);
        }

        [Fact]
        public void Update_ShouldReturnNull()
        {
            _mockProductRepository
                .Setup(m => m.Update(It.IsAny<Product>()))
                .Returns(new Product());

            Product product = new Product()
            {
                Id = 0,
                Name = "Pencil",
                Description = "Pencil",
                Price = 4
            };

            var result = _productService.Update(product);

            Assert.Null(result);
        }

        [Fact]
        public void Remove_ShouldReturnTrue()
        {
            int id = 2;

            var result = _productService.Remove(id);

            Assert.True(result);
        }

        [Fact]
        public void Remove_ShouldReturnFalse()
        {
            int id = 0;

            var result = _productService.Remove(id);

            Assert.False(result);
        }

        [Fact]
        public void GetById_ReturnProduct()
        {
            Product productFake = new Product()
            {
                Id = 1,
                Name = "Test",
                Description = "Test",
                Price = 10
            };

            _mockProductRepository
                .Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(productFake);

            var product = _productService.GetById(1);

            Assert.NotNull(product);
        }

        [Fact]
        public void GetById_ReturnNull()
        {
            Product productFake = new Product()
            {
                Id = 0,
                Name = "Test",
                Description = "Test",
                Price = 10
            };

            _mockProductRepository
                .Setup(m => m.GetById(It.IsAny<int>()))
                .Returns(productFake);

            var result = _productService.GetById(0);

            Assert.Null(result);
        }
    }
}
