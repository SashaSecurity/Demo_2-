using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BusinessLayer
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            return new Product(productId);
        }

        public bool Save(Product product)
        {
            return true;
        }
    }
}