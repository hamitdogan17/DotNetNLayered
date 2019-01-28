using System.Collections.Generic;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
