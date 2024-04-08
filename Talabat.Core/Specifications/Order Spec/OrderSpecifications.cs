using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities.Order_Aggregate;

namespace Talabat.Core.Specifications.Order_Spec
{
    public class OrderSpecifications : BaseSpecification<Order>
    {
        // get all orders for specific user 
        public OrderSpecifications(string email):base(ord=> ord.PuyerEmail == email)
        {
            Includes.Add(ord => ord.DeliveryMethod);
            Includes.Add(ord => ord.Items);

            AddOrderByDesc(ord => ord.OrderDate);

        }


        // get  specific order for Authorized user
        public OrderSpecifications( int id,string email) : base(ord => ord.PuyerEmail == email && ord.Id== id)
        {
            Includes.Add(ord => ord.DeliveryMethod);
            Includes.Add(ord => ord.Items);
        }
    }
}
