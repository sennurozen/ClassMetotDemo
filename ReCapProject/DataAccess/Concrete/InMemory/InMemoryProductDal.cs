using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal() //ctor tab tab ilel prtaik yo
        {
            _products = new List<Product> {
             new Product{Id=1, BrandId=1, ColorId=32, ModelYear="2010", DailyPrice=1600, Description="KDV fiyata dahildir. Geciken saat başı 200 TL eklenir"},
             new Product{Id=2, BrandId=1, ColorId=33, ModelYear="2009", DailyPrice=1500, Description="KDV fiyata dahildir. Geciken saat başı 150 TL eklenir"},
             new Product{Id=3, BrandId=2, ColorId=33, ModelYear="2010", DailyPrice=1800, Description="KDV fiyata dahildir. Geciken saat başı 200 TL eklenir"},
             new Product{Id=4, BrandId=3, ColorId=34, ModelYear="2011", DailyPrice=1900, Description="KDV fiyata dahildir. Geciken saat başı 250 TL eklenir"},
             new Product{Id=5, BrandId=3, ColorId=35, ModelYear="2012", DailyPrice=2500, Description="KDV fiyata dahildir. Geciken saat başı 300 TL eklenir"}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.Id == product.Id);
            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetById(int ıd)
        {
            return _products.Where(p=>p.Id == ıd).ToList();
        }

        public List<Product> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id); 
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;
        }
    }
}
