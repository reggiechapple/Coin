using Coin.Domain.Entities;
using Coin.Infrastructure.Data.Context;

namespace Coin.Infrastructure.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}