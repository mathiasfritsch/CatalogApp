using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System;
using CatalogApp.Model;
using Microsoft.EntityFrameworkCore;
using CatalogApp.Specification;
using CatalogApp.Repository;

namespace CatalogApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        public readonly IGenericRepository<Product> _repository;

        public ProductsController(IGenericRepository<Product> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var priceGreaterThan1Specification = new ProductAbovePriceSpecification(1);

            var products = await _repository.FindWithSpecificationPatternAsync(priceGreaterThan1Specification);
            return Ok(products);
        }
    }
}