using Agri.Energy.Connect.Web.Data;
using Agri.Energy.Connect.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Agri.Energy.Connect.Web.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Data.AgricoEnergyDbContext productDbContext;

        public ProductRepository(Data.AgricoEnergyDbContext bloggieDbContext)
        {
            this.productDbContext = bloggieDbContext;
        }

        public async Task<Product> AddAsync(Product product)
        {
            await productDbContext.AddAsync(product);
            await productDbContext.SaveChangesAsync();
            return product;
        }

        public async Task<Product?> DeleteAsync(Guid id)
        {
            var existingProduct = await productDbContext.Products.FindAsync(id);

            if (existingProduct != null)
            {
                productDbContext.Products.Remove(existingProduct);
                await productDbContext.SaveChangesAsync();
                return existingProduct;
            }

            return null;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await productDbContext.Products.ToListAsync();
        }

        public Task<Product?> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product?> UpdateAsync(Product blogPost)
        {
            var existingProduct = await productDbContext.Products.Include(x => x.Id)
                .FirstOrDefaultAsync(x => x.Id == blogPost.Id);

            if (existingProduct != null)
            {
                existingProduct.Id = blogPost.Id;
                existingProduct.Name = blogPost.Name;
                existingProduct.Category = blogPost.Category;
                existingProduct.ProductionDate = blogPost.ProductionDate;
             

                await productDbContext.SaveChangesAsync();
                return existingProduct;
            }

            return null;
        }
    }
}
