using Northwind.DataAccess;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager
    {
        public List<Product> GetAll()
        {
            ProductDal productDal = new ProductDal();
            return productDal.GetAll();
        }
    }
}
