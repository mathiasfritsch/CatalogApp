using CatalogApp.Model;
using System.Linq.Expressions;

namespace CatalogApp.Specification
{
    public class ProductAbovePriceSpecification : BaseSpecifcation<Product>
    {
        public ProductAbovePriceSpecification(decimal minPrice)
        {
            base.AddCriteria(c => c.Price > minPrice);
        }
    }
}