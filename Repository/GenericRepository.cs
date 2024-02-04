using CatalogApp.Specification;
using Microsoft.EntityFrameworkCore;

namespace CatalogApp.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly CatalogContext _context;

        public GenericRepository(CatalogContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> FindWithSpecificationPatternAsync(ISpecification<T> specification = null)
        {
            var query = SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), specification);

            return await query.ToListAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}