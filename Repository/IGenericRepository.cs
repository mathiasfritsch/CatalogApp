using CatalogApp.Specification;

namespace CatalogApp.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        Task<List<T>> GetAllAsync();

        Task<IEnumerable<T>> FindWithSpecificationPatternAsync(ISpecification<T> specification = null);
    }
}