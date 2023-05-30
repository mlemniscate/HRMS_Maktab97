using HRMS.Database;
using HRMS.Entities;

namespace HRMS.Repositories;

public class CartRepository : ICartRepository
{
    private readonly DbContext dbContext;

    public CartRepository(DbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void Create(Cart cart)
    {
        dbContext.Carts.Add(cart);
    }
}