using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities;

namespace Talabat.Core.Specifications
{
    /// <summary>
    /// this class for count records of request entity domain
    /// </summary>
    public class ProductWithFilterationForCountSpecefication:BaseSpecification<Product>
    {
        public ProductWithFilterationForCountSpecefication(ProductSpecParams specParams)
            :base(P =>
                ( string.IsNullOrEmpty(specParams.Search) || P.Name.ToLower().Contains(specParams.Search) )&&
                (!specParams.brandId.HasValue || P.ProductBrandId == specParams.brandId.Value) &&
                (!specParams.typeId.HasValue || P.ProductTypeId == specParams.typeId.Value)
            )
        {
            
        }
    }
}
