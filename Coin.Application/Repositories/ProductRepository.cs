using Coin.Domain.Entities;
using Coin.Data;
using Coin.Application.Interfaces;

namespace Coin.Application.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}