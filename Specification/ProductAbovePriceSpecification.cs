using CatalogApp.Model;
using System.Linq.Expressions;

namespace CatalogApp.Specification
{
    public class ProductAbovePriceSpecification : BaseSpecifcation<Product>
    {
        public ProductAbovePriceSpecification(decimal minPrice) : base(c => c.Price > minPrice)
        {
        }
    }
}