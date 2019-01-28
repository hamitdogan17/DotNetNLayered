using System;
using System.Collections.Generic;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        
        public List<Product> GetAll()
        {
            //Business Code
            return _productDal.GetAll();
        }
    }
}
