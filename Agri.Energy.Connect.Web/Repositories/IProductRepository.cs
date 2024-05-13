using Agri.Energy.Connect.Web.Models.Domain;

namespace Agri.Energy.Connect.Web.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();

        Task<Product?> GetAsync(Guid id);

        Task<Product> AddAsync(Product blogPost);

        Task<Product?> UpdateAsync(Product blogPost);

        Task<Product?> DeleteAsync(Guid id);
    }
}
