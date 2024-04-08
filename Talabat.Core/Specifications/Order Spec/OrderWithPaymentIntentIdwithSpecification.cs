using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities.Order_Aggregate;

namespace Talabat.Core.Specifications.Order_Spec
{
    public class OrderWithPaymentIntentIdwithSpecification :BaseSpecification<Order>
    {
        public OrderWithPaymentIntentIdwithSpecification(string paymentIntentId) // this is where condition order.where(o => o.PaymentIntentId == paymentIntentId).includes ...
            : base(o => o.PaymentIntentId == paymentIntentId)
        {
            
        }
    }
}
