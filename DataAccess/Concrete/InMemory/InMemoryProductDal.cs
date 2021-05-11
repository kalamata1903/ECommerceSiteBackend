using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId = 1, CategoryId=1,ProductName="A",UnitPrice=10,UnitsInStock=10},
                new Product{ProductId = 2, CategoryId=2,ProductName="B",UnitPrice=20,UnitsInStock=10},
                new Product{ProductId = 3, CategoryId=2,ProductName="C",UnitPrice=30,UnitsInStock=10},
                new Product{ProductId = 4, CategoryId=2,ProductName="D",UnitPrice=40,UnitsInStock=10},
                new Product{ProductId = 5, CategoryId=1,ProductName="E",UnitPrice=50,UnitsInStock=10}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete;

            productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate;

            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName     = product.ProductName;
            productToUpdate.UnitPrice       = product.UnitPrice;
            productToUpdate.UnitsInStock    = product.UnitsInStock;
            productToUpdate.CategoryId      = product.CategoryId;
        }
    }
}
