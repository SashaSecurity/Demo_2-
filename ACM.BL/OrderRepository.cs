using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BusinessLayer
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            return new Order(orderId);
        }

        public bool Save(Order order)
        {
            return true;
        }
    }
}